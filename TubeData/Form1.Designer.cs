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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            tblPnlButtons = new TableLayoutPanel();
            buttonSave = new Button();
            buttonClear = new Button();
            tblPanelLRAValues = new TableLayoutPanel();
            labelLength = new Label();
            labelRotationDegree = new Label();
            labelReadOut = new Label();
            labelSpringbackAngle = new Label();
            labelRequiredAngle = new Label();
            buttonTest = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            labelSpecialWorkInstruction = new Label();
            labelComments = new Label();
            toolStrip1.SuspendLayout();
            tblPnlMain.SuspendLayout();
            tblPanelDataEntry.SuspendLayout();
            tblPnlButtons.SuspendLayout();
            tblPanelLRAValues.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, printToolStripButton, toolStripSeparator, helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1436, 27);
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
            treeView1.Size = new Size(234, 507);
            treeView1.StateImageList = imageList1;
            treeView1.TabIndex = 1;
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
            progressBar1.Location = new Point(12, 644);
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
            tblPnlMain.Controls.Add(tblPanelLRAValues, 0, 1);
            tblPnlMain.Controls.Add(buttonTest, 0, 3);
            tblPnlMain.Controls.Add(tableLayoutPanel1, 0, 2);
            tblPnlMain.Location = new Point(286, 97);
            tblPnlMain.Name = "tblPnlMain";
            tblPnlMain.RowCount = 4;
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 54.4736824F));
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35.5263176F));
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.944752F));
            tblPnlMain.Size = new Size(1106, 559);
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
            tblPanelDataEntry.Controls.Add(textBox1, 1, 0);
            tblPanelDataEntry.Controls.Add(textBox2, 1, 1);
            tblPanelDataEntry.Controls.Add(textBox3, 1, 2);
            tblPanelDataEntry.Controls.Add(textBox4, 1, 3);
            tblPanelDataEntry.Controls.Add(textBox5, 3, 0);
            tblPanelDataEntry.Controls.Add(textBox6, 3, 1);
            tblPanelDataEntry.Controls.Add(textBox7, 3, 2);
            tblPanelDataEntry.Controls.Add(textBox8, 3, 3);
            tblPanelDataEntry.Controls.Add(tblPnlButtons, 3, 4);
            tblPanelDataEntry.Location = new Point(3, 3);
            tblPanelDataEntry.Name = "tblPanelDataEntry";
            tblPanelDataEntry.RowCount = 5;
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.RowStyles.Add(new RowStyle());
            tblPanelDataEntry.Size = new Size(1100, 173);
            tblPanelDataEntry.TabIndex = 0;
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
            labelDrawingNo.Location = new Point(548, 6);
            labelDrawingNo.Name = "labelDrawingNo";
            labelDrawingNo.Size = new Size(92, 20);
            labelDrawingNo.TabIndex = 0;
            labelDrawingNo.Text = "Drawing No:";
            // 
            // labelPartNo
            // 
            labelPartNo.Anchor = AnchorStyles.Left;
            labelPartNo.AutoSize = true;
            labelPartNo.Location = new Point(548, 39);
            labelPartNo.Name = "labelPartNo";
            labelPartNo.Size = new Size(61, 20);
            labelPartNo.TabIndex = 0;
            labelPartNo.Text = "Part No:";
            // 
            // labelTubeSize
            // 
            labelTubeSize.Anchor = AnchorStyles.Left;
            labelTubeSize.AutoSize = true;
            labelTubeSize.Location = new Point(548, 72);
            labelTubeSize.Name = "labelTubeSize";
            labelTubeSize.Size = new Size(76, 20);
            labelTubeSize.TabIndex = 0;
            labelTubeSize.Text = "Tube Size:";
            // 
            // labelToolingSize
            // 
            labelToolingSize.Anchor = AnchorStyles.Left;
            labelToolingSize.AutoSize = true;
            labelToolingSize.Location = new Point(548, 105);
            labelToolingSize.Name = "labelToolingSize";
            labelToolingSize.Size = new Size(93, 20);
            labelToolingSize.TabIndex = 0;
            labelToolingSize.Text = "Tooling Size:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(92, 3);
            textBox1.Margin = new Padding(3, 3, 20, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(92, 36);
            textBox2.Margin = new Padding(3, 3, 20, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(92, 69);
            textBox3.Margin = new Padding(3, 3, 20, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(433, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(92, 102);
            textBox4.Margin = new Padding(3, 3, 20, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(433, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(647, 3);
            textBox5.Margin = new Padding(3, 3, 20, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(433, 27);
            textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(647, 36);
            textBox6.Margin = new Padding(3, 3, 20, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(433, 27);
            textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(647, 69);
            textBox7.Margin = new Padding(3, 3, 20, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(433, 27);
            textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Location = new Point(647, 102);
            textBox8.Margin = new Padding(3, 3, 20, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(433, 27);
            textBox8.TabIndex = 1;
            // 
            // tblPnlButtons
            // 
            tblPnlButtons.Anchor = AnchorStyles.Right;
            tblPnlButtons.ColumnCount = 2;
            tblPnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnlButtons.ColumnStyles.Add(new ColumnStyle());
            tblPnlButtons.Controls.Add(buttonSave, 0, 0);
            tblPnlButtons.Controls.Add(buttonClear, 1, 0);
            tblPnlButtons.Location = new Point(647, 135);
            tblPnlButtons.Name = "tblPnlButtons";
            tblPnlButtons.RowCount = 1;
            tblPnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlButtons.Size = new Size(450, 35);
            tblPnlButtons.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Right;
            buttonSave.Location = new Point(185, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(119, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Right;
            buttonClear.Location = new Point(310, 3);
            buttonClear.Margin = new Padding(3, 3, 20, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(120, 29);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // tblPanelLRAValues
            // 
            tblPanelLRAValues.AutoScroll = true;
            tblPanelLRAValues.AutoSize = true;
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
            tblPanelLRAValues.Dock = DockStyle.Top;
            tblPanelLRAValues.Location = new Point(30, 209);
            tblPanelLRAValues.Margin = new Padding(30, 30, 30, 3);
            tblPanelLRAValues.Name = "tblPanelLRAValues";
            tblPanelLRAValues.RowCount = 1;
            tblPanelLRAValues.RowStyles.Add(new RowStyle());
            tblPanelLRAValues.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPanelLRAValues.Size = new Size(1046, 20);
            tblPanelLRAValues.TabIndex = 1;
            // 
            // labelLength
            // 
            labelLength.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelLength.AutoSize = true;
            labelLength.Location = new Point(451, 0);
            labelLength.Margin = new Padding(3, 0, 30, 0);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(165, 20);
            labelLength.TabIndex = 0;
            labelLength.Text = "Length (mm)";
            labelLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRotationDegree
            // 
            labelRotationDegree.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelRotationDegree.AutoSize = true;
            labelRotationDegree.Location = new Point(649, 0);
            labelRotationDegree.Margin = new Padding(3, 0, 30, 0);
            labelRotationDegree.Name = "labelRotationDegree";
            labelRotationDegree.Size = new Size(165, 20);
            labelRotationDegree.TabIndex = 0;
            labelRotationDegree.Text = "Rotation Degree";
            labelRotationDegree.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelReadOut
            // 
            labelReadOut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelReadOut.AutoSize = true;
            labelReadOut.Location = new Point(847, 0);
            labelReadOut.Margin = new Padding(3, 0, 30, 0);
            labelReadOut.Name = "labelReadOut";
            labelReadOut.Size = new Size(169, 20);
            labelReadOut.TabIndex = 0;
            labelReadOut.Text = "Read Out";
            labelReadOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSpringbackAngle
            // 
            labelSpringbackAngle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelSpringbackAngle.AutoSize = true;
            labelSpringbackAngle.Location = new Point(253, 0);
            labelSpringbackAngle.Margin = new Padding(3, 0, 30, 0);
            labelSpringbackAngle.Name = "labelSpringbackAngle";
            labelSpringbackAngle.Size = new Size(165, 20);
            labelSpringbackAngle.TabIndex = 0;
            labelSpringbackAngle.Text = "Springback Angle";
            labelSpringbackAngle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRequiredAngle
            // 
            labelRequiredAngle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelRequiredAngle.AutoSize = true;
            labelRequiredAngle.Location = new Point(55, 0);
            labelRequiredAngle.Margin = new Padding(3, 0, 30, 0);
            labelRequiredAngle.Name = "labelRequiredAngle";
            labelRequiredAngle.Size = new Size(165, 20);
            labelRequiredAngle.TabIndex = 0;
            labelRequiredAngle.Text = "Required Angle";
            labelRequiredAngle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(3, 524);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(94, 32);
            buttonTest.TabIndex = 2;
            buttonTest.Text = "button1";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 848F));
            tableLayoutPanel1.Controls.Add(richTextBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(labelSpecialWorkInstruction, 0, 0);
            tableLayoutPanel1.Controls.Add(labelComments, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 401);
            tableLayoutPanel1.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1100, 117);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(180, 66);
            richTextBox1.Margin = new Padding(3, 8, 3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(917, 48);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(180, 3);
            richTextBox2.Margin = new Padding(3, 3, 3, 8);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(917, 47);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // labelSpecialWorkInstruction
            // 
            labelSpecialWorkInstruction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelSpecialWorkInstruction.AutoSize = true;
            labelSpecialWorkInstruction.Location = new Point(3, 0);
            labelSpecialWorkInstruction.Name = "labelSpecialWorkInstruction";
            labelSpecialWorkInstruction.Size = new Size(171, 58);
            labelSpecialWorkInstruction.TabIndex = 1;
            labelSpecialWorkInstruction.Text = "Special Work Instruction:";
            labelSpecialWorkInstruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelComments
            // 
            labelComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelComments.AutoSize = true;
            labelComments.Location = new Point(47, 58);
            labelComments.Name = "labelComments";
            labelComments.Size = new Size(83, 59);
            labelComments.TabIndex = 1;
            labelComments.Text = "Comments:";
            labelComments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 668);
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
            tblPanelLRAValues.ResumeLayout(false);
            tblPanelLRAValues.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TableLayoutPanel tblPnlButtons;
        private Button buttonSave;
        private Button buttonClear;
        private TableLayoutPanel tblPanelLRAValues;
        private Label labelLength;
        private Label labelRotationDegree;
        private Label labelReadOut;
        private Label labelSpringbackAngle;
        private Label labelRequiredAngle;
        private Button buttonTest;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label labelSpecialWorkInstruction;
        private Label labelComments;
    }
}