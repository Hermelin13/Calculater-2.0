/* Author:  Adam Dalibor Jurčík xjurci08
 */

using System.Drawing;
using System.Windows.Forms;

namespace Calculater
{
    partial class standard
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new RoundedButton();
            button2 = new RoundedButton();
            button3 = new RoundedButton();
            button4 = new RoundedButton();
            button5 = new RoundedButton();
            button6 = new RoundedButton();
            button7 = new RoundedButton();
            button8 = new RoundedButton();
            button9 = new RoundedButton();
            button0 = new RoundedButton();
            buttonDOT = new RoundedButton();
            buttonPI = new RoundedButton();
            buttonEULER = new RoundedButton();
            buttonMULTI = new RoundedButton();
            buttonDIV = new RoundedButton();
            buttonCOS = new RoundedButton();
            buttonEXP2 = new RoundedButton();
            buttonROOT2 = new RoundedButton();
            buttonTAN = new RoundedButton();
            buttonLOG = new RoundedButton();
            buttonCOT = new RoundedButton();
            buttonFACT = new RoundedButton();
            buttonEQ = new RoundedButton();
            buttonPLUS = new RoundedButton();
            buttonMINUS = new RoundedButton();
            buttonSIN = new RoundedButton();
            buttonLBRACKET = new RoundedButton();
            buttonRBRACKET = new RoundedButton();
            buttonDEL = new RoundedButton();
            buttonCLEAR = new RoundedButton();
            inputMath = new TextBox();
            buttonMOD = new RoundedButton();
            buttonROOT3 = new RoundedButton();
            buttonROOT4 = new RoundedButton();
            buttonEXP4 = new RoundedButton();
            buttonEXP3 = new RoundedButton();
            buttonASIN = new RoundedButton();
            buttonACOS = new RoundedButton();
            buttonANS = new RoundedButton();
            labelhistory = new Label();
            history = new FlowLayoutPanel();
            roundedButton42 = new RoundedButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 80, 91);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(235, 319);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clickButton;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(62, 80, 91);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(294, 319);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += clickButton;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(62, 80, 91);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(353, 319);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += clickButton;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(62, 80, 91);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(235, 260);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += clickButton;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(62, 80, 91);
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(294, 260);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += clickButton;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(62, 80, 91);
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(353, 260);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 3;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += clickButton;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(62, 80, 91);
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(235, 201);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += clickButton;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(62, 80, 91);
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(294, 201);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += clickButton;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(62, 80, 91);
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(353, 201);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += clickButton;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(62, 80, 91);
            button0.Cursor = Cursors.Hand;
            button0.FlatStyle = FlatStyle.Popup;
            button0.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button0.ForeColor = Color.White;
            button0.Location = new Point(294, 379);
            button0.Name = "button0";
            button0.Size = new Size(119, 60);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += clickButton;
            // 
            // buttonDOT
            // 
            buttonDOT.BackColor = Color.FromArgb(62, 80, 91);
            buttonDOT.Cursor = Cursors.Hand;
            buttonDOT.FlatStyle = FlatStyle.Popup;
            buttonDOT.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDOT.ForeColor = Color.White;
            buttonDOT.Location = new Point(235, 379);
            buttonDOT.Name = "buttonDOT";
            buttonDOT.Size = new Size(60, 60);
            buttonDOT.TabIndex = 10;
            buttonDOT.Text = ".";
            buttonDOT.UseVisualStyleBackColor = false;
            buttonDOT.Click += clickButton;
            // 
            // buttonPI
            // 
            buttonPI.BackColor = Color.FromArgb(50, 73, 60);
            buttonPI.Cursor = Cursors.Hand;
            buttonPI.FlatStyle = FlatStyle.Popup;
            buttonPI.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPI.ForeColor = Color.White;
            buttonPI.Location = new Point(176, 438);
            buttonPI.Name = "buttonPI";
            buttonPI.Size = new Size(60, 60);
            buttonPI.TabIndex = 21;
            buttonPI.Text = "π";
            buttonPI.UseVisualStyleBackColor = false;
            buttonPI.Click += clickButton;
            // 
            // buttonEULER
            // 
            buttonEULER.BackColor = Color.FromArgb(50, 73, 60);
            buttonEULER.Cursor = Cursors.Hand;
            buttonEULER.FlatStyle = FlatStyle.Popup;
            buttonEULER.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEULER.ForeColor = Color.White;
            buttonEULER.Location = new Point(176, 379);
            buttonEULER.Name = "buttonEULER";
            buttonEULER.Size = new Size(60, 60);
            buttonEULER.TabIndex = 20;
            buttonEULER.Text = "ℯ";
            buttonEULER.UseVisualStyleBackColor = false;
            buttonEULER.Click += clickButton;
            // 
            // buttonMULTI
            // 
            buttonMULTI.BackColor = Color.FromArgb(50, 73, 60);
            buttonMULTI.Cursor = Cursors.Hand;
            buttonMULTI.FlatStyle = FlatStyle.Popup;
            buttonMULTI.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMULTI.ForeColor = Color.White;
            buttonMULTI.Location = new Point(176, 201);
            buttonMULTI.Name = "buttonMULTI";
            buttonMULTI.Size = new Size(60, 60);
            buttonMULTI.TabIndex = 19;
            buttonMULTI.Text = "*";
            buttonMULTI.UseVisualStyleBackColor = false;
            buttonMULTI.Click += clickButton;
            // 
            // buttonDIV
            // 
            buttonDIV.BackColor = Color.FromArgb(50, 73, 60);
            buttonDIV.Cursor = Cursors.Hand;
            buttonDIV.FlatStyle = FlatStyle.Popup;
            buttonDIV.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDIV.ForeColor = Color.White;
            buttonDIV.Location = new Point(176, 261);
            buttonDIV.Name = "buttonDIV";
            buttonDIV.Size = new Size(60, 60);
            buttonDIV.TabIndex = 18;
            buttonDIV.Text = "/";
            buttonDIV.UseVisualStyleBackColor = false;
            buttonDIV.Click += clickButton;
            // 
            // buttonCOS
            // 
            buttonCOS.BackColor = Color.FromArgb(50, 73, 60);
            buttonCOS.Cursor = Cursors.Hand;
            buttonCOS.FlatStyle = FlatStyle.Popup;
            buttonCOS.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCOS.ForeColor = Color.White;
            buttonCOS.Location = new Point(58, 142);
            buttonCOS.Name = "buttonCOS";
            buttonCOS.Size = new Size(60, 60);
            buttonCOS.TabIndex = 17;
            buttonCOS.Text = "cos";
            buttonCOS.UseVisualStyleBackColor = false;
            buttonCOS.Click += clickButton;
            // 
            // buttonEXP2
            // 
            buttonEXP2.BackColor = Color.FromArgb(50, 73, 60);
            buttonEXP2.Cursor = Cursors.Hand;
            buttonEXP2.FlatStyle = FlatStyle.Popup;
            buttonEXP2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEXP2.ForeColor = Color.White;
            buttonEXP2.Location = new Point(117, 83);
            buttonEXP2.Name = "buttonEXP2";
            buttonEXP2.Size = new Size(60, 60);
            buttonEXP2.TabIndex = 16;
            buttonEXP2.Text = "x²";
            buttonEXP2.UseVisualStyleBackColor = false;
            buttonEXP2.Click += clickButton;
            // 
            // buttonROOT2
            // 
            buttonROOT2.BackColor = Color.FromArgb(50, 73, 60);
            buttonROOT2.Cursor = Cursors.Hand;
            buttonROOT2.FlatStyle = FlatStyle.Popup;
            buttonROOT2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonROOT2.ForeColor = Color.White;
            buttonROOT2.Location = new Point(117, 260);
            buttonROOT2.Name = "buttonROOT2";
            buttonROOT2.Size = new Size(60, 60);
            buttonROOT2.TabIndex = 15;
            buttonROOT2.Text = "√x";
            buttonROOT2.UseVisualStyleBackColor = false;
            buttonROOT2.Click += clickButton;
            // 
            // buttonTAN
            // 
            buttonTAN.BackColor = Color.FromArgb(50, 73, 60);
            buttonTAN.Cursor = Cursors.Hand;
            buttonTAN.FlatStyle = FlatStyle.Popup;
            buttonTAN.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTAN.ForeColor = Color.White;
            buttonTAN.Location = new Point(58, 201);
            buttonTAN.Name = "buttonTAN";
            buttonTAN.Size = new Size(60, 60);
            buttonTAN.TabIndex = 14;
            buttonTAN.Text = "tan";
            buttonTAN.UseVisualStyleBackColor = false;
            buttonTAN.Click += clickButton;
            // 
            // buttonLOG
            // 
            buttonLOG.BackColor = Color.FromArgb(50, 73, 60);
            buttonLOG.Cursor = Cursors.Hand;
            buttonLOG.FlatStyle = FlatStyle.Popup;
            buttonLOG.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLOG.ForeColor = Color.White;
            buttonLOG.Location = new Point(58, 438);
            buttonLOG.Name = "buttonLOG";
            buttonLOG.Size = new Size(60, 60);
            buttonLOG.TabIndex = 13;
            buttonLOG.Text = "ln";
            buttonLOG.UseVisualStyleBackColor = false;
            buttonLOG.Click += clickButton;
            // 
            // buttonCOT
            // 
            buttonCOT.BackColor = Color.FromArgb(50, 73, 60);
            buttonCOT.Cursor = Cursors.Hand;
            buttonCOT.FlatStyle = FlatStyle.Popup;
            buttonCOT.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCOT.ForeColor = Color.White;
            buttonCOT.Location = new Point(58, 260);
            buttonCOT.Name = "buttonCOT";
            buttonCOT.Size = new Size(60, 60);
            buttonCOT.TabIndex = 12;
            buttonCOT.Text = "cot";
            buttonCOT.UseVisualStyleBackColor = false;
            buttonCOT.Click += clickButton;
            // 
            // buttonFACT
            // 
            buttonFACT.BackColor = Color.FromArgb(50, 73, 60);
            buttonFACT.Cursor = Cursors.Hand;
            buttonFACT.FlatStyle = FlatStyle.Popup;
            buttonFACT.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFACT.ForeColor = Color.White;
            buttonFACT.Location = new Point(117, 438);
            buttonFACT.Name = "buttonFACT";
            buttonFACT.Size = new Size(60, 60);
            buttonFACT.TabIndex = 11;
            buttonFACT.Text = "x!";
            buttonFACT.UseVisualStyleBackColor = false;
            buttonFACT.Click += clickButton;
            // 
            // buttonEQ
            // 
            buttonEQ.BackColor = Color.FromArgb(2, 101, 82);
            buttonEQ.Cursor = Cursors.Hand;
            buttonEQ.FlatStyle = FlatStyle.Popup;
            buttonEQ.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEQ.ForeColor = Color.White;
            buttonEQ.Location = new Point(294, 438);
            buttonEQ.Name = "buttonEQ";
            buttonEQ.Size = new Size(119, 60);
            buttonEQ.TabIndex = 22;
            buttonEQ.Text = "=";
            buttonEQ.UseVisualStyleBackColor = false;
            buttonEQ.Click += clickButton;
            // 
            // buttonPLUS
            // 
            buttonPLUS.BackColor = Color.FromArgb(50, 73, 60);
            buttonPLUS.Cursor = Cursors.Hand;
            buttonPLUS.FlatStyle = FlatStyle.Popup;
            buttonPLUS.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPLUS.ForeColor = Color.White;
            buttonPLUS.Location = new Point(176, 83);
            buttonPLUS.Name = "buttonPLUS";
            buttonPLUS.Size = new Size(60, 60);
            buttonPLUS.TabIndex = 28;
            buttonPLUS.Text = "+";
            buttonPLUS.UseVisualStyleBackColor = false;
            buttonPLUS.Click += clickButton;
            // 
            // buttonMINUS
            // 
            buttonMINUS.BackColor = Color.FromArgb(50, 73, 60);
            buttonMINUS.Cursor = Cursors.Hand;
            buttonMINUS.FlatStyle = FlatStyle.Popup;
            buttonMINUS.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMINUS.ForeColor = Color.White;
            buttonMINUS.Location = new Point(176, 142);
            buttonMINUS.Name = "buttonMINUS";
            buttonMINUS.Size = new Size(60, 60);
            buttonMINUS.TabIndex = 27;
            buttonMINUS.Text = "-";
            buttonMINUS.UseVisualStyleBackColor = false;
            buttonMINUS.Click += clickButton;
            // 
            // buttonSIN
            // 
            buttonSIN.BackColor = Color.FromArgb(50, 73, 60);
            buttonSIN.Cursor = Cursors.Hand;
            buttonSIN.FlatStyle = FlatStyle.Popup;
            buttonSIN.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSIN.ForeColor = Color.White;
            buttonSIN.Location = new Point(58, 83);
            buttonSIN.Name = "buttonSIN";
            buttonSIN.Size = new Size(60, 60);
            buttonSIN.TabIndex = 26;
            buttonSIN.Text = "sin";
            buttonSIN.UseVisualStyleBackColor = false;
            buttonSIN.Click += clickButton;
            // 
            // buttonLBRACKET
            // 
            buttonLBRACKET.BackColor = Color.FromArgb(62, 80, 91);
            buttonLBRACKET.Cursor = Cursors.Hand;
            buttonLBRACKET.FlatStyle = FlatStyle.Popup;
            buttonLBRACKET.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLBRACKET.ForeColor = Color.White;
            buttonLBRACKET.Location = new Point(294, 142);
            buttonLBRACKET.Name = "buttonLBRACKET";
            buttonLBRACKET.Size = new Size(60, 60);
            buttonLBRACKET.TabIndex = 25;
            buttonLBRACKET.Text = "(";
            buttonLBRACKET.UseVisualStyleBackColor = false;
            buttonLBRACKET.Click += clickButton;
            // 
            // buttonRBRACKET
            // 
            buttonRBRACKET.BackColor = Color.FromArgb(62, 80, 91);
            buttonRBRACKET.Cursor = Cursors.Hand;
            buttonRBRACKET.FlatStyle = FlatStyle.Popup;
            buttonRBRACKET.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRBRACKET.ForeColor = Color.White;
            buttonRBRACKET.Location = new Point(353, 142);
            buttonRBRACKET.Name = "buttonRBRACKET";
            buttonRBRACKET.Size = new Size(60, 60);
            buttonRBRACKET.TabIndex = 24;
            buttonRBRACKET.Text = ")";
            buttonRBRACKET.UseVisualStyleBackColor = false;
            buttonRBRACKET.Click += clickButton;
            // 
            // buttonDEL
            // 
            buttonDEL.BackColor = Color.FromArgb(204, 80, 91);
            buttonDEL.Cursor = Cursors.Hand;
            buttonDEL.FlatStyle = FlatStyle.Popup;
            buttonDEL.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDEL.ForeColor = Color.White;
            buttonDEL.Location = new Point(353, 83);
            buttonDEL.Name = "buttonDEL";
            buttonDEL.Size = new Size(60, 60);
            buttonDEL.TabIndex = 23;
            buttonDEL.Text = "DEL";
            buttonDEL.UseVisualStyleBackColor = false;
            buttonDEL.Click += clickButton;
            // 
            // buttonCLEAR
            // 
            buttonCLEAR.BackColor = Color.FromArgb(204, 80, 91);
            buttonCLEAR.Cursor = Cursors.Hand;
            buttonCLEAR.FlatStyle = FlatStyle.Popup;
            buttonCLEAR.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCLEAR.ForeColor = Color.White;
            buttonCLEAR.Location = new Point(294, 83);
            buttonCLEAR.Name = "buttonCLEAR";
            buttonCLEAR.Size = new Size(60, 60);
            buttonCLEAR.TabIndex = 30;
            buttonCLEAR.Text = "AC";
            buttonCLEAR.UseVisualStyleBackColor = false;
            buttonCLEAR.Click += clickButton;
            // 
            // inputMath
            // 
            inputMath.BackColor = Color.FromArgb(138, 176, 171);
            inputMath.BorderStyle = BorderStyle.None;
            inputMath.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inputMath.Location = new Point(482, 0);
            inputMath.Multiline = true;
            inputMath.Name = "inputMath";
            inputMath.ReadOnly = true;
            inputMath.Size = new Size(470, 70);
            inputMath.TabIndex = 31;
            inputMath.TabStop = false;
            // 
            // buttonMOD
            // 
            buttonMOD.BackColor = Color.FromArgb(50, 73, 60);
            buttonMOD.Cursor = Cursors.Hand;
            buttonMOD.FlatStyle = FlatStyle.Popup;
            buttonMOD.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMOD.ForeColor = Color.White;
            buttonMOD.Location = new Point(176, 320);
            buttonMOD.Name = "buttonMOD";
            buttonMOD.Size = new Size(60, 60);
            buttonMOD.TabIndex = 33;
            buttonMOD.Text = "#";
            buttonMOD.UseVisualStyleBackColor = false;
            buttonMOD.Click += clickButton;
            // 
            // buttonROOT3
            // 
            buttonROOT3.BackColor = Color.FromArgb(50, 73, 60);
            buttonROOT3.Cursor = Cursors.Hand;
            buttonROOT3.FlatStyle = FlatStyle.Popup;
            buttonROOT3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonROOT3.ForeColor = Color.White;
            buttonROOT3.Location = new Point(117, 320);
            buttonROOT3.Name = "buttonROOT3";
            buttonROOT3.Size = new Size(60, 60);
            buttonROOT3.TabIndex = 34;
            buttonROOT3.Text = "∛x";
            buttonROOT3.UseVisualStyleBackColor = false;
            buttonROOT3.Click += clickButton;
            // 
            // buttonROOT4
            // 
            buttonROOT4.BackColor = Color.FromArgb(50, 73, 60);
            buttonROOT4.Cursor = Cursors.Hand;
            buttonROOT4.FlatStyle = FlatStyle.Popup;
            buttonROOT4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonROOT4.ForeColor = Color.White;
            buttonROOT4.Location = new Point(117, 379);
            buttonROOT4.Name = "buttonROOT4";
            buttonROOT4.Size = new Size(60, 60);
            buttonROOT4.TabIndex = 35;
            buttonROOT4.Text = "∜x";
            buttonROOT4.UseVisualStyleBackColor = false;
            buttonROOT4.Click += clickButton;
            // 
            // buttonEXP4
            // 
            buttonEXP4.BackColor = Color.FromArgb(50, 73, 60);
            buttonEXP4.Cursor = Cursors.Hand;
            buttonEXP4.FlatStyle = FlatStyle.Popup;
            buttonEXP4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEXP4.ForeColor = Color.White;
            buttonEXP4.Location = new Point(117, 201);
            buttonEXP4.Name = "buttonEXP4";
            buttonEXP4.Size = new Size(60, 60);
            buttonEXP4.TabIndex = 36;
            buttonEXP4.Text = "x⁴";
            buttonEXP4.UseVisualStyleBackColor = false;
            buttonEXP4.Click += clickButton;
            // 
            // buttonEXP3
            // 
            buttonEXP3.BackColor = Color.FromArgb(50, 73, 60);
            buttonEXP3.Cursor = Cursors.Hand;
            buttonEXP3.FlatStyle = FlatStyle.Popup;
            buttonEXP3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEXP3.ForeColor = Color.White;
            buttonEXP3.Location = new Point(117, 142);
            buttonEXP3.Name = "buttonEXP3";
            buttonEXP3.Size = new Size(60, 60);
            buttonEXP3.TabIndex = 37;
            buttonEXP3.Text = "x³";
            buttonEXP3.UseVisualStyleBackColor = false;
            buttonEXP3.Click += clickButton;
            // 
            // buttonASIN
            // 
            buttonASIN.BackColor = Color.FromArgb(50, 73, 60);
            buttonASIN.Cursor = Cursors.Hand;
            buttonASIN.FlatStyle = FlatStyle.Popup;
            buttonASIN.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonASIN.ForeColor = Color.White;
            buttonASIN.Location = new Point(58, 320);
            buttonASIN.Name = "buttonASIN";
            buttonASIN.Size = new Size(60, 60);
            buttonASIN.TabIndex = 38;
            buttonASIN.Text = "asin";
            buttonASIN.UseVisualStyleBackColor = false;
            buttonASIN.Click += clickButton;
            // 
            // buttonACOS
            // 
            buttonACOS.BackColor = Color.FromArgb(50, 73, 60);
            buttonACOS.Cursor = Cursors.Hand;
            buttonACOS.FlatStyle = FlatStyle.Popup;
            buttonACOS.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonACOS.ForeColor = Color.White;
            buttonACOS.Location = new Point(58, 379);
            buttonACOS.Name = "buttonACOS";
            buttonACOS.Size = new Size(60, 60);
            buttonACOS.TabIndex = 39;
            buttonACOS.Text = "acos";
            buttonACOS.UseVisualStyleBackColor = false;
            buttonACOS.Click += clickButton;
            // 
            // buttonANS
            // 
            buttonANS.BackColor = Color.FromArgb(62, 80, 91);
            buttonANS.Cursor = Cursors.Hand;
            buttonANS.FlatStyle = FlatStyle.Popup;
            buttonANS.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonANS.ForeColor = Color.White;
            buttonANS.Location = new Point(235, 142);
            buttonANS.Name = "buttonANS";
            buttonANS.Size = new Size(60, 60);
            buttonANS.TabIndex = 40;
            buttonANS.Text = "Ans";
            buttonANS.UseVisualStyleBackColor = false;
            buttonANS.Click += clickButton;
            // 
            // labelhistory
            // 
            labelhistory.AutoSize = true;
            labelhistory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelhistory.ForeColor = Color.White;
            labelhistory.Location = new Point(482, 96);
            labelhistory.Name = "labelhistory";
            labelhistory.Size = new Size(89, 32);
            labelhistory.TabIndex = 47;
            labelhistory.Text = "History";
            // 
            // history
            // 
            history.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            history.AutoScroll = true;
            history.BackColor = Color.FromArgb(60, 80, 83);
            history.Location = new Point(481, 144);
            history.Margin = new Padding(3, 2, 3, 2);
            history.MinimumSize = new Size(471, 447);
            history.Name = "history";
            history.Size = new Size(471, 447);
            history.TabIndex = 48;
            // 
            // roundedButton42
            // 
            roundedButton42.BackColor = Color.FromArgb(50, 73, 60);
            roundedButton42.FlatStyle = FlatStyle.Popup;
            roundedButton42.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton42.ForeColor = Color.White;
            roundedButton42.Location = new Point(66, 3);
            roundedButton42.Name = "roundedButton42";
            roundedButton42.Size = new Size(219, 60);
            roundedButton42.TabIndex = 49;
            roundedButton42.Text = "Standard";
            roundedButton42.UseVisualStyleBackColor = false;
            // 
            // standard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 18, 14);
            Controls.Add(roundedButton42);
            Controls.Add(history);
            Controls.Add(labelhistory);
            Controls.Add(buttonANS);
            Controls.Add(buttonACOS);
            Controls.Add(buttonASIN);
            Controls.Add(buttonEXP3);
            Controls.Add(buttonEXP4);
            Controls.Add(buttonROOT4);
            Controls.Add(buttonROOT3);
            Controls.Add(buttonMOD);
            Controls.Add(inputMath);
            Controls.Add(buttonCLEAR);
            Controls.Add(buttonPLUS);
            Controls.Add(buttonMINUS);
            Controls.Add(buttonSIN);
            Controls.Add(buttonLBRACKET);
            Controls.Add(buttonRBRACKET);
            Controls.Add(buttonDEL);
            Controls.Add(buttonEQ);
            Controls.Add(buttonPI);
            Controls.Add(buttonEULER);
            Controls.Add(buttonMULTI);
            Controls.Add(buttonDIV);
            Controls.Add(buttonCOS);
            Controls.Add(buttonEXP2);
            Controls.Add(buttonROOT2);
            Controls.Add(buttonTAN);
            Controls.Add(buttonLOG);
            Controls.Add(buttonCOT);
            Controls.Add(buttonFACT);
            Controls.Add(buttonDOT);
            Controls.Add(button0);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "standard";
            Size = new Size(950, 591);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputMath;
        private RoundedButton button1;
        private RoundedButton button2;
        private RoundedButton button3;
        private RoundedButton button4;
        private RoundedButton button5;
        private RoundedButton button6;
        private RoundedButton button7;
        private RoundedButton button8;
        private RoundedButton button9;
        private RoundedButton button0;
        private RoundedButton buttonDOT;
        private RoundedButton buttonPI;
        private RoundedButton buttonEULER;
        private RoundedButton buttonMULTI;
        private RoundedButton buttonDIV;
        private RoundedButton buttonCOS;
        private RoundedButton buttonEXP2;
        private RoundedButton buttonROOT2;
        private RoundedButton buttonTAN;
        private RoundedButton buttonLOG;
        private RoundedButton buttonCOT;
        private RoundedButton buttonFACT;
        private RoundedButton buttonEQ;
        private RoundedButton buttonPLUS;
        private RoundedButton buttonMINUS;
        private RoundedButton buttonSIN;
        private RoundedButton buttonLBRACKET;
        private RoundedButton buttonRBRACKET;
        private RoundedButton buttonDEL;
        private RoundedButton buttonCLEAR;
        private RoundedButton buttonMOD;
        private RoundedButton buttonROOT3;
        private RoundedButton buttonROOT4;
        private RoundedButton buttonEXP4;
        private RoundedButton buttonEXP3;
        private RoundedButton buttonASIN;
        private RoundedButton buttonACOS;
        private RoundedButton buttonANS;
        private Label labelhistory;
        private FlowLayoutPanel history;
        private RoundedButton roundedButton42;
    }
}
