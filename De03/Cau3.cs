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
    public partial class Cau3 : Form
    {
        int index = -1;
        SqlConnection conn;
        SqlDataAdapter adp;
        DataTable dt;
        public Cau3()
        {
            InitializeComponent();
            loadbang();
        }
        public SqlConnection getcon()
        {
            return conn;
        }
        public void ketnoi()
        {
            string ketnoi = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\qlcauthu_tdt.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(ketnoi);
            conn.Open();
        }
        public void loadbang()
        {
            ketnoi();
            string sql = " SELECT * FROM cauthu";
            adp = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adp.Fill(dt);
            if(index>= 0 && index<dt.Rows.Count)
            {
                txtma.Text = dt.Rows[index][0].ToString();
                txtten.Text = dt.Rows[index][1].ToString();
                txtns.Text = dt.Rows[index][2].ToString();
                txtqq.Text = dt.Rows[index][3].ToString();
            }    
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ketnoi();
            string sql = "Update cauthu set hoten = N'" + txtten.Text + "',ngaysinh = N'" + txtns.Text + "',quequan = N'" + txtqq.Text + "' where mact =  N'" + txtma.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            loadbang();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            themcauthu fr = new themcauthu();
            fr.Show();
            loadbang();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
             if(index ==0)
            {
                MessageBox.Show("Bạn đang ở đầu danh sách");
            }
             else
            {
                index = 0;
                loadbang();
            }    
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (index <= 0)
            {
                index = 0;
                MessageBox.Show("Bạn đang ở đầu danh sách");
            }
            else
            {
                index = index-1;
                loadbang();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (index >= dt.Rows.Count-1)
            {
                index = dt.Rows.Count - 1;
                MessageBox.Show("Bạn đang ở cuối danh sách");
            }
            else
            {
                index += 1;
                loadbang();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (index >= dt.Rows.Count - 1)
            {
                
                MessageBox.Show("Bạn đang ở cuối danh sách");
            }
            else
            {
                index = dt.Rows.Count - 1;
                loadbang();
            }
        }
    }
}
