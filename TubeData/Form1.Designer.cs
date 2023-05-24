namespace TubeData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            txtDirectoryPath = new TextBox();
            FolderDirectoryBtn = new Button();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            progressBar1 = new ProgressBar();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolTip1 = new ToolTip(components);
            tblPnlMain = new TableLayoutPanel();
            tblPanelDataEntry = new TableLayoutPanel();
            labelClient = new Label();
            labelDate = new Label();
            labelMaterial = new Label();
            labelCutLength = new Label();
            labelDrawingNo = new Label();
            labelPartNo = new Label();
            labelTubeSize = new Label();
            labelToolingSize = new Label();
            tblPnlButtons = new TableLayoutPanel();
            buttonClear = new Button();
            textBox_1 = new TextBox();
            textBox_2 = new TextBox();
            textBox_3 = new TextBox();
            textBox_4 = new TextBox();
            textBox_5 = new TextBox();
            textBox_6 = new TextBox();
            textBox_7 = new TextBox();
            textBox_8 = new TextBox();
            tblPnlSaveCancel = new TableLayoutPanel();
            buttonCancel = new Button();
            buttonSave = new Button();
            tblPnlComments = new TableLayoutPanel();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            labelComments = new Label();
            labelSpecialWorkInstruction = new Label();
            tblPanelLRAControls = new TableLayoutPanel();
            buttonAddRow = new Button();
            buttonRemoveRow = new Button();
            buttonClearLRA = new Button();
            tblPanelLRAValues = new TableLayoutPanel();
            labelLength = new Label();
            labelRotationDegree = new Label();
            labelReadOut = new Label();
            labelSpringbackAngle = new Label();
            labelRequiredAngle = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelProductionOrder = new Label();
            textBoxProductionOrder = new TextBox();
            labelFileDirectory = new Label();
            mainPanel = new Panel();
            toolStrip1.SuspendLayout();
            tblPnlMain.SuspendLayout();
            tblPanelDataEntry.SuspendLayout();
            tblPnlButtons.SuspendLayout();
            tblPnlSaveCancel.SuspendLayout();
            tblPnlComments.SuspendLayout();
            tblPanelLRAControls.SuspendLayout();
            tblPanelLRAValues.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, printToolStripButton, toolStripSeparator, helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1414, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(63, 24);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += NewToolStripButton_Click;
            // 
            // openToolStripButton
            // 
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(69, 24);
            openToolStripButton.Text = "&Open";
            openToolStripButton.Click += OpenToolStripButton_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(64, 24);
            saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(63, 24);
            printToolStripButton.Text = "&Print";
            printToolStripButton.Click += PrintToolStripButton_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.Alignment = ToolStripItemAlignment.Right;
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(29, 24);
            helpToolStripButton.Text = "He&lp";
            // 
            // txtDirectoryPath
            // 
            txtDirectoryPath.Location = new Point(12, 97);
            txtDirectoryPath.Name = "txtDirectoryPath";
            txtDirectoryPath.Size = new Size(184, 27);
            txtDirectoryPath.TabIndex = 1;
            // 
            // FolderDirectoryBtn
            // 
            FolderDirectoryBtn.Location = new Point(202, 97);
            FolderDirectoryBtn.Name = "FolderDirectoryBtn";
            FolderDirectoryBtn.Size = new Size(44, 28);
            FolderDirectoryBtn.TabIndex = 2;
            FolderDirectoryBtn.Text = "...";
            FolderDirectoryBtn.UseVisualStyleBackColor = true;
            FolderDirectoryBtn.Click += FolderDirectoryBtn_Click;
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeView1.Location = new Point(12, 131);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(234, 720);
            treeView1.StateImageList = imageList1;
            treeView1.TabIndex = 3;
            treeView1.NodeMouseDoubleClick += TreeView1_NodeMouseDoubleClick_1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-opened-folder-16.png");
            imageList1.Images.SetKeyName(1, "slinky.jpg");
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progressBar1.Location = new Point(12, 857);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(234, 12);
            progressBar1.TabIndex = 4;
            // 
            // tblPnlMain
            // 
            tblPnlMain.AutoSize = true;
            tblPnlMain.ColumnCount = 1;
            tblPnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnlMain.Controls.Add(tblPanelDataEntry, 0, 1);
            tblPnlMain.Controls.Add(tblPnlSaveCancel, 0, 5);
            tblPnlMain.Controls.Add(tblPnlComments, 0, 4);
            tblPnlMain.Controls.Add(tblPanelLRAControls, 0, 3);
            tblPnlMain.Controls.Add(tblPanelLRAValues, 0, 2);
            tblPnlMain.Controls.Add(tableLayoutPanel4, 0, 0);
            tblPnlMain.Dock = DockStyle.Fill;
            tblPnlMain.Location = new Point(20, 20);
            tblPnlMain.Name = "tblPnlMain";
            tblPnlMain.RowCount = 6;
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.Size = new Size(1099, 859);
            tblPnlMain.TabIndex = 5;
            // 
            // tblPanelDataEntry
            // 
            tblPanelDataEntry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblPanelDataEntry.ColumnCount = 4;
            tblPanelDataEntry.ColumnStyles.Add(new ColumnStyle());
            tblPanelDataEntry.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPanelDataEntry.ColumnStyles.Add(new ColumnStyle());
            tblPanelDataEntry.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPanelDataEntry.Controls.Add(labelClient, 0, 0);
            tblPanelDataEntry.Controls.Add(labelDate, 0, 1);
            tblPanelDataEntry.Controls.Add(labelMaterial, 0, 2);
            tblPanelDataEntry.Controls.Add(labelCutLength, 0, 3);
            tblPanelDataEntry.Controls.Add(labelDrawingNo, 2, 0);
            tblPanelDataEntry.Controls.Add(labelPartNo, 2, 1);
            tblPanelDataEntry.Controls.Add(labelTubeSize, 2, 2);
            tblPanelDataEntry.Controls.Add(labelToolingSize, 2, 3);
            tblPanelDataEntry.Controls.Add(tblPnlButtons, 3, 4);
            tblPanelDataEntry.Controls.Add(textBox_1, 1, 0);
            tblPanelDataEntry.Controls.Add(textBox_2, 3, 0);
            tblPanelDataEntry.Controls.Add(textBox_3, 1, 1);
            tblPanelDataEntry.Controls.Add(textBox_4, 3, 1);
            tblPanelDataEntry.Controls.Add(textBox_5, 1, 2);
            tblPanelDataEntry.Controls.Add(textBox_6, 3, 2);
            tblPanelDataEntry.Controls.Add(textBox_7, 1, 3);
            tblPanelDataEntry.Controls.Add(textBox_8, 3, 3);
            tblPanelDataEntry.Location = new Point(30, 169);
            tblPanelDataEntry.Margin = new Padding(30, 15, 30, 3);
            tblPanelDataEntry.Name = "tblPanelDataEntry";
            tblPanelDataEntry.RowCount = 5;
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.Size = new Size(1039, 173);
            tblPanelDataEntry.TabIndex = 4;
            // 
            // labelClient
            // 
            labelClient.Anchor = AnchorStyles.Left;
            labelClient.AutoSize = true;
            labelClient.Location = new Point(3, 6);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(50, 20);
            labelClient.TabIndex = 0;
            labelClient.Text = "Client:";
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Left;
            labelDate.AutoSize = true;
            labelDate.Location = new Point(3, 39);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(44, 20);
            labelDate.TabIndex = 0;
            labelDate.Text = "Date:";
            // 
            // labelMaterial
            // 
            labelMaterial.Anchor = AnchorStyles.Left;
            labelMaterial.AutoSize = true;
            labelMaterial.Location = new Point(3, 72);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(67, 20);
            labelMaterial.TabIndex = 0;
            labelMaterial.Text = "Material:";
            // 
            // labelCutLength
            // 
            labelCutLength.Anchor = AnchorStyles.Left;
            labelCutLength.AutoSize = true;
            labelCutLength.Location = new Point(3, 105);
            labelCutLength.Name = "labelCutLength";
            labelCutLength.Size = new Size(83, 20);
            labelCutLength.TabIndex = 0;
            labelCutLength.Text = "Cut Length:";
            // 
            // labelDrawingNo
            // 
            labelDrawingNo.Anchor = AnchorStyles.Left;
            labelDrawingNo.AutoSize = true;
            labelDrawingNo.Location = new Point(517, 6);
            labelDrawingNo.Name = "labelDrawingNo";
            labelDrawingNo.Size = new Size(92, 20);
            labelDrawingNo.TabIndex = 0;
            labelDrawingNo.Text = "Drawing No:";
            // 
            // labelPartNo
            // 
            labelPartNo.Anchor = AnchorStyles.Left;
            labelPartNo.AutoSize = true;
            labelPartNo.Location = new Point(517, 39);
            labelPartNo.Name = "labelPartNo";
            labelPartNo.Size = new Size(61, 20);
            labelPartNo.TabIndex = 0;
            labelPartNo.Text = "Part No:";
            // 
            // labelTubeSize
            // 
            labelTubeSize.Anchor = AnchorStyles.Left;
            labelTubeSize.AutoSize = true;
            labelTubeSize.Location = new Point(517, 72);
            labelTubeSize.Name = "labelTubeSize";
            labelTubeSize.Size = new Size(76, 20);
            labelTubeSize.TabIndex = 0;
            labelTubeSize.Text = "Tube Size:";
            // 
            // labelToolingSize
            // 
            labelToolingSize.Anchor = AnchorStyles.Left;
            labelToolingSize.AutoSize = true;
            labelToolingSize.Location = new Point(517, 105);
            labelToolingSize.Name = "labelToolingSize";
            labelToolingSize.Size = new Size(93, 20);
            labelToolingSize.TabIndex = 0;
            labelToolingSize.Text = "Tooling Size:";
            // 
            // tblPnlButtons
            // 
            tblPnlButtons.Anchor = AnchorStyles.Right;
            tblPnlButtons.ColumnCount = 2;
            tblPnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnlButtons.ColumnStyles.Add(new ColumnStyle());
            tblPnlButtons.Controls.Add(buttonClear, 1, 0);
            tblPnlButtons.Location = new Point(816, 135);
            tblPnlButtons.Name = "tblPnlButtons";
            tblPnlButtons.RowCount = 1;
            tblPnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlButtons.Size = new Size(220, 35);
            tblPnlButtons.TabIndex = 8;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Right;
            buttonClear.Location = new Point(80, 3);
            buttonClear.Margin = new Padding(3, 3, 20, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(120, 29);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonClear_Click;
            // 
            // textBox_1
            // 
            textBox_1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_1.Location = new Point(92, 3);
            textBox_1.Margin = new Padding(3, 3, 20, 3);
            textBox_1.Name = "textBox_1";
            textBox_1.Size = new Size(402, 27);
            textBox_1.TabIndex = 0;
            textBox_1.Tag = "client";
            // 
            // textBox_2
            // 
            textBox_2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_2.Location = new Point(616, 3);
            textBox_2.Margin = new Padding(3, 3, 20, 3);
            textBox_2.Name = "textBox_2";
            textBox_2.Size = new Size(403, 27);
            textBox_2.TabIndex = 1;
            textBox_2.Tag = "drawingNo";
            // 
            // textBox_3
            // 
            textBox_3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_3.Location = new Point(92, 36);
            textBox_3.Margin = new Padding(3, 3, 20, 3);
            textBox_3.Name = "textBox_3";
            textBox_3.Size = new Size(402, 27);
            textBox_3.TabIndex = 2;
            textBox_3.Tag = "date";
            // 
            // textBox_4
            // 
            textBox_4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_4.Location = new Point(616, 36);
            textBox_4.Margin = new Padding(3, 3, 20, 3);
            textBox_4.Name = "textBox_4";
            textBox_4.Size = new Size(403, 27);
            textBox_4.TabIndex = 3;
            textBox_4.Tag = "partNo";
            // 
            // textBox_5
            // 
            textBox_5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_5.Location = new Point(92, 69);
            textBox_5.Margin = new Padding(3, 3, 20, 3);
            textBox_5.Name = "textBox_5";
            textBox_5.Size = new Size(402, 27);
            textBox_5.TabIndex = 4;
            textBox_5.Tag = "material";
            // 
            // textBox_6
            // 
            textBox_6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_6.Location = new Point(616, 69);
            textBox_6.Margin = new Padding(3, 3, 20, 3);
            textBox_6.Name = "textBox_6";
            textBox_6.Size = new Size(403, 27);
            textBox_6.TabIndex = 5;
            textBox_6.Tag = "tubeSize";
            // 
            // textBox_7
            // 
            textBox_7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_7.Location = new Point(92, 102);
            textBox_7.Margin = new Padding(3, 3, 20, 3);
            textBox_7.Name = "textBox_7";
            textBox_7.Size = new Size(402, 27);
            textBox_7.TabIndex = 6;
            textBox_7.Tag = "cutLength";
            // 
            // textBox_8
            // 
            textBox_8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_8.Location = new Point(616, 102);
            textBox_8.Margin = new Padding(3, 3, 20, 3);
            textBox_8.Name = "textBox_8";
            textBox_8.Size = new Size(403, 27);
            textBox_8.TabIndex = 7;
            textBox_8.Tag = "toolingSize";
            // 
            // tblPnlSaveCancel
            // 
            tblPnlSaveCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tblPnlSaveCancel.ColumnCount = 2;
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle());
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPnlSaveCancel.Controls.Add(buttonCancel, 1, 0);
            tblPnlSaveCancel.Controls.Add(buttonSave, 0, 0);
            tblPnlSaveCancel.Location = new Point(3, 818);
            tblPnlSaveCancel.Margin = new Padding(3, 3, 30, 3);
            tblPnlSaveCancel.Name = "tblPnlSaveCancel";
            tblPnlSaveCancel.RowCount = 1;
            tblPnlSaveCancel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlSaveCancel.Size = new Size(1066, 38);
            tblPnlSaveCancel.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Right;
            buttonCancel.Location = new Point(969, 6);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 26);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Right;
            buttonSave.Location = new Point(869, 6);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 26);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click_1;
            // 
            // tblPnlComments
            // 
            tblPnlComments.AutoSize = true;
            tblPnlComments.BackColor = SystemColors.Control;
            tblPnlComments.ColumnCount = 2;
            tblPnlComments.ColumnStyles.Add(new ColumnStyle());
            tblPnlComments.ColumnStyles.Add(new ColumnStyle());
            tblPnlComments.Controls.Add(richTextBox1, 1, 0);
            tblPnlComments.Controls.Add(richTextBox2, 1, 1);
            tblPnlComments.Controls.Add(labelComments, 0, 1);
            tblPnlComments.Controls.Add(labelSpecialWorkInstruction, 0, 0);
            tblPnlComments.Dock = DockStyle.Fill;
            tblPnlComments.Location = new Point(30, 670);
            tblPnlComments.Margin = new Padding(30, 15, 30, 3);
            tblPnlComments.Name = "tblPnlComments";
            tblPnlComments.Padding = new Padding(0, 0, 100, 0);
            tblPnlComments.RowCount = 2;
            tblPnlComments.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPnlComments.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPnlComments.Size = new Size(1039, 142);
            tblPnlComments.TabIndex = 7;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Left;
            richTextBox1.Location = new Point(180, 3);
            richTextBox1.Margin = new Padding(3, 3, 3, 8);
            richTextBox1.MaximumSize = new Size(660, 0);
            richTextBox1.MaxLength = 255;
            richTextBox1.MinimumSize = new Size(0, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(660, 60);
            richTextBox1.TabIndex = 0;
            richTextBox1.Tag = "specialWorkInstruction";
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Left;
            richTextBox2.Location = new Point(180, 79);
            richTextBox2.Margin = new Padding(3, 8, 3, 3);
            richTextBox2.MaximumSize = new Size(660, 0);
            richTextBox2.MaxLength = 255;
            richTextBox2.MinimumSize = new Size(0, 60);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(660, 60);
            richTextBox2.TabIndex = 1;
            richTextBox2.Tag = "comments";
            richTextBox2.Text = "";
            // 
            // labelComments
            // 
            labelComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelComments.AutoSize = true;
            labelComments.Location = new Point(47, 71);
            labelComments.Name = "labelComments";
            labelComments.Size = new Size(83, 71);
            labelComments.TabIndex = 1;
            labelComments.Text = "Comments:";
            labelComments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSpecialWorkInstruction
            // 
            labelSpecialWorkInstruction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelSpecialWorkInstruction.AutoSize = true;
            labelSpecialWorkInstruction.BackColor = SystemColors.Control;
            labelSpecialWorkInstruction.Location = new Point(3, 0);
            labelSpecialWorkInstruction.Name = "labelSpecialWorkInstruction";
            labelSpecialWorkInstruction.Size = new Size(171, 71);
            labelSpecialWorkInstruction.TabIndex = 1;
            labelSpecialWorkInstruction.Text = "Special Work Instruction:";
            labelSpecialWorkInstruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblPanelLRAControls
            // 
            tblPanelLRAControls.AutoSize = true;
            tblPanelLRAControls.BackColor = SystemColors.Control;
            tblPanelLRAControls.ColumnCount = 3;
            tblPanelLRAControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPanelLRAControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPanelLRAControls.ColumnStyles.Add(new ColumnStyle());
            tblPanelLRAControls.Controls.Add(buttonAddRow, 0, 0);
            tblPanelLRAControls.Controls.Add(buttonRemoveRow, 1, 0);
            tblPanelLRAControls.Controls.Add(buttonClearLRA, 2, 0);
            tblPanelLRAControls.Dock = DockStyle.Left;
            tblPanelLRAControls.Location = new Point(3, 612);
            tblPanelLRAControls.Margin = new Padding(3, 13, 3, 3);
            tblPanelLRAControls.MinimumSize = new Size(0, 40);
            tblPanelLRAControls.Name = "tblPanelLRAControls";
            tblPanelLRAControls.RowCount = 1;
            tblPanelLRAControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPanelLRAControls.Size = new Size(630, 40);
            tblPanelLRAControls.TabIndex = 6;
            // 
            // buttonAddRow
            // 
            buttonAddRow.Anchor = AnchorStyles.Left;
            buttonAddRow.Location = new Point(30, 5);
            buttonAddRow.Margin = new Padding(30, 3, 30, 3);
            buttonAddRow.MinimumSize = new Size(0, 30);
            buttonAddRow.Name = "buttonAddRow";
            buttonAddRow.Size = new Size(150, 30);
            buttonAddRow.TabIndex = 0;
            buttonAddRow.Text = "Add Row";
            buttonAddRow.UseVisualStyleBackColor = true;
            buttonAddRow.Click += ButtonAddRow_Click;
            // 
            // buttonRemoveRow
            // 
            buttonRemoveRow.Anchor = AnchorStyles.Left;
            buttonRemoveRow.Location = new Point(240, 5);
            buttonRemoveRow.Margin = new Padding(30, 3, 30, 3);
            buttonRemoveRow.MinimumSize = new Size(0, 30);
            buttonRemoveRow.Name = "buttonRemoveRow";
            buttonRemoveRow.Size = new Size(150, 30);
            buttonRemoveRow.TabIndex = 1;
            buttonRemoveRow.Text = "Remove Row";
            buttonRemoveRow.UseVisualStyleBackColor = true;
            buttonRemoveRow.Click += ButtonRemoveRow_Click;
            // 
            // buttonClearLRA
            // 
            buttonClearLRA.Anchor = AnchorStyles.Left;
            buttonClearLRA.Location = new Point(450, 5);
            buttonClearLRA.Margin = new Padding(30, 3, 30, 3);
            buttonClearLRA.MinimumSize = new Size(0, 30);
            buttonClearLRA.Name = "buttonClearLRA";
            buttonClearLRA.Size = new Size(150, 30);
            buttonClearLRA.TabIndex = 1;
            buttonClearLRA.Text = "Clear";
            buttonClearLRA.UseVisualStyleBackColor = true;
            buttonClearLRA.Click += ButtonClearLRA_Click;
            // 
            // tblPanelLRAValues
            // 
            tblPanelLRAValues.AutoScroll = true;
            tblPanelLRAValues.AutoSize = true;
            tblPanelLRAValues.BackColor = SystemColors.Control;
            tblPanelLRAValues.ColumnCount = 6;
            tblPanelLRAValues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tblPanelLRAValues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tblPanelLRAValues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tblPanelLRAValues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tblPanelLRAValues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tblPanelLRAValues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tblPanelLRAValues.Controls.Add(labelLength, 3, 0);
            tblPanelLRAValues.Controls.Add(labelRotationDegree, 4, 0);
            tblPanelLRAValues.Controls.Add(labelReadOut, 5, 0);
            tblPanelLRAValues.Controls.Add(labelSpringbackAngle, 2, 0);
            tblPanelLRAValues.Controls.Add(labelRequiredAngle, 1, 0);
            tblPanelLRAValues.Dock = DockStyle.Fill;
            tblPanelLRAValues.Location = new Point(30, 375);
            tblPanelLRAValues.Margin = new Padding(30, 30, 35, 3);
            tblPanelLRAValues.Name = "tblPanelLRAValues";
            tblPanelLRAValues.Padding = new Padding(0, 0, 10, 20);
            tblPanelLRAValues.RowCount = 1;
            tblPanelLRAValues.RowStyles.Add(new RowStyle());
            tblPanelLRAValues.Size = new Size(1034, 221);
            tblPanelLRAValues.TabIndex = 5;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Dock = DockStyle.Top;
            labelLength.Location = new Point(442, 0);
            labelLength.Margin = new Padding(3, 0, 30, 0);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(161, 20);
            labelLength.TabIndex = 0;
            labelLength.Text = "Length (mm)";
            labelLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRotationDegree
            // 
            labelRotationDegree.AutoSize = true;
            labelRotationDegree.Dock = DockStyle.Top;
            labelRotationDegree.Location = new Point(636, 0);
            labelRotationDegree.Margin = new Padding(3, 0, 30, 0);
            labelRotationDegree.Name = "labelRotationDegree";
            labelRotationDegree.Size = new Size(161, 20);
            labelRotationDegree.TabIndex = 0;
            labelRotationDegree.Text = "Rotation Degree";
            labelRotationDegree.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelReadOut
            // 
            labelReadOut.AutoSize = true;
            labelReadOut.Dock = DockStyle.Top;
            labelReadOut.Location = new Point(830, 0);
            labelReadOut.Margin = new Padding(3, 0, 30, 0);
            labelReadOut.Name = "labelReadOut";
            labelReadOut.Size = new Size(164, 20);
            labelReadOut.TabIndex = 0;
            labelReadOut.Text = "Read Out";
            labelReadOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSpringbackAngle
            // 
            labelSpringbackAngle.AutoSize = true;
            labelSpringbackAngle.Dock = DockStyle.Top;
            labelSpringbackAngle.Location = new Point(248, 0);
            labelSpringbackAngle.Margin = new Padding(3, 0, 30, 0);
            labelSpringbackAngle.Name = "labelSpringbackAngle";
            labelSpringbackAngle.Size = new Size(161, 20);
            labelSpringbackAngle.TabIndex = 0;
            labelSpringbackAngle.Text = "Springback Angle";
            labelSpringbackAngle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRequiredAngle
            // 
            labelRequiredAngle.AutoSize = true;
            labelRequiredAngle.Dock = DockStyle.Top;
            labelRequiredAngle.Location = new Point(54, 0);
            labelRequiredAngle.Margin = new Padding(3, 0, 30, 0);
            labelRequiredAngle.Name = "labelRequiredAngle";
            labelRequiredAngle.Size = new Size(161, 20);
            labelRequiredAngle.TabIndex = 0;
            labelRequiredAngle.Text = "Required Angle";
            labelRequiredAngle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(labelProductionOrder, 0, 0);
            tableLayoutPanel4.Controls.Add(textBoxProductionOrder, 0, 1);
            tableLayoutPanel4.Location = new Point(80, 30);
            tableLayoutPanel4.Margin = new Padding(80, 30, 80, 30);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(939, 94);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // labelProductionOrder
            // 
            labelProductionOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelProductionOrder.AutoSize = true;
            labelProductionOrder.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductionOrder.Location = new Point(3, 0);
            labelProductionOrder.Name = "labelProductionOrder";
            labelProductionOrder.Size = new Size(933, 35);
            labelProductionOrder.TabIndex = 8;
            labelProductionOrder.Text = "Production Order:";
            labelProductionOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxProductionOrder
            // 
            textBoxProductionOrder.Dock = DockStyle.Fill;
            textBoxProductionOrder.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductionOrder.Location = new Point(3, 50);
            textBoxProductionOrder.MaxLength = 80;
            textBoxProductionOrder.Name = "textBoxProductionOrder";
            textBoxProductionOrder.Size = new Size(933, 41);
            textBoxProductionOrder.TabIndex = 7;
            textBoxProductionOrder.TextAlign = HorizontalAlignment.Center;
            // 
            // labelFileDirectory
            // 
            labelFileDirectory.AutoSize = true;
            labelFileDirectory.Location = new Point(63, 74);
            labelFileDirectory.Name = "labelFileDirectory";
            labelFileDirectory.Size = new Size(97, 20);
            labelFileDirectory.TabIndex = 6;
            labelFileDirectory.Text = "File Directory";
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(tblPnlMain);
            mainPanel.Location = new Point(275, 27);
            mainPanel.Margin = new Padding(100);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(1139, 899);
            mainPanel.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 926);
            Controls.Add(mainPanel);
            Controls.Add(labelFileDirectory);
            Controls.Add(progressBar1);
            Controls.Add(treeView1);
            Controls.Add(FolderDirectoryBtn);
            Controls.Add(txtDirectoryPath);
            Controls.Add(toolStrip1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tblPnlMain.ResumeLayout(false);
            tblPnlMain.PerformLayout();
            tblPanelDataEntry.ResumeLayout(false);
            tblPanelDataEntry.PerformLayout();
            tblPnlButtons.ResumeLayout(false);
            tblPnlSaveCancel.ResumeLayout(false);
            tblPnlComments.ResumeLayout(false);
            tblPnlComments.PerformLayout();
            tblPanelLRAControls.ResumeLayout(false);
            tblPanelLRAValues.ResumeLayout(false);
            tblPanelLRAValues.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton helpToolStripButton;
        private TextBox txtDirectoryPath;
        private Button FolderDirectoryBtn;
        private TreeView treeView1;
        private ProgressBar progressBar1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ImageList imageList1;
        private ToolTip toolTip1;
        private TableLayoutPanel tblPnlMain;
        private TableLayoutPanel tblPanelDataEntry;
        private Label labelClient;
        private Label labelDate;
        private Label labelMaterial;
        private Label labelCutLength;
        private Label labelDrawingNo;
        private Label labelPartNo;
        private Label labelTubeSize;
        private Label labelToolingSize;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private TextBox textBox_4;
        private TextBox textBox_5;
        private TextBox textBox_6;
        private TextBox textBox_7;
        private TextBox textBox_8;
        private TableLayoutPanel tblPnlButtons;
        private Button buttonClear;
        private TableLayoutPanel tblPanelLRAValues;
        private Label labelLength;
        private Label labelRotationDegree;
        private Label labelReadOut;
        private Label labelSpringbackAngle;
        private Label labelRequiredAngle;
        private TableLayoutPanel tblPnlComments;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label labelSpecialWorkInstruction;
        private Label labelComments;
        private TableLayoutPanel tblPnlSaveCancel;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelFileDirectory;
        private TableLayoutPanel tblPanelLRAControls;
        private Button buttonAddRow;
        private Button buttonRemoveRow;
        private Button buttonClearLRA;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelProductionOrder;
        private TextBox textBoxProductionOrder;
        private Panel mainPanel;
    }
}