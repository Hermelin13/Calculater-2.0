/* Author:  David Zahálka       xzahal03
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using org.mariuszgromada.math.mxparser;

namespace Calculater
{

    public partial class binary : UserControl
    {
        bool hex = true;
        bool dec = false;
        bool oct = false;
        bool bin = false;
        private List<HistoryEntry> historyList = new List<HistoryEntry>();
        private string historyFileName = "history.txt";
        private string historyFilePath;

        public binary()
        {
            InitializeComponent();
            historyFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, historyFileName);
            LoadHistoryFromFile();
        }

        private void SetSelectedButton(Button selectedButton)
        {
            buttonHEX.BackColor = Color.FromArgb(50, 73, 60);
            buttonOCT.BackColor = Color.FromArgb(50, 73, 60);
            buttonBIN.BackColor = Color.FromArgb(50, 73, 60);
            buttonDEC.BackColor = Color.FromArgb(50, 73, 60);

            selectedButton.BackColor = Color.FromArgb(50, 93, 60);
        }

        private void ChangeNumericSystem(string sys)
        {
            if (sys == "dec")
            {
                dec = true;
                bin = false;
                oct = false;
                hex = false;
                SetSelectedButton(buttonDEC);

                button2.BackColor = Color.FromArgb(62, 80, 91);
                button2.Enabled = true;
                button3.BackColor = Color.FromArgb(62, 80, 91);
                button3.Enabled = true;
                button4.BackColor = Color.FromArgb(62, 80, 91);
                button4.Enabled = true;
                button5.BackColor = Color.FromArgb(62, 80, 91);
                button5.Enabled = true;
                button6.BackColor = Color.FromArgb(62, 80, 91);
                button6.Enabled = true;
                button7.BackColor = Color.FromArgb(62, 80, 91);
                button7.Enabled = true;
                button8.BackColor = Color.FromArgb(62, 80, 91);
                button8.Enabled = true;
                button9.BackColor = Color.FromArgb(62, 80, 91);
                button9.Enabled = true;

                buttonA.BackColor = Color.FromArgb(42, 60, 71);
                buttonA.Enabled = false;
                buttonB.BackColor = Color.FromArgb(42, 60, 71);
                buttonB.Enabled = false;
                buttonC.BackColor = Color.FromArgb(42, 60, 71);
                buttonC.Enabled = false;
                buttonD.BackColor = Color.FromArgb(42, 60, 71);
                buttonD.Enabled = false;
                buttonE.BackColor = Color.FromArgb(42, 60, 71);
                buttonE.Enabled = false;
                buttonF.BackColor = Color.FromArgb(42, 60, 71);
                buttonF.Enabled = false;
            }
            else if (sys == "oct")
            {
                dec = false;
                bin = false;
                oct = true;
                hex = false;
                SetSelectedButton(buttonOCT);

                button2.BackColor = Color.FromArgb(62, 80, 91);
                button2.Enabled = true;
                button3.BackColor = Color.FromArgb(62, 80, 91);
                button3.Enabled = true;
                button4.BackColor = Color.FromArgb(62, 80, 91);
                button4.Enabled = true;
                button5.BackColor = Color.FromArgb(62, 80, 91);
                button5.Enabled = true;
                button6.BackColor = Color.FromArgb(62, 80, 91);
                button6.Enabled = true;
                button7.BackColor = Color.FromArgb(62, 80, 91);
                button7.Enabled = true;

                button8.BackColor = Color.FromArgb(42, 60, 71);
                button8.Enabled = false;
                button9.BackColor = Color.FromArgb(42, 60, 71);
                button9.Enabled = false;
                buttonA.BackColor = Color.FromArgb(42, 60, 71);
                buttonA.Enabled = false;
                buttonB.BackColor = Color.FromArgb(42, 60, 71);
                buttonB.Enabled = false;
                buttonC.BackColor = Color.FromArgb(42, 60, 71);
                buttonC.Enabled = false;
                buttonD.BackColor = Color.FromArgb(42, 60, 71);
                buttonD.Enabled = false;
                buttonE.BackColor = Color.FromArgb(42, 60, 71);
                buttonE.Enabled = false;
                buttonF.BackColor = Color.FromArgb(42, 60, 71);
                buttonF.Enabled = false;
            }
            else if (sys == "bin")
            {
                dec = false;
                bin = true;
                oct = false;
                hex = false;
                SetSelectedButton(buttonBIN);

                button2.BackColor = Color.FromArgb(42, 60, 71);
                button2.Enabled = false;
                button3.BackColor = Color.FromArgb(42, 60, 71);
                button3.Enabled = false;
                button4.BackColor = Color.FromArgb(42, 60, 71);
                button4.Enabled = false;
                button5.BackColor = Color.FromArgb(42, 60, 71);
                button5.Enabled = false;
                button6.BackColor = Color.FromArgb(42, 60, 71);
                button6.Enabled = false;
                button7.BackColor = Color.FromArgb(42, 60, 71);
                button7.Enabled = false;
                button8.BackColor = Color.FromArgb(42, 60, 71);
                button8.Enabled = false;
                button9.BackColor = Color.FromArgb(42, 60, 71);
                button9.Enabled = false;
                buttonA.BackColor = Color.FromArgb(42, 60, 71);
                buttonA.Enabled = false;
                buttonB.BackColor = Color.FromArgb(42, 60, 71);
                buttonB.Enabled = false;
                buttonC.BackColor = Color.FromArgb(42, 60, 71);
                buttonC.Enabled = false;
                buttonD.BackColor = Color.FromArgb(42, 60, 71);
                buttonD.Enabled = false;
                buttonE.BackColor = Color.FromArgb(42, 60, 71);
                buttonE.Enabled = false;
                buttonF.BackColor = Color.FromArgb(42, 60, 71);
                buttonF.Enabled = false;
            }
            else if (sys == "hex")
            {
                dec = false;
                bin = false;
                oct = false;
                hex = true;
                SetSelectedButton(buttonHEX);

                button2.BackColor = Color.FromArgb(62, 80, 91);
                button2.Enabled = true;
                button3.BackColor = Color.FromArgb(62, 80, 91);
                button3.Enabled = true;
                button4.BackColor = Color.FromArgb(62, 80, 91);
                button4.Enabled = true;
                button5.BackColor = Color.FromArgb(62, 80, 91);
                button5.Enabled = true;
                button6.BackColor = Color.FromArgb(62, 80, 91);
                button6.Enabled = true;
                button7.BackColor = Color.FromArgb(62, 80, 91);
                button7.Enabled = true;
                button8.BackColor = Color.FromArgb(62, 80, 91);
                button8.Enabled = true;
                button9.BackColor = Color.FromArgb(62, 80, 91);
                button9.Enabled = true;
                buttonA.BackColor = Color.FromArgb(62, 80, 91);
                buttonA.Enabled = true;
                buttonB.BackColor = Color.FromArgb(62, 80, 91);
                buttonB.Enabled = true;
                buttonC.BackColor = Color.FromArgb(62, 80, 91);
                buttonC.Enabled = true;
                buttonD.BackColor = Color.FromArgb(62, 80, 91);
                buttonD.Enabled = true;
                buttonE.BackColor = Color.FromArgb(62, 80, 91);
                buttonE.Enabled = true;
                buttonF.BackColor = Color.FromArgb(62, 80, 91);
                buttonF.Enabled = true;
            }
        }
        public static string decimalToBinary(string decimalNumber)
        {
            if (!int.TryParse(decimalNumber, out int decimalInt))
            {
                return "Nefunguje kdyz tam mam operatory";
            }

            if (decimalInt == 0)
            {
                return "0";
            }

            StringBuilder binaryNumber = new StringBuilder();
            while (decimalInt > 0)
            {
                int tmp = decimalInt % 2;
                binaryNumber.Insert(0, tmp);
                decimalInt /= 2;
            }

            return binaryNumber.ToString();
        }

        public string expressionProcess(string expression)
        {
            expression = Regex.Replace(expression, "AND", "@&");
            expression = Regex.Replace(expression, "XOR", "@^");
            expression = Regex.Replace(expression, "OR", "@|");
            expression = Regex.Replace(expression, ">>", "@>>");
            expression = Regex.Replace(expression, "<<", "@<<");

            expression = Regex.Replace(expression, @"([^&|()]+)\s*NOT\b", "@~$1");

            return expression;
        }

        static string ConvertBinary(string input, int Base)
        {
            string pattern = @"\b[01]+\b";
            string result = Regex.Replace(input, pattern, match =>
            {
                string binaryNumber = match.Value;
                int decimalNumber = Convert.ToInt32(binaryNumber, 2);
                return Convert.ToString(decimalNumber, Base);
            });

            return result;
        }

        static string ConvertHexadecimal(string input, int Base)
        {
            string pattern = @"\b[0-9A-Fa-f]+\b";
            string result = Regex.Replace(input, pattern, match =>
            {
                string hexNumber = match.Value;
                int decimalNumber = Convert.ToInt32(hexNumber, 16);
                return Convert.ToString(decimalNumber, Base);
            });

            return result;
        }
        static string ConvertOctal(string input, int Base)
        {
            string pattern = @"\b[0-7]+\b";
            string result = Regex.Replace(input, pattern, match =>
            {
                string octalNumber = match.Value;
                int decimalNumber = Convert.ToInt32(octalNumber, 8);
                return Convert.ToString(decimalNumber, Base);
            });

            return result;
        }
        static string ConvertDecimal(string input, int Base)
        {
            string pattern = @"\b[0-9]+\b";
            string result = Regex.Replace(input, pattern, match =>
            {
                string decNumber = match.Value;
                int decimalNumber = Convert.ToInt32(decNumber, 10);
                return Convert.ToString(decimalNumber, Base);
            });

            return result;
        }
        private void LoadHistoryFromFile()
        {
            if (File.Exists(historyFilePath))
            {
                historyList.Clear();
                string[] lines = File.ReadAllLines(historyFilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        string input = parts[0].Trim();
                        string result = parts[1].Trim();
                        string[] numericSystem = result.Split("[");

                        CreateInput(input, numericSystem[0]);
                        //historyList.Add($"{input} = {result}");
                        historyList.Add(new HistoryEntry
                        {
                            Input = input,
                            Result = numericSystem[0],
                            NumericSystem = numericSystem[1].Trim(']', ' ')
                        });
                    }
                }
            }
        }

        private void SaveToHistory(string input, string result, string numericSystem)
        {
            CreateInput(input, result);

            //string newEntry = $"{input} = {result}";
            HistoryEntry newEntry = new HistoryEntry
            {
                Input = input,
                Result = result.Trim(),
                NumericSystem = numericSystem
            };
            historyList.Insert(0, newEntry);
            File.AppendAllText(historyFilePath, $"{input} = {result} [{numericSystem}]" + Environment.NewLine);
        }

        private void CreateInput(string input, string result)
        {
            TableLayoutPanel historyRowPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 1,
                AutoSize = true,
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
            };

            TextBox historyRow = new TextBox
            {
                BackColor = Color.FromArgb(60, 80, 83),
                Name = "historyTemplate",
                Anchor = AnchorStyles.None,
                BorderStyle = BorderStyle.None,
                Location = new Point(6, 3),
                ReadOnly = true,
                Size = new Size(443, 44),
                TabIndex = 48,
                Cursor = Cursors.Arrow,
                Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
                Text = $"{input} = {result}",
            };

            PictureBox deleteButton = new PictureBox
            {
                Anchor = AnchorStyles.None,
                Image = Properties.Resources.trash,
                Location = new Point(historyRow.Width + 6, 0),
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 49,
                TabStop = false,
                Cursor = Cursors.Hand,
            };
            deleteButton.Click += DeleteHistoryRow;


            historyRowPanel.Controls.Add(historyRow, 0, 0);
            historyRowPanel.Controls.Add(deleteButton, 1, 0);

            historyRow.Click += (sender, e) =>
            {
                string[] clickedExpression = historyRow.Text.Split('=');
                inputMath.Text = clickedExpression[0].Trim();
                HistoryEntry historyEntry = historyList
                    .FirstOrDefault(entry =>
                        entry.Input.Trim() == clickedExpression[0].Trim() &&
                        entry.Result.Trim() == clickedExpression[1].Trim());
                string sys = historyEntry.NumericSystem;
                ChangeNumericSystem(sys);
            };

            history.Controls.Add(historyRowPanel);
            history.Controls.SetChildIndex(historyRowPanel, 0);
        }

        private void DeleteHistoryRow(object sender, EventArgs e)
        {
            PictureBox deleteButton = sender as PictureBox;
            TableLayoutPanel historyRowPanel = deleteButton?.Parent as TableLayoutPanel;

            if (historyRowPanel != null)
            {
                foreach (Control control in history.Controls)
                {
                    if (control.Location.Y > historyRowPanel.Location.Y)
                    {
                        control.Location = new Point(control.Location.X, control.Location.Y - historyRowPanel.Height);
                    }
                }

                TextBox clickedTextBox = (TextBox)historyRowPanel.Controls[0];
                string[] clickedExpression = clickedTextBox.Text.Split("=");

                // Find the corresponding HistoryEntry in the list
                HistoryEntry historyEntry = historyList
                    .FirstOrDefault(entry =>
                        entry.Input.Trim() == clickedExpression[0].Trim() &&
                        entry.Result.Trim() == clickedExpression[1].Trim());

                if (historyEntry != null)
                {
                    // Remove the entry from the list
                    historyList.Remove(historyEntry);

                    // Read all lines from the file
                    string[] fileLines = File.ReadAllLines(historyFilePath);

                    // Remove the corresponding line from the file content
                    string lineToRemove = $"{historyEntry.Input} = {historyEntry.Result}[{historyEntry.NumericSystem}]";
                    fileLines = fileLines.Where(line => line != lineToRemove).ToArray();

                    // Update the file content
                    File.WriteAllLines(historyFilePath, fileLines);
                }
                history.Controls.Remove(historyRowPanel);
            }
        }

        private void clickButton(object sender, EventArgs e)
        {
            Button buttonPRESSED = sender as Button;
            string sys;

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
                    if (dec)
                    {
                        string tmp = expressionProcess(inputMath.Text);
                        Expression ex = new Expression(tmp);
                        var result = ex.calculate();
                        sys = "dec";
                        //history.Text += inputMath.Text + " = " + result.ToString() + Environment.NewLine;  
                        SaveToHistory(inputMath.Text, result.ToString().Trim(), sys);
                        inputMath.Text = result.ToString();
                    }
                    else if (bin)
                    {
                        string tmp = ConvertBinary(inputMath.Text, 10);
                        string tmp1 = expressionProcess(tmp);
                        Expression ex = new Expression(tmp1);
                        var result = ex.calculate();
                        sys = "bin";
                        //history.Text = inputMath.Text + " = " + Convert.ToString((int)result, 2);
                        SaveToHistory(inputMath.Text, Convert.ToString((int)result, 2).Trim(), sys);
                        inputMath.Text = Convert.ToString((int)result, 2);
                    }
                    else if (hex)
                    {
                        string tmp = expressionProcess(inputMath.Text);
                        string tmp1 = ConvertHexadecimal(tmp, 10);
                        Expression ex = new Expression(tmp1);
                        var result = ex.calculate();
                        sys = "hex";
                        //history.Text = inputMath.Text + " = " + Convert.ToString((int)result, 16);
                        SaveToHistory(inputMath.Text, Convert.ToString((int)result, 16).Trim(), sys);
                        inputMath.Text = Convert.ToString((int)result, 16);
                    }
                    else if (oct)
                    {
                        string tmp = expressionProcess(inputMath.Text);
                        string tmp1 = ConvertOctal(tmp, 10);
                        Expression ex = new Expression(tmp1);
                        var result = ex.calculate();
                        sys = "oct";
                        //history.Text = inputMath.Text + " = " + Convert.ToString((int)result, 8);
                        SaveToHistory(inputMath.Text, Convert.ToString((int)result, 8).Trim(), sys);
                        inputMath.Text = Convert.ToString((int)result, 8);
                    }
                    break;
                case "buttonPLUS":
                case "buttonMINUS":
                case "buttonMULT":
                case "buttonDIV":
                case "buttonBSR":
                case "buttonBSL":
                case "buttonLB":
                case "buttonRB":
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                    break;
                case "buttonAND":
                case "buttonOR":
                case "buttonNOT":
                case "buttonNAND":
                case "buttonNOR":
                case "buttonXOR":
                    inputMath.Text = inputMath.Text + " " + buttonPRESSED.Text + " ";
                    break;
                case "buttonHEX":
                    if (dec)
                    {
                        inputMath.Text = ConvertDecimal(inputMath.Text, 16);
                    }
                    else if (bin)
                    {
                        inputMath.Text = ConvertBinary(inputMath.Text, 16);
                    }
                    else if (oct)
                    {
                        inputMath.Text = ConvertOctal(inputMath.Text, 16);
                    }
                    sys = "hex";
                    ChangeNumericSystem(sys);
                    break;
                case "buttonDEC":
                    if (bin)
                    {
                        inputMath.Text = ConvertBinary(inputMath.Text, 10);
                    }
                    else if (hex)
                    {
                        inputMath.Text = ConvertHexadecimal(inputMath.Text, 10);
                    }
                    else if (oct)
                    {
                        inputMath.Text = ConvertOctal(inputMath.Text, 10);
                    }
                    sys = "dec";
                    ChangeNumericSystem(sys);
                    break;
                case "buttonOCT":
                    if (dec)
                    {
                        inputMath.Text = ConvertDecimal(inputMath.Text, 8);
                    }
                    else if (bin)
                    {
                        inputMath.Text = ConvertBinary(inputMath.Text, 8);
                    }
                    else if (hex)
                    {
                        inputMath.Text = ConvertHexadecimal(inputMath.Text, 8);
                    }
                    sys = "oct";
                    ChangeNumericSystem(sys);
                    break;
                case "buttonBIN":
                    if (dec)
                    {
                        inputMath.Text = ConvertDecimal(inputMath.Text, 2);
                    }

                    else if (hex)
                    {
                        inputMath.Text = ConvertHexadecimal(inputMath.Text, 2);
                    }
                    else if (oct)
                    {
                        inputMath.Text = ConvertOctal(inputMath.Text, 2);
                    }
                    sys = "bin";
                    ChangeNumericSystem(sys);
                    break;

                default:
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                    break;

            }
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
                case Keys.A:
                    if (hex)
                    {
                        buttonA.PerformClick();
                        break;
                    }
                    break;
                case Keys.B:
                    if (hex)
                    {
                        buttonB.PerformClick();
                        break;
                    }
                    break;
                case Keys.C:
                    if (hex)
                    {
                        buttonC.PerformClick();
                        break;
                    }
                    break;
                case Keys.D:
                    if (hex)
                    {
                        buttonD.PerformClick();
                        break;
                    }
                    break;
                case Keys.E:
                    if (hex)
                    {
                        buttonE.PerformClick();
                        break;
                    }
                    break;
                case Keys.F:
                    if (hex)
                    {
                        buttonF.PerformClick();
                        break;
                    }
                    break;
                case Keys.Enter:
                case Keys.Oemplus: // =
                    buttonEQ.PerformClick();
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

        private void binary_Load(object sender, EventArgs e)
        {

        }
    }
    public class HistoryEntry
    {
        public string Input { get; set; }
        public string Result { get; set; }
        public string NumericSystem { get; set; }
    }
}
