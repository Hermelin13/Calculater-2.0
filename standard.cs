/* Author:  Adam Dalibor Jurčík xjurci08
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
using System.Xml;
using Microsoft.VisualBasic;
using org.mariuszgromada.math.mxparser;
using org.mariuszgromada.math.mxparser.mathcollection;
using System.IO;

namespace Calculater
{
    public partial class standard : UserControl
    {
        bool number = false;
        bool dot = false;
        bool op = false;
        bool konst = false;
        bool nothing = true;
        bool sqrt = false;
        bool bracket = false;
        bool root = false;
        bool fact = false;
        int brackets = 0;
        string const_ANS;

        public standard()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void nullFunc()
        {
            number = false;
            dot = false;
            op = false;
            konst = false;
            nothing = true;
            sqrt = false;
            bracket = false;
            root = false;
            fact = false;
            brackets = 0;
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
                        if (inputMath.Text.Length == 0)
                        {
                            nullFunc();
                        }
                    }
                    break;
                case "buttonCLEAR":
                    inputMath.Text = "";
                    nullFunc();
                    break;
                case "buttonEQ":
                    Expression ex = new Expression(inputMath.Text);
                    var result = ex.calculate();
                    saveToHistory(inputMath.Text, result.ToString().Replace(",", "."));
                    const_ANS = result.ToString().Replace(",", ".");
                    inputMath.Text = "";
                    nullFunc();
                    break;
                case "buttonDOT":
                    if (!nothing && number && !dot)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        dot = true;
                    }
                    break;
                case "buttonPLUS":
                case "buttonMINUS":
                    if (!op)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        number = false;
                        op = true;
                        nothing = true;
                        konst = false;
                        sqrt = false;
                        root = false;
                        fact = false;
                        dot = false;
                    }
                    break;
                case "buttonFACT":
                    if (!nothing && !konst && !fact)
                    {
                        inputMath.Text = inputMath.Text + "!";
                        number = false;
                        fact = true;
                    }
                    break;
                case "buttonMULTI":
                case "buttonDIV":
                case "buttonMOD":
                    if (!nothing)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        number = false;
                        op = true;
                        nothing = true;
                        sqrt = false;
                        fact = false;
                        dot = false;
                    }
                    break;
                case "buttonEXP2":
                    if (!nothing && !sqrt && !fact)
                    {
                        inputMath.Text = inputMath.Text + "^2";
                        number = false;
                        sqrt = true;
                    }
                    break;
                case "buttonEXP3":
                    if (!nothing && !sqrt && !fact)
                    {
                        inputMath.Text = inputMath.Text + "^3";
                        number = false;
                        sqrt = true;
                    }
                    break;
                case "buttonEXP4":
                    if (!nothing && !sqrt && !fact)
                    {
                        inputMath.Text = inputMath.Text + "^4";
                        number = false;
                        sqrt = true;
                    }
                    break;
                case "buttonROOT2":
                    if (nothing && !root)
                    {
                        inputMath.Text = inputMath.Text + "√";
                        nothing = true;
                        op = true;
                        root = true;
                    }
                    break;
                case "buttonROOT3":
                    if (nothing && !root)
                    {
                        inputMath.Text = inputMath.Text + "∛";
                        nothing = true;
                        op = true;
                        root = true;
                    }
                    break;
                case "buttonROOT4":
                    if (nothing && !root)
                    {
                        inputMath.Text = inputMath.Text + "∜";
                        nothing = true;
                        op = true;
                        root = true;
                    }
                    break;
                case "buttonPI":
                case "buttonEULER":
                    if (nothing)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        konst = true;
                        nothing = false;
                        op = false;
                        root = false;
                    }
                    break;
                case "buttonLOG":
                case "buttonCOT":
                case "buttonTAN":
                case "buttonCOS":
                case "buttonSIN":
                case "buttonASIN":
                case "buttonACOS":
                    if (nothing)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text + "(";
                        op = false;
                        brackets++;
                        konst = false;
                    }
                    break;
                case "buttonLBRACKET":
                    if (nothing || op)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        brackets++;
                        nothing = true;
                        op = false;
                    }
                    break;
                case "buttonRBRACKET":
                    if (brackets != 0)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        brackets--;
                        konst = false;
                        nothing = false;
                        sqrt = false;
                        op = false;
                        bracket = true;
                    }
                    break;
                case "buttonANS":
                    if (nothing || (number && !bracket))
                    {
                        inputMath.Text = inputMath.Text + const_ANS;
                        nothing = false;
                        number = true;
                        op = false;
                        bracket = false;
                        root = false;
                    }
                    break;
                default:
                    if (nothing || (number && !bracket))
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        nothing = false;
                        number = true;
                        op = false;
                        bracket = false;
                        root = false;
                    }
                    break;
            }
        }

        public void HistoryToXml(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            XmlElement rootElement = document.CreateElement("root");
            XmlElement standard = document.CreateElement("standard");

            foreach (var historyRow in history.Controls)
            {
                TextBox historyTextBox = (historyRow as TableLayoutPanel).Controls.Find("historyTemplate", true)[0] as TextBox;

                XmlElement xmlHistoryRow = document.CreateElement("historyRow");
                xmlHistoryRow.InnerText = historyTextBox.Text;
                standard.AppendChild(xmlHistoryRow);
            }

            rootElement.AppendChild(standard);
            document.AppendChild(rootElement);

            document.Save("standardHistory.xml");
        }

        private void LoadHistory()
        {
            if (File.Exists("standardHistory.xml"))
            {
                try
                {
                    XmlDocument document = new XmlDocument();
                    document.Load("standardHistory.xml");

                    var historyRows = document.SelectNodes("/root/standard/historyRow");
                    List<XmlNode> reversedHistoryRows = new List<XmlNode>();

                    foreach (XmlNode historyRow in historyRows)
                    {
                        reversedHistoryRows.Insert(0, historyRow);
                    }

                    foreach (XmlNode historyRow in reversedHistoryRows)
                    {
                        string[] inputResult = historyRow.InnerText.Split(" = ");
                        saveToHistory(inputResult[0], inputResult[1]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading from XML: {ex.Message}");
                }
            }
        }

        private void saveToHistory(string input, string result)
        {
            // Create a new TableLayoutPanel
            TableLayoutPanel historyRowPanel = new TableLayoutPanel();
            historyRowPanel.ColumnCount = 2;
            historyRowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.5F));
            historyRowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));

            // Create a new RoundedTextBox
            TextBox historyRow = new TextBox();
            historyRow.BackColor = Color.FromArgb(60, 80, 83);
            historyRow.Name = "historyTemplate";
            historyRow.Anchor = AnchorStyles.None;
            historyRow.BorderStyle = BorderStyle.None;
            historyRow.Location = new Point(6, 3);
            historyRow.ReadOnly = true;
            historyRow.Size = new Size(443, 44);
            historyRow.TabIndex = 48;
            historyRow.Cursor = Cursors.Arrow;
            historyRow.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            historyRow.Text = input + " = " + result;
            historyRow.Click += change;

            // Create a new PictureBox for deletion
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

            // Add the controls to the TableLayoutPanel
            historyRowPanel.Controls.Add(historyRow, 0, 0);
            historyRowPanel.Controls.Add(deleteButton, 1, 0);

            // Set the location of the new TableLayoutPanel to the top
            historyRowPanel.Location = new Point(3, 3);
            historyRowPanel.Name = "historyRowPanel";
            historyRowPanel.RowCount = 1;
            historyRowPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            historyRowPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            historyRowPanel.Size = new Size(450, 50);
            historyRowPanel.TabIndex = 50;

            // Shift existing controls down
            foreach (Control control in history.Controls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + historyRowPanel.Height);
            }

            // Add the new TableLayoutPanel to the top of the history panel
            history.Controls.Add(historyRowPanel);
            history.Controls.SetChildIndex(historyRowPanel, 0);
        }

        private void deleteHistoryRow(object sender, EventArgs e)
        {
            PictureBox deleteButton = sender as PictureBox;

            history.Controls.Remove(deleteButton.Parent);
        }

        private void change(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string[] expr = textBox.Text.Split(" = ");
            inputMath.Text = expr[0];
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
                    buttonCLEAR.PerformClick();
                    break;
                case Keys.Enter:
                case Keys.Oemplus: // =
                    buttonEQ.PerformClick();
                    break;
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                case Keys.Decimal:
                    buttonDOT.PerformClick();
                    break;
                case Keys.Add:
                    buttonPLUS.PerformClick();
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    buttonMINUS.PerformClick();
                    break;
                case Keys.Multiply:
                    buttonMULTI.PerformClick();
                    break;
                case Keys.Divide:
                    buttonDIV.PerformClick();
                    break;
                case Keys.P:
                    buttonPI.PerformClick();
                    break;
                case Keys.E:
                    buttonEULER.PerformClick();
                    break;
            }
        }
    }
}

