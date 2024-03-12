
namespace B211200039
{
    partial class MenuForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OyuncuAdiTextBox = new System.Windows.Forms.TextBox();
            this.KalanTextBox = new System.Windows.Forms.TextBox();
            this.SureText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.basla = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 54);
            this.label5.TabIndex = 0;
            this.label5.Text = "En İyi Beş Skoru Görmek\r\nİçin Tıklayınız\r\n\r\n\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 54);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tuş Takım Bilgisi\r\nİçin Tıklayınız\r\n\r\n\r\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 131);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oyuna Başlamak İçin\r\nBaşla Butonuna Basınız.\r\nOyun Ekrana Geldiğin de\r\nEnter Tuşu" +
    "na Basarak Oyunu\r\nBaşlatınız.\r\n\r\n";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 75);
            this.label2.TabIndex = 3;
            this.label2.Text = "\r\nSkorunuz=(Yaptığınız Ürün sayısı)*10-(Kalan Ürün Sayısı)*10+(Süpriz Kutudan Çık" +
    "an Değer)*5.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.OyuncuAdiTextBox);
            this.panel1.Controls.Add(this.KalanTextBox);
            this.panel1.Controls.Add(this.SureText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(317, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 143);
            this.panel1.TabIndex = 4;
            // 
            // OyuncuAdiTextBox
            // 
            this.OyuncuAdiTextBox.Location = new System.Drawing.Point(137, 91);
            this.OyuncuAdiTextBox.Name = "OyuncuAdiTextBox";
            this.OyuncuAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.OyuncuAdiTextBox.TabIndex = 5;
            this.OyuncuAdiTextBox.TextChanged += new System.EventHandler(this.OyuncuAdiTextBox_TextChanged);
            // 
            // KalanTextBox
            // 
            this.KalanTextBox.Location = new System.Drawing.Point(137, 57);
            this.KalanTextBox.Name = "KalanTextBox";
            this.KalanTextBox.Size = new System.Drawing.Size(100, 20);
            this.KalanTextBox.TabIndex = 4;
            this.KalanTextBox.TextChanged += new System.EventHandler(this.KalanTextBox_TextChanged);
            // 
            // SureText
            // 
            this.SureText.Location = new System.Drawing.Point(137, 23);
            this.SureText.Name = "SureText";
            this.SureText.Size = new System.Drawing.Size(100, 20);
            this.SureText.TabIndex = 3;
            this.SureText.TextChanged += new System.EventHandler(this.SureText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "SİPARİŞ ADEDİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "MÜŞTERİ ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SÜRE:";
            // 
            // basla
            // 
            this.basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basla.Location = new System.Drawing.Point(358, 248);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(198, 81);
            this.basla.TabIndex = 5;
            this.basla.Text = "BAŞLA";
            this.basla.UseVisualStyleBackColor = true;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 97);
            this.label8.TabIndex = 6;
            this.label8.Text = "Süpriz Kutudan \r\n-1 Veya +1 değeri\r\nÇıkabilir.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.basla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "MenuForm";
            this.Text = "MENÜ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OyuncuAdiTextBox;
        public System.Windows.Forms.TextBox KalanTextBox;
        private System.Windows.Forms.TextBox SureText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.Label label8;
    }
}

