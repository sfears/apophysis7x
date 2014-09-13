using System;
using System.Drawing;
using Xyrus.Apophysis.Models;
using Xyrus.Apophysis.Threading;

namespace Xyrus.Apophysis.Calculation
{
	[PublicAPI]
	public class ThreadedRenderer : IDisposable
	{
		class RenderParameters
		{
			public readonly Flame Flame;
			public readonly double Density;
			public readonly Size Size;

			public RenderParameters(Flame flame, double density, Size size)
			{
				Flame = flame;
				Density = density;
				Size = size;
			}
		}

		private RenderParameters mParameters;
		private ThreadController mThreadController;
		private bool mIsDisposed;

		~ThreadedRenderer()
		{
			Dispose(false);
		}
		public ThreadedRenderer()
		{
			mThreadController = new ThreadController();
		}
		protected void Dispose(bool disposing)
		{
			if (mIsDisposed)
				return;

			if (disposing)
			{
				if (mThreadController != null)
				{
					mThreadController.Dispose();
					mThreadController = null;
				}
			}

			DisposeOverride(disposing);
			mIsDisposed = true;
		}
		protected virtual void DisposeOverride(bool disposing)
		{
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public void StartCreateBitmap([NotNull] Flame flame, double density, Size size, Action<Bitmap> callback)
		{
			if (flame == null) throw new ArgumentNullException("flame");
			if (density <= 0) throw new ArgumentOutOfRangeException("density");
			if (size.Width <= 0 || size.Height <= 0) throw new ArgumentOutOfRangeException("size");

			mParameters = new RenderParameters(flame, density, size);
			mThreadController.StartThread(CreateBitmap, callback);
		}

		public void Suspend()
		{
			mThreadController.Suspend();
		}
		public void Resume()
		{
			mThreadController.Resume();
		}
		public void Cancel()
		{
			mThreadController.Cancel();
		}

		public bool IsSuspended
		{
			get { return mThreadController.IsSuspended; }
		}
		public bool IsRunning
		{
			get { return mThreadController.IsRunning; }
		}
		public bool IsCancelling
		{
			get { return mThreadController.IsCancelling; }
		}

		public event ProgressEventHandler Progress;
		public event EventHandler Exit;

		//todo multithreading
		private Bitmap CreateBitmap(ThreadStateToken threadState)
		{
			var renderer = new Renderer();
			var result = renderer.CreateBitmap(mParameters.Flame, mParameters.Density, mParameters.Size, ProgressUpdate, threadState);

			mParameters = null;

			if (Exit != null)
				Exit(this, new EventArgs());

			return result;
		}
		private void ProgressUpdate(ProgressEventArgs args)
		{
			if (Progress != null)
				Progress(this, args);
		}
	}
}