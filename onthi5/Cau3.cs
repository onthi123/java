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
    public partial class Cau3 : Form
    {
        public Cau3()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter adapter;
        DataSet ds;

        public void connect()
        {
            String kn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Application.StartupPath}\qlxebuyt.mdf"";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(kn);

            con.Open();
        }

        public void showData()
        {
            connect();
            String sql = "select * from dsxe";
            adapter  = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            adapter.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cau3_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnhan.Clear();
            txtsoghe.Clear();
            txtgia.Clear();
            txttuyen.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                //String sql = "insert into dsxe values(n'" + txtnhan.Text + "', " + txtsoghe.Text + ", " + txtgia.Text + ", " + txttuyen.Text + ")";
                String sql = "insert into dsxe values(@nhan, @soghe, @gia, @tuyen)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nhan", txtnhan.Text);
                cmd.Parameters.AddWithValue("@soghe", txtsoghe.Text);
                cmd.Parameters.AddWithValue("@gia", txtgia.Text);
                cmd.Parameters.AddWithValue("@tuyen", txttuyen.Text);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Them thanh cong");
                    showData();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("loi");
            }
        }
    }
}
