using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onthi5
{
    public partial class Cau1 : Form
    {
        public Cau1()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau2 cau2 = new Cau2();
            //cau2.MdiParent = this;
            cau2.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau3 cau3 = new Cau3();
            cau3.MdiParent = this;
            cau3.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void câu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau4 cau4 = new Cau4();
            cau4.Show();
        }

        private void câu5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau5 cau5 = new Cau5();
            cau5.Show();
        }

        private void câu6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau6 cau6 = new Cau6();
            cau6.Show();
        }
    }
}
