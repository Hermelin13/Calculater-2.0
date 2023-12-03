using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

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
                    Expression ex = new Expression(inputMath.Text);
                    var result = ex.calculate();
                    history.Text = result.ToString();
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
                case Keys.C:
                    buttonCLEAR.PerformClick();
                    break;
                case Keys.Enter:
                case Keys.Oemplus: // =
                    buttonEQ.PerformClick();
                    break;
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                case Keys.Decimal:
                    buttonDOT.PerformClick();
                    break;
                case Keys.Add:
                    buttonPLUS.PerformClick();
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    buttonMINUS.PerformClick();
                    break;
                case Keys.Multiply:
                    buttonMULTI.PerformClick();
                    break;
                case Keys.Divide:
                    buttonDIV.PerformClick();
                    break;
                case Keys.P:
                    buttonPI.PerformClick();
                    break;
                case Keys.E:
                    buttonEULER.PerformClick();
                    break;
            }
        }
    }
}
