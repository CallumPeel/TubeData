using System.Drawing.Printing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TubeData
{
    internal class FileHandler : InputHandler
    {
        bool isButtonsShowing;

        public FileHandler(
            System.Windows.Forms.TextBox textBoxProductionOrder, 
            TableLayoutPanel tblPanelDataEntry, 
            TableLayoutPanel tblPanelLRAValues,
            TableLayoutPanel tblPanelLRAControls,
            TableLayoutPanel tblPnlComments,
            TableLayoutPanel tblPnlSaveCancel,
            RichTextBox richTextBox1, 
            RichTextBox richTextBox2, 
            System.Windows.Forms.ProgressBar progressBar1, 
            System.Windows.Forms.TreeView treeView1,
            System.Windows.Forms.TextBox txtDirectoryPath) : 
            base(
                textBoxProductionOrder, 
                tblPanelDataEntry, 
                tblPanelLRAValues,
                tblPanelLRAControls,
                tblPnlSaveCancel,
                tblPnlComments,
                richTextBox1, 
                richTextBox2,
                progressBar1, 
                treeView1, 
                txtDirectoryPath
                )
        {
            isButtonsShowing = true;
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

        private void UpdateProgress()
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

        public void SaveTube()
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

        public static Tube GetTubeFromFile(string filePath)
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

        public void PrintTubeInformation(string filePath)
        {
            // Opening a previously saved Tube instance from a binary file
            Tube openedTube = GetTubeFromFile(filePath);
            if (openedTube != null)
            {
                // Set the values to the corresponding text boxes
                textBoxProductionOrder.Text = openedTube.ProductionOrderValue;
                SetTextBoxValuesToTableLayoutPanel(tblPanelDataEntry, tblPanelLRAValues, openedTube.TextBoxValues);
                richTextBox1.Text = openedTube.RichTextBoxValue1;
                richTextBox2.Text = openedTube.RichTextBoxValue2;
            }
        }

        public Panel ResizePanelToA4(Panel panel)
        {
            // A4 paper size in millimeters
            float paperWidth = 210f;
            float paperHeight = 297f;

            // Get the graphics object of the panel
            Graphics graphics = panel.CreateGraphics();
            float dpiX = graphics.DpiX;
            float dpiY = graphics.DpiY;

            // Convert millimeters to pixels at the specified DPI
            int pixelWidth = (int)(paperWidth / 25.4 * dpiX);
            int pixelHeight = (int)(paperHeight / 25.4 * dpiY);

            // Adjust the pixel height to fill the entire page vertically
            int formHeight = panel.Parent.ClientSize.Height; // Assuming the panel is directly placed within the parent control
            if (pixelHeight < formHeight)
                pixelHeight = formHeight;

            // Set the panel size to match the A4 dimensions
            panel.Size = new Size(pixelWidth, pixelHeight);
            //panel.Size = new Size(2480, 8508);

            // Dispose the graphics object
            graphics.Dispose();

            return panel;
        }

        public void formatForPrinting()
        {
            if (isButtonsShowing == true)
            {
                this.tblPanelLRAControls.Hide();
                this.tblPanelDataEntry.Controls["tblPnlButtons"].Controls["buttonClear"].Hide();
                this.tblPnlSaveCancel.Hide();
                this.tblPnlComments.Margin = new Padding(30, 15, 30, 100);
                isButtonsShowing = false;
            } else
            {
                this.tblPanelLRAControls.Show();
                this.tblPanelDataEntry.Controls["tblPnlButtons"].Controls["buttonClear"].Show();
                this.tblPnlSaveCancel.Show();

                this.tblPnlComments.Margin = new Padding(30, 15, 30, 3);
                isButtonsShowing = true;
            }
        }

        public void PrintPanel(Panel panel)
        {
            PrintDocument printDocument = new PrintDocument();
            Panel resizedPanel = ResizePanelToA4(panel);
            printDocument.PrintPage += (sender, e) => PrintPanel(sender, e, resizedPanel);


            //Optionally, you can use the PrintPreviewDialog to preview the print layout
             PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

            // Alternatively, you can use the PrintDialog to specify print settings and print directly
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPanel(object sender, PrintPageEventArgs e, Panel panel)
        {
            Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));
            e.Graphics.DrawImage(bitmap, new Point(0, 0));
            bitmap.Dispose();
        }
    }
}
