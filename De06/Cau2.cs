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
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }
        public bool Isrealnumber(string str)
        {
            try
            {
                double.Parse(str);
                return true;
            }
            catch
            {
                return false; 
            }
        }
        private void btngiai_Click(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == ""  || txtm.Text=="" || txtc.Text == "" || txtd.Text == "" || txtn.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu dữ liệu!!!!");
            }
            else if(!Isrealnumber(txta.Text) || !Isrealnumber(txtb.Text) || !Isrealnumber(txtm.Text) || !Isrealnumber(txtc.Text) || !Isrealnumber(txtd.Text) || !Isrealnumber(txtn.Text))
            {
                MessageBox.Show("Bạn nhập sai dữ liệu, dữ liệu yêu cầu số thực");
            }
            else
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                double m = double.Parse(txtm.Text);
                double c = double.Parse(txtc.Text);
                double d = double.Parse(txtd.Text);
                double n = double.Parse(txtn.Text);
                double D = a * d - b * c;
                double Dx = d * m - n*b;
                double Dy = a*n - m*c;
                if(D==0)
                {
                    if(Dx==Dy && Dx==0)
                    {
                        MessageBox.Show("Phương trình vô số nghiệm");
                    }
                    else
                    {
                        MessageBox.Show("Phương trình vô nghiệm");
                    }    
                }
                else
                {
                    double x = Dx / D;
                    double y = Dy / D;
                    MessageBox.Show("Phương trình có 2 nghiệm\nx = " + x + "\ny = " + y);
                }    
            }
        }
    }
}
