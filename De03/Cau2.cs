using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De03
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontdialog.ShowDialog() == DialogResult.OK)
            {
                rtb.Font = fontdialog.Font;
            }    
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colordialog.ShowDialog() == DialogResult.OK)
            {
                rtb.ForeColor = colordialog.Color;
            }    
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
