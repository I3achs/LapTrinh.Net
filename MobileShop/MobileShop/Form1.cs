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

namespace MobileShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = taikhoan.Text;
            string password = matkhau.Text;
            string stringConnect = "Server=localhost; Database=MobileShop; User Id=sa; Password=11111";

            using (SqlConnection conn = new SqlConnection(stringConnect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NguoiDung WHERE tenDN = @username AND MK = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    FormMain mainForm = new FormMain();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
        }
    }
}
