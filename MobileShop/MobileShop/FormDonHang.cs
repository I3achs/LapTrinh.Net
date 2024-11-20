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
    public partial class FormDonHang : Form
    {
        private SqlConnection conn;
        public FormDonHang()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = localhost; Database = MobileShop; User Id = sa; Password = 11111");
            LoadData();
        }
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DonHang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM DonHang WHERE idKH = @khachhangid", conn))
            {
                cmd.Parameters.AddWithValue("@khachhangid", txtIDKH.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO DonHang (idKH, idSP, soluong, ngaymua) VALUES (@khachhangid, @sanphamid, @soluong, @ngaymua)", conn))
            {
                cmd.Parameters.AddWithValue("@khachhangid", txtIDKH.Text);
                cmd.Parameters.AddWithValue("@sanphamid", txtIDSP.Text);
                cmd.Parameters.AddWithValue("@soluong", txtSL.Text);
                cmd.Parameters.AddWithValue("@ngaymua", DateTime.Now);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE DonHang SET idKH = @khachhangid, idSP = @sanphamid, soluong = @soluong WHERE idKH = @khachhangid", conn))
            {
                //cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@khachhangid", txtIDKH.Text);
                cmd.Parameters.AddWithValue("@sanphamid", txtIDSP.Text);
                cmd.Parameters.AddWithValue("@soluong", txtSL.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
            }
        }
    }
}
