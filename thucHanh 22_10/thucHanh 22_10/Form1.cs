namespace thucHanh_22_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "1234")
            {
                
                MessageBox.Show("Đăng nhập thành công!", "Đăng nhập");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.", "Đăng nhập");
            }
        }
    }
}
