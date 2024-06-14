using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De01
{
    public partial class hptbac1 : Form
    {
        public hptbac1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double a1 = double.Parse(txta1.Text);
            double b1 = double.Parse(txtb1.Text);
            double c1 = double.Parse(txtc1.Text);   
            double a2 = double.Parse(txta2.Text);
            double b2 = double.Parse(txtb2.Text);
            double c2 = double.Parse(txtc2.Text);
            double d = a1 * b2 - a2 * b1;
            double dx = c1* b2 - c2 * b1;
            double dy = c2 * a1 - c1 * a2;

            MessageBox.Show("x = " + (dx / d) + "y = " + (dy / d));
        }
    }
}
