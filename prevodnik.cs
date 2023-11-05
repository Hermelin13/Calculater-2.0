using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcLib;

namespace Calculater
{
    public partial class prevodnik : UserControl
    {
        bool number = false;

        public prevodnik()
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
                case "buttonLB":
                case "buttonRB":
                default:
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                    number = true;
                    break;

            }
        }
    }
}
