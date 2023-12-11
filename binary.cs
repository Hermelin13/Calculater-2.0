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

namespace Calculater
{
    public partial class binary : UserControl
    {
        bool hex = false;
        bool dec = true;
        bool oct = false;
        bool bin = false;

        public binary()
        {
            InitializeComponent();
        }


        public string computeExpression(string myExpression, int myBase)
        {
            try
            {
                StringBuilder decimalExpression = new StringBuilder();
                StringBuilder currentNumber = new StringBuilder();

                foreach (char c in myExpression)
                {
                    if(myBase == 2)
                    {
                        if (c == '0' || c == '1')
                        {
                            currentNumber.Append(c);
                        }
                    }
                    else if(myBase == 8)
                    {
                        if(c >= '0' && c <= '7')
                        {
                            currentNumber.Append(c);
                        }
                    }
                    else if(myBase == 16)
                    {
                        if (Char.IsDigit(c) || "abcdefABCDEF".Contains(c))
                        {
                            currentNumber.Append(c);
                        }
                    }
                    if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        if (currentNumber.Length > 0)
                        {
                            int decimalNumber = Convert.ToInt32(currentNumber.ToString(), myBase);
                            decimalExpression.Append(decimalNumber);
                            currentNumber.Clear();
                        }
                        decimalExpression.Append($" {c} ");
                    }
                }

                if (currentNumber.Length > 0)
                {
                    int lastDecimalNumber = Convert.ToInt32(currentNumber.ToString(), myBase);
                    decimalExpression.Append(lastDecimalNumber);
                }

                var result = new DataTable().Compute(decimalExpression.ToString(), null);

                return Convert.ToString(Convert.ToInt32(result), myBase);
 
            }
            catch
            {
                return "Error: Invalid Input";
            }
        }

        private static bool isBitwiseOperator(string op)
        {
            return op.ToUpper() == "AND" || op.ToUpper() == "OR" ||
                   op.ToUpper() == "NOT" || op.ToUpper() == "XOR" ||
                   op.ToUpper() == "NAND" || op.ToUpper() == "NOR";
        }

        private static int PerformBitwiseOperation(int left, int right, string op)
        {
            switch (op.ToUpper())
            {
                case "AND":
                    return left & right;
                case "OR":
                    return left | right;
                case "NOT":
                    return ~left;
                case "XOR":
                    return left ^ right;
                case "NAND":
                    return ~(left & right);
                case "NOR":
                    return ~(left | right);
                default:
                    throw new ArgumentException($"Unsupported bitwise operator: {op}");
            }
        }
        public string splitExpression(string myExpression, int myBase)
        {
            /* TODO NEFUNGUJE VICE BITWISE OPERATORU V JEDNOM EXPRESSIONU */
            string[] tokens = myExpression.Split(' ');
            string[] tmp_result = new string[tokens.Length];
            int i = 0;

            // First step: Evaluate basic arithmetic expressions
            foreach (string token in tokens)
            {
                if (isBitwiseOperator(token))
                {
                    tmp_result[i] = token;
                }
                else
                {
                    tmp_result[i] = computeExpression(token, myBase);
                }
                i++;
            }

            // Second step: Combine the computed results with bitwise operators
            string resultExpression = string.Join(" ", tmp_result.Where(token => token != null));

            // Third step: Evaluate bitwise operations
            string[] finalTokens = resultExpression.Split(' ');
            i = 0;
            while (i < finalTokens.Length)
            {
                if (isBitwiseOperator(finalTokens[i]))
                {
                    int left = Convert.ToInt32(finalTokens[i - 1], myBase);
                    int right = Convert.ToInt32(finalTokens[i + 1], myBase);
                    int result = PerformBitwiseOperation(left, right, finalTokens[i]);
                    finalTokens[i + 1] = result.ToString();
                    finalTokens[i - 1] = finalTokens[i] = string.Empty;  // Clear used tokens
                }

                i++;
            }

            // Join the result tokens to form the final expression
            string finalResult = string.Join(" ", finalTokens.Where(token => !string.IsNullOrEmpty(token)));

            return finalResult;
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
                        var result = new DataTable().Compute(inputMath.Text, null);
                        history.Text = inputMath.Text + "=" + result.ToString();
                    }
                    else if (bin)
                    {
                        var result = splitExpression(inputMath.Text, 2);
                        history.Text = inputMath.Text + "=" + result.ToString();
                    }
                    else if (hex)
                    {
                        var result = computeExpression(inputMath.Text, 16);
                        history.Text = inputMath.Text + "=" + result.ToString();
                    }
                    else if(oct)
                    {
                        var result = computeExpression(inputMath.Text, 8);
                        history.Text = inputMath.Text + "=" + result.ToString();
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
                    if (dec == true)
                    {
                        inputMath.Text = decimalToBinary(inputMath.Text);
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
                    if(hex)
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
