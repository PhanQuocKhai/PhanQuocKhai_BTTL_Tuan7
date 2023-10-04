namespace _24_2001200684_PhanQuocKhai
{
    partial class GiaiPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2_PT2 = new System.Windows.Forms.RadioButton();
            this.radioButton1_PT1 = new System.Windows.Forms.RadioButton();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.btGiai = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2_PT2);
            this.groupBox1.Controls.Add(this.radioButton1_PT1);
            this.groupBox1.Location = new System.Drawing.Point(92, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn Vui Lòng Chọn";
            // 
            // radioButton2_PT2
            // 
            this.radioButton2_PT2.AutoSize = true;
            this.radioButton2_PT2.Location = new System.Drawing.Point(53, 67);
            this.radioButton2_PT2.Name = "radioButton2_PT2";
            this.radioButton2_PT2.Size = new System.Drawing.Size(151, 17);
            this.radioButton2_PT2.TabIndex = 1;
            this.radioButton2_PT2.TabStop = true;
            this.radioButton2_PT2.Text = "Giải Phương Trình Bậc Hai";
            this.radioButton2_PT2.UseVisualStyleBackColor = true;
            this.radioButton2_PT2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1_PT1
            // 
            this.radioButton1_PT1.AutoSize = true;
            this.radioButton1_PT1.Location = new System.Drawing.Point(53, 29);
            this.radioButton1_PT1.Name = "radioButton1_PT1";
            this.radioButton1_PT1.Size = new System.Drawing.Size(158, 17);
            this.radioButton1_PT1.TabIndex = 0;
            this.radioButton1_PT1.TabStop = true;
            this.radioButton1_PT1.Text = "Giải Phương Trình Bậc Nhất";
            this.radioButton1_PT1.UseVisualStyleBackColor = true;
            this.radioButton1_PT1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(191, 172);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(191, 213);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 2;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(191, 258);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 3;
            // 
            // btGiai
            // 
            this.btGiai.Location = new System.Drawing.Point(391, 172);
            this.btGiai.Name = "btGiai";
            this.btGiai.Size = new System.Drawing.Size(75, 23);
            this.btGiai.TabIndex = 4;
            this.btGiai.Text = "Giải";
            this.btGiai.UseVisualStyleBackColor = true;
            this.btGiai.Click += new System.EventHandler(this.btGiai_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(391, 229);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhập b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kết Quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(191, 294);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(259, 74);
            this.txtKetQua.TabIndex = 11;
            // 
            // GiaiPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 395);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btGiai);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.groupBox1);
            this.Name = "GiaiPT";
            this.Text = "Bai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Button btGiai;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.RadioButton radioButton2_PT2;
        private System.Windows.Forms.RadioButton radioButton1_PT1;
    }
}