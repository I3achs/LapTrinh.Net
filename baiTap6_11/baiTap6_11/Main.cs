using System.Data;
using System.Xml.Linq;

namespace baiTap6_11
{
    public partial class Main : Form
    {
        private Connection conn = new Connection();
        private bool isEditing = false;
        public Main()
        {
            InitializeComponent();
            LoadProducts();
            LockFields();
        }

        private void LoadProducts()
        {
            DataTable products = conn.GetProducts();
            dataGridView1.DataSource = products;
        }
        private void ClearFields()
        {
            textMa.Clear();
            textTen.Clear();
            textGia.Clear();
            textLoai.Clear();
            txtTim.Clear(); // Clear search field
        }
        private void LockFields()
        {
            textMa.Enabled = false;
            textTen.Enabled = false;
            textGia.Enabled = false;
            textLoai.Enabled = false;
        }
        private void UnlockFields()
        {
            textMa.Enabled = true;
            textTen.Enabled = true;
            textGia.Enabled = true;
            textLoai.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                textMa.Text = selectedRow.Cells["MaSP"].Value.ToString();
                textTen.Text = selectedRow.Cells["TenSP"].Value.ToString();
                textGia.Text = selectedRow.Cells["DonGia"].Value.ToString();
                textLoai.Text = selectedRow.Cells["Maloai"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string MaSP = selectedRow.Cells["MaSP"].Value.ToString(); // Lưu mã sản phẩm hiện tại

                // Hiển thị hộp thoại xác nhận
                var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm này không?\n\n" +
                                             $"Mã sản phẩm: {textMa.Text}\n" +
                                             $"Tên sản phẩm: {textTen.Text}\n" +
                                             $"Đơn giá: {textGia.Text}\n" +
                                             $"Mã loại: {textLoai.Text}",
                                             "Xác nhận xóa",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                // Nếu người dùng chọn "Có", thực hiện xóa
                if (confirmResult == DialogResult.Yes)
                {
                    conn.DeleteProduct(MaSP); // Gọi phương thức xóa trong DatabaseHelper
                    LoadProducts(); // Tải lại danh sách sản phẩm
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields(); // Xóa các trường khi thêm
            UnlockFields(); // Mở khóa các TextBox để nhập liệu
            isEditing = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Lấy thông tin sản phẩm được chọn
                string MaSP = selectedRow.Cells["MaSP"].Value.ToString();
                string TenSP = selectedRow.Cells["TenSP"].Value.ToString();
                decimal DonGia = decimal.Parse(selectedRow.Cells["DonGia"].Value.ToString());
                string Maloai = selectedRow.Cells["Maloai"].Value.ToString();

                // Mở form sửa và truyền dữ liệu sản phẩm vào
                FormEdit editForm = new FormEdit(MaSP, TenSP, DonGia, Maloai);
                DialogResult result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Nếu người dùng nhấn "Lưu" trong form sửa, tải lại danh sách sản phẩm
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text;
            DataTable searchResults = conn.SearchProducts(keyword);
            dataGridView1.DataSource = searchResults;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                conn.AddProduct(textMa.Text, textTen.Text, decimal.Parse(textGia.Text), int.Parse(textLoai.Text));
                LoadProducts();
                LockFields(); // Khóa lại các TextBox sau khi lưu
                ClearFields();
                isEditing = false; // Đặt lại trạng thái
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LockFields(); // Khóa lại các TextBox
            ClearFields(); // Xóa các trường
            isEditing = false; // Đặt lại trạng thái
        }
    }
}
