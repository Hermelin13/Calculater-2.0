
using System.Drawing;

namespace Calculater
{
    partial class FITCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            standard1 = new standard();
            prevodnik1 = new prevodnik();
            binary1 = new binary();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            menuBar = new System.Windows.Forms.FlowLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            menuButton = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            standardButton = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            PrevodnikButton = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            binaryButton = new System.Windows.Forms.Button();
            barTimer = new System.Windows.Forms.Timer(components);
            menuBar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // standard1
            // 
            standard1.BackColor = Color.FromArgb(3, 18, 14);
            standard1.Location = new Point(134, 0);
            standard1.Name = "standard1";
            standard1.Size = new Size(950, 591);
            standard1.TabIndex = 24;
            // 
            // prevodnik1
            // 
            prevodnik1.BackColor = Color.FromArgb(3, 18, 14);
            prevodnik1.Location = new Point(134, 0);
            prevodnik1.Name = "prevodnik1";
            prevodnik1.Size = new Size(950, 591);
            prevodnik1.TabIndex = 25;
            // 
            // binary1
            // 
            binary1.BackColor = Color.FromArgb(3, 18, 14);
            binary1.Location = new Point(134, 0);
            binary1.Name = "binary1";
            binary1.Size = new Size(950, 591);
            binary1.TabIndex = 26;
            // 
            // button1
            // 
            button1.Location = new Point(523, 473);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Standard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(404, 529);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 28;
            button2.Text = "Převodník";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(404, 489);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 29;
            button3.Text = "Programátorská";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menuBar
            // 
            menuBar.BackColor = Color.Green;
            menuBar.Controls.Add(panel2);
            menuBar.Controls.Add(panel1);
            menuBar.Controls.Add(panel3);
            menuBar.Controls.Add(panel4);
            menuBar.Location = new Point(-1, 0);
            menuBar.MaximumSize = new Size(200, 210);
            menuBar.MinimumSize = new Size(60, 60);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(200, 60);
            menuBar.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuButton);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 56);
            panel2.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.Location = new Point(3, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(50, 50);
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(standardButton);
            panel1.Location = new Point(3, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 43);
            panel1.TabIndex = 0;
            // 
            // standardButton
            // 
            standardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            standardButton.Location = new Point(-3, -11);
            standardButton.Name = "standardButton";
            standardButton.Size = new Size(203, 67);
            standardButton.TabIndex = 0;
            standardButton.Text = "button4";
            standardButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LimeGreen;
            panel3.Controls.Add(PrevodnikButton);
            panel3.Location = new Point(3, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 43);
            panel3.TabIndex = 2;
            // 
            // PrevodnikButton
            // 
            PrevodnikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PrevodnikButton.Location = new Point(-3, -11);
            PrevodnikButton.Name = "PrevodnikButton";
            PrevodnikButton.Size = new Size(203, 67);
            PrevodnikButton.TabIndex = 0;
            PrevodnikButton.Text = "button5";
            PrevodnikButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(binaryButton);
            panel4.Location = new Point(3, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 43);
            panel4.TabIndex = 3;
            // 
            // binaryButton
            // 
            binaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            binaryButton.Location = new Point(-3, -11);
            binaryButton.Name = "binaryButton";
            binaryButton.Size = new Size(203, 67);
            binaryButton.TabIndex = 0;
            binaryButton.Text = "button6";
            binaryButton.UseVisualStyleBackColor = true;
            // 
            // barTimer
            // 
            barTimer.Interval = 10;
            barTimer.Tick += barTimer_Tick;
            // 
            // FITCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 18, 14);
            ClientSize = new Size(1084, 591);
            Controls.Add(menuBar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(standard1);
            Controls.Add(binary1);
            Controls.Add(prevodnik1);
            Name = "FITCalculator";
            Text = "FITCalculator";
            Load += Form1_Load;
            menuBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private standard standard1;
        private prevodnik prevodnik1;
        private binary binary1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel menuBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button standardButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PrevodnikButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button binaryButton;
        private System.Windows.Forms.Timer barTimer;
    }
}

