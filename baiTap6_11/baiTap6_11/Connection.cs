using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace baiTap6_11
{
    internal class Connection
    {
        private string connectionString = "Data Source=LAPTOP-JMI09MML;Initial Catalog=QLSanpham;Integrated Security=True;TrustServerCertificate=True";

        public DataTable GetProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sanpham", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void AddProduct(string MaSP, string TenSP, decimal DonGia, int Maloai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Sanpham (MaSP, TenSP, DonGia, Maloai) VALUES (@TenSP, @TenSP, @DonGia, @Maloai)", conn);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
                cmd.Parameters.AddWithValue("@TenSP", TenSP);
                cmd.Parameters.AddWithValue("@DonGia", DonGia);
                cmd.Parameters.AddWithValue("@Maloai", Maloai);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(string MaSP, string TenSP, decimal DonGia, string Maloai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Sanpham SET TenSP = @TenSP, MaSP = @MaSP, DonGia = @DonGia, Maloai = @Maloai WHERE MaSP = @MaSP", conn);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
                cmd.Parameters.AddWithValue("@TenSP", TenSP);
                cmd.Parameters.AddWithValue("@DonGia", DonGia);
                cmd.Parameters.AddWithValue("@Maloai", Maloai);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(string MaSP)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Sanpham WHERE MaSP = @MaSP", conn);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SearchProducts(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Sanpham WHERE TenSP LIKE @Keyword", conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
