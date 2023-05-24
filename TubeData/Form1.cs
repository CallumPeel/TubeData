using System.Windows.Forms;

namespace TubeData
{
    public partial class Form1 : Form
    {
        FileHandler FH;

        public Form1()
        {

            InitializeComponent();

            this.FH = new FileHandler(
                textBoxProductionOrder: textBoxProductionOrder,
                tblPanelDataEntry: tblPanelDataEntry,
                tblPanelLRAValues: tblPanelLRAValues,
                tblPanelLRAControls: tblPanelLRAControls,
                tblPnlSaveCancel: tblPnlSaveCancel,
                tblPnlComments: tblPnlComments,
                richTextBox1: richTextBox1,
                richTextBox2: richTextBox2,
                progressBar1: progressBar1,
                treeView1: treeView1,
                txtDirectoryPath: txtDirectoryPath
            );
            this.WindowState = FormWindowState.Maximized;
            tblPanelLRAValues.RowCount--;
            for (int i = 0; i < 5; i++) InputHandler.AddRow(tblPanelLRAValues);
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

        private void ButtonSave_Click_1(object sender, EventArgs e)
        {
            this.FH.SaveTube();
        }

        private void ButtonAddRow_Click(object sender, EventArgs e)
        {
            InputHandler.AddRow(tblPanelLRAValues);
        }

        private void ButtonRemoveRow_Click(object sender, EventArgs e)
        {
            InputHandler.RemoveRow(tblPanelLRAValues);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            InputHandler.ClearDataEntryTable(tblPanelDataEntry);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            FH.textBoxProductionOrder.Clear();
            InputHandler.ClearLRATable(tblPanelLRAValues);
            InputHandler.ClearDataEntryTable(tblPanelDataEntry);
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tube Files (*.TUBE)|*.TUBE";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FH.PrintTubeInformation(openFileDialog.FileName);
            }
        }

        private void ButtonClearLRA_Click(object sender, EventArgs e)
        {
            InputHandler.ClearLRATable(tblPanelLRAValues);
        }

        private void TreeView1_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is string filePath)
            {
                if (Path.GetExtension(filePath).Equals(".TUBE", StringComparison.OrdinalIgnoreCase))
                {
                    FH.PrintTubeInformation(filePath);
                }
            }
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void PrintPanel(Panel panel)
        {
            int width = panel.Width;
            int height = panel.Height;
            FH.PrintPanel(panel);
            panel.Width = width;
            panel.Height = height;
        }

        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            mainPanel.Hide();
            PrintPanel(mainPanel);
            mainPanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
