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
            buttonHmotnost = new RoundedButton();
            buttonDelka = new RoundedButton();
            buttonPlocha = new RoundedButton();
            buttonObjem = new RoundedButton();
            inputMath = new RoundedTextBox();
            roundedButton42 = new RoundedButton();
            roundedTextBox1 = new RoundedTextBox();
            roundedTextBox2 = new RoundedTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            roundedTextBox3 = new RoundedTextBox();
            history = new RoundedTextBox();
            roundedButton1 = new RoundedButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonData = new RoundedButton();
            buttonMena = new RoundedButton();
            buttonTeplota = new RoundedButton();
            buttonCas = new RoundedButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(62, 80, 91);
            button9.FlatStyle = FlatStyle.Popup;
            button9.ForeColor = Color.White;
            button9.Location = new Point(337, 133);
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
            button8.ForeColor = Color.White;
            button8.Location = new Point(280, 133);
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
            button7.ForeColor = Color.White;
            button7.Location = new Point(223, 133);
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
            buttonDEL.ForeColor = Color.White;
            buttonDEL.Location = new Point(337, 76);
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
            button0.ForeColor = Color.White;
            button0.Location = new Point(280, 304);
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
            buttonAC.FlatStyle = FlatStyle.Popup;
            buttonAC.ForeColor = Color.White;
            buttonAC.Location = new Point(280, 76);
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
            button3.ForeColor = Color.White;
            button3.Location = new Point(337, 247);
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
            button2.Location = new Point(280, 247);
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
            button1.ForeColor = Color.White;
            button1.Location = new Point(223, 247);
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
            button6.ForeColor = Color.White;
            button6.Location = new Point(337, 190);
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
            button5.ForeColor = Color.White;
            button5.Location = new Point(280, 190);
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
            button4.ForeColor = Color.White;
            button4.Location = new Point(223, 190);
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
            buttonEQ.FlatStyle = FlatStyle.Popup;
            buttonEQ.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEQ.ForeColor = Color.White;
            buttonEQ.Location = new Point(280, 361);
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
            buttonDIV.FlatStyle = FlatStyle.Popup;
            buttonDIV.ForeColor = Color.White;
            buttonDIV.Location = new Point(166, 304);
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
            buttonMULT.ForeColor = Color.White;
            buttonMULT.Location = new Point(166, 247);
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
            buttonMINUS.ForeColor = Color.White;
            buttonMINUS.Location = new Point(166, 190);
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
            buttonPLUS.ForeColor = Color.White;
            buttonPLUS.Location = new Point(166, 133);
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
            buttonRB.ForeColor = Color.White;
            buttonRB.Location = new Point(223, 76);
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
            buttonLB.ForeColor = Color.White;
            buttonLB.Location = new Point(166, 76);
            buttonLB.Name = "buttonLB";
            buttonLB.Size = new Size(60, 60);
            buttonLB.TabIndex = 33;
            buttonLB.Text = "(";
            buttonLB.UseVisualStyleBackColor = false;
            buttonLB.Click += clickButton;
            // 
            // buttonHmotnost
            // 
            buttonHmotnost.BackColor = Color.FromArgb(50, 73, 60);
            buttonHmotnost.FlatStyle = FlatStyle.Popup;
            buttonHmotnost.ForeColor = Color.White;
            buttonHmotnost.Location = new Point(3, 3);
            buttonHmotnost.Name = "buttonHmotnost";
            buttonHmotnost.Size = new Size(111, 60);
            buttonHmotnost.TabIndex = 39;
            buttonHmotnost.Text = "Hmotnost";
            buttonHmotnost.UseVisualStyleBackColor = false;
            buttonHmotnost.Click += clickButton;
            // 
            // buttonDelka
            // 
            buttonDelka.BackColor = Color.FromArgb(50, 73, 60);
            buttonDelka.FlatStyle = FlatStyle.Popup;
            buttonDelka.ForeColor = Color.White;
            buttonDelka.Location = new Point(3, 69);
            buttonDelka.Name = "buttonDelka";
            buttonDelka.Size = new Size(111, 60);
            buttonDelka.TabIndex = 40;
            buttonDelka.Text = "Délka";
            buttonDelka.UseVisualStyleBackColor = false;
            buttonDelka.Click += clickButton;
            // 
            // buttonPlocha
            // 
            buttonPlocha.BackColor = Color.FromArgb(50, 73, 60);
            buttonPlocha.FlatStyle = FlatStyle.Popup;
            buttonPlocha.ForeColor = Color.White;
            buttonPlocha.Location = new Point(3, 135);
            buttonPlocha.Name = "buttonPlocha";
            buttonPlocha.Size = new Size(111, 60);
            buttonPlocha.TabIndex = 41;
            buttonPlocha.Text = "Plocha";
            buttonPlocha.UseVisualStyleBackColor = false;
            buttonPlocha.Click += clickButton;
            // 
            // buttonObjem
            // 
            buttonObjem.BackColor = Color.FromArgb(50, 73, 60);
            buttonObjem.FlatStyle = FlatStyle.Popup;
            buttonObjem.ForeColor = Color.White;
            buttonObjem.Location = new Point(3, 201);
            buttonObjem.Name = "buttonObjem";
            buttonObjem.Size = new Size(111, 60);
            buttonObjem.TabIndex = 42;
            buttonObjem.Text = "Objem";
            buttonObjem.UseVisualStyleBackColor = false;
            buttonObjem.Click += clickButton;
            // 
            // inputMath
            // 
            inputMath.Anchor = AnchorStyles.None;
            inputMath.BackColor = Color.FromArgb(138, 176, 171);
            inputMath.BorderRadius = 30;
            inputMath.BorderStyle = BorderStyle.None;
            inputMath.Location = new Point(3, 7);
            inputMath.Multiline = true;
            inputMath.Name = "inputMath";
            inputMath.ReadOnly = true;
            inputMath.Size = new Size(520, 60);
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
            // roundedTextBox1
            // 
            roundedTextBox1.Anchor = AnchorStyles.Right;
            roundedTextBox1.BackColor = Color.FromArgb(138, 176, 171);
            roundedTextBox1.BorderRadius = 30;
            roundedTextBox1.BorderStyle = BorderStyle.None;
            roundedTextBox1.Location = new Point(363, 82);
            roundedTextBox1.Multiline = true;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Size = new Size(160, 60);
            roundedTextBox1.TabIndex = 46;
            roundedTextBox1.Text = "g";
            roundedTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.Anchor = AnchorStyles.None;
            roundedTextBox2.BackColor = Color.FromArgb(138, 176, 171);
            roundedTextBox2.BorderRadius = 30;
            roundedTextBox2.BorderStyle = BorderStyle.None;
            roundedTextBox2.Location = new Point(3, 157);
            roundedTextBox2.Multiline = true;
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.ReadOnly = true;
            roundedTextBox2.Size = new Size(520, 60);
            roundedTextBox2.TabIndex = 47;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(roundedTextBox3, 0, 3);
            tableLayoutPanel1.Controls.Add(inputMath, 0, 0);
            tableLayoutPanel1.Controls.Add(roundedTextBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(roundedTextBox2, 0, 2);
            tableLayoutPanel1.Location = new Point(410, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(526, 300);
            tableLayoutPanel1.TabIndex = 48;
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.Anchor = AnchorStyles.Right;
            roundedTextBox3.BackColor = Color.FromArgb(138, 176, 171);
            roundedTextBox3.BorderRadius = 30;
            roundedTextBox3.BorderStyle = BorderStyle.None;
            roundedTextBox3.Location = new Point(363, 232);
            roundedTextBox3.Multiline = true;
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.Size = new Size(160, 60);
            roundedTextBox3.TabIndex = 48;
            roundedTextBox3.Text = "kg";
            roundedTextBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // history
            // 
            history.BackColor = Color.FromArgb(60, 80, 83);
            history.BorderRadius = 30;
            history.BorderStyle = BorderStyle.None;
            history.Location = new Point(410, 306);
            history.Multiline = true;
            history.Name = "history";
            history.ReadOnly = true;
            history.Size = new Size(526, 271);
            history.TabIndex = 44;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(50, 73, 60);
            roundedButton1.FlatStyle = FlatStyle.Popup;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(223, 304);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(60, 60);
            roundedButton1.TabIndex = 49;
            roundedButton1.Text = ".";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(buttonData, 0, 7);
            tableLayoutPanel2.Controls.Add(buttonHmotnost, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonDelka, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonPlocha, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonObjem, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonMena, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonTeplota, 0, 5);
            tableLayoutPanel2.Controls.Add(buttonCas, 0, 6);
            tableLayoutPanel2.Location = new Point(20, 61);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(140, 530);
            tableLayoutPanel2.TabIndex = 50;
            // 
            // buttonData
            // 
            buttonData.BackColor = Color.FromArgb(50, 73, 60);
            buttonData.FlatStyle = FlatStyle.Popup;
            buttonData.ForeColor = Color.White;
            buttonData.Location = new Point(3, 465);
            buttonData.Name = "buttonData";
            buttonData.Size = new Size(111, 60);
            buttonData.TabIndex = 46;
            buttonData.Text = "Data";
            buttonData.UseVisualStyleBackColor = false;
            // 
            // buttonMena
            // 
            buttonMena.BackColor = Color.FromArgb(50, 73, 60);
            buttonMena.FlatStyle = FlatStyle.Popup;
            buttonMena.ForeColor = Color.White;
            buttonMena.Location = new Point(3, 267);
            buttonMena.Name = "buttonMena";
            buttonMena.Size = new Size(111, 60);
            buttonMena.TabIndex = 43;
            buttonMena.Text = "Měna";
            buttonMena.UseVisualStyleBackColor = false;
            // 
            // buttonTeplota
            // 
            buttonTeplota.BackColor = Color.FromArgb(50, 73, 60);
            buttonTeplota.FlatStyle = FlatStyle.Popup;
            buttonTeplota.ForeColor = Color.White;
            buttonTeplota.Location = new Point(3, 333);
            buttonTeplota.Name = "buttonTeplota";
            buttonTeplota.Size = new Size(111, 60);
            buttonTeplota.TabIndex = 44;
            buttonTeplota.Text = "Teplota";
            buttonTeplota.UseVisualStyleBackColor = false;
            // 
            // buttonCas
            // 
            buttonCas.BackColor = Color.FromArgb(50, 73, 60);
            buttonCas.FlatStyle = FlatStyle.Popup;
            buttonCas.ForeColor = Color.White;
            buttonCas.Location = new Point(3, 399);
            buttonCas.Name = "buttonCas";
            buttonCas.Size = new Size(111, 60);
            buttonCas.TabIndex = 45;
            buttonCas.Text = "Čas";
            buttonCas.UseVisualStyleBackColor = false;
            // 
            // prevodnik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 18, 14);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(roundedButton1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(roundedButton42);
            Controls.Add(history);
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
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private RoundedButton buttonHmotnost;
        private RoundedButton buttonDelka;
        private RoundedButton buttonPlocha;
        private RoundedButton buttonObjem;
        private RoundedTextBox inputMath;
        private RoundedButton roundedButton42;
        private RoundedTextBox roundedTextBox1;
        private RoundedTextBox roundedTextBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private RoundedTextBox roundedTextBox3;
        private RoundedTextBox history;
        private RoundedButton roundedButton1;
        private TableLayoutPanel tableLayoutPanel2;
        private RoundedButton buttonData;
        private RoundedButton buttonMena;
        private RoundedButton buttonTeplota;
        private RoundedButton buttonCas;
    }
}
