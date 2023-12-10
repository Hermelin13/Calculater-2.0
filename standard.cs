﻿/* Author:  Adam Dalibor Jurčík xjurci08
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
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
        string const_ANS;

        public standard()
        {
            InitializeComponent();
        }

        private void nullFunc()
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
                            nullFunc();
                        }
                    }
                    break;
                case "buttonCLEAR":
                    inputMath.Text = "";
                    nullFunc();
                    break;
                case "buttonEQ":
                    Expression ex = new Expression(inputMath.Text);
                    var result = ex.calculate();
                    history6.Text = history5.Text;
                    history5.Text = history4.Text;
                    history4.Text = history3.Text;
                    history3.Text = history2.Text;
                    history2.Text = history1.Text;
                    history1.Text = inputMath.Text + "=" + result.ToString().Replace(",", ".");
                    const_ANS = result.ToString().Replace(",", ".");
                    inputMath.Text = "";
                    nullFunc();
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
                case "buttonEXP2":
                    if (!nothing && !sqrt && !fact)
                    {
                        inputMath.Text = inputMath.Text + "^2";
                        number = false;
                        sqrt = true;
                    }
                    break;
                case "buttonEXP3":
                    if (!nothing && !sqrt && !fact)
                    {
                        inputMath.Text = inputMath.Text + "^3";
                        number = false;
                        sqrt = true;
                    }
                    break;
                case "buttonEXP4":
                    if (!nothing && !sqrt && !fact)
                    {
                        inputMath.Text = inputMath.Text + "^4";
                        number = false;
                        sqrt = true;
                    }
                    break;
                case "buttonROOT2":
                    if (nothing && !root)
                    {
                        inputMath.Text = inputMath.Text + "√";
                        nothing = true;
                        op = true;
                        root = true;
                    }
                    break;
                case "buttonROOT3":
                    if (nothing && !root)
                    {
                        inputMath.Text = inputMath.Text + "∛";
                        nothing = true;
                        op = true;
                        root = true;
                    }
                    break;
                case "buttonROOT4":
                    if (nothing && !root)
                    {
                        inputMath.Text = inputMath.Text + "∜";
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
                case "buttonCOT":
                case "buttonTAN":
                case "buttonCOS":
                case "buttonSIN":
                case "buttonASIN":
                case "buttonACOS":
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
                case "buttonANS":
                    if (nothing || (number && !bracket))
                    {
                        inputMath.Text = inputMath.Text + const_ANS;
                        nothing = false;
                        number = true;
                        op = false;
                        bracket = false;
                        root = false;
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

        private void changeVis(object sender, EventArgs e)
        {
            TextBox TextBoxHover = sender as TextBox;
            switch (TextBoxHover.Name)
            {
                case "history1":
                    if (history1.Text != "")
                    {
                        delButton1.Visible = true;
                    }
                    else
                    {
                        delButton1.Visible = false;
                    }
                    break;
                case "history2":
                    if (history2.Text != "")
                    {
                        delButton2.Visible = true;
                    }
                    else
                    {
                        delButton2.Visible = false;
                    }
                    break;
                case "history3":
                    if (history3.Text != "")
                    {
                        delButton3.Visible = true;
                    }
                    else
                    {
                        delButton3.Visible = false;
                    }
                    break;
                case "history4":
                    if (history4.Text != "")
                    {
                        delButton4.Visible = true;
                    }
                    else
                    {
                        delButton4.Visible = false;
                    }
                    break;
                case "history5":
                    if (history5.Text != "")
                    {
                        delButton5.Visible = true;
                    }
                    else
                    {
                        delButton5.Visible = false;
                    }
                    break;
                case "history6":
                    if (history6.Text != "")
                    {
                        delButton6.Visible = true;
                    }
                    else
                    {
                        delButton6.Visible = false;
                    }
                    break;
            }
        }

        private void deleteButton(object sender, EventArgs e)
        {
            PictureBox delButton = sender as PictureBox;
            switch (delButton.Name)
            {
                case "delButton1":
                    history1.Text = history2.Text;
                    history2.Text = history3.Text;
                    history3.Text = history4.Text;
                    history4.Text = history5.Text;
                    history5.Text = history6.Text;
                    history6.Text = "";
                    break;
                case "delButton2":
                    history2.Text = history3.Text;
                    history3.Text = history4.Text;
                    history4.Text = history5.Text;
                    history5.Text = history6.Text;
                    history6.Text = "";
                    break;
                case "delButton3":
                    history3.Text = history4.Text;
                    history4.Text = history5.Text;
                    history5.Text = history6.Text;
                    history6.Text = "";
                    break;
                case "delButton4":
                    history4.Text = history5.Text;
                    history5.Text = history6.Text;
                    history6.Text = "";
                    break;
                case "delButton5":
                    history5.Text = history6.Text;
                    history6.Text = "";
                    break;
                case "delButton6":
                    history6.Text = "";
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
