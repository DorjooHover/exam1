using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    groupBox1.BackColor = Color.Red;
                    break;
                case 1:
                    groupBox1.BackColor = Color.Green;
                    break;
                case 2:
                    groupBox1.BackColor = Color.Black;
                    break;
                case 3: 
                    groupBox1.BackColor = Color.Yellow;
                    break;
                case 4:
                    groupBox1.BackColor = Color.Orange;
                    break;
                default:

                    break;

            }


        }
    }
}
