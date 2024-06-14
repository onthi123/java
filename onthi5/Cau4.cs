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

namespace onthi5
{
    public partial class Cau4 : Form
    {
        public Cau4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            if (cbtinh.Text == "+")
            {
                txtB.Text = (a + b).ToString();
            }else if (cbtinh.Text =="-")
            {
                txtB.Text = (a - b).ToString();
            }else if (cbtinh.Text == "*")
            {
                txtB.Text = (a * b).ToString();
            }
            else
            {
                txtB.Text = (a / b).ToString();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txt1.ForeColor = colorDialog.Color;
                txt2.ForeColor = colorDialog.Color;
                txtB.ForeColor = colorDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txt1.Font = fontDialog.Font;
                txt2.Font = fontDialog.Font;
                txtB.Font = fontDialog.Font;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Open Files (*.txt)|*.txt";
            openFileDialog.Title = "Documents";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fo = File.ReadAllText(openFileDialog.FileName);
                txtB.Text = fo;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Save Files (*.txt)|*.txt";
            saveFileDialog.Title = "Documents";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fs = saveFileDialog.FileName;
                StreamWriter fw = new StreamWriter(fs);
                fw.Write(txtB.Text);
                fw.Close();
            }
        }
    }
}
