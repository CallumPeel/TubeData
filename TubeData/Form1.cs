using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Reflection.Emit;

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
        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value
            progressBar1.Maximum = Directory.GetFiles(
                Dir, "*.*",
                SearchOption.AllDirectories).Length
                + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
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
            string[] Files = Directory.GetFiles(dir, "*.*");
            foreach (string file in Files)
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
            System.Windows.Forms.Label rowLabel = new System.Windows.Forms.Label();
            rowLabel.Text = tblPanelLRAValues.RowCount.ToString();
            rowLabel.AutoSize = true;
            rowLabel.Dock = DockStyle.Top;
            rowLabel.TextAlign = ContentAlignment.MiddleCenter;
            rowLabel.Padding = new Padding(0, 5, 0, 0);


            // Create text boxes for data entry
            TextBox textBox1 = new TextBox();
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Margin = new Padding(3, 3, 30, 3);
            textBox1.Dock = DockStyle.Top;

            TextBox textBox2 = new TextBox();
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Margin = new Padding(3, 3, 30, 3);
            textBox2.Dock = DockStyle.Top;

            TextBox textBox3 = new TextBox();
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Margin = new Padding(3, 3, 30, 3);
            textBox3.Dock = DockStyle.Top;

            TextBox textBox4 = new TextBox();
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Margin = new Padding(3, 3, 30, 3);
            textBox4.Dock = DockStyle.Top;

            TextBox textBox5 = new TextBox();
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Margin = new Padding(3, 3, 30, 3);
            textBox5.Dock = DockStyle.Top;

            // Set RowStyles
            tblPanelLRAValues.RowStyles.Clear(); // Clear any existing row styles

            // Set the second row to use a fixed height
            tblPanelLRAValues.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // Adjust the height as needed

            // Add controls to the new row
            tblPanelLRAValues.Controls.Add(rowLabel, 0, tblPanelLRAValues.RowCount); // Add label to column 0
            tblPanelLRAValues.Controls.Add(textBox1, 1, tblPanelLRAValues.RowCount); // Add text box to column 1
            tblPanelLRAValues.Controls.Add(textBox2, 2, tblPanelLRAValues.RowCount); // Add text box to column 2
            tblPanelLRAValues.Controls.Add(textBox3, 3, tblPanelLRAValues.RowCount); // Add text box to column 3
            tblPanelLRAValues.Controls.Add(textBox4, 4, tblPanelLRAValues.RowCount); // Add text box to column 4
            tblPanelLRAValues.Controls.Add(textBox5, 5, tblPanelLRAValues.RowCount); // Add text box to column 5
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

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            List<string> textBoxValues = new List<string>();

            // Iterate over the controls in the TableLayoutPanel
            foreach (Control control in tblPanelDataEntry.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Add the value of the text box to the list
                    textBoxValues.Add(textBox.Text);
                }
            }

            // Iterate over the controls in the TableLayoutPanel
            foreach (Control control in tblPanelLRAValues.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Add the value of the text box to the list
                    textBoxValues.Add(textBox.Text);
                }
            }

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is RichTextBox textBox)
                {
                    // Add the value of the text box to the list
                    textBoxValues.Add(textBox.Text);
                }
            }

            MessageBox.Show(string.Join(Environment.NewLine, textBoxValues));
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            newRow();
        }

        private void buttonRemoveRow_Click(object sender, EventArgs e)
        {
            removeRow();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //List<string> textBoxValues = new List<string>();

            //// Iterate over the controls in the TableLayoutPanel
            //foreach (Control control in tblPanelDataEntry.Controls)
            //{
            //    if (control is TextBox textBox)
            //    {
            //        // Add the value of the text box to the list
            //        textBoxValues.Add(textBox.Text);
            //    }
            //}

            //MessageBox.Show(string.Join(Environment.NewLine, textBoxValues));

            // Iterate over the controls in the TableLayoutPanel
            foreach (Control control in tblPanelDataEntry.Controls)
            {
                if (control is TextBox textBox)
                {
                    control.Text = "";
                }
            }
        }
    }
}