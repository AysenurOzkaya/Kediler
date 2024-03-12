using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B211200039.Somut;
using B211200039.Enum;

namespace B211200039
{
    //Ayşenur Özkaya B211200039
    public partial class OyunForm : Form
    {
        SkorForm skorForm2 = new SkorForm();
        Oyun oyun;
        public OyunForm()
        {
            InitializeComponent();
            oyun = new Oyun(OyunAlaniPanel, GorunmezLabel);
        }


        int gerisayim;



        private void OyuncuLabel_TextChanged(object sender, EventArgs e)
        {
            skorForm2.SkorunSahibiLabel.Text = OyuncuLabel.Text;
        }

        private void GerisayimTimer_Tick(object sender, EventArgs e)
        {
            GerisayimTimer.Interval = 1000;
            gerisayim = gerisayim - 1;
            SureLabel.Text = Convert.ToString(gerisayim);


            if (gerisayim == 0)
            {
                skorForm2.Show();
                this.Close();
            }
        }

        private void ToplamYapilanLabelTimer_Tick(object sender, EventArgs e)
        {
            ToplamYapilanLabelTimer.Interval = 50;
            ToplamYapilanLabel.Text = Convert.ToString(oyun.UrunOlustur());

            skorForm2.skorLabel.Text = Convert.ToString(oyun.SkorHesapla());
            skorForm2.YakalananArtiKutuLabel.Text = Convert.ToString(oyun.sayk1());
            skorForm2.KalanUrunSayisiSkorLabel.Text = Convert.ToString(oyun.sayKalanUrun());

            Malzeme1Label.Text = Convert.ToString(oyun.say1());
            Malzeme2Label.Text = Convert.ToString(oyun.say2());
            Malzeme3Label.Text = Convert.ToString(oyun.say3());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 55;
            KalanLabel.Text = Convert.ToString(oyun.KalanUrunHesapla());
        }

        private void OyunForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {

                        GerisayimTimer.Start();
                        gerisayim = Convert.ToInt32(SureLabel.Text);
                        oyun.basla();
                        ToplamYapilanLabelTimer.Start();
                        timer1.Start();

                    }
                    break;
                case Keys.P:
                    {
                        oyun.duraklat();
                        GerisayimTimer.Stop();
                        ToplamYapilanLabelTimer.Stop();
                        timer1.Stop();
                    }
                    break;


                case Keys.Right:
                    oyun.toplayiciHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    oyun.toplayiciHareketEttir(Yon.Sola);
                    break;
            }
        }

        private void ToplamYapilanLabel_TextChanged(object sender, EventArgs e)
        {
            skorForm2.SiparisUrunSayisiLabel.Text = ToplamYapilanLabel.Text;
        }
    }
}
