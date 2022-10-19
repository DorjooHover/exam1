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
    public partial class Form3 : Form
    {
        private int _size;
        public int size
        {
            get { return _size; }
            set { _size = value; } 
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int l = 0;
            int.TryParse(unit.Text, out l);
            if (list.Items.Count  < l)
            {
                list.Items.Add(product.Text);
                product.Text = string.Empty;
            }
            
            
            
            
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if(list.SelectedIndex != -1)
            {
                list.Items.RemoveAt(list.SelectedIndex);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
        }
    }
}
