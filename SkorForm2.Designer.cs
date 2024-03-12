
namespace B211200039
{
    partial class SkorForm2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.İsimlerLabel = new System.Windows.Forms.Label();
            this.SkorLabel = new System.Windows.Forms.Label();
            this.SkorForm2Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.SkorLabel);
            this.panel1.Controls.Add(this.İsimlerLabel);
            this.panel1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(60, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 130);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "En İyi Beş Skor:";
            // 
            // İsimlerLabel
            // 
            this.İsimlerLabel.AutoSize = true;
            this.İsimlerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.İsimlerLabel.Location = new System.Drawing.Point(34, 11);
            this.İsimlerLabel.Name = "İsimlerLabel";
            this.İsimlerLabel.Size = new System.Drawing.Size(41, 17);
            this.İsimlerLabel.TabIndex = 3;
            this.İsimlerLabel.Text = "label2";
            // 
            // SkorLabel
            // 
            this.SkorLabel.AutoSize = true;
            this.SkorLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkorLabel.Location = new System.Drawing.Point(117, 11);
            this.SkorLabel.Name = "SkorLabel";
            this.SkorLabel.Size = new System.Drawing.Size(45, 17);
            this.SkorLabel.TabIndex = 4;
            this.SkorLabel.Text = "label1";
            // 
            // SkorForm2Timer
            // 
            this.SkorForm2Timer.Interval = 5000;
            this.SkorForm2Timer.Tick += new System.EventHandler(this.SkorForm2Timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SkorForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(329, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "SkorForm2";
            this.Text = "En İyi Beş Skor";
            this.Load += new System.EventHandler(this.SkorForm2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SkorLabel;
        private System.Windows.Forms.Label İsimlerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SkorForm2Timer;
        private System.Windows.Forms.Timer timer1;
    }
}