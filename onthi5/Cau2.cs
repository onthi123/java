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
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                if (a == 0)
                {
                    MessageBox.Show("Vui long nhap so a");
                }
                if (a == 0 && b==0 && c==0)
                {
                    MessageBox.Show("Nhap du lieu");
                }
                double dt = b * b - 4 * a * c;
                if (dt > 0)
                {
                    double x1 = -(b + Math.Sqrt(dt)) / (2 * a);
                    double x2 = -(b - Math.Sqrt(dt)) / (2 * a);
                    richTextBox1.Text= "Phuong trinh co 2 nghiem x1 va x2: \n";
                    richTextBox1.AppendText("x1 = " + x1.ToString() + ".\n");
                    richTextBox1.AppendText("x2 = " + x2.ToString() + ".\n");
                }else if (dt == 0)
                {
                    double x = -b / (2 * a);
                    richTextBox1.Text = "Phuong trinh co nghiem kep: \n";
                    richTextBox1.AppendText("x = " + x.ToString() + ".\n");
                }
                else
                {
                    richTextBox1.Text = "Phuong trinh vo nghiem!!!";
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            richTextBox1.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Documents";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fo = File.ReadAllText(openFileDialog.FileName);
                richTextBox1.Text = fo;
            }



        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Save Files (*.txt)|*.txt";
            saveFileDialog.Title = "Documents";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String so = saveFileDialog.FileName;
                StreamWriter streamWriter = new StreamWriter(so);
                streamWriter.Write(richTextBox1.Text);
                streamWriter.Close();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            if (cl.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = cl.Color;
            }
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }
    }
}
