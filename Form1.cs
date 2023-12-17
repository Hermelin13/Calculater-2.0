/* Author:  Adam Dalibor Jurčík xjurci08         
 *          David Zahálka       xzahal03
 *          Antonín Štoll       xstoll01
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

namespace Calculater
{
    public partial class FITCalculator : Form
    {
        bool sidebarExpansion;
        public FITCalculator()
        {
            InitializeComponent();
            this.FormClosing += prevodnik1.HistoryToXml;
            this.FormClosing += standard1.HistoryToXml;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            standard1.Visible = true;
            prevodnik1.Visible = false;
            binary1.Visible = false;
        }

        private void standardButton_Click(object sender, EventArgs e)
        {
            barTimer.Start();
            standard1.Visible = true;
            prevodnik1.Visible = false;
            binary1.Visible = false;
        }

        private void PrevodnikButton_Click(object sender, EventArgs e)
        {
            barTimer.Start();
            standard1.Visible = false;
            prevodnik1.Visible = true;
            binary1.Visible = false;
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            barTimer.Start();
            standard1.Visible = false;
            prevodnik1.Visible = false;
            binary1.Visible = true;
        }

        private void barTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpansion)
            {
                menuBar.Height -= 10;
                menuBar.Width -= 10;
                if (menuBar.Height == menuBar.MinimumSize.Height && menuBar.Width == menuBar.MinimumSize.Width)
                {
                    menuBar.BackColor = Color.FromArgb(3, 18, 14);
                    sidebarExpansion = false;
                    barTimer.Stop();
                }
            }
            else
            {
                menuBar.BackColor = Color.FromArgb(21, 42, 37);
                menuBar.Height += 10;
                menuBar.Width += 10;
                if (menuBar.Height == menuBar.MaximumSize.Height && menuBar.Width == menuBar.MaximumSize.Width)
                {

                    sidebarExpansion = true;
                    barTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            barTimer.Start();
        }

        private void pressed(object sender, KeyEventArgs e)
        {
            if (standard1.Visible)
            {
                standard1.keyPressed(e);
            }
            else if (binary1.Visible)
            {
                binary1.keyPressed(e);
            }
            else if (prevodnik1.Visible)
            {
                prevodnik1.keyPressed(e);
            }
        }
    }
}
