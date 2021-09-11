namespace MaverickImageEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.redo = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.grayscale = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.veriticalFlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalFlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertButton = new System.Windows.Forms.ToolStripButton();
            this.redFilter = new System.Windows.Forms.ToolStripButton();
            this.greenFilter = new System.Windows.Forms.ToolStripButton();
            this.blueFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cropbutton = new System.Windows.Forms.Button();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.brightnessUpDown = new System.Windows.Forms.NumericUpDown();
            this.brightnessApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.contrastApply = new System.Windows.Forms.Button();
            this.contrastUpDown = new System.Windows.Forms.NumericUpDown();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveMenu,
            this.resetToolStripMenuItem,
            this.undo,
            this.redo,
            this.cancelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.save,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open (New Image)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 22);
            this.save.Text = "Save As ...";
            this.save.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(43, 20);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(48, 20);
            this.undo.Text = "Undo";
            this.undo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click_1);
            // 
            // redo
            // 
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(46, 20);
            this.redo.Text = "Redo";
            this.redo.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.grayscale,
            this.toolStripSplitButton1,
            this.invertButton,
            this.redFilter,
            this.greenFilter,
            this.blueFilter,
            this.toolStripButton4});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(978, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Crop";
            this.toolStripButton3.ToolTipText = "Crop";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // grayscale
            // 
            this.grayscale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grayscale.Image = ((System.Drawing.Image)(resources.GetObject("grayscale.Image")));
            this.grayscale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.grayscale.Name = "grayscale";
            this.grayscale.Size = new System.Drawing.Size(23, 22);
            this.grayscale.Text = "grayscale";
            this.grayscale.ToolTipText = "GrayScale";
            this.grayscale.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.veriticalFlipToolStripMenuItem,
            this.horizontalFlipToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ToolTipText = "Flip";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem2.Text = "90";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem3.Text = "180";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem4.Text = "-90";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // veriticalFlipToolStripMenuItem
            // 
            this.veriticalFlipToolStripMenuItem.Name = "veriticalFlipToolStripMenuItem";
            this.veriticalFlipToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.veriticalFlipToolStripMenuItem.Text = "Veritical Flip";
            this.veriticalFlipToolStripMenuItem.Click += new System.EventHandler(this.veriticalFlipToolStripMenuItem_Click);
            // 
            // horizontalFlipToolStripMenuItem
            // 
            this.horizontalFlipToolStripMenuItem.Name = "horizontalFlipToolStripMenuItem";
            this.horizontalFlipToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.horizontalFlipToolStripMenuItem.Text = "Horizontal Flip";
            this.horizontalFlipToolStripMenuItem.Click += new System.EventHandler(this.horizontalFlipToolStripMenuItem_Click);
            // 
            // invertButton
            // 
            this.invertButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invertButton.Image = ((System.Drawing.Image)(resources.GetObject("invertButton.Image")));
            this.invertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(23, 22);
            this.invertButton.Text = "toolStripButton1";
            this.invertButton.ToolTipText = "Invert";
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // redFilter
            // 
            this.redFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redFilter.Image = ((System.Drawing.Image)(resources.GetObject("redFilter.Image")));
            this.redFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redFilter.Name = "redFilter";
            this.redFilter.Size = new System.Drawing.Size(23, 22);
            this.redFilter.Text = "redFilter";
            this.redFilter.ToolTipText = "Red Filter";
            this.redFilter.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // greenFilter
            // 
            this.greenFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.greenFilter.Image = ((System.Drawing.Image)(resources.GetObject("greenFilter.Image")));
            this.greenFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenFilter.Name = "greenFilter";
            this.greenFilter.Size = new System.Drawing.Size(23, 22);
            this.greenFilter.Text = "green filter";
            this.greenFilter.ToolTipText = "Green Filter";
            this.greenFilter.Click += new System.EventHandler(this.greenFilter_Click);
            // 
            // blueFilter
            // 
            this.blueFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blueFilter.Image = ((System.Drawing.Image)(resources.GetObject("blueFilter.Image")));
            this.blueFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blueFilter.Name = "blueFilter";
            this.blueFilter.Size = new System.Drawing.Size(23, 22);
            this.blueFilter.Text = "blueFilter";
            this.blueFilter.Click += new System.EventHandler(this.blueFilter_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Sepia Filter";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.PictureBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(978, 519);
            this.splitContainer1.SplitterDistance = 710;
            this.splitContainer1.TabIndex = 2;
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(12, 38);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(679, 447);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 239);
            this.tabControl1.TabIndex = 3;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.button1);
            this.tab1.Controls.Add(this.cropbutton);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(256, 211);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Crop";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(67, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cropbutton
            // 
            this.cropbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cropbutton.AutoSize = true;
            this.cropbutton.Location = new System.Drawing.Point(67, 66);
            this.cropbutton.Name = "cropbutton";
            this.cropbutton.Size = new System.Drawing.Size(126, 30);
            this.cropbutton.TabIndex = 0;
            this.cropbutton.Text = "Crop";
            this.cropbutton.UseVisualStyleBackColor = true;
            this.cropbutton.Click += new System.EventHandler(this.cropbutton_Click);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.brightnessUpDown);
            this.tab2.Controls.Add(this.brightnessApply);
            this.tab2.Controls.Add(this.label1);
            this.tab2.Controls.Add(this.brightnessTrackBar);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(256, 211);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Brightness";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // brightnessUpDown
            // 
            this.brightnessUpDown.AutoSize = true;
            this.brightnessUpDown.Location = new System.Drawing.Point(186, 67);
            this.brightnessUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.brightnessUpDown.Name = "brightnessUpDown";
            this.brightnessUpDown.Size = new System.Drawing.Size(47, 21);
            this.brightnessUpDown.TabIndex = 3;
            this.brightnessUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // brightnessApply
            // 
            this.brightnessApply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brightnessApply.AutoSize = true;
            this.brightnessApply.Location = new System.Drawing.Point(93, 119);
            this.brightnessApply.Name = "brightnessApply";
            this.brightnessApply.Size = new System.Drawing.Size(86, 28);
            this.brightnessApply.TabIndex = 2;
            this.brightnessApply.Text = "Apply";
            this.brightnessApply.UseVisualStyleBackColor = true;
            this.brightnessApply.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Brightness";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(14, 58);
            this.brightnessTrackBar.Maximum = 255;
            this.brightnessTrackBar.Minimum = -255;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(144, 45);
            this.brightnessTrackBar.TabIndex = 0;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.label2);
            this.tab3.Controls.Add(this.contrastApply);
            this.tab3.Controls.Add(this.contrastUpDown);
            this.tab3.Controls.Add(this.contrastTrackBar);
            this.tab3.Location = new System.Drawing.Point(4, 24);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(256, 211);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Contrast";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set Contrast";
            // 
            // contrastApply
            // 
            this.contrastApply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contrastApply.AutoSize = true;
            this.contrastApply.Location = new System.Drawing.Point(95, 126);
            this.contrastApply.Name = "contrastApply";
            this.contrastApply.Size = new System.Drawing.Size(86, 28);
            this.contrastApply.TabIndex = 5;
            this.contrastApply.Text = "Apply";
            this.contrastApply.UseVisualStyleBackColor = true;
            this.contrastApply.Click += new System.EventHandler(this.contrastApply_Click);
            // 
            // contrastUpDown
            // 
            this.contrastUpDown.AutoSize = true;
            this.contrastUpDown.Location = new System.Drawing.Point(187, 66);
            this.contrastUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.contrastUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.contrastUpDown.Name = "contrastUpDown";
            this.contrastUpDown.Size = new System.Drawing.Size(47, 21);
            this.contrastUpDown.TabIndex = 4;
            this.contrastUpDown.ValueChanged += new System.EventHandler(this.contrastUpDown_ValueChanged);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(27, 57);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = -100;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(144, 45);
            this.contrastTrackBar.TabIndex = 1;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.PictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Location = new System.Drawing.Point(3, 20);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(258, 248);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 568);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Maverick";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ToolStripButton grayscale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.NumericUpDown brightnessUpDown;
        private System.Windows.Forms.Button brightnessApply;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem horizontalFlipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriticalFlipToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton invertButton;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem redo;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.NumericUpDown contrastUpDown;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.Button contrastApply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button cropbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton redFilter;
        private System.Windows.Forms.ToolStripButton greenFilter;
        private System.Windows.Forms.ToolStripButton blueFilter;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

