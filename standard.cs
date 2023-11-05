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

        public standard()
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
                        if (inputMath.Text.Length == 0)
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
                    }
                    break;
                case "buttonCLEAR":
                    inputMath.Text = "";
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
                    break;
                case "buttonEQ":
                    history.Text = inputMath.Text;
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
                    }
                    break;
                case "buttonSQRT":
                    if (!nothing && !sqrt && !fact)
                    {
                        inputMath.Text = inputMath.Text + "^2";
                        number = false;
                        sqrt = true;
                    }
                    break;
                case "buttonSQRT3":
                    if (!nothing && !sqrt && !fact)
                    {
                        inputMath.Text = inputMath.Text + "^3";
                        number = false;
                        sqrt = true;
                    }
                    break;
                case "buttonROOT":
                    if (nothing && !root)
                    {
                        inputMath.Text = inputMath.Text + "√";
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
                case "buttonTAN":
                case "buttonCOS":
                case "buttonSIN":
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

    }
}
