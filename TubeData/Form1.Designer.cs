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
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCancel = new Button();
            buttonSave = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            labelComments = new Label();
            labelSpecialWorkInstruction = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonAddRow = new Button();
            buttonRemoveRow = new Button();
            tblPanelLRAValues = new TableLayoutPanel();
            labelLength = new Label();
            labelRotationDegree = new Label();
            labelReadOut = new Label();
            labelSpringbackAngle = new Label();
            labelRequiredAngle = new Label();
            labelFileDirectory = new Label();
            toolStrip1.SuspendLayout();
            tblPnlMain.SuspendLayout();
            tblPanelDataEntry.SuspendLayout();
            tblPnlButtons.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tblPanelLRAValues.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, printToolStripButton, toolStripSeparator, helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1293, 27);
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
            // 
            // openToolStripButton
            // 
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(69, 24);
            openToolStripButton.Text = "&Open";
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
            treeView1.Size = new Size(234, 462);
            treeView1.StateImageList = imageList1;
            treeView1.TabIndex = 3;
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
            progressBar1.Location = new Point(12, 599);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(234, 12);
            progressBar1.TabIndex = 4;
            // 
            // tblPnlMain
            // 
            tblPnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblPnlMain.ColumnCount = 1;
            tblPnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnlMain.Controls.Add(tblPanelDataEntry, 0, 0);
            tblPnlMain.Controls.Add(tableLayoutPanel2, 0, 4);
            tblPnlMain.Controls.Add(tableLayoutPanel1, 0, 3);
            tblPnlMain.Controls.Add(tableLayoutPanel3, 0, 2);
            tblPnlMain.Controls.Add(tblPanelLRAValues, 0, 1);
            tblPnlMain.Location = new Point(286, 97);
            tblPnlMain.Name = "tblPnlMain";
            tblPnlMain.RowCount = 5;
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.Size = new Size(963, 514);
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
            tblPanelDataEntry.Location = new Point(3, 3);
            tblPanelDataEntry.Name = "tblPanelDataEntry";
            tblPanelDataEntry.RowCount = 5;
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.Size = new Size(957, 173);
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
            labelDrawingNo.Location = new Point(476, 6);
            labelDrawingNo.Name = "labelDrawingNo";
            labelDrawingNo.Size = new Size(92, 20);
            labelDrawingNo.TabIndex = 0;
            labelDrawingNo.Text = "Drawing No:";
            // 
            // labelPartNo
            // 
            labelPartNo.Anchor = AnchorStyles.Left;
            labelPartNo.AutoSize = true;
            labelPartNo.Location = new Point(476, 39);
            labelPartNo.Name = "labelPartNo";
            labelPartNo.Size = new Size(61, 20);
            labelPartNo.TabIndex = 0;
            labelPartNo.Text = "Part No:";
            // 
            // labelTubeSize
            // 
            labelTubeSize.Anchor = AnchorStyles.Left;
            labelTubeSize.AutoSize = true;
            labelTubeSize.Location = new Point(476, 72);
            labelTubeSize.Name = "labelTubeSize";
            labelTubeSize.Size = new Size(76, 20);
            labelTubeSize.TabIndex = 0;
            labelTubeSize.Text = "Tube Size:";
            // 
            // labelToolingSize
            // 
            labelToolingSize.Anchor = AnchorStyles.Left;
            labelToolingSize.AutoSize = true;
            labelToolingSize.Location = new Point(476, 105);
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
            tblPnlButtons.Location = new Point(575, 135);
            tblPnlButtons.Name = "tblPnlButtons";
            tblPnlButtons.RowCount = 1;
            tblPnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlButtons.Size = new Size(379, 35);
            tblPnlButtons.TabIndex = 8;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Right;
            buttonClear.Location = new Point(239, 3);
            buttonClear.Margin = new Padding(3, 3, 20, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(120, 29);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBox_1
            // 
            textBox_1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_1.Location = new Point(92, 3);
            textBox_1.Margin = new Padding(3, 3, 20, 3);
            textBox_1.Name = "textBox_1";
            textBox_1.Size = new Size(361, 27);
            textBox_1.TabIndex = 0;
            textBox_1.Tag = "client";
            // 
            // textBox_2
            // 
            textBox_2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_2.Location = new Point(92, 36);
            textBox_2.Margin = new Padding(3, 3, 20, 3);
            textBox_2.Name = "textBox_2";
            textBox_2.Size = new Size(361, 27);
            textBox_2.TabIndex = 1;
            textBox_2.Tag = "drawingNo";
            // 
            // textBox_3
            // 
            textBox_3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_3.Location = new Point(92, 69);
            textBox_3.Margin = new Padding(3, 3, 20, 3);
            textBox_3.Name = "textBox_3";
            textBox_3.Size = new Size(361, 27);
            textBox_3.TabIndex = 2;
            textBox_3.Tag = "date";
            // 
            // textBox_4
            // 
            textBox_4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_4.Location = new Point(92, 102);
            textBox_4.Margin = new Padding(3, 3, 20, 3);
            textBox_4.Name = "textBox_4";
            textBox_4.Size = new Size(361, 27);
            textBox_4.TabIndex = 3;
            textBox_4.Tag = "partNo";
            // 
            // textBox_5
            // 
            textBox_5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_5.Location = new Point(575, 3);
            textBox_5.Margin = new Padding(3, 3, 20, 3);
            textBox_5.Name = "textBox_5";
            textBox_5.Size = new Size(362, 27);
            textBox_5.TabIndex = 4;
            textBox_5.Tag = "material";
            // 
            // textBox_6
            // 
            textBox_6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_6.Location = new Point(575, 36);
            textBox_6.Margin = new Padding(3, 3, 20, 3);
            textBox_6.Name = "textBox_6";
            textBox_6.Size = new Size(362, 27);
            textBox_6.TabIndex = 5;
            textBox_6.Tag = "tubeSize";
            // 
            // textBox_7
            // 
            textBox_7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_7.Location = new Point(575, 69);
            textBox_7.Margin = new Padding(3, 3, 20, 3);
            textBox_7.Name = "textBox_7";
            textBox_7.Size = new Size(362, 27);
            textBox_7.TabIndex = 6;
            textBox_7.Tag = "cutLength";
            // 
            // textBox_8
            // 
            textBox_8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_8.Location = new Point(575, 102);
            textBox_8.Margin = new Padding(3, 3, 20, 3);
            textBox_8.Name = "textBox_8";
            textBox_8.Size = new Size(362, 27);
            textBox_8.TabIndex = 7;
            textBox_8.Tag = "toolingSize";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 12;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonSave, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 470);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(957, 41);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Right;
            buttonCancel.Location = new Point(660, 7);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 26);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Right;
            buttonSave.Location = new Point(560, 7);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 26);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 848F));
            tableLayoutPanel1.Controls.Add(richTextBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(labelComments, 0, 1);
            tableLayoutPanel1.Controls.Add(labelSpecialWorkInstruction, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 422);
            tableLayoutPanel1.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(957, 42);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(180, 29);
            richTextBox2.Margin = new Padding(3, 8, 3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(842, 10);
            richTextBox2.TabIndex = 1;
            richTextBox2.Tag = "comments";
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(180, 3);
            richTextBox1.Margin = new Padding(3, 3, 3, 8);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(842, 10);
            richTextBox1.TabIndex = 0;
            richTextBox1.Tag = "specialWorkInstruction";
            richTextBox1.Text = "";
            // 
            // labelComments
            // 
            labelComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelComments.AutoSize = true;
            labelComments.Location = new Point(47, 21);
            labelComments.Name = "labelComments";
            labelComments.Size = new Size(83, 21);
            labelComments.TabIndex = 1;
            labelComments.Text = "Comments:";
            labelComments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSpecialWorkInstruction
            // 
            labelSpecialWorkInstruction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelSpecialWorkInstruction.AutoSize = true;
            labelSpecialWorkInstruction.Location = new Point(3, 0);
            labelSpecialWorkInstruction.Name = "labelSpecialWorkInstruction";
            labelSpecialWorkInstruction.Size = new Size(171, 21);
            labelSpecialWorkInstruction.TabIndex = 1;
            labelSpecialWorkInstruction.Text = "Special Work Instruction:";
            labelSpecialWorkInstruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonAddRow, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonRemoveRow, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Left;
            tableLayoutPanel3.Location = new Point(3, 372);
            tableLayoutPanel3.Margin = new Padding(3, 13, 3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(420, 32);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // buttonAddRow
            // 
            buttonAddRow.Anchor = AnchorStyles.Left;
            buttonAddRow.Location = new Point(30, 3);
            buttonAddRow.Margin = new Padding(30, 3, 30, 3);
            buttonAddRow.Name = "buttonAddRow";
            buttonAddRow.Size = new Size(150, 26);
            buttonAddRow.TabIndex = 0;
            buttonAddRow.Text = "Add Row";
            buttonAddRow.UseVisualStyleBackColor = true;
            buttonAddRow.Click += buttonAddRow_Click;
            // 
            // buttonRemoveRow
            // 
            buttonRemoveRow.Anchor = AnchorStyles.Left;
            buttonRemoveRow.Location = new Point(240, 3);
            buttonRemoveRow.Margin = new Padding(30, 3, 30, 3);
            buttonRemoveRow.Name = "buttonRemoveRow";
            buttonRemoveRow.Size = new Size(150, 26);
            buttonRemoveRow.TabIndex = 1;
            buttonRemoveRow.Text = "Remove Row";
            buttonRemoveRow.UseVisualStyleBackColor = true;
            buttonRemoveRow.Click += buttonRemoveRow_Click;
            // 
            // tblPanelLRAValues
            // 
            tblPanelLRAValues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblPanelLRAValues.AutoScroll = true;
            tblPanelLRAValues.AutoSize = true;
            tblPanelLRAValues.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            tblPanelLRAValues.Location = new Point(30, 209);
            tblPanelLRAValues.Margin = new Padding(30, 30, 35, 3);
            tblPanelLRAValues.Name = "tblPanelLRAValues";
            tblPanelLRAValues.Padding = new Padding(0, 0, 10, 20);
            tblPanelLRAValues.RowCount = 1;
            tblPanelLRAValues.RowStyles.Add(new RowStyle());
            tblPanelLRAValues.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPanelLRAValues.Size = new Size(898, 147);
            tblPanelLRAValues.TabIndex = 5;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Dock = DockStyle.Top;
            labelLength.Location = new Point(383, 0);
            labelLength.Margin = new Padding(3, 0, 30, 0);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(135, 20);
            labelLength.TabIndex = 0;
            labelLength.Text = "Length (mm)";
            labelLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRotationDegree
            // 
            labelRotationDegree.AutoSize = true;
            labelRotationDegree.Dock = DockStyle.Top;
            labelRotationDegree.Location = new Point(551, 0);
            labelRotationDegree.Margin = new Padding(3, 0, 30, 0);
            labelRotationDegree.Name = "labelRotationDegree";
            labelRotationDegree.Size = new Size(135, 20);
            labelRotationDegree.TabIndex = 0;
            labelRotationDegree.Text = "Rotation Degree";
            labelRotationDegree.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelReadOut
            // 
            labelReadOut.AutoSize = true;
            labelReadOut.Dock = DockStyle.Top;
            labelReadOut.Location = new Point(719, 0);
            labelReadOut.Margin = new Padding(3, 0, 30, 0);
            labelReadOut.Name = "labelReadOut";
            labelReadOut.Size = new Size(139, 20);
            labelReadOut.TabIndex = 0;
            labelReadOut.Text = "Read Out";
            labelReadOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSpringbackAngle
            // 
            labelSpringbackAngle.AutoSize = true;
            labelSpringbackAngle.Dock = DockStyle.Top;
            labelSpringbackAngle.Location = new Point(215, 0);
            labelSpringbackAngle.Margin = new Padding(3, 0, 30, 0);
            labelSpringbackAngle.Name = "labelSpringbackAngle";
            labelSpringbackAngle.Size = new Size(135, 20);
            labelSpringbackAngle.TabIndex = 0;
            labelSpringbackAngle.Text = "Springback Angle";
            labelSpringbackAngle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRequiredAngle
            // 
            labelRequiredAngle.AutoSize = true;
            labelRequiredAngle.Dock = DockStyle.Top;
            labelRequiredAngle.Location = new Point(47, 0);
            labelRequiredAngle.Margin = new Padding(3, 0, 30, 0);
            labelRequiredAngle.Name = "labelRequiredAngle";
            labelRequiredAngle.Size = new Size(135, 20);
            labelRequiredAngle.TabIndex = 0;
            labelRequiredAngle.Text = "Required Angle";
            labelRequiredAngle.TextAlign = ContentAlignment.MiddleCenter;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 623);
            Controls.Add(labelFileDirectory);
            Controls.Add(tblPnlMain);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tblPanelLRAValues.ResumeLayout(false);
            tblPanelLRAValues.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label labelSpecialWorkInstruction;
        private Label labelComments;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelFileDirectory;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonAddRow;
        private Button buttonRemoveRow;
    }
}