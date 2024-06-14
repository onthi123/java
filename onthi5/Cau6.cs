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

namespace onthi5
{
    public partial class Cau6 : Form
    {
        public Cau6()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter adapter;
        DataSet ds;

        public void ketnoi()
        {
            String kn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Application.StartupPath}\qlsinhvien.mdf"";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(kn);
            con.Open();
        }

        public void hienthi()
        {
            ketnoi();
            String sql = "SELECT * FROM sinhvien";
            adapter = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            adapter.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
            cboKhoa.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtque.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void Cau6_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtten.Clear();
            dtNgaySinh.CustomFormat = "";
            dtNgaySinh.Format = DateTimePickerFormat.Custom;
            //cboKhoa.Text = "";
            cboKhoa.SelectedIndex = -1;
            txtque.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                String sql = "INSERT INTO sinhvien VALUES(N'"+txtma.Text+"',N'"+txtten.Text+"','"+dtNgaySinh.Value+"', N'"+cboKhoa.Text+"',N'"+txtque.Text+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("thanh cong");
                    hienthi();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("loi");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                String sql = "UPDATE sinhvien SET hoten = N'" + txtten.Text + "', ngaysinh = '" + dtNgaySinh.Value + "',khoa = N'" + cboKhoa.SelectedItem + "', quequan = N'" + txtque.Text + "' WHERE masinhvien = N'" + txtma.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("thanh cong");
                    hienthi();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("loi");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                String sql = "DELETE FROM sinhvien WHERE masinhvien = N'" + txtma.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = cmd.ExecuteNonQuery();
                if(kq > 0)
                {
                    MessageBox.Show("thanh cong");
                    hienthi();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("loi");
            }
        }
    }
}
