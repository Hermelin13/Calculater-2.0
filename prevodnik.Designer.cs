/* Author:  Antonín Štoll       xstoll01
 */

using System.Drawing;
using System.Windows.Forms;

namespace Calculater
{
    partial class prevodnik
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
            buttonEQ = new RoundedButton();
            buttonDIV = new RoundedButton();
            buttonMULT = new RoundedButton();
            buttonMINUS = new RoundedButton();
            buttonPLUS = new RoundedButton();
            buttonRB = new RoundedButton();
            buttonLB = new RoundedButton();
            inputMath = new RoundedTextBox();
            roundedButton42 = new RoundedButton();
            resultTextBox = new RoundedTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            unitsFrom = new ComboBox();
            unitsTo = new ComboBox();
            buttonDot = new RoundedButton();
            quantitySelector = new FlowLayoutPanel();
            panel1 = new Panel();
            history = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(62, 80, 91);
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Popup;
            button9.ForeColor = Color.White;
            button9.Location = new Point(337, 146);
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
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Popup;
            button8.ForeColor = Color.White;
            button8.Location = new Point(280, 146);
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
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.White;
            button7.Location = new Point(223, 146);
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
            buttonDEL.Cursor = Cursors.Hand;
            buttonDEL.FlatStyle = FlatStyle.Popup;
            buttonDEL.ForeColor = Color.White;
            buttonDEL.Location = new Point(337, 89);
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
            button0.Cursor = Cursors.Hand;
            button0.FlatStyle = FlatStyle.Popup;
            button0.ForeColor = Color.White;
            button0.Location = new Point(280, 317);
            button0.Name = "button0";
            button0.Size = new Size(117, 60);
            button0.TabIndex = 18;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += clickButton;
            // 
            // buttonAC
            // 
            buttonAC.BackColor = Color.FromArgb(204, 80, 91);
            buttonAC.Cursor = Cursors.Hand;
            buttonAC.FlatStyle = FlatStyle.Popup;
            buttonAC.ForeColor = Color.White;
            buttonAC.Location = new Point(280, 89);
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
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(337, 260);
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
            button2.ForeColor = Color.White;
            button2.Location = new Point(280, 260);
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
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(223, 260);
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
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = Color.White;
            button6.Location = new Point(337, 203);
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
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.White;
            button5.Location = new Point(280, 203);
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
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.White;
            button4.Location = new Point(223, 203);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 11;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += clickButton;
            // 
            // buttonEQ
            // 
            buttonEQ.BackColor = Color.FromArgb(2, 101, 82);
            buttonEQ.Cursor = Cursors.Hand;
            buttonEQ.FlatStyle = FlatStyle.Popup;
            buttonEQ.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEQ.ForeColor = Color.White;
            buttonEQ.Location = new Point(280, 374);
            buttonEQ.Name = "buttonEQ";
            buttonEQ.Size = new Size(117, 60);
            buttonEQ.TabIndex = 26;
            buttonEQ.Text = "=";
            buttonEQ.UseVisualStyleBackColor = false;
            buttonEQ.Click += clickButton;
            // 
            // buttonDIV
            // 
            buttonDIV.BackColor = Color.FromArgb(50, 73, 60);
            buttonDIV.Cursor = Cursors.Hand;
            buttonDIV.FlatStyle = FlatStyle.Popup;
            buttonDIV.ForeColor = Color.White;
            buttonDIV.Location = new Point(166, 317);
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
            buttonMULT.Cursor = Cursors.Hand;
            buttonMULT.FlatStyle = FlatStyle.Popup;
            buttonMULT.ForeColor = Color.White;
            buttonMULT.Location = new Point(166, 260);
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
            buttonMINUS.Cursor = Cursors.Hand;
            buttonMINUS.FlatStyle = FlatStyle.Popup;
            buttonMINUS.ForeColor = Color.White;
            buttonMINUS.Location = new Point(166, 203);
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
            buttonPLUS.Cursor = Cursors.Hand;
            buttonPLUS.FlatStyle = FlatStyle.Popup;
            buttonPLUS.ForeColor = Color.White;
            buttonPLUS.Location = new Point(166, 146);
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
            buttonRB.Cursor = Cursors.Hand;
            buttonRB.FlatStyle = FlatStyle.Popup;
            buttonRB.ForeColor = Color.White;
            buttonRB.Location = new Point(223, 89);
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
            buttonLB.Cursor = Cursors.Hand;
            buttonLB.FlatStyle = FlatStyle.Popup;
            buttonLB.ForeColor = Color.White;
            buttonLB.Location = new Point(166, 89);
            buttonLB.Name = "buttonLB";
            buttonLB.Size = new Size(60, 60);
            buttonLB.TabIndex = 33;
            buttonLB.Text = "(";
            buttonLB.UseVisualStyleBackColor = false;
            buttonLB.Click += clickButton;
            // 
            // inputMath
            // 
            inputMath.Anchor = AnchorStyles.None;
            inputMath.BackColor = Color.FromArgb(138, 176, 171);
            inputMath.BorderRadius = 30;
            inputMath.BorderStyle = BorderStyle.None;
            inputMath.Location = new Point(3, 5);
            inputMath.Multiline = true;
            inputMath.Name = "inputMath";
            inputMath.ReadOnly = true;
            inputMath.Size = new Size(520, 39);
            inputMath.TabIndex = 43;
            // 
            // roundedButton42
            // 
            roundedButton42.BackColor = Color.FromArgb(50, 73, 60);
            roundedButton42.FlatStyle = FlatStyle.Popup;
            roundedButton42.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton42.ForeColor = Color.White;
            roundedButton42.Location = new Point(7, 3);
            roundedButton42.Name = "roundedButton42";
            roundedButton42.Size = new Size(278, 60);
            roundedButton42.TabIndex = 45;
            roundedButton42.Text = "Převodník";
            roundedButton42.UseVisualStyleBackColor = false;
            // 
            // resultTextBox
            // 
            resultTextBox.Anchor = AnchorStyles.None;
            resultTextBox.BackColor = Color.FromArgb(138, 176, 171);
            resultTextBox.BorderRadius = 30;
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Location = new Point(3, 105);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(520, 39);
            resultTextBox.TabIndex = 47;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(inputMath, 0, 0);
            tableLayoutPanel1.Controls.Add(resultTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(unitsFrom, 0, 1);
            tableLayoutPanel1.Controls.Add(unitsTo, 0, 3);
            tableLayoutPanel1.Location = new Point(410, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(526, 200);
            tableLayoutPanel1.TabIndex = 48;
            // 
            // unitsFrom
            // 
            unitsFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            unitsFrom.BackColor = Color.FromArgb(138, 176, 171);
            unitsFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            unitsFrom.FlatStyle = FlatStyle.Flat;
            unitsFrom.FormattingEnabled = true;
            unitsFrom.Location = new Point(275, 53);
            unitsFrom.Name = "unitsFrom";
            unitsFrom.Size = new Size(248, 23);
            unitsFrom.TabIndex = 48;
            // 
            // unitsTo
            // 
            unitsTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            unitsTo.BackColor = Color.FromArgb(138, 176, 171);
            unitsTo.DropDownStyle = ComboBoxStyle.DropDownList;
            unitsTo.FlatStyle = FlatStyle.Flat;
            unitsTo.FormattingEnabled = true;
            unitsTo.Location = new Point(275, 153);
            unitsTo.Name = "unitsTo";
            unitsTo.Size = new Size(248, 23);
            unitsTo.TabIndex = 49;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = Color.FromArgb(50, 73, 60);
            buttonDot.Cursor = Cursors.Hand;
            buttonDot.FlatStyle = FlatStyle.Popup;
            buttonDot.ForeColor = Color.White;
            buttonDot.Location = new Point(223, 317);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(60, 60);
            buttonDot.TabIndex = 49;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            // 
            // quantitySelector
            // 
            quantitySelector.AutoScroll = true;
            quantitySelector.Location = new Point(7, 89);
            quantitySelector.Name = "quantitySelector";
            quantitySelector.Size = new Size(156, 488);
            quantitySelector.TabIndex = 52;
            // 
            // panel1
            // 
            panel1.Location = new Point(141, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(25, 524);
            panel1.TabIndex = 53;
            // 
            // history
            // 
            history.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            history.AutoScroll = true;
            history.BackColor = Color.FromArgb(60, 80, 83);
            history.Location = new Point(410, 206);
            history.Name = "history";
            history.Size = new Size(526, 371);
            history.TabIndex = 54;
            // 
            // prevodnik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 18, 14);
            Controls.Add(history);
            Controls.Add(panel1);
            Controls.Add(quantitySelector);
            Controls.Add(buttonDot);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(roundedButton42);
            Controls.Add(buttonRB);
            Controls.Add(buttonLB);
            Controls.Add(buttonDIV);
            Controls.Add(buttonMULT);
            Controls.Add(buttonMINUS);
            Controls.Add(buttonPLUS);
            Controls.Add(buttonEQ);
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
            Name = "prevodnik";
            Size = new Size(950, 591);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private RoundedButton buttonEQ;
        private RoundedButton buttonDIV;
        private RoundedButton buttonMULT;
        private RoundedButton buttonMINUS;
        private RoundedButton buttonPLUS;
        private RoundedButton buttonRB;
        private RoundedButton buttonLB;
        private RoundedTextBox inputMath;
        private RoundedButton roundedButton42;
        private RoundedTextBox resultTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private RoundedButton buttonDot;
        private ComboBox unitsFrom;
        private ComboBox unitsTo;
        private FlowLayoutPanel quantitySelector;
        private Panel panel1;
        private FlowLayoutPanel history;
    }
}
