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
    public partial class GiaiPT : Form
    {
        public GiaiPT()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
                this.Close();
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            double a, b;
            if (radioButton1_PT1.Checked && !radioButton2_PT2.Checked) MessageBox.Show("Bạn hãy chọn 1 phương trình để giải", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(!double.TryParse(this.txta.Text, out a) || a==0) MessageBox.Show("a phải là số và a khác 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(!double.TryParse(this.txtb.Text, out b) || a==0) MessageBox.Show("b phải là số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(radioButton1_PT1.Checked)
            {
                this.txtKetQua.Text = "Phương Trình có nghiệm \t x = " + Math.Round(-b / a, 2).ToString();
            }
            else
            {
                double c;
                if (!double.TryParse(this.txtc.Text, out c) || a == 0) MessageBox.Show("c phải là số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                double del = b * b - 4 * a * c;
                if (del == 0) this.txtKetQua.Text = "Phương Trình có 2 nghiệm \t x1 = x2 = " + Math.Round(-b / 2 / a, 2);
                else if (del < 0) this.txtKetQua.Text = "Phương Trình Vô Nghiệm";
                else
                {
                    double x1 = Math.Round((-b - Math.Sqrt(del)) / 2 / a, 2);
                    double x2 = Math.Round((-b + Math.Sqrt(del)) / 2 / a, 2);
                    this.txtKetQua.Text = "Phương Trình có hai nghiệm phân biệt x1 = " + x1 + "x2 = " + x2;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1_PT1.Checked)
            this.txtc.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2_PT2.Checked)
            {
                this.txtc.Enabled = true;
            }

        }

    }
}
