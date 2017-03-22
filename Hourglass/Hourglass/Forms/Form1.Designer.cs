﻿
namespace Hourglass
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.levelSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spHierarchyPanel = new System.Windows.Forms.SplitContainer();
			this.mMenuButton = new Hourglass.MenuButton();
			this.mCreateMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mCreateMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.mCreateMenuAddChild = new System.Windows.Forms.ToolStripMenuItem();
			this.Tree = new System.Windows.Forms.TreeView();
			this.spWorldView = new System.Windows.Forms.SplitContainer();
			this.graphicsPanel1 = new Hourglass.GraphicsPanel();
			this.LeftToggle = new Hourglass.NoFocusButton();
			this.RightToggle = new Hourglass.NoFocusButton();
			this.btnComponentAdd = new Hourglass.MenuButton();
			this.mComponentStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.planeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controllerColliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.particleEmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumeEmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.radialEmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.codeComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.meshComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.audioComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.mObjectStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spHierarchyPanel)).BeginInit();
			this.spHierarchyPanel.Panel1.SuspendLayout();
			this.spHierarchyPanel.Panel2.SuspendLayout();
			this.spHierarchyPanel.SuspendLayout();
			this.mCreateMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spWorldView)).BeginInit();
			this.spWorldView.Panel1.SuspendLayout();
			this.spWorldView.Panel2.SuspendLayout();
			this.spWorldView.SuspendLayout();
			this.graphicsPanel1.SuspendLayout();
			this.mComponentStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(944, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// createToolStripMenuItem
			// 
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.createToolStripMenuItem.Text = "Create";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
			this.editToolStripMenuItem.Enabled = false;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Enabled = false;
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.undoToolStripMenuItem.Text = "&Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Enabled = false;
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.redoToolStripMenuItem.Text = "&Redo";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Enabled = false;
			this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
			this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.cutToolStripMenuItem.Text = "Cu&t";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Enabled = false;
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Enabled = false;
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Enabled = false;
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelSettingsToolStripMenuItem,
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// levelSettingsToolStripMenuItem
			// 
			this.levelSettingsToolStripMenuItem.Name = "levelSettingsToolStripMenuItem";
			this.levelSettingsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.levelSettingsToolStripMenuItem.Text = "Level Settings";
			this.levelSettingsToolStripMenuItem.Click += new System.EventHandler(this.levelSettingsToolStripMenuItem_Click);
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.Enabled = false;
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Enabled = false;
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Enabled = false;
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.contentsToolStripMenuItem.Text = "&Contents";
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.Enabled = false;
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.indexToolStripMenuItem.Text = "&Index";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Enabled = false;
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.searchToolStripMenuItem.Text = "&Search";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// spHierarchyPanel
			// 
			this.spHierarchyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spHierarchyPanel.Location = new System.Drawing.Point(0, 24);
			this.spHierarchyPanel.Margin = new System.Windows.Forms.Padding(0);
			this.spHierarchyPanel.Name = "spHierarchyPanel";
			// 
			// spHierarchyPanel.Panel1
			// 
			this.spHierarchyPanel.Panel1.Controls.Add(this.mMenuButton);
			this.spHierarchyPanel.Panel1.Controls.Add(this.Tree);
			this.spHierarchyPanel.Panel1.ForeColor = System.Drawing.SystemColors.Control;
			this.spHierarchyPanel.Panel1MinSize = 150;
			// 
			// spHierarchyPanel.Panel2
			// 
			this.spHierarchyPanel.Panel2.Controls.Add(this.spWorldView);
			this.spHierarchyPanel.Panel2MinSize = 750;
			this.spHierarchyPanel.Size = new System.Drawing.Size(944, 628);
			this.spHierarchyPanel.SplitterDistance = 161;
			this.spHierarchyPanel.SplitterWidth = 8;
			this.spHierarchyPanel.TabIndex = 3;
			this.spHierarchyPanel.TabStop = false;
			// 
			// mMenuButton
			// 
			this.mMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.mMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.mMenuButton.Location = new System.Drawing.Point(0, 0);
			this.mMenuButton.Menu = this.mCreateMenuStrip;
			this.mMenuButton.Name = "mMenuButton";
			this.mMenuButton.Size = new System.Drawing.Size(161, 23);
			this.mMenuButton.TabIndex = 1;
			this.mMenuButton.Text = "Create Object            ";
			this.mMenuButton.UseVisualStyleBackColor = true;
			this.mMenuButton.Click += new System.EventHandler(this.mMenuButton_Click);
			// 
			// mCreateMenuStrip
			// 
			this.mCreateMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCreateMenuAdd,
            this.mCreateMenuAddChild});
			this.mCreateMenuStrip.Name = "contextMenuStrip1";
			this.mCreateMenuStrip.Size = new System.Drawing.Size(147, 48);
			// 
			// mCreateMenuAdd
			// 
			this.mCreateMenuAdd.Name = "mCreateMenuAdd";
			this.mCreateMenuAdd.Size = new System.Drawing.Size(146, 22);
			this.mCreateMenuAdd.Text = "Create Object";
			this.mCreateMenuAdd.Click += new System.EventHandler(this.mCreateMenuAdd_Click);
			// 
			// mCreateMenuAddChild
			// 
			this.mCreateMenuAddChild.Name = "mCreateMenuAddChild";
			this.mCreateMenuAddChild.Size = new System.Drawing.Size(146, 22);
			this.mCreateMenuAddChild.Text = "Create Child";
			this.mCreateMenuAddChild.Click += new System.EventHandler(this.mCreateMenuAddChild_Click);
			// 
			// Tree
			// 
			this.Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Tree.BackColor = System.Drawing.SystemColors.Control;
			this.Tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Tree.CausesValidation = false;
			this.Tree.HideSelection = false;
			this.Tree.Indent = 10;
			this.Tree.Location = new System.Drawing.Point(-3, 22);
			this.Tree.Name = "Tree";
			this.Tree.PathSeparator = "/";
			this.Tree.ShowRootLines = false;
			this.Tree.Size = new System.Drawing.Size(161, 606);
			this.Tree.TabIndex = 0;
			this.Tree.TabStop = false;
			this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
			// 
			// spWorldView
			// 
			this.spWorldView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spWorldView.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.spWorldView.Location = new System.Drawing.Point(0, 0);
			this.spWorldView.Margin = new System.Windows.Forms.Padding(0);
			this.spWorldView.Name = "spWorldView";
			// 
			// spWorldView.Panel1
			// 
			this.spWorldView.Panel1.Controls.Add(this.graphicsPanel1);
			this.spWorldView.Panel1MinSize = 450;
			// 
			// spWorldView.Panel2
			// 
			this.spWorldView.Panel2.AutoScroll = true;
			this.spWorldView.Panel2.Controls.Add(this.btnComponentAdd);
			this.spWorldView.Panel2MinSize = 300;
			this.spWorldView.Size = new System.Drawing.Size(775, 628);
			this.spWorldView.SplitterDistance = 450;
			this.spWorldView.SplitterWidth = 8;
			this.spWorldView.TabIndex = 3;
			// 
			// graphicsPanel1
			// 
			this.graphicsPanel1.Controls.Add(this.LeftToggle);
			this.graphicsPanel1.Controls.Add(this.RightToggle);
			this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.graphicsPanel1.Location = new System.Drawing.Point(0, 0);
			this.graphicsPanel1.Name = "graphicsPanel1";
			this.graphicsPanel1.Size = new System.Drawing.Size(450, 628);
			this.graphicsPanel1.TabIndex = 2;
			this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
			this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
			this.graphicsPanel1.MouseLeave += new System.EventHandler(this.graphicsPanel1_MouseLeave);
			this.graphicsPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseMove);
			this.graphicsPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseUp);
			// 
			// LeftToggle
			// 
			this.LeftToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LeftToggle.Location = new System.Drawing.Point(3, 3);
			this.LeftToggle.MinimumSize = new System.Drawing.Size(1, 1);
			this.LeftToggle.Name = "LeftToggle";
			this.LeftToggle.Size = new System.Drawing.Size(23, 23);
			this.LeftToggle.TabIndex = 1;
			this.LeftToggle.Text = "<";
			this.LeftToggle.UseVisualStyleBackColor = true;
			this.LeftToggle.Click += new System.EventHandler(this.LeftToggle_Click);
			// 
			// RightToggle
			// 
			this.RightToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RightToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RightToggle.Location = new System.Drawing.Point(417, 3);
			this.RightToggle.MinimumSize = new System.Drawing.Size(1, 1);
			this.RightToggle.Name = "RightToggle";
			this.RightToggle.Size = new System.Drawing.Size(23, 23);
			this.RightToggle.TabIndex = 0;
			this.RightToggle.Text = ">";
			this.RightToggle.UseVisualStyleBackColor = true;
			this.RightToggle.Click += new System.EventHandler(this.RightToggle_Click);
			// 
			// btnComponentAdd
			// 
			this.btnComponentAdd.ArrowVisible = false;
			this.btnComponentAdd.Location = new System.Drawing.Point(81, 3);
			this.btnComponentAdd.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
			this.btnComponentAdd.Menu = this.mComponentStrip;
			this.btnComponentAdd.Name = "btnComponentAdd";
			this.btnComponentAdd.Size = new System.Drawing.Size(158, 23);
			this.btnComponentAdd.TabIndex = 0;
			this.btnComponentAdd.Text = "Add Component";
			this.btnComponentAdd.UseVisualStyleBackColor = true;
			// 
			// mComponentStrip
			// 
			this.mComponentStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.particleEmitterToolStripMenuItem,
            this.codeComponentsToolStripMenuItem,
            this.meshComponentToolStripMenuItem,
            this.audioComponentToolStripMenuItem});
			this.mComponentStrip.Name = "contextMenuStrip1";
			this.mComponentStrip.Size = new System.Drawing.Size(175, 114);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boxToolStripMenuItem,
            this.sphereToolStripMenuItem,
            this.planeToolStripMenuItem,
            this.buttonToolStripMenuItem,
            this.controllerColliderToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
			this.toolStripMenuItem1.Text = "Colliders";
			// 
			// boxToolStripMenuItem
			// 
			this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
			this.boxToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.boxToolStripMenuItem.Text = "Box Collider";
			this.boxToolStripMenuItem.Click += new System.EventHandler(this.AddColliderComponent);
			// 
			// sphereToolStripMenuItem
			// 
			this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
			this.sphereToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.sphereToolStripMenuItem.Text = "Sphere Collider";
			// 
			// planeToolStripMenuItem
			// 
			this.planeToolStripMenuItem.Name = "planeToolStripMenuItem";
			this.planeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.planeToolStripMenuItem.Text = "Plane Collider";
			// 
			// buttonToolStripMenuItem
			// 
			this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
			this.buttonToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.buttonToolStripMenuItem.Text = "Button Collider";
			// 
			// controllerColliderToolStripMenuItem
			// 
			this.controllerColliderToolStripMenuItem.Name = "controllerColliderToolStripMenuItem";
			this.controllerColliderToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.controllerColliderToolStripMenuItem.Text = "Controller Collider";
			// 
			// particleEmitterToolStripMenuItem
			// 
			this.particleEmitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumeEmitterToolStripMenuItem,
            this.radialEmitterToolStripMenuItem,
            this.iDCToolStripMenuItem});
			this.particleEmitterToolStripMenuItem.Name = "particleEmitterToolStripMenuItem";
			this.particleEmitterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.particleEmitterToolStripMenuItem.Text = "Particle Emitters";
			// 
			// volumeEmitterToolStripMenuItem
			// 
			this.volumeEmitterToolStripMenuItem.Name = "volumeEmitterToolStripMenuItem";
			this.volumeEmitterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.volumeEmitterToolStripMenuItem.Text = "Volume Emitter";
			// 
			// radialEmitterToolStripMenuItem
			// 
			this.radialEmitterToolStripMenuItem.Name = "radialEmitterToolStripMenuItem";
			this.radialEmitterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.radialEmitterToolStripMenuItem.Text = "Radial Emitter";
			// 
			// iDCToolStripMenuItem
			// 
			this.iDCToolStripMenuItem.Name = "iDCToolStripMenuItem";
			this.iDCToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.iDCToolStripMenuItem.Text = "\"IDC\"";
			// 
			// codeComponentsToolStripMenuItem
			// 
			this.codeComponentsToolStripMenuItem.Name = "codeComponentsToolStripMenuItem";
			this.codeComponentsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.codeComponentsToolStripMenuItem.Text = "Code Components";
			// 
			// meshComponentToolStripMenuItem
			// 
			this.meshComponentToolStripMenuItem.Name = "meshComponentToolStripMenuItem";
			this.meshComponentToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.meshComponentToolStripMenuItem.Text = "Mesh Component";
			// 
			// audioComponentToolStripMenuItem
			// 
			this.audioComponentToolStripMenuItem.Name = "audioComponentToolStripMenuItem";
			this.audioComponentToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.audioComponentToolStripMenuItem.Text = "Audio Component";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// mObjectStrip
			// 
			this.mObjectStrip.Name = "mObjectStrip";
			this.mObjectStrip.Size = new System.Drawing.Size(61, 4);
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 652);
			this.Controls.Add(this.spHierarchyPanel);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(960, 39);
			this.Name = "Editor";
			this.Text = "Level Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.spHierarchyPanel.Panel1.ResumeLayout(false);
			this.spHierarchyPanel.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spHierarchyPanel)).EndInit();
			this.spHierarchyPanel.ResumeLayout(false);
			this.mCreateMenuStrip.ResumeLayout(false);
			this.spWorldView.Panel1.ResumeLayout(false);
			this.spWorldView.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spWorldView)).EndInit();
			this.spWorldView.ResumeLayout(false);
			this.graphicsPanel1.ResumeLayout(false);
			this.mComponentStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.SplitContainer spWorldView;
        private System.Windows.Forms.SplitContainer spHierarchyPanel;
        private NoFocusButton RightToggle;
        private NoFocusButton LeftToggle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.ToolStripMenuItem levelSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private MenuButton mMenuButton;
        private System.Windows.Forms.ContextMenuStrip mCreateMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mCreateMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem mCreateMenuAddChild;
        private System.Windows.Forms.ContextMenuStrip mObjectStrip;
		private System.Windows.Forms.ContextMenuStrip mComponentStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem planeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem controllerColliderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem particleEmitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem meshComponentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem audioComponentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem codeComponentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumeEmitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem radialEmitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iDCToolStripMenuItem;
		private MenuButton btnComponentAdd;
	}
}

