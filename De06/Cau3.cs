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

namespace De06
{
    public partial class Cau3 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adp;
        DataSet ds;
        public Cau3()
        {
            InitializeComponent();
        }
        public void ketnoi()
        {
            string sql = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QLSinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(sql);
            conn.Open();
        }
        public void loadbang()
        {
            ketnoi();
            string sql = "SELECT * FROM Sinhvien";
            adp = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dt.Clear();
            adp.Fill(dt);
            dgv.DataSource = dt;
        }
        private void Cau3_Load(object sender, EventArgs e)
        {
            loadbang();
        }
        public bool isrealnumber(String str)
        {
            try
            {
                float.Parse(str);
                return true;
            }
            catch (Exception ex)
            {
               return false;
            }
        }
        public bool isnumber(String str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
               if(txtma.Text =="" || txtten.Text =="" || txtns.Text =="" || txtcn.Text =="" || txtdtb.Text=="")
                {
                    MessageBox.Show("Bạn nhập thiếu giá trị rồi!!!!");
                }
               else 
               {
                    if (!isnumber(txtns.Text))
                        MessageBox.Show("Bạn nhập sai dữ liệu ô năm sinh yêu cầu dạng số nguyên!!!!");
                    if (!isrealnumber(txtdtb.Text))
                        MessageBox.Show("Bạn nhập sai dữ liệu ô điểm trung bình yêu cầu dạng số thực!!!!");
                    if(isnumber(txtns.Text) && isrealnumber(txtdtb.Text))
                    {
                        string sql = "INSERT INTO Sinhvien values(N'" + txtma.Text + "',N'" + txtten.Text + "'," + txtns.Text + ",N'" + txtcn.Text + "'," + txtdtb.Text + ")";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        loadbang();
                    }    
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn nhập trùng dữ liệu mã sinh viên");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtma.Text == "" || txtten.Text == "" || txtns.Text == "" || txtcn.Text == "" || txtdtb.Text == "")
                {
                    MessageBox.Show("Bạn nhập thiếu giá trị rồi!!!!");
                }
                else
                {
                    if (!isnumber(txtns.Text))
                        MessageBox.Show("Bạn nhập sai dữ liệu ô năm sinh yêu cầu dạng số nguyên!!!!");
                    if (!isrealnumber(txtdtb.Text))
                        MessageBox.Show("Bạn nhập sai dữ liệu ô điểm trung bình yêu cầu dạng số thực!!!!");
                    if (isnumber(txtns.Text) && isrealnumber(txtdtb.Text))
                    {
                        string sql = "UPDATE sinhvien set hoten = N'"+txtten.Text+"', namsinh = "+txtns.Text+", chuyennganh = N'"+txtcn.Text+"', diemtb = "+txtdtb.Text+" where masv =  N'"+txtma.Text+"'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        loadbang();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn nhập trùng dữ liệu mã sinh viên");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show(" Không thể xoá vì Bạn nhập thiếu giá trị ở ô mã sinh viên rồi!!!!");
            }
            else
            {
                string sql = "Delete from sinhvien where masv = N'" + txtma.Text + "'";
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
            txtma.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtns.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtcn.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txtdtb.Text = dgv.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
