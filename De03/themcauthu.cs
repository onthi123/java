using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De03
{
    public partial class themcauthu : Form
    {
        public themcauthu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Cau3 cau3 = new Cau3();
                cau3.ketnoi();
                string sql = "Insert into cauthu values(N'" + txtma.Text + "',N'" + txtten.Text + "',N'" + txtns.Text + "',N'" + cbqq.Text + "')";
                SqlCommand cmd  = new SqlCommand(sql,cau3.getcon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm cầu thủ "+txtten.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập trùng mã cầu thủ");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtma.Text = txtten.Text = txtns.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
