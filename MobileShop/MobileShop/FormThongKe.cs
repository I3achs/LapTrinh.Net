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
    public partial class FormThongKe : Form
    {
        private SqlConnection conn;
        public FormThongKe()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = localhost; Database = MobileShop; User Id = sa; Password = 11111");
            loadData();
        }
        private void loadData()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"
                                    SELECT MONTH(ngaymua) AS Thang, 
                                    SUM(soluong * gia) AS DoanhThu 
                                    FROM DonHang 
                                    JOIN SanPham ON DonHang.idSP = SanPham.idSP 
                                    GROUP BY MONTH(ngaymua)", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
