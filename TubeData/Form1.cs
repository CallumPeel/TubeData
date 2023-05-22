using System.Runtime.Serialization.Formatters.Binary;

namespace TubeData
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tblPanelLRAValues.RowCount--;
            for (int i = 0; i < 5; i++) addRow();
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

        public void addRow()
        {
            tblPanelLRAValues.RowCount++; // Increment row count

            // Create label for the row number
            System.Windows.Forms.Label rowLabel = new System.Windows.Forms.Label
            {
                Text = tblPanelLRAValues.RowCount.ToString(),
                AutoSize = true,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0, 5, 0, 0)
            };

            TextBox[] textBoxes = new TextBox[5];

            // Create text boxes for data entry
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i] = new TextBox
                {
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    Margin = new Padding(3, 3, 30, 3),
                    Dock = DockStyle.Top
                };
            }

            // Set RowStyles
            tblPanelLRAValues.RowStyles.Clear(); // Clear any existing row styles

            // Set the new row to use a fixed height
            tblPanelLRAValues.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // Adjust the height as needed

            // Add controls to the new row
            tblPanelLRAValues.Controls.Add(rowLabel, 0, tblPanelLRAValues.RowCount); // Add label to column 0

            // Add text boxes to columns 1-5
            for (int i = 0; i < textBoxes.Length; i++)
            {
                tblPanelLRAValues.Controls.Add(textBoxes[i], i + 1, tblPanelLRAValues.RowCount);
            }
        }


        private void removeRow()
        {
            for (int i = 0; i < 6; i++)
            {
                tblPanelLRAValues.Controls.RemoveAt(tblPanelLRAValues.Controls.Count - 1);
            }
            tblPanelLRAValues.RowCount--;

        }

        private void newRow()
        {
            tblPanelLRAValues.Visible = false;
            addRow();
            tblPanelLRAValues.Visible = true;
        }

        //private void buttonSave_Click_1(object sender, EventArgs e)
        //{
        //    List<string> textBoxValues = new List<string>();

        //    GetTextBoxValuesFromTableLayoutPanel(tblPanelDataEntry, textBoxValues);
        //    GetTextBoxValuesFromTableLayoutPanel(tblPanelLRAValues, textBoxValues);
        //    GetRichTextBoxValuesFromTableLayoutPanel(tableLayoutPanel1, textBoxValues);

        //    MessageBox.Show(string.Join(Environment.NewLine, textBoxValues));
        //}

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            List<string> textBoxValues = new List<string>();

            GetTextBoxValuesFromTableLayoutPanel(tblPanelDataEntry, textBoxValues);
            GetTextBoxValuesFromTableLayoutPanel(tblPanelLRAValues, textBoxValues);
            GetRichTextBoxValuesFromTableLayoutPanel(tableLayoutPanel1, textBoxValues);

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
            saveFileDialog.Filter = "Binary Files (*.bin)|*.bin";
            saveFileDialog.FileName = tube.ProductionOrderValue;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Save the Tube object to the selected file
                tube.Save(filePath);
            }
        }


        private void GetTextBoxValuesFromTableLayoutPanel(TableLayoutPanel tableLayoutPanel, List<string> textBoxValues)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBoxValues.Add(textBox.Text);
                }
            }
        }

        private void GetRichTextBoxValuesFromTableLayoutPanel(TableLayoutPanel tableLayoutPanel, List<string> textBoxValues)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is RichTextBox richTextBox)
                {
                    textBoxValues.Add(richTextBox.Text);
                }
            }
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            newRow();
        }

        private void buttonRemoveRow_Click(object sender, EventArgs e)
        {
            removeRow();
        }

        private void clearDataEntryTable()
        {
            foreach (Control control in tblPanelDataEntry.Controls)
            {
                if (control is TextBox textBox)
                {
                    control.Text = "";
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearDataEntryTable();
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
            clearLRATable();
            clearDataEntryTable();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }


        private void SetTextBoxValuesToTableLayoutPanel(TableLayoutPanel tableLayoutPanel1, TableLayoutPanel tableLayoutPanel2, List<string> textBoxValues)
        {
            int textBoxIndex = 0;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Check if there are more values to assign
                    if (textBoxIndex < textBoxValues.Count)
                    {
                        textBox.Text = textBoxValues[textBoxIndex];
                        textBoxIndex++;
                    }
                    else
                    {
                        // If there are no more values, you can choose to handle it accordingly
                        // For example, clear the text box or set a default value
                        textBox.Text = string.Empty;
                    }
                }
            }

            if (tableLayoutPanel2.Controls.OfType<TextBox>().Count() < textBoxValues.Count - 2)
            {
                // Calculate the number of additional controls needed
                int remainingControls = textBoxValues.Count - tableLayoutPanel2.Controls.OfType<TextBox>().Count() - 2;

                // Call the addRow() method to add the required number of controls
                for (int i = 0; i < remainingControls / 5 - 1; i++)
                {
                    addRow();
                }
            }

            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Exclude the last two items from the textBoxValues list
                    if (textBoxIndex < textBoxValues.Count - 2)
                    {
                        textBox.Text = textBoxValues[textBoxIndex];
                        textBoxIndex++;
                    }
                    else
                    {
                        // If there are no more values, you can choose to handle it accordingly
                        // For example, clear the text box or set a default value
                        textBox.Text = string.Empty;
                    }
                }
            }
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
                SetTextBoxValuesToTableLayoutPanel(tblPanelDataEntry, tblPanelLRAValues, openedTextBoxValues);
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

        private void clearLRATable()
        {
            foreach (Control control in tblPanelLRAValues.Controls)
            {
                if (control is TextBox textBox)
                {
                    control.Text = "";
                }
            }
        }

        private void buttonClearLRA_Click(object sender, EventArgs e)
        {
            clearLRATable();
        }

        //private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Node.Tag is string filePath)
        //    {
        //        if (Path.GetExtension(filePath).Equals(".TUBE", StringComparison.OrdinalIgnoreCase))
        //        {
        //            openTubeFile(filePath);
        //        }
        //    }
        //}

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