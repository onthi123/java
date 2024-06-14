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

namespace De01
{
    public partial class Cau3 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adp;
        DataSet ds;
        string matxt="";
        public Cau3()
        {
            InitializeComponent();
            loadbang();
        }
        public void ketnoi()
        {
            string sql = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\qlteamleader.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(sql);
            conn.Open();
        }
        public bool isnumber(string str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch (Exception) { return false; }
        }
        public void loadbang()
        {
            ketnoi();
            string sql = "SELECT * FROM teamleader";
            adp = new SqlDataAdapter(sql, conn);
            ds =new DataSet();
            adp.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "" || txtns.Text == "" || txtluongcb.Text == "" || txttientk.Text == "" || txtluongtn.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu dữ liệu, yêu cầu bạn nhập đầy đủ thông tin trước khi thêm !!!!", "Warning");
            }
            else
            {
                if (isnumber(txtns.Text) || isnumber(txtluongcb.Text) || isnumber(txttientk.Text) || isnumber(txtluongtn.Text))
                {
                    ketnoi();
                    string sql = "INSERT INTO teamleader values(N'" + txtten.Text + "'," + txtns.Text + "," + txtluongcb.Text + "," + txttientk.Text + "," + txtluongtn.Text + ")";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadbang();
                }
                else
                {
                    MessageBox.Show("lỗi");
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if(matxt=="")
            {
                matxt = txtten.Text;
            }
            if (txtten.Text == "" || txtns.Text == "" || txtluongcb.Text == "" || txttientk.Text == "" || txtluongtn.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu dữ liệu, yêu cầu bạn nhập đầy đủ thông tin trước khi thêm !!!!", "Warning");
            }
            else
            {
                if (isnumber(txtns.Text) || isnumber(txtluongcb.Text) || isnumber(txttientk.Text) || isnumber(txtluongtn.Text))
                {
                    ketnoi();
                    string sql = "UPDATE teamleader set ten = N'" + txtten.Text + "', namsinh = " + txtns.Text + ", mucluong = " + txtluongcb.Text + ", tientk = " + txttientk.Text + ", luongtn = " + txtluongtn.Text + " where ten = N'" + matxt + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadbang();
                    matxt = "";
                }
                else
                {
                    MessageBox.Show("lỗi");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu dữ liệu, yêu cầu bạn nhập tên trước khi thêm !!!!", "Warning");
            }
            else
            {
                ketnoi();
                string sql = "Delete from teamleader  where ten = N'" + txtten.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                loadbang();
            }    
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtten.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtns.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtluongcb.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txttientk.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txtluongtn.Text = dgv.CurrentRow.Cells[4].Value.ToString();
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentRow.Index ==0)
            {
                MessageBox.Show("Bạn đang ở đầu bảng");
            }    
            else
            {
                dgv.CurrentCell = dgv.Rows[0].Cells[0];
            }              
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;
            if (dgv.CurrentRow.Index == 0)
            {
                MessageBox.Show("Bạn đang ở đầu bảng");
            }
            else
            {
                dgv.CurrentCell = dgv.Rows[index - 1].Cells[0];
            }
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;
            if (index == dgv.RowCount-1)
            {
                MessageBox.Show("Bạn đang ở cuối bảng");
            }
            else
            {
                dgv.CurrentCell = dgv.Rows[index + 1].Cells[0];
            }
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;
            if (index == dgv.RowCount - 1)
            {
                MessageBox.Show("Bạn đang ở đầu bảng");
            }
            else
            {
                dgv.CurrentCell = dgv.Rows[dgv.RowCount - 1].Cells[0];
            }
        }
    }
}
