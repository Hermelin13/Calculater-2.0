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
        bool number = false;
        bool dot = false;

        public binary()
        {
            InitializeComponent();
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
                    history.Text = inputMath.Text;
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
                case "buttonDEC":
                case "buttonOCT":
                case "buttonBIN":
                case "buttonQWORD":
                case "buttonDWORD":
                case "buttonWORD":
                case "buttonBYTE":

                default:
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                    number = true;
                    break;

            }
        }
    }
}
