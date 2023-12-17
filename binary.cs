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
            SetSelectedButton(buttonHEX);
        }

        /** 
         * prebarveni aktualne zvoleneho tlacitka s ciselnymi soustavami
         */
        private void SetSelectedButton(Button selectedButton)
        {
            buttonHEX.BackColor = Color.FromArgb(50, 73, 60);
            buttonOCT.BackColor = Color.FromArgb(50, 73, 60);
            buttonBIN.BackColor = Color.FromArgb(50, 73, 60);
            buttonDEC.BackColor = Color.FromArgb(50, 73, 60);

            selectedButton.BackColor = Color.FromArgb(2, 101, 82);
        }

        /**
         * zmena tlacitek pro praci s ciselnou soustavou
         */
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

        /**
         * zpracovani bitovych operatoru
         */
        public string expressionProcess(string expression)
        {
            expression = Regex.Replace(expression, "AND", "@&");
            expression = Regex.Replace(expression, "XOR", "@^");
            expression = Regex.Replace(expression, "OR", "@|");
            expression = Regex.Replace(expression, ">>", "@>>");
            expression = Regex.Replace(expression, "<<", "@<<");

            expression = Regex.Replace(expression, @"([^&|()]+)\s*NOT\b", "@~$1");
            expression = expression.Replace(",", ".");

            return expression;
        }

        /**
         * ctyri funkce na prevedeni do dane soustavy
         */
        static string ConvertBinary(string input, int Base)
        {
            string pattern = @"\b[01]+\b";
            try
            {
                string result = Regex.Replace(input, pattern, match =>
                {
                    string binaryNumber = match.Value;
                    long decimalNumber = Convert.ToInt64(binaryNumber, 2);
                    return Convert.ToString(decimalNumber, Base);
                });

                return result;
            }
            catch(Exception ex)
            {
                return "Error: number too large";
            }
        }

        static string ConvertHexadecimal(string input, int Base)
        {
            string pattern = @"\b[0-9A-Fa-f]+\b";
            try
            {
                string result = Regex.Replace(input, pattern, match =>
                {
                    string hexNumber = match.Value;
                    long decimalNumber = Convert.ToInt64(hexNumber, 16);
                    return Convert.ToString(decimalNumber, Base);
                });

                return result;
            }
            catch( Exception ex)
            {
                return "Error: number too large";
            }
        }
        static string ConvertOctal(string input, int Base)
        {
            string pattern = @"\b[0-7]+\b";
            try
            {
                string result = Regex.Replace(input, pattern, match =>
                {
                    string octalNumber = match.Value;
                    long decimalNumber = Convert.ToInt64(octalNumber, 8);
                    return Convert.ToString(decimalNumber, Base);
                });

                return result;
            }
            catch(Exception ex) 
            {
                return "Error: number too large";
            }
        }
        static string ConvertDecimal(string input, int Base)
        {
            string pattern = @"\b[0-9]+\b";
            string result = Regex.Replace(input, pattern, match =>
            {
                string decNumber = match.Value;
                long decimalNumber = Convert.ToInt64(decNumber, 10);
                return Convert.ToString(decimalNumber, Base);
            });

            return result;
        }
        /** ========================================================== */

        /**
         * nacitani ze souboru do historie
         */
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

        /**
         * ukladani historie do souboru
         */
        private async void SaveToHistory(string input, string result, string numericSystem)
        {
            CreateInput(input, result);

            HistoryEntry newEntry = new HistoryEntry
            {
                Input = input.Trim(),
                Result = result.Trim(),
                NumericSystem = numericSystem
            };
            historyList.Insert(0, newEntry);
            File.AppendAllText(historyFilePath, $"{input} = {result} [{numericSystem}]" + Environment.NewLine);
        }

        /**
         * vytvoreni UI zobrazeni historie pro uzivatele
         */
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

            /* moznost nacist priklad z historie pro upravy */
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

        /**
         * smazani polozky z historie
         */
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

                HistoryEntry historyEntry = historyList
                    .FirstOrDefault(entry =>
                        entry.Input.Trim() == clickedExpression[0].Trim() &&
                        entry.Result.Trim() == clickedExpression[1].Trim());

                if (historyEntry != null)
                {
                    historyList.Remove(historyEntry);
                    string[] fileLines = File.ReadAllLines(historyFilePath);

                    string lineToRemove = $"{historyEntry.Input.Trim()} = {historyEntry.Result.Trim()} [{historyEntry.NumericSystem}]";
                    fileLines = fileLines.Where(line => line != lineToRemove).ToArray();
                    File.WriteAllLines(historyFilePath, fileLines);

                }
                history.Controls.Remove(historyRowPanel);
            }
        }

        /**
         * funkce na zpracovani jednotlivych tlacitek z UI
         */
        private void clickButton(object sender, EventArgs e)
        {
            Button buttonPRESSED = sender as Button;
            List<string> operatorsToRemove = new List<string> { " AND ", " OR ", " NOT ", " XOR ", " NAND ", " NOR " };
            string sys;

            switch (buttonPRESSED.Name)
            {
                case "buttonDEL":
                    if (inputMath.Text.Length > 0)
                    {
                        foreach (string op in operatorsToRemove)
                        {
                            if (inputMath.Text.EndsWith(op))
                            {
                                inputMath.Text = inputMath.Text.Substring(0, inputMath.Text.Length - op.Length);
                                return;
                            }
                        }

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
                        SaveToHistory(inputMath.Text.Trim(), result.ToString().Trim(), sys);
                        inputMath.Text = result.ToString();
                    }
                    else if (bin)
                    {
                        string tmp = ConvertBinary(inputMath.Text, 10);
                        if(tmp.Contains("Error"))
                        {
                            inputMath.Text = tmp;
                        }
                        else
                        {
                            string tmp1 = expressionProcess(tmp);
                            Expression ex = new Expression(tmp1);
                            var result = ex.calculate();
                            sys = "bin";
                            SaveToHistory(inputMath.Text.Trim(), Convert.ToString((long)result, 2).Trim(), sys);
                            inputMath.Text = Convert.ToString((long)result, 2);
                        }
                        
                    }
                    else if (hex)
                    {
                        string tmp = expressionProcess(inputMath.Text);
                        string tmp1 = ConvertHexadecimal(tmp, 10);
                        if (tmp1.Contains("Error"))
                        {
                            inputMath.Text = tmp1;
                        }
                        else
                        {
                            Expression ex = new Expression(tmp1);
                            var result = ex.calculate();
                            sys = "hex";
                            SaveToHistory(inputMath.Text.Trim(), Convert.ToString((long)result, 16).Trim(), sys);
                            inputMath.Text = Convert.ToString((long)result, 16);
                        }
                        
                    }
                    else if (oct)
                    {
                        string tmp = expressionProcess(inputMath.Text);
                        string tmp1 = ConvertOctal(tmp, 10);
                        if (tmp1.Contains("Error"))
                        {
                            inputMath.Text = tmp1;
                        }
                        else
                        {
                            Expression ex = new Expression(tmp1);
                            var result = ex.calculate();
                            sys = "oct";
                            SaveToHistory(inputMath.Text.Trim(), Convert.ToString((long)result, 8).Trim(), sys);
                            inputMath.Text = Convert.ToString((long)result, 8);
                        }             
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
                case "buttonXOR":
                    inputMath.Text = inputMath.Text + " " + buttonPRESSED.Text + " ";
                    break;
                case "buttonHEX":
                    if (dec)
                    {
                        try
                        {
                            inputMath.Text = ConvertDecimal(inputMath.Text, 16);
                        }
                        catch 
                        {
                            inputMath.Text = "Error: number too large to convert";
                        }
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
                        try
                        {
                            inputMath.Text = ConvertDecimal(inputMath.Text, 8);
                        }
                        catch
                        {
                            inputMath.Text = "Error: number too large to convert";
                        }                  
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
                        try
                        {
                            inputMath.Text = ConvertDecimal(inputMath.Text, 2);
                        }
                        catch
                        {
                            inputMath.Text = "Error: number too large to convert";
                        }
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

        /**
         * prevedeni stisknutí tlacitek klavesnice na vstup
         */
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
    }
    /**
     * trida pro zpracovani polozek, ktere se ukladaji do historie
     */
    public class HistoryEntry
    {
        public string Input { get; set; }
        public string Result { get; set; }
        public string NumericSystem { get; set; }
    }
}
