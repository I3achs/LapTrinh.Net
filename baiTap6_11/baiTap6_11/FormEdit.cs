using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace baiTap6_11
{
    public partial class FormEdit : Form
    {
        private Connection conn = new Connection();
        private string MaSP;
        public FormEdit(string maSP, string tenSP, decimal donGia, string maLoai)
        {
            InitializeComponent();
            this.MaSP = maSP;
            textBox1.Text = maSP;  // Điền mã sản phẩm vào TextBox
            textBox4.Text = tenSP;  // Điền tên sản phẩm
            textBox3.Text = donGia.ToString();  // Điền đơn giá
            textBox2.Text = maLoai;  // Điền mã loại
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newTenSP = textBox4.Text;
            decimal newDonGia = decimal.Parse(textBox3.Text);
            string newMaLoai = textBox2.Text;

            // Cập nhật thông tin sản phẩm trong cơ sở dữ liệu
            conn.UpdateProduct(MaSP, newTenSP, newDonGia, newMaLoai);

            // Đóng form và trả về kết quả OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
