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
    public partial class standard : UserControl
    {
        public standard()
        {
            InitializeComponent();
        }

        bool number = false;
        bool dot = false;
        bool op = false;
        bool konst = false;
        bool nothing = true;
        int brackets = 0;

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
                case "buttonCLEAR":
                    inputMath.Text = "";
                    break;
                case "buttonEQ":
                    history.Text = inputMath.Text;
                    break;
                case "buttonDOT":
                    if (number && !dot && !nothing)
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
                    }
                    break;
                case "buttonFACT":
                    if (number && !op && !konst && !nothing)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        number = false;
                        op = true;
                    }
                    break;
                case "buttonMULTI":  
                case "buttonDIV":
                    if ((number || konst) && !op && !nothing)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        number = false;
                        op = true;
                    }
                    break;
                case "buttonSQRT":
                    if ((number || konst) && !op && !nothing)
                    {
                        inputMath.Text = inputMath.Text + "^2";
                        number = false;
                    }
                    break;
                case "buttonSQRT3":
                    if ((number || konst) && !op && !nothing)
                    {
                        inputMath.Text = inputMath.Text + "^3";
                        number = false;
                    }
                    break;
                case "buttonROOT":
                    if (nothing)
                    {
                        inputMath.Text = inputMath.Text + "√";
                        number = false;
                        op = true;
                    }
                    break;
                case "buttonPI":
                case "buttonEULER":
                    if (!number && !dot)
                    {
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        konst = true;
                    }
                    break;
                case "buttonLOG":
                case "buttonTAN":
                case "buttonCOS":
                case "buttonSIN":
                    if (!number )
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text + "(";
                    
                    break;
                case "buttonMOD":
                case "buttonLBRACKET":
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                    brackets++;
                    break;
                case "buttonRBRACKET":
                    if (brackets != 0){
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        brackets--;
                    }
                    break;
                default:
                    if (op || !konst || (!op && !number)){
                        inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                        number = true;
                        op = false;
                    }
                    break;

            }
        }

    }
}
