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
    public partial class standard : UserControl
    {
        public standard()
        {
            InitializeComponent();
        }

        private void standard_Load(object sender, EventArgs e)
        {

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
                    }
                    break;
                case "buttonCLEAR":
                    inputMath.Text = "";
                    break;
                default:
                    inputMath.Text = inputMath.Text + buttonPRESSED.Text;
                    break;

            }
        }

    }
}
