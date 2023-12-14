/* Author:  David Zahálka       xzahal03
 */

using System;
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

        public binary()
        {
            InitializeComponent();
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
                    if (dec)
                    {
                        string tmp = expressionProcess(inputMath.Text);
                        Expression ex = new Expression(tmp);
                        var result = ex.calculate();
                        history.Text = inputMath.Text + "=" + result.ToString();
                        inputMath.Text = result.ToString();
                    }
                    else if (bin)
                    {
                        string tmp = ConvertBinary(inputMath.Text, 10);
                        string tmp1 = expressionProcess(tmp);
                        Expression ex = new Expression(tmp1);
                        var result = ex.calculate();
                        history.Text = inputMath.Text + "=" + Convert.ToString((int)result, 2);
                        inputMath.Text = Convert.ToString((int)result, 2);
                    }
                    else if (hex)
                    {
                        string tmp = expressionProcess(inputMath.Text);
                        string tmp1 = ConvertHexadecimal(tmp, 10);
                        Expression ex = new Expression(tmp1);
                        var result = ex.calculate();
                        history.Text = inputMath.Text + "=" + Convert.ToString((int)result, 16);
                        inputMath.Text = Convert.ToString((int)result, 16);
                    }
                    else if (oct)
                    {
                        string tmp = expressionProcess(inputMath.Text);
                        string tmp1 = ConvertOctal(tmp, 10);
                        Expression ex = new Expression(tmp1);
                        var result = ex.calculate();
                        history.Text = inputMath.Text + "=" + Convert.ToString((int)result, 8);
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
                    dec = false;
                    bin = false;
                    oct = false;
                    hex = true;

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
                    dec = true;
                    bin = false;
                    oct = false;
                    hex = false;

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
                    dec = false;
                    bin = false;
                    oct = true;
                    hex = false;

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
                    dec = false;
                    bin = true;
                    oct = false;
                    hex = false;

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
                    break;
                case "buttonQWORD":
                case "buttonDWORD":
                case "buttonWORD":
                case "buttonBYTE":

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
    }
}
