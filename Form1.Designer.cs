
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FITCalculator));
            standard1 = new standard();
            prevodnik1 = new prevodnik();
            binary1 = new binary();
            menuBar = new System.Windows.Forms.FlowLayoutPanel();
            panelMenu = new System.Windows.Forms.Panel();
            menuButton = new System.Windows.Forms.PictureBox();
            standardButton = new RoundedButton();
            PrevodnikButton = new RoundedButton();
            binaryButton = new RoundedButton();
            barTimer = new System.Windows.Forms.Timer(components);
            menuBar.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            SuspendLayout();
            // 
            // standard1
            // 
            standard1.BackColor = Color.FromArgb(3, 18, 14);
            standard1.Location = new Point(-1, 0);
            standard1.Name = "standard1";
            standard1.Size = new Size(950, 591);
            standard1.TabIndex = 24;
            // 
            // prevodnik1
            // 
            prevodnik1.BackColor = Color.FromArgb(3, 18, 14);
            prevodnik1.Location = new Point(-1, 0);
            prevodnik1.Name = "prevodnik1";
            prevodnik1.Size = new Size(950, 591);
            prevodnik1.TabIndex = 25;
            // 
            // binary1
            // 
            binary1.BackColor = Color.FromArgb(3, 18, 14);
            binary1.Location = new Point(-1, 0);
            binary1.Name = "binary1";
            binary1.Size = new Size(950, 591);
            binary1.TabIndex = 26;
            // 
            // menuBar
            // 
            menuBar.BackColor = Color.FromArgb(3, 18, 14);
            menuBar.Controls.Add(panelMenu);
            menuBar.Controls.Add(standardButton);
            menuBar.Controls.Add(PrevodnikButton);
            menuBar.Controls.Add(binaryButton);
            menuBar.Location = new Point(-1, 0);
            menuBar.MaximumSize = new Size(170, 210);
            menuBar.MinimumSize = new Size(60, 60);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(60, 60);
            menuBar.TabIndex = 30;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(menuButton);
            panelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            panelMenu.Location = new Point(3, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(57, 56);
            panelMenu.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.Image = Properties.Resources.menu_bars;
            menuButton.Location = new Point(0, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(54, 50);
            menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // standardButton
            // 
            standardButton.BackColor = Color.FromArgb(50, 73, 60);
            standardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            standardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            standardButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            standardButton.ForeColor = Color.White;
            standardButton.Location = new Point(3, 65);
            standardButton.Name = "standardButton";
            standardButton.Size = new Size(160, 41);
            standardButton.TabIndex = 0;
            standardButton.Text = "Standardní";
            standardButton.UseVisualStyleBackColor = false;
            standardButton.Click += standardButton_Click;
            // 
            // PrevodnikButton
            // 
            PrevodnikButton.BackColor = Color.FromArgb(50, 73, 60);
            PrevodnikButton.Cursor = System.Windows.Forms.Cursors.Hand;
            PrevodnikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PrevodnikButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PrevodnikButton.ForeColor = Color.White;
            PrevodnikButton.Location = new Point(3, 112);
            PrevodnikButton.Name = "PrevodnikButton";
            PrevodnikButton.Size = new Size(160, 41);
            PrevodnikButton.TabIndex = 0;
            PrevodnikButton.Text = "Převodník";
            PrevodnikButton.UseVisualStyleBackColor = false;
            PrevodnikButton.Click += PrevodnikButton_Click;
            // 
            // binaryButton
            // 
            binaryButton.BackColor = Color.FromArgb(50, 73, 60);
            binaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            binaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            binaryButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            binaryButton.ForeColor = Color.White;
            binaryButton.Location = new Point(3, 159);
            binaryButton.Name = "binaryButton";
            binaryButton.Size = new Size(160, 41);
            binaryButton.TabIndex = 0;
            binaryButton.Text = "Programátorská";
            binaryButton.UseVisualStyleBackColor = false;
            binaryButton.Click += binaryButton_Click;
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
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(3, 18, 14);
            ClientSize = new Size(949, 591);
            Controls.Add(menuBar);
            Controls.Add(standard1);
            Controls.Add(binary1);
            Controls.Add(prevodnik1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FITCalculator";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FITCalculator";
            Load += Form1_Load;
            KeyDown += pressed;
            menuBar.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private standard standard1;
        private prevodnik prevodnik1;
        private binary binary1;
        private System.Windows.Forms.FlowLayoutPanel menuBar;
        private RoundedButton standardButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox menuButton;
        private RoundedButton PrevodnikButton;
        private RoundedButton binaryButton;
        private System.Windows.Forms.Timer barTimer;
    }
}

