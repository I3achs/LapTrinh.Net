using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FormCal
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool c = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnNumber(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((textBox1.Text == "0") || (c))
                textBox1.Clear();
            c = false;
            textBox1.Text += btn.Text;
        }
        private void btnOperator(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (result != 0)
            {
                button15.PerformClick();
                operation = btn.Text;
                c = true;
            }
            else
            {
                operation = btn.Text;
                result = double.Parse(textBox1.Text);
                c = true;
            }
        }
        private void btnEquals(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        textBox1.Text = (result + double.Parse(textBox1.Text)).ToString(); break;
                    case "-":
                        textBox1.Text = (result - double.Parse(textBox1.Text)).ToString(); break;
                    case "*":
                        textBox1.Text = (result * double.Parse(textBox1.Text)).ToString(); break;
                    case "/":
                        if(double.Parse(textBox1.Text) == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "0";
                        }
                        else
                        {
                            textBox1.Text = (result / double.Parse(textBox1.Text)).ToString(); break;
                        }
                        break;
                }
                result = double.Parse(textBox1.Text);
                operation = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể chia cho 0!" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnC(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
