using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public string computeBinaryExpression(string binaryExpression)
        {
            try
            {
                StringBuilder decimalExpression = new StringBuilder();
                StringBuilder currentNumber = new StringBuilder();

                foreach (char c in binaryExpression)
                {
                    if (c == '0' || c == '1')
                    {
                        currentNumber.Append(c);
                    }
                    else if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        if (currentNumber.Length > 0)
                        {
                            int decimalNumber = Convert.ToInt32(currentNumber.ToString(), 2);
                            decimalExpression.Append(decimalNumber);
                            currentNumber.Clear();
                        }
                        decimalExpression.Append($" {c} ");
                    }
                }

                if (currentNumber.Length > 0)
                {
                    int lastDecimalNumber = Convert.ToInt32(currentNumber.ToString(), 2);
                    decimalExpression.Append(lastDecimalNumber);
                }

                var result = new DataTable().Compute(decimalExpression.ToString(), null);

                return Convert.ToString(Convert.ToInt32(result), 2);
            }
            catch
            {
                return "Error: Invalid Input";
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
                    if (dec == true)
                    {
                        var result = new DataTable().Compute(inputMath.Text, null);
                        history.Text = result.ToString();
                    }
                    else if (bin == true)
                    {
                        var result = computeBinaryExpression(inputMath.Text);
                        history.Text = result.ToString();
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
                case "buttonAND":
                case "buttonOR":
                case "buttonNOT":
                case "buttonNAND":
                case "buttonNOR":
                case "buttonXOR":
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
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
                    if(dec == true)
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
                case Keys.NumPad0:
                    button0.PerformClick();
                    break;
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
            }
        }
    }
}
