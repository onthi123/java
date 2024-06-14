using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De01
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog odl = new OpenFileDialog();
            odl.Filter = "Text file (*.txt)|*.txt|Word Document (*.docx)|*.docx|All files (*.*)|*.*";
            odl.Title = "Mo tai lieu";

            if (odl.ShowDialog() == DialogResult.OK)
            {
                String conten = File.ReadAllText(odl.FileName);
                richtext.Text = conten;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtext.Clear();
            this.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
