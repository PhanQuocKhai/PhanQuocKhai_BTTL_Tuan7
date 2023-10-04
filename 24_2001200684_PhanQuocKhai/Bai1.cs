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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void clearAll() {
            labelResult.Text = "";
        }
        private void btnInSNT_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtInput.Text, out num))
            {
                if (num >= 2)
                {
                    labelResult.Text = "Các số nguyên tố từ 1 đến " + num + " là:\n";
                    for (int i = 2; i <= num; i++)
                    {
                        if (IsPrime(i))
                        {
                            labelResult.Text += i + " ";
                        }
                    }
                }
                else
                {
                    labelResult.Text = "Vui lòng nhập số nguyên lớn hơn hoặc bằng 2.";
                }
            }
            else
            {
                labelResult.Text = "Vui lòng nhập hệ số hợp lệ!";
            }
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtInput.Text, out num))
            {
                if (IsPrime(num))
                {
                    labelResult.Text = "{num} là số nguyên tố!";
                }
                else
                {
                    labelResult.Text = "{num} không phải là số nguyên tố!";
                }
            }
            else
            {
                labelResult.Text = "Vui lòng nhập hệ số hợp lệ!";
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}