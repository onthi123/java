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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau2 fr = new Cau2();
            fr.MdiParent = this;
            fr.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau3 fr = new Cau3();
            fr.MdiParent = this;
            fr.Show();
        }

        private void hptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hptbac1 h = new hptbac1();
            h.Show();
        }
    }
}
