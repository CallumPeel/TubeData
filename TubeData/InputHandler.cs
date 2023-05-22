using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubeData
{
    internal class InputHandler
    {

        public void addRow(TableLayoutPanel panel)
        {
            panel.Visible = false;

            panel.RowCount++; // Increment row count

            // Create label for the row number
            System.Windows.Forms.Label rowLabel = new System.Windows.Forms.Label
            {
                Text = panel.RowCount.ToString(),
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
            panel.RowStyles.Clear(); // Clear any existing row styles

            // Set the new row to use a fixed height
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // Adjust the height as needed

            // Add controls to the new row
            panel.Controls.Add(rowLabel, 0, panel.RowCount); // Add label to column 0

            // Add text boxes to columns 1-5
            for (int i = 0; i < textBoxes.Length; i++)
            {
                panel.Controls.Add(textBoxes[i], i + 1, panel.RowCount);
            }
            panel.Visible = true;
        }

        public void removeRow(TableLayoutPanel panel)
        {
            for (int i = 0; i < 6; i++)
            {
                panel.Controls.RemoveAt(panel.Controls.Count - 1);
            }
            panel.RowCount--;

        }

        public void clearDataEntryTable(TableLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    control.Text = "";
                }
            }
        }

        public void SetTextBoxValuesToTableLayoutPanel(TableLayoutPanel tableLayoutPanel1, TableLayoutPanel tableLayoutPanel2, List<string> textBoxValues)
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
                    addRow(tableLayoutPanel2);
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
        
        public void clearLRATable(TableLayoutPanel tblPanelLRAValues)
        {
            foreach (Control control in tblPanelLRAValues.Controls)
            {
                if (control is TextBox textBox)
                {
                    control.Text = "";
                }
            }
        }

        public void GetRichTextBoxValuesFromTableLayoutPanel(TableLayoutPanel tableLayoutPanel, List<string> textBoxValues)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is RichTextBox richTextBox)
                {
                    textBoxValues.Add(richTextBox.Text);
                }
            }
        }

        public void GetTextBoxValuesFromTableLayoutPanel(TableLayoutPanel tableLayoutPanel, List<string> textBoxValues)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBoxValues.Add(textBox.Text);
                }
            }
        }
    }

}
