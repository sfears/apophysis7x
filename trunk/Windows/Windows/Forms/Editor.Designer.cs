﻿using Xyrus.Apophysis.Windows.Controls;

namespace Xyrus.Apophysis.Windows.Forms
{
	partial class Editor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			this.mRootSplitter = new System.Windows.Forms.SplitContainer();
			this.IteratorCanvas = new Xyrus.Apophysis.Windows.Controls.EditorCanvas();
			this.mSettings = new Xyrus.Apophysis.Windows.Controls.EditorSettings();
			this.mSidebarSplitter = new System.Windows.Forms.SplitContainer();
			this.mPreviewPanel = new System.Windows.Forms.Panel();
			this.mPictureBevel = new System.Windows.Forms.Label();
			this.mTabs = new System.Windows.Forms.TabControl();
			this.mColorTab = new System.Windows.Forms.TabPage();
			this.mIteratorColorGroupBox = new System.Windows.Forms.GroupBox();
			this.IteratorIsExclusiveCheckBox = new System.Windows.Forms.CheckBox();
			this.IteratorDirectColorTextBox = new System.Windows.Forms.TextBox();
			this.IteratorDirectColorDragPanel = new Xyrus.Apophysis.Windows.Controls.DragPanel();
			this.IteratorOpacityTextBox = new System.Windows.Forms.TextBox();
			this.IteratorOpacityDragPanel = new Xyrus.Apophysis.Windows.Controls.DragPanel();
			this.IteratorColorSpeedTextBox = new System.Windows.Forms.TextBox();
			this.IteratorColorSpeedDragPanel = new Xyrus.Apophysis.Windows.Controls.DragPanel();
			this.IteratorColorScrollBar = new System.Windows.Forms.HScrollBar();
			this.mPalettePictureBox = new System.Windows.Forms.PictureBox();
			this.IteratorColorTextBox = new System.Windows.Forms.TextBox();
			this.IteratorColorDragPanel = new Xyrus.Apophysis.Windows.Controls.DragPanel();
			this.mPaletteBevel = new System.Windows.Forms.Label();
			this.mIteratorPropertyPanel = new System.Windows.Forms.Panel();
			this.IteratorWeightTextBox = new System.Windows.Forms.TextBox();
			this.IteratorWeightDragPanel = new Xyrus.Apophysis.Windows.Controls.DragPanel();
			this.IteratorNameTextBox = new System.Windows.Forms.TextBox();
			this.mIteratorNameLabel = new System.Windows.Forms.Label();
			this.IteratorSelectionComboBox = new System.Windows.Forms.ComboBox();
			this.mIteratorSelectLabel = new System.Windows.Forms.Label();
			this.mPointTab = new System.Windows.Forms.TabPage();
			this.mPointCoordGroupBox = new System.Windows.Forms.GroupBox();
			this.mPointCoordXLabel = new System.Windows.Forms.Label();
			this.mPointCoordYLabel = new System.Windows.Forms.Label();
			this.mPointCoordOLabel = new System.Windows.Forms.Label();
			this.IteratorPointXxTextBox = new System.Windows.Forms.TextBox();
			this.IteratorPointXyTextBox = new System.Windows.Forms.TextBox();
			this.IteratorPointYyTextBox = new System.Windows.Forms.TextBox();
			this.IteratorPointYxTextBox = new System.Windows.Forms.TextBox();
			this.IteratorPointOyTextBox = new System.Windows.Forms.TextBox();
			this.IteratorPointOxTextBox = new System.Windows.Forms.TextBox();
			this.mIteratorControlsGroupBox = new System.Windows.Forms.GroupBox();
			this.IteratorRotate90CCW = new System.Windows.Forms.Button();
			this.IteratorRotate90CW = new System.Windows.Forms.Button();
			this.IteratorRotateCCW = new System.Windows.Forms.Button();
			this.IteratorRotateCW = new System.Windows.Forms.Button();
			this.IteratorSnapAngle = new System.Windows.Forms.ComboBox();
			this.mRootSplitter.Panel1.SuspendLayout();
			this.mRootSplitter.Panel2.SuspendLayout();
			this.mRootSplitter.SuspendLayout();
			this.mSidebarSplitter.Panel1.SuspendLayout();
			this.mSidebarSplitter.Panel2.SuspendLayout();
			this.mSidebarSplitter.SuspendLayout();
			this.mPreviewPanel.SuspendLayout();
			this.mTabs.SuspendLayout();
			this.mColorTab.SuspendLayout();
			this.mIteratorColorGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mPalettePictureBox)).BeginInit();
			this.mIteratorPropertyPanel.SuspendLayout();
			this.mPointTab.SuspendLayout();
			this.mPointCoordGroupBox.SuspendLayout();
			this.mIteratorControlsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// mRootSplitter
			// 
			this.mRootSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mRootSplitter.Location = new System.Drawing.Point(0, 0);
			this.mRootSplitter.Name = "mRootSplitter";
			// 
			// mRootSplitter.Panel1
			// 
			this.mRootSplitter.Panel1.Controls.Add(this.IteratorCanvas);
			// 
			// mRootSplitter.Panel2
			// 
			this.mRootSplitter.Panel2.Controls.Add(this.mSidebarSplitter);
			this.mRootSplitter.Size = new System.Drawing.Size(1014, 659);
			this.mRootSplitter.SplitterDistance = 711;
			this.mRootSplitter.TabIndex = 3;
			// 
			// IteratorCanvas
			// 
			this.IteratorCanvas.ActiveMatrix = Xyrus.Apophysis.Windows.Controls.IteratorMatrix.PreAffine;
			this.IteratorCanvas.BackColor = System.Drawing.Color.Black;
			this.IteratorCanvas.BackdropColor = System.Drawing.Color.Transparent;
			this.IteratorCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.IteratorCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.IteratorCanvas.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IteratorCanvas.ForeColor = System.Drawing.Color.White;
			this.IteratorCanvas.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.IteratorCanvas.GridZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.IteratorCanvas.HighlightOrigin = true;
			this.IteratorCanvas.Iterators = null;
			this.IteratorCanvas.Location = new System.Drawing.Point(0, 0);
			this.IteratorCanvas.Name = "IteratorCanvas";
			this.IteratorCanvas.ReferenceColor = System.Drawing.Color.Gray;
			this.IteratorCanvas.RulerBackdropColor = System.Drawing.Color.Transparent;
			this.IteratorCanvas.RulerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.IteratorCanvas.RulerGridLineColor = System.Drawing.Color.Silver;
			this.IteratorCanvas.Settings = this.mSettings;
			this.IteratorCanvas.ShowRuler = true;
			this.IteratorCanvas.Size = new System.Drawing.Size(711, 659);
			this.IteratorCanvas.TabIndex = 1;
			// 
			// mSettings
			// 
			this.mSettings.AngleSnap = 15D;
			this.mSettings.LockAxes = false;
			this.mSettings.MoveAmount = 0.1D;
			this.mSettings.ScaleSnap = 125D;
			this.mSettings.ShowVariationPreview = false;
			this.mSettings.ZoomAutomatically = false;
			// 
			// mSidebarSplitter
			// 
			this.mSidebarSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mSidebarSplitter.Location = new System.Drawing.Point(0, 0);
			this.mSidebarSplitter.Name = "mSidebarSplitter";
			this.mSidebarSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// mSidebarSplitter.Panel1
			// 
			this.mSidebarSplitter.Panel1.Controls.Add(this.mPreviewPanel);
			this.mSidebarSplitter.Panel1MinSize = 100;
			// 
			// mSidebarSplitter.Panel2
			// 
			this.mSidebarSplitter.Panel2.Controls.Add(this.mTabs);
			this.mSidebarSplitter.Panel2.Controls.Add(this.mIteratorPropertyPanel);
			this.mSidebarSplitter.Size = new System.Drawing.Size(299, 659);
			this.mSidebarSplitter.SplitterDistance = 156;
			this.mSidebarSplitter.TabIndex = 0;
			// 
			// mPreviewPanel
			// 
			this.mPreviewPanel.Controls.Add(this.mPictureBevel);
			this.mPreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mPreviewPanel.Location = new System.Drawing.Point(0, 0);
			this.mPreviewPanel.Name = "mPreviewPanel";
			this.mPreviewPanel.Size = new System.Drawing.Size(299, 156);
			this.mPreviewPanel.TabIndex = 0;
			// 
			// mPictureBevel
			// 
			this.mPictureBevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mPictureBevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mPictureBevel.Location = new System.Drawing.Point(0, 4);
			this.mPictureBevel.Name = "mPictureBevel";
			this.mPictureBevel.Size = new System.Drawing.Size(296, 152);
			this.mPictureBevel.TabIndex = 0;
			// 
			// mTabs
			// 
			this.mTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mTabs.Controls.Add(this.mPointTab);
			this.mTabs.Controls.Add(this.mColorTab);
			this.mTabs.Location = new System.Drawing.Point(10, 95);
			this.mTabs.Name = "mTabs";
			this.mTabs.SelectedIndex = 0;
			this.mTabs.Size = new System.Drawing.Size(280, 392);
			this.mTabs.TabIndex = 1;
			// 
			// mColorTab
			// 
			this.mColorTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.mColorTab.Controls.Add(this.mIteratorColorGroupBox);
			this.mColorTab.Location = new System.Drawing.Point(4, 22);
			this.mColorTab.Name = "mColorTab";
			this.mColorTab.Padding = new System.Windows.Forms.Padding(3);
			this.mColorTab.Size = new System.Drawing.Size(272, 366);
			this.mColorTab.TabIndex = 0;
			this.mColorTab.Text = "Color";
			// 
			// mIteratorColorGroupBox
			// 
			this.mIteratorColorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorIsExclusiveCheckBox);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorDirectColorTextBox);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorDirectColorDragPanel);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorOpacityTextBox);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorOpacityDragPanel);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorColorSpeedTextBox);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorColorSpeedDragPanel);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorColorScrollBar);
			this.mIteratorColorGroupBox.Controls.Add(this.mPalettePictureBox);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorColorTextBox);
			this.mIteratorColorGroupBox.Controls.Add(this.IteratorColorDragPanel);
			this.mIteratorColorGroupBox.Controls.Add(this.mPaletteBevel);
			this.mIteratorColorGroupBox.Location = new System.Drawing.Point(6, 6);
			this.mIteratorColorGroupBox.Name = "mIteratorColorGroupBox";
			this.mIteratorColorGroupBox.Size = new System.Drawing.Size(260, 228);
			this.mIteratorColorGroupBox.TabIndex = 0;
			this.mIteratorColorGroupBox.TabStop = false;
			this.mIteratorColorGroupBox.Text = "Transform color";
			// 
			// IteratorIsExclusiveCheckBox
			// 
			this.IteratorIsExclusiveCheckBox.AutoSize = true;
			this.IteratorIsExclusiveCheckBox.Location = new System.Drawing.Point(7, 194);
			this.IteratorIsExclusiveCheckBox.Name = "IteratorIsExclusiveCheckBox";
			this.IteratorIsExclusiveCheckBox.Size = new System.Drawing.Size(47, 17);
			this.IteratorIsExclusiveCheckBox.TabIndex = 16;
			this.IteratorIsExclusiveCheckBox.Text = "Solo";
			this.IteratorIsExclusiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// IteratorDirectColorTextBox
			// 
			this.IteratorDirectColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IteratorDirectColorTextBox.Location = new System.Drawing.Point(112, 158);
			this.IteratorDirectColorTextBox.Name = "IteratorDirectColorTextBox";
			this.IteratorDirectColorTextBox.Size = new System.Drawing.Size(142, 20);
			this.IteratorDirectColorTextBox.TabIndex = 15;
			this.IteratorDirectColorTextBox.Text = "1.000";
			// 
			// IteratorDirectColorDragPanel
			// 
			this.IteratorDirectColorDragPanel.BackColor = System.Drawing.SystemColors.Window;
			this.IteratorDirectColorDragPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.IteratorDirectColorDragPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IteratorDirectColorDragPanel.Default = 1D;
			this.IteratorDirectColorDragPanel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.IteratorDirectColorDragPanel.Location = new System.Drawing.Point(6, 158);
			this.IteratorDirectColorDragPanel.Maximum = 1D;
			this.IteratorDirectColorDragPanel.Minimum = 0D;
			this.IteratorDirectColorDragPanel.Name = "IteratorDirectColorDragPanel";
			this.IteratorDirectColorDragPanel.Size = new System.Drawing.Size(107, 21);
			this.IteratorDirectColorDragPanel.TabIndex = 14;
			this.IteratorDirectColorDragPanel.Text = "Direct color:";
			this.IteratorDirectColorDragPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.IteratorDirectColorDragPanel.TextBox = this.IteratorDirectColorTextBox;
			this.IteratorDirectColorDragPanel.Value = 1D;
			// 
			// IteratorOpacityTextBox
			// 
			this.IteratorOpacityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IteratorOpacityTextBox.Location = new System.Drawing.Point(112, 135);
			this.IteratorOpacityTextBox.Name = "IteratorOpacityTextBox";
			this.IteratorOpacityTextBox.Size = new System.Drawing.Size(142, 20);
			this.IteratorOpacityTextBox.TabIndex = 13;
			this.IteratorOpacityTextBox.Text = "1.000";
			// 
			// IteratorOpacityDragPanel
			// 
			this.IteratorOpacityDragPanel.BackColor = System.Drawing.SystemColors.Window;
			this.IteratorOpacityDragPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.IteratorOpacityDragPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IteratorOpacityDragPanel.Default = 1D;
			this.IteratorOpacityDragPanel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.IteratorOpacityDragPanel.Location = new System.Drawing.Point(6, 135);
			this.IteratorOpacityDragPanel.Maximum = 1D;
			this.IteratorOpacityDragPanel.Minimum = 0D;
			this.IteratorOpacityDragPanel.Name = "IteratorOpacityDragPanel";
			this.IteratorOpacityDragPanel.Size = new System.Drawing.Size(107, 21);
			this.IteratorOpacityDragPanel.TabIndex = 12;
			this.IteratorOpacityDragPanel.Text = "Opacity:";
			this.IteratorOpacityDragPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.IteratorOpacityDragPanel.TextBox = this.IteratorOpacityTextBox;
			this.IteratorOpacityDragPanel.Value = 1D;
			// 
			// IteratorColorSpeedTextBox
			// 
			this.IteratorColorSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IteratorColorSpeedTextBox.Location = new System.Drawing.Point(112, 112);
			this.IteratorColorSpeedTextBox.Name = "IteratorColorSpeedTextBox";
			this.IteratorColorSpeedTextBox.Size = new System.Drawing.Size(142, 20);
			this.IteratorColorSpeedTextBox.TabIndex = 11;
			this.IteratorColorSpeedTextBox.Text = "0.000";
			// 
			// IteratorColorSpeedDragPanel
			// 
			this.IteratorColorSpeedDragPanel.BackColor = System.Drawing.SystemColors.Window;
			this.IteratorColorSpeedDragPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.IteratorColorSpeedDragPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IteratorColorSpeedDragPanel.Default = 0D;
			this.IteratorColorSpeedDragPanel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.IteratorColorSpeedDragPanel.Location = new System.Drawing.Point(6, 112);
			this.IteratorColorSpeedDragPanel.Maximum = 1D;
			this.IteratorColorSpeedDragPanel.Minimum = -1D;
			this.IteratorColorSpeedDragPanel.Name = "IteratorColorSpeedDragPanel";
			this.IteratorColorSpeedDragPanel.Size = new System.Drawing.Size(107, 21);
			this.IteratorColorSpeedDragPanel.TabIndex = 10;
			this.IteratorColorSpeedDragPanel.Text = "Color speed:";
			this.IteratorColorSpeedDragPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.IteratorColorSpeedDragPanel.TextBox = this.IteratorColorSpeedTextBox;
			this.IteratorColorSpeedDragPanel.Value = 0D;
			// 
			// IteratorColorScrollBar
			// 
			this.IteratorColorScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IteratorColorScrollBar.LargeChange = 1;
			this.IteratorColorScrollBar.Location = new System.Drawing.Point(7, 76);
			this.IteratorColorScrollBar.Maximum = 1000;
			this.IteratorColorScrollBar.Name = "IteratorColorScrollBar";
			this.IteratorColorScrollBar.Size = new System.Drawing.Size(248, 17);
			this.IteratorColorScrollBar.TabIndex = 9;
			// 
			// mPalettePictureBox
			// 
			this.mPalettePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mPalettePictureBox.BackColor = System.Drawing.Color.Black;
			this.mPalettePictureBox.Location = new System.Drawing.Point(8, 55);
			this.mPalettePictureBox.Name = "mPalettePictureBox";
			this.mPalettePictureBox.Size = new System.Drawing.Size(247, 18);
			this.mPalettePictureBox.TabIndex = 8;
			this.mPalettePictureBox.TabStop = false;
			// 
			// IteratorColorTextBox
			// 
			this.IteratorColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IteratorColorTextBox.Location = new System.Drawing.Point(59, 31);
			this.IteratorColorTextBox.Name = "IteratorColorTextBox";
			this.IteratorColorTextBox.Size = new System.Drawing.Size(196, 20);
			this.IteratorColorTextBox.TabIndex = 7;
			this.IteratorColorTextBox.Text = "0.000";
			// 
			// IteratorColorDragPanel
			// 
			this.IteratorColorDragPanel.BackColor = System.Drawing.Color.Black;
			this.IteratorColorDragPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.IteratorColorDragPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IteratorColorDragPanel.Default = 0D;
			this.IteratorColorDragPanel.Location = new System.Drawing.Point(7, 31);
			this.IteratorColorDragPanel.Maximum = 1D;
			this.IteratorColorDragPanel.Minimum = 0D;
			this.IteratorColorDragPanel.Name = "IteratorColorDragPanel";
			this.IteratorColorDragPanel.Size = new System.Drawing.Size(56, 21);
			this.IteratorColorDragPanel.TabIndex = 6;
			this.IteratorColorDragPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.IteratorColorDragPanel.TextBox = this.IteratorColorTextBox;
			this.IteratorColorDragPanel.Value = 0D;
			// 
			// mPaletteBevel
			// 
			this.mPaletteBevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mPaletteBevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mPaletteBevel.Location = new System.Drawing.Point(7, 54);
			this.mPaletteBevel.Name = "mPaletteBevel";
			this.mPaletteBevel.Size = new System.Drawing.Size(249, 20);
			this.mPaletteBevel.TabIndex = 17;
			// 
			// mIteratorPropertyPanel
			// 
			this.mIteratorPropertyPanel.Controls.Add(this.IteratorWeightTextBox);
			this.mIteratorPropertyPanel.Controls.Add(this.IteratorWeightDragPanel);
			this.mIteratorPropertyPanel.Controls.Add(this.IteratorNameTextBox);
			this.mIteratorPropertyPanel.Controls.Add(this.mIteratorNameLabel);
			this.mIteratorPropertyPanel.Controls.Add(this.IteratorSelectionComboBox);
			this.mIteratorPropertyPanel.Controls.Add(this.mIteratorSelectLabel);
			this.mIteratorPropertyPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.mIteratorPropertyPanel.Location = new System.Drawing.Point(0, 0);
			this.mIteratorPropertyPanel.Name = "mIteratorPropertyPanel";
			this.mIteratorPropertyPanel.Size = new System.Drawing.Size(299, 89);
			this.mIteratorPropertyPanel.TabIndex = 0;
			// 
			// IteratorWeightTextBox
			// 
			this.IteratorWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IteratorWeightTextBox.Location = new System.Drawing.Point(120, 57);
			this.IteratorWeightTextBox.Name = "IteratorWeightTextBox";
			this.IteratorWeightTextBox.Size = new System.Drawing.Size(168, 20);
			this.IteratorWeightTextBox.TabIndex = 5;
			this.IteratorWeightTextBox.Text = "0.500";
			// 
			// IteratorWeightDragPanel
			// 
			this.IteratorWeightDragPanel.BackColor = System.Drawing.SystemColors.Window;
			this.IteratorWeightDragPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.IteratorWeightDragPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IteratorWeightDragPanel.Default = 0.5D;
			this.IteratorWeightDragPanel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.IteratorWeightDragPanel.Location = new System.Drawing.Point(10, 57);
			this.IteratorWeightDragPanel.Maximum = 1000D;
			this.IteratorWeightDragPanel.Minimum = 0.001D;
			this.IteratorWeightDragPanel.Name = "IteratorWeightDragPanel";
			this.IteratorWeightDragPanel.Size = new System.Drawing.Size(110, 21);
			this.IteratorWeightDragPanel.TabIndex = 4;
			this.IteratorWeightDragPanel.Text = "Weight:";
			this.IteratorWeightDragPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.IteratorWeightDragPanel.TextBox = this.IteratorWeightTextBox;
			this.IteratorWeightDragPanel.Value = 0.5D;
			// 
			// IteratorNameTextBox
			// 
			this.IteratorNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IteratorNameTextBox.Location = new System.Drawing.Point(120, 34);
			this.IteratorNameTextBox.Name = "IteratorNameTextBox";
			this.IteratorNameTextBox.Size = new System.Drawing.Size(168, 20);
			this.IteratorNameTextBox.TabIndex = 3;
			// 
			// mIteratorNameLabel
			// 
			this.mIteratorNameLabel.BackColor = System.Drawing.SystemColors.Window;
			this.mIteratorNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mIteratorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mIteratorNameLabel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.mIteratorNameLabel.Location = new System.Drawing.Point(10, 34);
			this.mIteratorNameLabel.Name = "mIteratorNameLabel";
			this.mIteratorNameLabel.Size = new System.Drawing.Size(110, 21);
			this.mIteratorNameLabel.TabIndex = 2;
			this.mIteratorNameLabel.Text = "Name:";
			this.mIteratorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IteratorSelectionComboBox
			// 
			this.IteratorSelectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IteratorSelectionComboBox.BackColor = System.Drawing.Color.Black;
			this.IteratorSelectionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.IteratorSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.IteratorSelectionComboBox.ForeColor = System.Drawing.Color.White;
			this.IteratorSelectionComboBox.FormattingEnabled = true;
			this.IteratorSelectionComboBox.ItemHeight = 15;
			this.IteratorSelectionComboBox.Location = new System.Drawing.Point(120, 10);
			this.IteratorSelectionComboBox.MaxDropDownItems = 20;
			this.IteratorSelectionComboBox.Name = "IteratorSelectionComboBox";
			this.IteratorSelectionComboBox.Size = new System.Drawing.Size(168, 21);
			this.IteratorSelectionComboBox.TabIndex = 1;
			// 
			// mIteratorSelectLabel
			// 
			this.mIteratorSelectLabel.BackColor = System.Drawing.SystemColors.Window;
			this.mIteratorSelectLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mIteratorSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mIteratorSelectLabel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.mIteratorSelectLabel.Location = new System.Drawing.Point(10, 10);
			this.mIteratorSelectLabel.Name = "mIteratorSelectLabel";
			this.mIteratorSelectLabel.Size = new System.Drawing.Size(110, 22);
			this.mIteratorSelectLabel.TabIndex = 0;
			this.mIteratorSelectLabel.Text = "Transform:";
			this.mIteratorSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mPointTab
			// 
			this.mPointTab.Controls.Add(this.mIteratorControlsGroupBox);
			this.mPointTab.Controls.Add(this.mPointCoordGroupBox);
			this.mPointTab.Location = new System.Drawing.Point(4, 22);
			this.mPointTab.Name = "mPointTab";
			this.mPointTab.Padding = new System.Windows.Forms.Padding(3);
			this.mPointTab.Size = new System.Drawing.Size(272, 366);
			this.mPointTab.TabIndex = 1;
			this.mPointTab.Text = "Triangle";
			this.mPointTab.UseVisualStyleBackColor = true;
			// 
			// mPointCoordGroupBox
			// 
			this.mPointCoordGroupBox.Controls.Add(this.IteratorPointOyTextBox);
			this.mPointCoordGroupBox.Controls.Add(this.IteratorPointOxTextBox);
			this.mPointCoordGroupBox.Controls.Add(this.IteratorPointYyTextBox);
			this.mPointCoordGroupBox.Controls.Add(this.IteratorPointYxTextBox);
			this.mPointCoordGroupBox.Controls.Add(this.IteratorPointXyTextBox);
			this.mPointCoordGroupBox.Controls.Add(this.IteratorPointXxTextBox);
			this.mPointCoordGroupBox.Controls.Add(this.mPointCoordOLabel);
			this.mPointCoordGroupBox.Controls.Add(this.mPointCoordYLabel);
			this.mPointCoordGroupBox.Controls.Add(this.mPointCoordXLabel);
			this.mPointCoordGroupBox.Location = new System.Drawing.Point(11, 15);
			this.mPointCoordGroupBox.Name = "mPointCoordGroupBox";
			this.mPointCoordGroupBox.Size = new System.Drawing.Size(249, 104);
			this.mPointCoordGroupBox.TabIndex = 0;
			this.mPointCoordGroupBox.TabStop = false;
			// 
			// mPointCoordXLabel
			// 
			this.mPointCoordXLabel.AutoSize = true;
			this.mPointCoordXLabel.Location = new System.Drawing.Point(10, 22);
			this.mPointCoordXLabel.Name = "mPointCoordXLabel";
			this.mPointCoordXLabel.Size = new System.Drawing.Size(17, 13);
			this.mPointCoordXLabel.TabIndex = 0;
			this.mPointCoordXLabel.Text = "X:";
			// 
			// mPointCoordYLabel
			// 
			this.mPointCoordYLabel.AutoSize = true;
			this.mPointCoordYLabel.Location = new System.Drawing.Point(10, 47);
			this.mPointCoordYLabel.Name = "mPointCoordYLabel";
			this.mPointCoordYLabel.Size = new System.Drawing.Size(17, 13);
			this.mPointCoordYLabel.TabIndex = 1;
			this.mPointCoordYLabel.Text = "Y:";
			// 
			// mPointCoordOLabel
			// 
			this.mPointCoordOLabel.AutoSize = true;
			this.mPointCoordOLabel.Location = new System.Drawing.Point(10, 73);
			this.mPointCoordOLabel.Name = "mPointCoordOLabel";
			this.mPointCoordOLabel.Size = new System.Drawing.Size(18, 13);
			this.mPointCoordOLabel.TabIndex = 2;
			this.mPointCoordOLabel.Text = "O:";
			// 
			// IteratorPointXxTextBox
			// 
			this.IteratorPointXxTextBox.Location = new System.Drawing.Point(33, 19);
			this.IteratorPointXxTextBox.Name = "IteratorPointXxTextBox";
			this.IteratorPointXxTextBox.Size = new System.Drawing.Size(99, 20);
			this.IteratorPointXxTextBox.TabIndex = 3;
			this.IteratorPointXxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPress);
			// 
			// IteratorPointXyTextBox
			// 
			this.IteratorPointXyTextBox.Location = new System.Drawing.Point(138, 19);
			this.IteratorPointXyTextBox.Name = "IteratorPointXyTextBox";
			this.IteratorPointXyTextBox.Size = new System.Drawing.Size(99, 20);
			this.IteratorPointXyTextBox.TabIndex = 4;
			this.IteratorPointXyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPress);
			// 
			// IteratorPointYyTextBox
			// 
			this.IteratorPointYyTextBox.Location = new System.Drawing.Point(138, 44);
			this.IteratorPointYyTextBox.Name = "IteratorPointYyTextBox";
			this.IteratorPointYyTextBox.Size = new System.Drawing.Size(99, 20);
			this.IteratorPointYyTextBox.TabIndex = 6;
			this.IteratorPointYyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPress);
			// 
			// IteratorPointYxTextBox
			// 
			this.IteratorPointYxTextBox.Location = new System.Drawing.Point(33, 44);
			this.IteratorPointYxTextBox.Name = "IteratorPointYxTextBox";
			this.IteratorPointYxTextBox.Size = new System.Drawing.Size(99, 20);
			this.IteratorPointYxTextBox.TabIndex = 5;
			this.IteratorPointYxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPress);
			// 
			// IteratorPointOyTextBox
			// 
			this.IteratorPointOyTextBox.Location = new System.Drawing.Point(138, 70);
			this.IteratorPointOyTextBox.Name = "IteratorPointOyTextBox";
			this.IteratorPointOyTextBox.Size = new System.Drawing.Size(99, 20);
			this.IteratorPointOyTextBox.TabIndex = 8;
			this.IteratorPointOyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPress);
			// 
			// IteratorPointOxTextBox
			// 
			this.IteratorPointOxTextBox.Location = new System.Drawing.Point(33, 70);
			this.IteratorPointOxTextBox.Name = "IteratorPointOxTextBox";
			this.IteratorPointOxTextBox.Size = new System.Drawing.Size(99, 20);
			this.IteratorPointOxTextBox.TabIndex = 7;
			this.IteratorPointOxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPress);
			// 
			// mIteratorControlsGroupBox
			// 
			this.mIteratorControlsGroupBox.Controls.Add(this.IteratorSnapAngle);
			this.mIteratorControlsGroupBox.Controls.Add(this.IteratorRotateCW);
			this.mIteratorControlsGroupBox.Controls.Add(this.IteratorRotateCCW);
			this.mIteratorControlsGroupBox.Controls.Add(this.IteratorRotate90CW);
			this.mIteratorControlsGroupBox.Controls.Add(this.IteratorRotate90CCW);
			this.mIteratorControlsGroupBox.Location = new System.Drawing.Point(24, 131);
			this.mIteratorControlsGroupBox.Name = "mIteratorControlsGroupBox";
			this.mIteratorControlsGroupBox.Size = new System.Drawing.Size(224, 144);
			this.mIteratorControlsGroupBox.TabIndex = 1;
			this.mIteratorControlsGroupBox.TabStop = false;
			// 
			// IteratorRotate90CCW
			// 
			this.IteratorRotate90CCW.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.IteratorRotate90CCW.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.IteratorRotate90CCW.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.IteratorRotate90CCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IteratorRotate90CCW.Image = ((System.Drawing.Image)(resources.GetObject("IteratorRotate90CCW.Image")));
			this.IteratorRotate90CCW.Location = new System.Drawing.Point(20, 23);
			this.IteratorRotate90CCW.Name = "IteratorRotate90CCW";
			this.IteratorRotate90CCW.Size = new System.Drawing.Size(24, 24);
			this.IteratorRotate90CCW.TabIndex = 0;
			this.IteratorRotate90CCW.UseVisualStyleBackColor = true;
			// 
			// IteratorRotate90CW
			// 
			this.IteratorRotate90CW.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.IteratorRotate90CW.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.IteratorRotate90CW.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.IteratorRotate90CW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IteratorRotate90CW.Image = ((System.Drawing.Image)(resources.GetObject("IteratorRotate90CW.Image")));
			this.IteratorRotate90CW.Location = new System.Drawing.Point(182, 23);
			this.IteratorRotate90CW.Name = "IteratorRotate90CW";
			this.IteratorRotate90CW.Size = new System.Drawing.Size(24, 24);
			this.IteratorRotate90CW.TabIndex = 1;
			this.IteratorRotate90CW.UseVisualStyleBackColor = true;
			// 
			// IteratorRotateCCW
			// 
			this.IteratorRotateCCW.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.IteratorRotateCCW.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.IteratorRotateCCW.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.IteratorRotateCCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IteratorRotateCCW.Image = ((System.Drawing.Image)(resources.GetObject("IteratorRotateCCW.Image")));
			this.IteratorRotateCCW.Location = new System.Drawing.Point(50, 23);
			this.IteratorRotateCCW.Name = "IteratorRotateCCW";
			this.IteratorRotateCCW.Size = new System.Drawing.Size(24, 24);
			this.IteratorRotateCCW.TabIndex = 2;
			this.IteratorRotateCCW.UseVisualStyleBackColor = true;
			// 
			// IteratorRotateCW
			// 
			this.IteratorRotateCW.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.IteratorRotateCW.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.IteratorRotateCW.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.IteratorRotateCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IteratorRotateCW.Image = ((System.Drawing.Image)(resources.GetObject("IteratorRotateCW.Image")));
			this.IteratorRotateCW.Location = new System.Drawing.Point(152, 23);
			this.IteratorRotateCW.Name = "IteratorRotateCW";
			this.IteratorRotateCW.Size = new System.Drawing.Size(24, 24);
			this.IteratorRotateCW.TabIndex = 3;
			this.IteratorRotateCW.UseVisualStyleBackColor = true;
			// 
			// IteratorSnapAngle
			// 
			this.IteratorSnapAngle.FormattingEnabled = true;
			this.IteratorSnapAngle.Location = new System.Drawing.Point(80, 25);
			this.IteratorSnapAngle.Name = "IteratorSnapAngle";
			this.IteratorSnapAngle.Size = new System.Drawing.Size(66, 21);
			this.IteratorSnapAngle.TabIndex = 4;
			this.IteratorSnapAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPress);
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 659);
			this.Controls.Add(this.mRootSplitter);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(600, 600);
			this.Name = "Editor";
			this.Text = "xw_prototype_2014-337";
			this.Load += new System.EventHandler(this.OnWindowLoaded);
			this.mRootSplitter.Panel1.ResumeLayout(false);
			this.mRootSplitter.Panel2.ResumeLayout(false);
			this.mRootSplitter.ResumeLayout(false);
			this.mSidebarSplitter.Panel1.ResumeLayout(false);
			this.mSidebarSplitter.Panel2.ResumeLayout(false);
			this.mSidebarSplitter.ResumeLayout(false);
			this.mPreviewPanel.ResumeLayout(false);
			this.mTabs.ResumeLayout(false);
			this.mColorTab.ResumeLayout(false);
			this.mIteratorColorGroupBox.ResumeLayout(false);
			this.mIteratorColorGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mPalettePictureBox)).EndInit();
			this.mIteratorPropertyPanel.ResumeLayout(false);
			this.mIteratorPropertyPanel.PerformLayout();
			this.mPointTab.ResumeLayout(false);
			this.mPointCoordGroupBox.ResumeLayout(false);
			this.mPointCoordGroupBox.PerformLayout();
			this.mIteratorControlsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer mRootSplitter;
		private EditorSettings mSettings;
		private System.Windows.Forms.SplitContainer mSidebarSplitter;
		private System.Windows.Forms.Panel mPreviewPanel;
		private System.Windows.Forms.Panel mIteratorPropertyPanel;
		private System.Windows.Forms.Label mIteratorSelectLabel;
		private System.Windows.Forms.Label mIteratorNameLabel;
		private System.Windows.Forms.Label mPictureBevel;
		private System.Windows.Forms.TabControl mTabs;
		private System.Windows.Forms.TabPage mColorTab;
		public System.Windows.Forms.ComboBox IteratorSelectionComboBox;
		public System.Windows.Forms.TextBox IteratorNameTextBox;
		public DragPanel IteratorWeightDragPanel;
		public System.Windows.Forms.TextBox IteratorWeightTextBox;
		public EditorCanvas IteratorCanvas;
		private System.Windows.Forms.GroupBox mIteratorColorGroupBox;
		public System.Windows.Forms.TextBox IteratorColorTextBox;
		public DragPanel IteratorColorDragPanel;
		private System.Windows.Forms.PictureBox mPalettePictureBox;
		public System.Windows.Forms.TextBox IteratorColorSpeedTextBox;
		public DragPanel IteratorColorSpeedDragPanel;
		public System.Windows.Forms.TextBox IteratorOpacityTextBox;
		public DragPanel IteratorOpacityDragPanel;
		public System.Windows.Forms.TextBox IteratorDirectColorTextBox;
		public DragPanel IteratorDirectColorDragPanel;
		public System.Windows.Forms.CheckBox IteratorIsExclusiveCheckBox;
		public System.Windows.Forms.HScrollBar IteratorColorScrollBar;
		private System.Windows.Forms.Label mPaletteBevel;
		private System.Windows.Forms.TabPage mPointTab;
		private System.Windows.Forms.GroupBox mPointCoordGroupBox;
		private System.Windows.Forms.Label mPointCoordOLabel;
		private System.Windows.Forms.Label mPointCoordYLabel;
		private System.Windows.Forms.Label mPointCoordXLabel;
		private System.Windows.Forms.TextBox IteratorPointXyTextBox;
		private System.Windows.Forms.TextBox IteratorPointXxTextBox;
		private System.Windows.Forms.TextBox IteratorPointYyTextBox;
		private System.Windows.Forms.TextBox IteratorPointYxTextBox;
		private System.Windows.Forms.TextBox IteratorPointOyTextBox;
		private System.Windows.Forms.TextBox IteratorPointOxTextBox;
		private System.Windows.Forms.GroupBox mIteratorControlsGroupBox;
		public System.Windows.Forms.Button IteratorRotate90CCW;
		public System.Windows.Forms.Button IteratorRotate90CW;
		public System.Windows.Forms.Button IteratorRotateCCW;
		public System.Windows.Forms.Button IteratorRotateCW;
		public System.Windows.Forms.ComboBox IteratorSnapAngle;
	}
}

