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

        public string ComputeBinaryExpression(string binaryExpression)
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
                    if(dec == true)
                    {
                        var result = new DataTable().Compute(inputMath.Text, null);
                        history.Text = result.ToString();
                    }
                    else if(bin == true)
                    {
                        var result = ComputeBinaryExpression(inputMath.Text);
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
                case "buttonHEX":
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                    break;
                case "buttonDEC":
                    dec = true;
                    bin = false;
                    oct = false;
                    hex = false;
                    break;
                case "buttonOCT":
                case "buttonBIN":
                    dec = false;
                    bin = true;
                    oct = false;
                    hex = false;
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
    }
}
