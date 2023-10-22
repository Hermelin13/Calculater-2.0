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
        public FITCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            standard1.Visible = true;
            prevodnik1.Visible = false;
            binary1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            standard1.Visible = true;
            prevodnik1.Visible = false;
            binary1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            standard1.Visible = false;
            prevodnik1.Visible = true;
            binary1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            standard1.Visible = false;
            prevodnik1.Visible = false;
            binary1.Visible = true;
        }

        private void binary1_Load(object sender, EventArgs e)
        {

        }
    }
}
