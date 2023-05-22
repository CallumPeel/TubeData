using System.Runtime.Serialization.Formatters.Binary;

namespace TubeData
{
    public partial class Form1 : Form
    {
        InputHandler IH;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tblPanelLRAValues.RowCount--;
            IH = new InputHandler();
            for (int i = 0; i < 5; i++) IH.addRow(tblPanelLRAValues);
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }

        private void FolderDirectoryBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDirectoryPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtDirectoryPath.Text = folderBrowserDialog1.SelectedPath;
            LoadDirectory(sender, e);
        }

        private void LoadDirectory(object sender, EventArgs e)
        {
            // Setting Inital Value of Progress Bar
            progressBar1.Value = 0;
            // Clear All Nodes if Already Exists
            treeView1.Nodes.Clear();
            toolTip1.ShowAlways = true;
            if (txtDirectoryPath.Text != "" && Directory.Exists(txtDirectoryPath.Text))
                LoadDirectory(txtDirectoryPath.Text);
            else
                MessageBox.Show("Select Directory!!");
        }

        public void LoadDirectory(string dir)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            progressBar1.Maximum = Directory.GetFiles(dir, "*.TUBE", SearchOption.AllDirectories).Length; // Filter files by .TUBE extension
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(dir, tds);
            LoadSubDirectories(dir, tds);
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                UpdateProgress();
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] files = Directory.GetFiles(dir, "*.TUBE"); // Filter files by .TUBE extension
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                UpdateProgress();
            }
        }

        private void UpdateProgress()
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                progressBar1.CreateGraphics().DrawString(
                    percent.ToString() + "%",
                    new Font("Arial", (float)8.25, FontStyle.Regular),
                    Brushes.Black,
                    new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7)
                );
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the node at the current mouse pointer location.
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.
                if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeView1))
                    this.toolTip1.SetToolTip(this.treeView1, theNode.Tag.ToString());
            }
            else     // Pointer is not over a node so clear the ToolTip.
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            List<string> textBoxValues = new List<string>();

            IH.GetTextBoxValuesFromTableLayoutPanel(tblPanelDataEntry, textBoxValues);
            IH.GetTextBoxValuesFromTableLayoutPanel(tblPanelLRAValues, textBoxValues);
            IH.GetRichTextBoxValuesFromTableLayoutPanel(tableLayoutPanel1, textBoxValues);

            // Create an instance of the Tube class
            Tube tube = new Tube();

            tube.ProductionOrderValue = textBoxProductionOrder.Text;

            // Set the TextBoxValues property with the textBoxValues list
            tube.TextBoxValues = textBoxValues;

            // Set the RichTextBoxValue1 and RichTextBoxValue2 properties with the rich text box values
            tube.RichTextBoxValue1 = richTextBox1.Text;
            tube.RichTextBoxValue2 = richTextBox2.Text;

            // Prompt the user to select a file for saving the Tube object
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tube Files (*.TUBE)|*.TUBE";
            saveFileDialog.FileName = tube.ProductionOrderValue + ".TUBE";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Save the Tube object to the selected file
                tube.Save(filePath);
            }
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            IH.addRow(tblPanelLRAValues);
        }

        private void buttonRemoveRow_Click(object sender, EventArgs e)
        {
            IH.removeRow(tblPanelLRAValues);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            IH.clearDataEntryTable(tblPanelDataEntry);
        }

        public static Tube Open(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (Tube)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while opening Tube: " + ex.Message);
                return null;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IH.clearLRATable(tblPanelLRAValues);
            IH.clearDataEntryTable(tblPanelDataEntry);
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void openTubeFile(string filePath)
        {
            // Opening a previously saved Tube instance from a binary file
            Tube openedTube = Open(filePath);
            if (openedTube != null)
            {
                // Accessing the properties of the opened Tube instance
                string openedProductionOrderValue = openedTube.ProductionOrderValue;
                List<string> openedTextBoxValues = openedTube.TextBoxValues;
                string openedRichTextBoxValue1 = openedTube.RichTextBoxValue1;
                string openedRichTextBoxValue2 = openedTube.RichTextBoxValue2;

                // Set the values to the corresponding text boxes
                textBoxProductionOrder.Text = openedProductionOrderValue;
                IH.SetTextBoxValuesToTableLayoutPanel(tblPanelDataEntry, tblPanelLRAValues, openedTextBoxValues);
                richTextBox1.Text = openedRichTextBoxValue1;
                richTextBox2.Text = openedRichTextBoxValue2;
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tube Files (*.TUBE)|*.TUBE";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openTubeFile(openFileDialog.FileName);
            }
        }

        private void buttonClearLRA_Click(object sender, EventArgs e)
        {
            IH.clearLRATable(tblPanelLRAValues);
        }

        private void treeView1_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is string filePath)
            {
                if (Path.GetExtension(filePath).Equals(".TUBE", StringComparison.OrdinalIgnoreCase))
                {
                    openTubeFile(filePath);
                }
            }
        }
    }
}