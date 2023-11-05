
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
            standard1 = new standard();
            prevodnik1 = new prevodnik();
            binary1 = new binary();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
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
            binary1.Load += binary1_Load;
            // 
            // button1
            // 
            button1.Location = new Point(12, 98);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Standard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 152);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 28;
            button2.Text = "Převodník";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 213);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 29;
            button3.Text = "Programátorská";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FITCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 18, 14);
            ClientSize = new Size(1084, 591);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(standard1);
            Controls.Add(binary1);
            Controls.Add(prevodnik1);
            Name = "FITCalculator";
            Text = "FITCalculator";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private standard standard1;
        private prevodnik prevodnik1;
        private binary binary1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

