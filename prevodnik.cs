/* Author:  Antonín Štoll       xstoll01
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitsNet;
using org.mariuszgromada.math.mxparser;

namespace Calculater
{
    public partial class prevodnik : UserControl
    {
        QuantityInfo selectedQuantity;

        public prevodnik()
        {
            InitializeComponent();
            selectedQuantity = null;

            string[] quantities = new string[] { "Mass", "Length", "Area",
                                                  "Volume", "Temperature", "Duration",
                                                  "Information", "Speed", "Energy",
                                                  "Power"};

            foreach (string quantity in quantities)
            {
                RoundedButton quantityButton = new RoundedButton();
                quantityButton.BackColor = Color.FromArgb(50, 73, 60);
                quantityButton.FlatStyle = FlatStyle.Popup;
                quantityButton.ForeColor = Color.White;
                quantityButton.Location = new Point(262, 470);
                quantityButton.Name = quantity;
                quantityButton.Size = new Size(130, 60);
                quantityButton.TabIndex = 51;
                quantityButton.Text = quantity;
                quantityButton.UseVisualStyleBackColor = false;
                quantityButton.Cursor = Cursors.Hand;
                quantityButton.Click += clickQuantityButton;

                quantitySelector.Controls.Add(quantityButton);
            }
        }

        private void clickQuantityButton(object sender, EventArgs e)
        {
            Button buttonPRESSED = sender as Button;

            selectedQuantity = Quantity.ByName[buttonPRESSED.Name];

            unitsFrom.Items.Clear();
            unitsTo.Items.Clear();
            foreach (Enum unitValue in selectedQuantity.UnitInfos.Select(ui => ui.Value))
            {
                unitsFrom.Items.Add(unitValue.ToString());
                unitsFrom.SelectedIndex = 0;
                unitsTo.Items.Add(unitValue.ToString());
                unitsTo.SelectedIndex = 0;
            }
        }

        private void clickButton(object sender, EventArgs e)
        {
            Button buttonPRESSED = sender as Button;


            switch (buttonPRESSED.Name)
            {
                case "buttonDEL":
                    if (inputMath.Text.Length > 0)
                    {
                        inputMath.Text = inputMath.Text.Substring(0, inputMath.Text.Length - 1);
                    }
                    break;
                case "buttonAC":
                    inputMath.Text = "";
                    break;
                case "buttonEQ":
                    if (selectedQuantity != null)
                    {
                        Expression ex = new Expression(inputMath.Text);
                        double result = ex.calculate();

                        if (!double.IsNaN(result))
                        {
                            result = UnitConverter.Convert(result,
                                selectedQuantity.UnitInfos.FirstOrDefault(info => info.Name == unitsFrom.Text).Value,
                                selectedQuantity.UnitInfos.FirstOrDefault(info => info.Name == unitsTo.Text).Value);

                            saveToHistory(inputMath.Text, result.ToString().Replace(",", "."));
                        }

                        resultTextBox.Text = result.ToString().Replace(",", ".");
                    }
                    break;
                case "buttonPLUS":
                case "buttonMINUS":
                case "buttonMULT":
                case "buttonDIV":
                case "buttonLB":
                case "buttonRB":
                default:
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                    break;

            }
        }

        private void saveToHistory(string input, string result)
        {
            RoundedTextBox historyRow = new RoundedTextBox();
            historyRow.BackColor = Color.FromArgb(60, 80, 83);
            historyRow.BorderRadius = 0;
            historyRow.Name = "historyTemplate";
            historyRow.Anchor = AnchorStyles.None;
            historyRow.BorderStyle = BorderStyle.None;
            historyRow.Location = new Point(6, 3);
            historyRow.Multiline = true;
            historyRow.ReadOnly = true;
            historyRow.Size = new Size(443, 44);
            historyRow.TabIndex = 48;
            historyRow.Cursor = Cursors.Arrow;
            historyRow.Text = input + " " + unitsFrom.Text + " = " + result + " " + unitsTo.Text;

            PictureBox deleteButton = new PictureBox();
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Image = Properties.Resources.trash;
            deleteButton.Location = new Point(462, 0);
            deleteButton.Margin = new Padding(0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(50, 50);
            deleteButton.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteButton.TabIndex = 49;
            deleteButton.TabStop = false;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Click += deleteHistoryRow;

            TableLayoutPanel historyRowPanel = new TableLayoutPanel();
            historyRowPanel.ColumnCount = 2;
            historyRowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.5F));
            historyRowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            historyRowPanel.Controls.Add(historyRow, 0, 0);
            historyRowPanel.Controls.Add(deleteButton, 1, 0);
            historyRowPanel.Location = new Point(3, 3);
            historyRowPanel.Name = "historyRowPanel";
            historyRowPanel.RowCount = 1;
            historyRowPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            historyRowPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            historyRowPanel.Size = new Size(500, 50);
            historyRowPanel.TabIndex = 50;

            history.Controls.Add(historyRowPanel);
            history.Controls.SetChildIndex(historyRowPanel, 0);
        }

        private void deleteHistoryRow(object sender, EventArgs e)
        {
            PictureBox deleteButton = sender as PictureBox;

            history.Controls.Remove(deleteButton.Parent);
        }

        public void keyPressed(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    button0.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
                case Keys.Back:
                case Keys.Delete:
                    buttonDEL.PerformClick();
                    break;
                case Keys.C:
                    buttonAC.PerformClick();
                    break;
                case Keys.Enter:
                case Keys.Oemplus: // =
                    buttonEQ.PerformClick();
                    break;
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                case Keys.Decimal:
                    buttonDot.PerformClick();
                    break;
                case Keys.Add:
                    buttonPLUS.PerformClick();
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    buttonMINUS.PerformClick();
                    break;
                case Keys.Multiply:
                    buttonMULT.PerformClick();
                    break;
                case Keys.Divide:
                    buttonDIV.PerformClick();
                    break;
            }
        }
    }
}
