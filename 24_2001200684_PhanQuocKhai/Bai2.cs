using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_2001200684_PhanQuocKhai
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "X^2 +";
            label3.Text = "X +";
            textBox3.Text = "";
            bttinhnghiem.Text = "Tính nghiệm";
            bttinhnghiem.Click += bttinhnghiem_Click;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.clearAll();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void clearAll() {
            labelResult.Text = "";
            labelx1.Text = "";
            labelx2.Text = "";
        }
        private void bttinhnghiem_Click(object sender, EventArgs e)
        {
            this.clearAll();
            double a, b, c;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b) && double.TryParse(textBox3.Text, out c))
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    labelResult.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    labelResult.Text = "Phương trình có nghiệm kép:";
                    labelx1.Text = "X1 = X2 = " + x;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    labelResult.Text = "Phương trình có hai nghiệm phân biệt:";
                    labelx1.Text = "X1 = " + x1;
                    labelx2.Text = "X2 = " + x2;
                }
            }
            else
            {
                labelResult.Text = "Vui lòng nhập hệ số hợp lệ!";
            }
        }
    }
}