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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau2 cau2 = new Cau2();
            cau2.MdiParent = this;
            cau2.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau3 cau3 = new Cau3();
            cau3.MdiParent = this;
            cau3.Show();
        }
    }
}
