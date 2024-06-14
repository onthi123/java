using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De06
{
    public partial class frMain : Form
    {
        public frMain()
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

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
