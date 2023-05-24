namespace TubeData
{
    internal class InputHandler
    {
        public TextBox textBoxProductionOrder;
        public TableLayoutPanel 
            tblPanelDataEntry, 
            tblPanelLRAValues, 
            tblPanelLRAControls, 
            tblPnlSaveCancel, 
            tblPnlComments;
        public RichTextBox richTextBox1, richTextBox2;
        public ProgressBar progressBar1;
        public TreeView treeView1;
        public TextBox txtDirectoryPath;

        public InputHandler(
            TextBox textBoxProductionOrder,
            TableLayoutPanel tblPanelDataEntry,
            TableLayoutPanel tblPanelLRAValues,
            TableLayoutPanel tblPanelLRAControls,
            TableLayoutPanel tblPnlSaveCancel,
            TableLayoutPanel tblPnlComments,
            RichTextBox richTextBox1,
            RichTextBox richTextBox2,
            ProgressBar progressBar1,
            TreeView treeView1,
            TextBox txtDirectoryPath
            )
        {
            this.textBoxProductionOrder = textBoxProductionOrder;
            this.tblPanelDataEntry = tblPanelDataEntry;
            this.tblPanelLRAValues = tblPanelLRAValues;
            this.tblPanelLRAControls = tblPanelLRAControls;
            this.tblPnlSaveCancel = tblPnlSaveCancel;
            this.tblPnlComments = tblPnlComments;
            this.richTextBox1 = richTextBox1;
            this.richTextBox2 = richTextBox2;
            this.progressBar1 = progressBar1;
            this.treeView1 = treeView1;
            this.txtDirectoryPath = txtDirectoryPath;
        }


        public static void AddRow(TableLayoutPanel panel)
        {
            if (panel.RowCount >= 15) {
                return;
            }

            panel.Visible = false;
            panel.RowCount++;

            System.Windows.Forms.Label rowLabel = new System.Windows.Forms.Label
            {
                Text = panel.RowCount.ToString(),
                AutoSize = true,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0, 5, 0, 0)
            };

            TextBox[] textBoxes = new TextBox[5];

            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i] = new TextBox
                {
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    Margin = new Padding(3, 3, 30, 3),
                    Dock = DockStyle.Top
                };
            }

            panel.RowStyles.Clear();
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            panel.Controls.Add(rowLabel, 0, panel.RowCount);

            for (int i = 0; i < textBoxes.Length; i++)
            {
                panel.Controls.Add(textBoxes[i], i + 1, panel.RowCount);
            }
            panel.Visible = true;
        }

        public static void RemoveRow(TableLayoutPanel panel)
        {
            for (int i = 0; i < 6; i++)
            {
                panel.Controls.RemoveAt(panel.Controls.Count - 1);
            }
            panel.RowCount--;

        }

        public static void ClearDataEntryTable(TableLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    control.Text = "";
                }
            }
        }

        public static void SetTextBoxValuesToTableLayoutPanel(TableLayoutPanel tableLayoutPanel1, TableLayoutPanel tableLayoutPanel2, List<string> textBoxValues)
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
                    AddRow(tableLayoutPanel2);
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

        public static void ClearLRATable(TableLayoutPanel tblPanelLRAValues)
        {
            foreach (Control control in tblPanelLRAValues.Controls)
            {
                if (control is TextBox textBox)
                {
                    control.Text = "";
                }
            }
        }

        public List<string> GetTextBoxValuesFromTableLayoutPanel()
        {
            List<string> textBoxValues = new List<string>();
            AddPanelToList(textBoxValues, this.tblPanelDataEntry);
            AddPanelToList(textBoxValues, this.tblPanelLRAValues);
            return textBoxValues;
        }

        private static List<string> AddPanelToList(List<string> textBoxValues, TableLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBoxValues.Add(textBox.Text);
                }
            }
            return textBoxValues;
        }

        public Tube GetTube()
        {
            Tube tube = new Tube();
            tube.ProductionOrderValue = this.textBoxProductionOrder.Text;
            tube.TextBoxValues = GetTextBoxValuesFromTableLayoutPanel();
            tube.RichTextBoxValue1 = richTextBox1.Text;
            tube.RichTextBoxValue2 = richTextBox2.Text;
            return tube;
        }

    }
}
