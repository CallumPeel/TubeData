using System.Runtime.Serialization.Formatters.Binary;

namespace TubeData
{
    public partial class Form1 : Form
    {
        InputHandler IH;
        FileHandler FH;


        public Form1()
        {

            InitializeComponent();

            this.IH = new InputHandler(
                textBoxProductionOrder: textBoxProductionOrder,
                tblPanelDataEntry: tblPanelDataEntry,
                tblPanelLRAValues: tblPanelLRAValues,
                richTextBox1: richTextBox1,
                richTextBox2: richTextBox2,
                progressBar1: progressBar1,
                treeView1: treeView1,
                txtDirectoryPath: txtDirectoryPath
            );
            this.FH = new FileHandler(this.IH);
            this.WindowState = FormWindowState.Maximized;
            tblPanelLRAValues.RowCount--;
            for (int i = 0; i < 5; i++) IH.addRow(tblPanelLRAValues);
            FH.LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }

        private void FolderDirectoryBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDirectoryPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtDirectoryPath.Text = folderBrowserDialog1.SelectedPath;
            FH.LoadDirectory(sender, e);
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
            this.FH.saveTube();
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