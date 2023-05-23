using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TubeData
{
    internal class FileHandler : InputHandler
    {
        public FileHandler(System.Windows.Forms.TextBox textBoxProductionOrder, TableLayoutPanel tblPanelDataEntry, TableLayoutPanel tblPanelLRAValues, RichTextBox richTextBox1, RichTextBox richTextBox2, System.Windows.Forms.ProgressBar progressBar1, System.Windows.Forms.TreeView treeView1, System.Windows.Forms.TextBox txtDirectoryPath) : base(textBoxProductionOrder, tblPanelDataEntry, tblPanelLRAValues, richTextBox1, richTextBox2, progressBar1, treeView1, txtDirectoryPath)
        {
        }

        public void LoadDirectory(object sender, EventArgs e)
        {
            // Setting Inital Value of Progress Bar
            this.progressBar1.Value = 0;
            // Clear All Nodes if Already Exists
            this.treeView1.Nodes.Clear();
            if (this.txtDirectoryPath.Text != "" && Directory.Exists(this.txtDirectoryPath.Text))
                LoadDirectory(this.txtDirectoryPath.Text);
            else
                MessageBox.Show("Select Directory!!");
        }

        public void LoadDirectory(string dir)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            this.progressBar1.Maximum = Directory.GetFiles(dir, "*.TUBE", SearchOption.AllDirectories).Length; // Filter files by .TUBE extension
            TreeNode tds = this.treeView1.Nodes.Add(di.Name);
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

        public void UpdateProgress()
        {
            System.Windows.Forms.ProgressBar progressBar1 = this.progressBar1;
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

        public void saveTube()
        {
            List<string> textBoxValues = new List<string>();

            // Create an instance of the Tube class
            Tube tube = GetTube();

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


        public void openTubeFile(string filePath)
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

    }
}
