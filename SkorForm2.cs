using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace B211200039
{
    public partial class SkorForm2 : Form
    {
        public SkorForm2()
        {
            InitializeComponent();
        }

        private void SkorForm2_Load(object sender, EventArgs e)
        {
            SkorForm2Timer.Start();
            timer1.Start();
        }

        private void SkorForm2Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dosya_adi = "skor.txt";
            string dosya_yolu = Application.StartupPath + @"\skor.txt";
            string hedef_yol = Path.Combine(dosya_yolu, dosya_adi);
            string isim_dosya_yolu = Application.StartupPath + @"\isim.txt";

            string oku = File.ReadAllText(dosya_yolu);
            string oku2 = File.ReadAllText(isim_dosya_yolu);

            SkorLabel.Text = oku;
            İsimlerLabel.Text = oku2;
        }
    }
}
