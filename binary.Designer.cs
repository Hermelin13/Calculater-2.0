/* Author:  David Zahálka       xzahal03
 */

using System.Drawing;
using System.Windows.Forms;

namespace Calculater
{
    partial class binary
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
            buttonD = new RoundedButton();
            buttonE = new RoundedButton();
            buttonF = new RoundedButton();
            buttonC = new RoundedButton();
            buttonB = new RoundedButton();
            buttonA = new RoundedButton();
            button9 = new RoundedButton();
            button8 = new RoundedButton();
            button7 = new RoundedButton();
            buttonDEL = new RoundedButton();
            button0 = new RoundedButton();
            buttonAC = new RoundedButton();
            button3 = new RoundedButton();
            button2 = new RoundedButton();
            button1 = new RoundedButton();
            button6 = new RoundedButton();
            button5 = new RoundedButton();
            button4 = new RoundedButton();
            buttonAND = new RoundedButton();
            buttonOR = new RoundedButton();
            buttonNOT = new RoundedButton();
            buttonXOR = new RoundedButton();
            buttonEQ = new RoundedButton();
            buttonBSL = new RoundedButton();
            buttonBSR = new RoundedButton();
            buttonDIV = new RoundedButton();
            buttonMULT = new RoundedButton();
            buttonMINUS = new RoundedButton();
            buttonPLUS = new RoundedButton();
            buttonRB = new RoundedButton();
            buttonLB = new RoundedButton();
            buttonHEX = new RoundedButton();
            buttonDEC = new RoundedButton();
            buttonOCT = new RoundedButton();
            buttonBIN = new RoundedButton();
            inputMath = new RoundedTextBox();
            roundedButton42 = new RoundedButton();
            history = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // buttonD
            // 
            buttonD.BackColor = Color.FromArgb(62, 80, 91);
            buttonD.FlatStyle = FlatStyle.Popup;
            buttonD.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonD.ForeColor = Color.White;
            buttonD.Location = new Point(102, 154);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(60, 60);
            buttonD.TabIndex = 2;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += clickButton;
            // 
            // buttonE
            // 
            buttonE.BackColor = Color.FromArgb(62, 80, 91);
            buttonE.FlatStyle = FlatStyle.Popup;
            buttonE.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonE.ForeColor = Color.White;
            buttonE.Location = new Point(159, 154);
            buttonE.Margin = new Padding(0);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(60, 60);
            buttonE.TabIndex = 3;
            buttonE.Text = "E";
            buttonE.UseVisualStyleBackColor = false;
            buttonE.Click += clickButton;
            // 
            // buttonF
            // 
            buttonF.BackColor = Color.FromArgb(62, 80, 91);
            buttonF.FlatStyle = FlatStyle.Popup;
            buttonF.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonF.ForeColor = Color.White;
            buttonF.Location = new Point(216, 154);
            buttonF.Name = "buttonF";
            buttonF.Size = new Size(60, 60);
            buttonF.TabIndex = 4;
            buttonF.Text = "F";
            buttonF.UseVisualStyleBackColor = false;
            buttonF.Click += clickButton;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.FromArgb(62, 80, 91);
            buttonC.FlatStyle = FlatStyle.Popup;
            buttonC.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.ForeColor = Color.White;
            buttonC.Location = new Point(216, 211);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(60, 60);
            buttonC.TabIndex = 7;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += clickButton;
            // 
            // buttonB
            // 
            buttonB.BackColor = Color.FromArgb(62, 80, 91);
            buttonB.FlatStyle = FlatStyle.Popup;
            buttonB.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonB.ForeColor = Color.White;
            buttonB.Location = new Point(159, 211);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(60, 60);
            buttonB.TabIndex = 6;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = false;
            buttonB.Click += clickButton;
            // 
            // buttonA
            // 
            buttonA.BackColor = Color.FromArgb(62, 80, 91);
            buttonA.FlatStyle = FlatStyle.Popup;
            buttonA.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonA.ForeColor = Color.White;
            buttonA.Location = new Point(102, 211);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(60, 60);
            buttonA.TabIndex = 5;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += clickButton;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(62, 80, 91);
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(216, 268);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += clickButton;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(62, 80, 91);
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(159, 268);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += clickButton;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(62, 80, 91);
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(102, 268);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += clickButton;
            // 
            // buttonDEL
            // 
            buttonDEL.BackColor = Color.FromArgb(204, 80, 91);
            buttonDEL.FlatStyle = FlatStyle.Popup;
            buttonDEL.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDEL.ForeColor = Color.White;
            buttonDEL.Location = new Point(216, 439);
            buttonDEL.Margin = new Padding(0);
            buttonDEL.Name = "buttonDEL";
            buttonDEL.Size = new Size(60, 60);
            buttonDEL.TabIndex = 19;
            buttonDEL.Text = "DEL";
            buttonDEL.UseVisualStyleBackColor = false;
            buttonDEL.Click += clickButton;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(62, 80, 91);
            button0.FlatStyle = FlatStyle.Popup;
            button0.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button0.ForeColor = Color.White;
            button0.Location = new Point(159, 439);
            button0.Name = "button0";
            button0.Size = new Size(60, 60);
            button0.TabIndex = 18;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += clickButton;
            // 
            // buttonAC
            // 
            buttonAC.BackColor = Color.FromArgb(204, 80, 91);
            buttonAC.FlatStyle = FlatStyle.Popup;
            buttonAC.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAC.ForeColor = Color.White;
            buttonAC.Location = new Point(102, 439);
            buttonAC.Name = "buttonAC";
            buttonAC.Size = new Size(60, 60);
            buttonAC.TabIndex = 17;
            buttonAC.Text = "AC";
            buttonAC.UseVisualStyleBackColor = false;
            buttonAC.Click += clickButton;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(62, 80, 91);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(216, 382);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 16;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += clickButton;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(62, 80, 91);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(159, 382);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 15;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += clickButton;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 80, 91);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(102, 382);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 14;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clickButton;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(62, 80, 91);
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(216, 325);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(60, 60);
            button6.TabIndex = 13;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += clickButton;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(62, 80, 91);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(159, 325);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 12;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += clickButton;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(62, 80, 91);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(102, 325);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 11;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += clickButton;
            // 
            // buttonAND
            // 
            buttonAND.BackColor = Color.FromArgb(50, 73, 60);
            buttonAND.FlatStyle = FlatStyle.Popup;
            buttonAND.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAND.ForeColor = Color.White;
            buttonAND.Location = new Point(282, 123);
            buttonAND.Name = "buttonAND";
            buttonAND.Size = new Size(60, 60);
            buttonAND.TabIndex = 20;
            buttonAND.Text = "AND";
            buttonAND.UseVisualStyleBackColor = false;
            buttonAND.Click += clickButton;
            // 
            // buttonOR
            // 
            buttonOR.BackColor = Color.FromArgb(50, 73, 60);
            buttonOR.FlatStyle = FlatStyle.Popup;
            buttonOR.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOR.ForeColor = Color.White;
            buttonOR.Location = new Point(339, 123);
            buttonOR.Name = "buttonOR";
            buttonOR.Size = new Size(60, 60);
            buttonOR.TabIndex = 21;
            buttonOR.Text = "OR";
            buttonOR.UseVisualStyleBackColor = false;
            buttonOR.Click += clickButton;
            // 
            // buttonNOT
            // 
            buttonNOT.BackColor = Color.FromArgb(50, 73, 60);
            buttonNOT.FlatStyle = FlatStyle.Popup;
            buttonNOT.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNOT.ForeColor = Color.White;
            buttonNOT.Location = new Point(282, 180);
            buttonNOT.Name = "buttonNOT";
            buttonNOT.Size = new Size(60, 60);
            buttonNOT.TabIndex = 22;
            buttonNOT.Text = "NOT";
            buttonNOT.UseVisualStyleBackColor = false;
            buttonNOT.Click += clickButton;
            // 
            // buttonXOR
            // 
            buttonXOR.BackColor = Color.FromArgb(50, 73, 60);
            buttonXOR.FlatStyle = FlatStyle.Popup;
            buttonXOR.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonXOR.ForeColor = Color.White;
            buttonXOR.Location = new Point(339, 180);
            buttonXOR.Name = "buttonXOR";
            buttonXOR.Size = new Size(60, 60);
            buttonXOR.TabIndex = 25;
            buttonXOR.Text = "XOR";
            buttonXOR.UseVisualStyleBackColor = false;
            buttonXOR.Click += clickButton;
            // 
            // buttonEQ
            // 
            buttonEQ.BackColor = Color.FromArgb(2, 101, 82);
            buttonEQ.FlatStyle = FlatStyle.Popup;
            buttonEQ.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEQ.ForeColor = Color.White;
            buttonEQ.Location = new Point(282, 238);
            buttonEQ.Name = "buttonEQ";
            buttonEQ.Size = new Size(117, 60);
            buttonEQ.TabIndex = 26;
            buttonEQ.Text = "=";
            buttonEQ.UseVisualStyleBackColor = false;
            buttonEQ.Click += clickButton;
            // 
            // buttonBSL
            // 
            buttonBSL.BackColor = Color.FromArgb(50, 73, 60);
            buttonBSL.FlatStyle = FlatStyle.Popup;
            buttonBSL.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBSL.ForeColor = Color.White;
            buttonBSL.Location = new Point(339, 411);
            buttonBSL.Name = "buttonBSL";
            buttonBSL.Size = new Size(60, 60);
            buttonBSL.TabIndex = 32;
            buttonBSL.Text = "<<";
            buttonBSL.UseVisualStyleBackColor = false;
            buttonBSL.Click += clickButton;
            // 
            // buttonBSR
            // 
            buttonBSR.BackColor = Color.FromArgb(50, 73, 60);
            buttonBSR.FlatStyle = FlatStyle.Popup;
            buttonBSR.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBSR.ForeColor = Color.White;
            buttonBSR.Location = new Point(282, 411);
            buttonBSR.Name = "buttonBSR";
            buttonBSR.Size = new Size(60, 60);
            buttonBSR.TabIndex = 31;
            buttonBSR.Text = ">>";
            buttonBSR.UseVisualStyleBackColor = false;
            buttonBSR.Click += clickButton;
            // 
            // buttonDIV
            // 
            buttonDIV.BackColor = Color.FromArgb(50, 73, 60);
            buttonDIV.FlatStyle = FlatStyle.Popup;
            buttonDIV.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDIV.ForeColor = Color.White;
            buttonDIV.Location = new Point(339, 354);
            buttonDIV.Name = "buttonDIV";
            buttonDIV.Size = new Size(60, 60);
            buttonDIV.TabIndex = 30;
            buttonDIV.Text = "/";
            buttonDIV.UseVisualStyleBackColor = false;
            buttonDIV.Click += clickButton;
            // 
            // buttonMULT
            // 
            buttonMULT.BackColor = Color.FromArgb(50, 73, 60);
            buttonMULT.FlatStyle = FlatStyle.Popup;
            buttonMULT.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMULT.ForeColor = Color.White;
            buttonMULT.Location = new Point(282, 354);
            buttonMULT.Name = "buttonMULT";
            buttonMULT.Size = new Size(60, 60);
            buttonMULT.TabIndex = 29;
            buttonMULT.Text = "*";
            buttonMULT.UseVisualStyleBackColor = false;
            buttonMULT.Click += clickButton;
            // 
            // buttonMINUS
            // 
            buttonMINUS.BackColor = Color.FromArgb(50, 73, 60);
            buttonMINUS.FlatStyle = FlatStyle.Popup;
            buttonMINUS.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMINUS.ForeColor = Color.White;
            buttonMINUS.Location = new Point(339, 297);
            buttonMINUS.Name = "buttonMINUS";
            buttonMINUS.Size = new Size(60, 60);
            buttonMINUS.TabIndex = 28;
            buttonMINUS.Text = "-";
            buttonMINUS.UseVisualStyleBackColor = false;
            buttonMINUS.Click += clickButton;
            // 
            // buttonPLUS
            // 
            buttonPLUS.BackColor = Color.FromArgb(50, 73, 60);
            buttonPLUS.FlatStyle = FlatStyle.Popup;
            buttonPLUS.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPLUS.ForeColor = Color.White;
            buttonPLUS.Location = new Point(282, 297);
            buttonPLUS.Name = "buttonPLUS";
            buttonPLUS.Size = new Size(60, 60);
            buttonPLUS.TabIndex = 27;
            buttonPLUS.Text = "+";
            buttonPLUS.UseVisualStyleBackColor = false;
            buttonPLUS.Click += clickButton;
            // 
            // buttonRB
            // 
            buttonRB.BackColor = Color.FromArgb(50, 73, 60);
            buttonRB.FlatStyle = FlatStyle.Popup;
            buttonRB.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRB.ForeColor = Color.White;
            buttonRB.Location = new Point(339, 468);
            buttonRB.Name = "buttonRB";
            buttonRB.Size = new Size(60, 60);
            buttonRB.TabIndex = 34;
            buttonRB.Text = ")";
            buttonRB.UseVisualStyleBackColor = false;
            buttonRB.Click += clickButton;
            // 
            // buttonLB
            // 
            buttonLB.BackColor = Color.FromArgb(50, 73, 60);
            buttonLB.FlatStyle = FlatStyle.Popup;
            buttonLB.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLB.ForeColor = Color.White;
            buttonLB.Location = new Point(282, 468);
            buttonLB.Name = "buttonLB";
            buttonLB.Size = new Size(60, 60);
            buttonLB.TabIndex = 33;
            buttonLB.Text = "(";
            buttonLB.UseVisualStyleBackColor = false;
            buttonLB.Click += clickButton;
            // 
            // buttonHEX
            // 
            buttonHEX.BackColor = Color.FromArgb(50, 73, 60);
            buttonHEX.FlatStyle = FlatStyle.Popup;
            buttonHEX.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHEX.ForeColor = Color.White;
            buttonHEX.Location = new Point(14, 211);
            buttonHEX.Name = "buttonHEX";
            buttonHEX.Size = new Size(80, 60);
            buttonHEX.TabIndex = 39;
            buttonHEX.Text = "HEX";
            buttonHEX.UseVisualStyleBackColor = false;
            buttonHEX.Click += clickButton;
            // 
            // buttonDEC
            // 
            buttonDEC.BackColor = Color.FromArgb(50, 73, 60);
            buttonDEC.FlatStyle = FlatStyle.Popup;
            buttonDEC.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDEC.ForeColor = Color.White;
            buttonDEC.Location = new Point(14, 268);
            buttonDEC.Name = "buttonDEC";
            buttonDEC.Size = new Size(80, 60);
            buttonDEC.TabIndex = 40;
            buttonDEC.Text = "DEC";
            buttonDEC.UseVisualStyleBackColor = false;
            buttonDEC.Click += clickButton;
            // 
            // buttonOCT
            // 
            buttonOCT.BackColor = Color.FromArgb(50, 73, 60);
            buttonOCT.FlatStyle = FlatStyle.Popup;
            buttonOCT.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOCT.ForeColor = Color.White;
            buttonOCT.Location = new Point(14, 325);
            buttonOCT.Name = "buttonOCT";
            buttonOCT.Size = new Size(80, 60);
            buttonOCT.TabIndex = 41;
            buttonOCT.Text = "OCT";
            buttonOCT.UseVisualStyleBackColor = false;
            buttonOCT.Click += clickButton;
            // 
            // buttonBIN
            // 
            buttonBIN.BackColor = Color.FromArgb(50, 73, 60);
            buttonBIN.FlatStyle = FlatStyle.Popup;
            buttonBIN.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBIN.ForeColor = Color.White;
            buttonBIN.Location = new Point(14, 382);
            buttonBIN.Name = "buttonBIN";
            buttonBIN.Size = new Size(80, 60);
            buttonBIN.TabIndex = 42;
            buttonBIN.Text = "BIN";
            buttonBIN.UseVisualStyleBackColor = false;
            buttonBIN.Click += clickButton;
            // 
            // inputMath
            // 
            inputMath.BackColor = Color.FromArgb(138, 176, 171);
            inputMath.BorderRadius = 30;
            inputMath.BorderStyle = BorderStyle.None;
            inputMath.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputMath.Location = new Point(410, 3);
            inputMath.Multiline = true;
            inputMath.Name = "inputMath";
            inputMath.ReadOnly = true;
            inputMath.Size = new Size(526, 120);
            inputMath.TabIndex = 43;
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
            roundedButton42.TabIndex = 45;
            roundedButton42.Text = "Programmer";
            roundedButton42.UseVisualStyleBackColor = false;
            // 
            // history
            // 
            history.AutoScroll = true;
            history.BackColor = Color.FromArgb(60, 80, 83);
            history.Location = new Point(410, 128);
            history.Name = "history";
            history.Size = new Size(526, 445);
            history.TabIndex = 46;
            // 
            // binary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 18, 14);
            Controls.Add(history);
            Controls.Add(roundedButton42);
            Controls.Add(inputMath);
            Controls.Add(buttonBIN);
            Controls.Add(buttonOCT);
            Controls.Add(buttonDEC);
            Controls.Add(buttonHEX);
            Controls.Add(buttonRB);
            Controls.Add(buttonLB);
            Controls.Add(buttonBSL);
            Controls.Add(buttonBSR);
            Controls.Add(buttonDIV);
            Controls.Add(buttonMULT);
            Controls.Add(buttonMINUS);
            Controls.Add(buttonPLUS);
            Controls.Add(buttonEQ);
            Controls.Add(buttonXOR);
            Controls.Add(buttonNOT);
            Controls.Add(buttonOR);
            Controls.Add(buttonAND);
            Controls.Add(buttonDEL);
            Controls.Add(button0);
            Controls.Add(buttonAC);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(buttonF);
            Controls.Add(buttonE);
            Controls.Add(buttonD);
            Name = "binary";
            Size = new Size(950, 591);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundedButton buttonD;
        private RoundedButton buttonE;
        private RoundedButton buttonF;
        private RoundedButton buttonC;
        private RoundedButton buttonB;
        private RoundedButton buttonA;
        private RoundedButton button9;
        private RoundedButton button8;
        private RoundedButton button7;
        private RoundedButton buttonDEL;
        private RoundedButton button0;
        private RoundedButton buttonAC;
        private RoundedButton button3;
        private RoundedButton button2;
        private RoundedButton button1;
        private RoundedButton button6;
        private RoundedButton button5;
        private RoundedButton button4;
        private RoundedButton buttonAND;
        private RoundedButton buttonOR;
        private RoundedButton buttonNOT;
        private RoundedButton buttonXOR;
        private RoundedButton buttonEQ;
        private RoundedButton buttonBSL;
        private RoundedButton buttonBSR;
        private RoundedButton buttonDIV;
        private RoundedButton buttonMULT;
        private RoundedButton buttonMINUS;
        private RoundedButton buttonPLUS;
        private RoundedButton buttonRB;
        private RoundedButton buttonLB;
        private RoundedButton buttonHEX;
        private RoundedButton buttonDEC;
        private RoundedButton buttonOCT;
        private RoundedButton buttonBIN;
        private RoundedTextBox inputMath;
        private RoundedButton roundedButton42;
        private FlowLayoutPanel history;
    }
}
