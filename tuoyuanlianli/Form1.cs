using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace tuoyuanlianli
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

        private void go_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox_a.Text);
                double b = double.Parse(textBox_b.Text);
                if (b > a) { var c = a; a = b; b = c; };
                double k = double.Parse(textBox_k.Text);
                double b2 = double.Parse(textBox_b2.Text);
                double 二次项系数 = (Math.Pow(b, 2) / Math.Pow(a, 2)) + Math.Pow(k, 2);
                double 一次项系数 = 2 * k * b2 / 二次项系数;
                double 常数项 = Math.Pow(b2, 2) - Math.Pow(b, 2) / 二次项系数;
                StringBuilder str = new();
                str.Append("x²+").Append(Math.Round(一次项系数, 2)).Append("x+").Append(Math.Round(常数项, 2)).Append("=0");
                str.Replace("-+", "-");
                label1.Text = str.ToString();
            }
            catch (Exception) 
            {
                label1.Text = "输入错误！";
            }
        }
    }
}