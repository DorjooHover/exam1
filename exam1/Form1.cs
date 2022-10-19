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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int total = 0, pizzaPrice = 0, extra_price = 1000, extra_checked = 0,
                laaz_qnt = 1, laaz_price = 1500, juice_qnt = 0, juice_price = 1000, 
                tea_qnt = 0, tea_price = 500, water_qnt = 0, water_price = 500;
            if(sizeMedium.Checked)
            {
                int.TryParse(mediumSizePrice.Text,out pizzaPrice);
                total = pizzaPrice;
            }
            if (sizeSmall.Checked)
            {
                int.TryParse(smallSizePrice.Text, out pizzaPrice);
                total = pizzaPrice;
            }
            if (sizeLarge.Checked)
            {
                int.TryParse(largeSizePrice.Text, out pizzaPrice);
                total = pizzaPrice;
            }
            int.TryParse(extraPrice.Text, out extra_price);
            for(int i=0; i<extra.Items.Count-1; i++)
            {
                if(extra.GetItemChecked(i))
                {
                    extra_checked++;
                }
            }
            total += extra_checked * extra_price;

            int.TryParse(laazQnt.Text, out laaz_qnt);
            int.TryParse(laazPrice.Text, out laaz_price);
            int.TryParse(juiceQnt.Text, out juice_qnt);
            int.TryParse(juicePrice.Text, out juice_price);
            int.TryParse(teaQnt.Text, out tea_qnt);
            int.TryParse(teaPrice.Text, out tea_price);
            int.TryParse(waterQnt.Text, out water_qnt);
            int.TryParse(waterPrice.Text, out water_price);

            laazTotal.Text = (laaz_qnt * laaz_price).ToString();
            juiceTotal.Text = (juice_qnt * juice_price).ToString();
            teaTotal.Text = (tea_qnt * tea_price).ToString();
            waterTotal.Text = (water_qnt * water_price).ToString();

            total = total + laaz_qnt * laaz_price + juice_qnt * juice_price + tea_qnt * tea_price + water_qnt * water_price;

            totalPrice.Text = total.ToString();
        }
    }
}
