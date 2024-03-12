
namespace B211200039
{
    partial class OyunForm
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
            this.YorumPanel = new System.Windows.Forms.Panel();
            this.OyunAlaniPanel = new System.Windows.Forms.Panel();
            this.GorunmezLabel = new System.Windows.Forms.Label();
            this.SureLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToplamYapilanLabel = new System.Windows.Forms.Label();
            this.KalanLabel = new System.Windows.Forms.Label();
            this.OyuncuLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Malzeme1Label = new System.Windows.Forms.Label();
            this.Malzeme2Label = new System.Windows.Forms.Label();
            this.Malzeme3Label = new System.Windows.Forms.Label();
            this.GerisayimTimer = new System.Windows.Forms.Timer(this.components);
            this.ToplamYapilanLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GorunmezLabel2 = new System.Windows.Forms.Label();
            this.YorumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // YorumPanel
            // 
            this.YorumPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.YorumPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.YorumPanel.Controls.Add(this.GorunmezLabel2);
            this.YorumPanel.Controls.Add(this.Malzeme3Label);
            this.YorumPanel.Controls.Add(this.Malzeme2Label);
            this.YorumPanel.Controls.Add(this.Malzeme1Label);
            this.YorumPanel.Controls.Add(this.label5);
            this.YorumPanel.Controls.Add(this.label4);
            this.YorumPanel.Controls.Add(this.label3);
            this.YorumPanel.Controls.Add(this.OyuncuLabel);
            this.YorumPanel.Controls.Add(this.KalanLabel);
            this.YorumPanel.Controls.Add(this.ToplamYapilanLabel);
            this.YorumPanel.Controls.Add(this.label2);
            this.YorumPanel.Controls.Add(this.label1);
            this.YorumPanel.Controls.Add(this.SureLabel);
            this.YorumPanel.Controls.Add(this.GorunmezLabel);
            this.YorumPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.YorumPanel.Location = new System.Drawing.Point(619, 0);
            this.YorumPanel.Name = "YorumPanel";
            this.YorumPanel.Size = new System.Drawing.Size(181, 450);
            this.YorumPanel.TabIndex = 0;
            // 
            // OyunAlaniPanel
            // 
            this.OyunAlaniPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.OyunAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OyunAlaniPanel.Location = new System.Drawing.Point(0, 0);
            this.OyunAlaniPanel.Name = "OyunAlaniPanel";
            this.OyunAlaniPanel.Size = new System.Drawing.Size(619, 450);
            this.OyunAlaniPanel.TabIndex = 1;
            // 
            // GorunmezLabel
            // 
            this.GorunmezLabel.AutoSize = true;
            this.GorunmezLabel.Location = new System.Drawing.Point(53, 7);
            this.GorunmezLabel.Name = "GorunmezLabel";
            this.GorunmezLabel.Size = new System.Drawing.Size(35, 13);
            this.GorunmezLabel.TabIndex = 0;
            this.GorunmezLabel.Text = "label1";
            this.GorunmezLabel.Visible = false;
            // 
            // SureLabel
            // 
            this.SureLabel.BackColor = System.Drawing.Color.Salmon;
            this.SureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SureLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SureLabel.Location = new System.Drawing.Point(14, 29);
            this.SureLabel.Name = "SureLabel";
            this.SureLabel.Size = new System.Drawing.Size(151, 126);
            this.SureLabel.TabIndex = 1;
            this.SureLabel.Text = "0";
            this.SureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam yapılan:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kalan:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToplamYapilanLabel
            // 
            this.ToplamYapilanLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ToplamYapilanLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToplamYapilanLabel.Location = new System.Drawing.Point(102, 174);
            this.ToplamYapilanLabel.Name = "ToplamYapilanLabel";
            this.ToplamYapilanLabel.Size = new System.Drawing.Size(63, 30);
            this.ToplamYapilanLabel.TabIndex = 14;
            this.ToplamYapilanLabel.Text = "0";
            this.ToplamYapilanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToplamYapilanLabel.TextChanged += new System.EventHandler(this.ToplamYapilanLabel_TextChanged);
            // 
            // KalanLabel
            // 
            this.KalanLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.KalanLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KalanLabel.Location = new System.Drawing.Point(102, 209);
            this.KalanLabel.Name = "KalanLabel";
            this.KalanLabel.Size = new System.Drawing.Size(63, 30);
            this.KalanLabel.TabIndex = 15;
            this.KalanLabel.Text = "0";
            this.KalanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OyuncuLabel
            // 
            this.OyuncuLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.OyuncuLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OyuncuLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OyuncuLabel.Location = new System.Drawing.Point(14, 259);
            this.OyuncuLabel.Name = "OyuncuLabel";
            this.OyuncuLabel.Size = new System.Drawing.Size(151, 52);
            this.OyuncuLabel.TabIndex = 16;
            this.OyuncuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OyuncuLabel.TextChanged += new System.EventHandler(this.OyuncuLabel_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Malzeme2:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Malzeme3:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Malzeme1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Malzeme1Label
            // 
            this.Malzeme1Label.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Malzeme1Label.Location = new System.Drawing.Point(106, 329);
            this.Malzeme1Label.Name = "Malzeme1Label";
            this.Malzeme1Label.Size = new System.Drawing.Size(53, 25);
            this.Malzeme1Label.TabIndex = 20;
            this.Malzeme1Label.Text = "0";
            this.Malzeme1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Malzeme2Label
            // 
            this.Malzeme2Label.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Malzeme2Label.Location = new System.Drawing.Point(106, 365);
            this.Malzeme2Label.Name = "Malzeme2Label";
            this.Malzeme2Label.Size = new System.Drawing.Size(53, 25);
            this.Malzeme2Label.TabIndex = 21;
            this.Malzeme2Label.Text = "0";
            this.Malzeme2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Malzeme3Label
            // 
            this.Malzeme3Label.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Malzeme3Label.Location = new System.Drawing.Point(106, 399);
            this.Malzeme3Label.Name = "Malzeme3Label";
            this.Malzeme3Label.Size = new System.Drawing.Size(53, 25);
            this.Malzeme3Label.TabIndex = 22;
            this.Malzeme3Label.Text = "0";
            this.Malzeme3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GerisayimTimer
            // 
            this.GerisayimTimer.Tick += new System.EventHandler(this.GerisayimTimer_Tick);
            // 
            // ToplamYapilanLabelTimer
            // 
            this.ToplamYapilanLabelTimer.Tick += new System.EventHandler(this.ToplamYapilanLabelTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GorunmezLabel2
            // 
            this.GorunmezLabel2.AutoSize = true;
            this.GorunmezLabel2.Location = new System.Drawing.Point(99, 7);
            this.GorunmezLabel2.Name = "GorunmezLabel2";
            this.GorunmezLabel2.Size = new System.Drawing.Size(35, 13);
            this.GorunmezLabel2.TabIndex = 23;
            this.GorunmezLabel2.Text = "label1";
            this.GorunmezLabel2.Visible = false;
            // 
            // OyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OyunAlaniPanel);
            this.Controls.Add(this.YorumPanel);
            this.Name = "OyunForm";
            this.Text = "OYUN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OyunForm_KeyDown);
            this.YorumPanel.ResumeLayout(false);
            this.YorumPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel YorumPanel;
        private System.Windows.Forms.Label Malzeme3Label;
        private System.Windows.Forms.Label Malzeme2Label;
        private System.Windows.Forms.Label Malzeme1Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label OyuncuLabel;
        public System.Windows.Forms.Label KalanLabel;
        public System.Windows.Forms.Label ToplamYapilanLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label SureLabel;
        public System.Windows.Forms.Label GorunmezLabel;
        public System.Windows.Forms.Panel OyunAlaniPanel;
        private System.Windows.Forms.Timer GerisayimTimer;
        private System.Windows.Forms.Timer ToplamYapilanLabelTimer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label GorunmezLabel2;
    }
}