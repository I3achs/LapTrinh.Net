using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace thucHanh5_11
{
    public partial class Form1 : Form
    {
        // Danh sách khách hàng
        private List<Customer> ctm = new List<Customer>();
        private int currentId = 1; // ID hiện tại để tạo mã khách hàng mới
        private List<Service> services; // Danh sách dịch vụ
        public Form1()
        {
            InitializeComponent();
            InitializeServices(); // Khởi tạo danh sách dịch vụ mặc định
            LoadServices(); // Tải dữ liệu dịch vụ lên DataGridView
            LoadCustomers(); // Tải dữ liệu khách hàng lên ComboBox
            LoadServicesToCheckedListBox(); // Tải danh sách dịch vụ lên CheckedListBox
        }

        // Tải lại dữ liệu khách hàng vào DataGridView
        private void LoadData()
        {
            dtKH.DataSource = null;
            dtKH.DataSource = ctm;
        }

        // Xóa dữ liệu nhập trong TextBox
        private void ClearInputs()
        {
            txtTen.Clear();
            txtSDT.Clear();
            txtDC.Clear();
        }

        // Xử lý sự kiện khi bấm nút Thêm khách hàng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các TextBox có được nhập hay không
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDC.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDC.Focus();
                return;
            }

            // Nếu tất cả các trường đều hợp lệ, thêm khách hàng
            var customer = new Customer
            {
                ID = currentId++,
                Name = txtTen.Text,
                SDT = txtSDT.Text,
                Diachi = txtDC.Text
            };

            ctm.Add(customer); // Thêm khách hàng vào danh sách
            LoadData(); // Tải lại danh sách lên DataGridView
            comboBox1.Items.Add(customer); // Thêm trực tiếp đối tượng Customer vào ComboBox
            comboBox1.DisplayMember = "Name"; // Đặt DisplayMember sau khi thêm
            ClearInputs(); // Xóa dữ liệu nhập
        }

        // Xử lý khi bấm nút Sửa khách hàng
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dtKH.SelectedRows.Count > 0)
            {
                var selectedRow = dtKH.SelectedRows[0];
                var customer = (Customer)selectedRow.DataBoundItem;

                customer.Name = txtTen.Text;
                customer.SDT = txtSDT.Text;
                customer.Diachi = txtDC.Text;
                LoadData();
                ClearInputs();
            }
        }

        // Xử lý khi bấm nút Xóa khách hàng
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtKH.SelectedRows.Count > 0)
            {
                var selectedRow = dtKH.SelectedRows[0];
                var customer = (Customer)selectedRow.DataBoundItem;

                ctm.Remove(customer); // Xóa khách hàng khỏi danh sách
                LoadData();
                ClearInputs();
            }
        }

        // Xử lý khi chọn một hàng trong DataGridView
        private void dtKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dtKH.Rows[e.RowIndex];
                var customer = (Customer)selectedRow.DataBoundItem;

                txtTen.Text = customer.Name;
                txtSDT.Text = customer.SDT;
                txtDC.Text = customer.Diachi;
            }
        }

        // Khởi tạo danh sách dịch vụ mặc định
        private void InitializeServices()
        {
            services = new List<Service>
            {
                new Service("DV001", "Dịch vụ giặt ủi", 50000),
                new Service("DV002", "Dịch vụ sửa chữa", 100000),
                new Service("DV003", "Dịch vụ vệ sinh", 80000),
                new Service("DV004", "Dịch vụ làm tóc", 150000),
                new Service("DV005", "Dịch vụ massage", 200000)
            };
        }

        // Hiển thị dịch vụ vào DataGridView
        private void LoadServices()
        {
            // Thiết lập DataGridView
            dataGridView1.AutoGenerateColumns = false; // Không tự động tạo cột
            dataGridView1.Columns.Clear(); // Xóa các cột cũ

            // Thêm cột vào DataGridView
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mã dịch vụ", DataPropertyName = "MaDV" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên dịch vụ", DataPropertyName = "TenDV" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Giá", DataPropertyName = "GiaDV" });

            // Gán danh sách dịch vụ cho DataGridView
            dataGridView1.DataSource = services;
        }

        // Tải danh sách khách hàng vào ComboBox
        private void LoadCustomers()
        {
            comboBox1.Items.Clear();
            foreach (var customer in ctm)
            {
                comboBox1.Items.Add(customer); // Thêm trực tiếp đối tượng Customer
            }
            comboBox1.DisplayMember = "Name"; // Hiển thị tên khách hàng trong ComboBox
        }
        private void LoadServicesToCheckedListBox()
        {
            checkedListBox1.Items.Clear(); // Xóa các mục cũ
            foreach (var service in services)
            {
                checkedListBox1.Items.Add(service.TenDV); // Thêm dịch vụ vào CheckedListBox
            }
        }


        // Xử lý sự kiện khi bấm nút Tạo hóa đơn
        private void btnHdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            Customer selectedCustomer = (Customer)comboBox1.SelectedItem;
            decimal totalAmount = 0;

            string invoice = $"Hóa đơn dịch vụ:{Environment.NewLine}Tên khách hàng: {selectedCustomer.Name}{Environment.NewLine}Số điện thoại: {selectedCustomer.SDT}{Environment.NewLine}Địa chỉ: {selectedCustomer.Diachi}{Environment.NewLine}{Environment.NewLine}";
            invoice += "Dịch vụ đã chọn:" + Environment.NewLine;

            foreach (var item in checkedListBox1.CheckedItems)
            {
                var selectedService = services.FirstOrDefault(s => s.TenDV == item.ToString());
                if (selectedService != null)
                {
                    invoice += $"{selectedService.TenDV} - {selectedService.GiaDV} VNĐ{Environment.NewLine}";
                    totalAmount += selectedService.GiaDV;
                }
            }

            invoice += $"{Environment.NewLine}Tổng tiền: {totalAmount} VNĐ";

            // Hiển thị hóa đơn trong TextBox
            txtThongTinHoaDon.Text = invoice;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }
    }
}
