using System.Numerics;
using System.Windows.Forms;

namespace KiemTra01
{
    public partial class Form1 : Form
    {
        private ShoppingCart spc;
        public Form1()
        {
            InitializeComponent();
            spc = new ShoppingCart();
            //LoadProducts();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Name", "Tên sản phẩm");
            dataGridView1.Columns.Add("Price", "Giá");
            dataGridView1.Columns.Add("Image", "Ảnh");

            dataGridView2.Columns.Add("Name", "Tên sản phẩm");
            dataGridView2.Columns.Add("Price", "Giá");
            dataGridView2.Columns.Add("Quantity", "Số lượng");
            //dataGridView2.Columns.Add("Total", "Tổng giá");

            LoadProducts();
        }
        private void LoadProducts()
        {
            Product pr1 = new Product("Sản phẩm 1", 11111, "");
            Product pr2 = new Product("Sản phẩm 2", 22222, "");

            dataGridView1.Rows.Add(pr1.Name, pr1.Price, pr1.Image);
            dataGridView1.Rows.Add(pr2.Name, pr2.Price, pr2.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                decimal price = (decimal)selectedRow.Cells["Price"].Value;

                Product selectedPr = new Product(name, price, "", 1);
                spc.Add(selectedPr);

                UpdateCart();
            }
        }
        private void UpdateCart()
        {
            dataGridView2.Rows.Clear();
            foreach (var item in spc.GetProduct())
            {
                decimal total = item.Key.Price * item.Value;
                dataGridView2.Rows.Add(item.Key.Name, item.Key.Price, item.Value, total);
            }
            label1.Text = $"Tổng giá trị: {spc.TotalPrice()} VND";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView2.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                var productRemove = spc.GetProduct().FirstOrDefault(p => p.Key.Name == name);
                if (productRemove.Key != null)
                {
                    spc.Remove(productRemove.Key);
                    UpdateCart();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                spc.Clear();
                UpdateCart();
                MessageBox.Show("Thanh toán thành công.");
            }
        }
    }
}
