using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B211200039
{
    //Ayşenur Özkaya B211200039
    public partial class SkorForm : Form
    {

        public SkorForm()
        {
            InitializeComponent();
        }

        private void SkorForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SkorTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }



        private void skortxt()
        {
            string dosya_adi = "skor.txt";
            string dosya_yolu = Application.StartupPath + @"\skor.txt";
            string hedef_yol = System.IO.Path.Combine(dosya_yolu, dosya_adi);
            string isim_dosya_yolu = Application.StartupPath + @"\isim.txt";
            int[] skor1 = new int[5];
            int j;
            int g;
            string isim;
            string sonisim;


            isim = SkorunSahibiLabel.Text;
            j = Convert.ToInt32(skorLabel.Text);


            string[] isimdizi = System.IO.File.ReadAllLines(isim_dosya_yolu);
            string[] skor = System.IO.File.ReadAllLines(dosya_yolu);



            for (int i = 0; i < 5; i++)
            {
                skor1[i] = Convert.ToInt32(skor[i]);
            }



            for (int m = 0; m < 5; m++)
            {
                if (skor1[m] <= j)
                {
                    skor1[4] = j;
                    isimdizi[4] = isim;

                    for (int i = 0; i < skor1.Length - 1; i++)
                    {
                        for (int k = i; k < skor1.Length; k++)
                        {
                            if (skor1[i] <= skor1[k])
                            {
                                sonisim = isimdizi[k];
                                isimdizi[k] = isimdizi[i];
                                isimdizi[i] = sonisim;


                                g = skor1[k];
                                skor1[k] = skor1[i];
                                skor1[i] = g;
                            }

                        }

                    }

                    break;
                }
            }


            for (int i = 0; i < 5; i++)
            {
                skor[i] = Convert.ToString(skor1[i]);
            }

            System.IO.File.WriteAllLines(dosya_yolu, skor);
            System.IO.File.WriteAllLines(isim_dosya_yolu, isimdizi);
        }

        private void SkorTimer_Tick(object sender, EventArgs e)
        {
            skortxt();
        }
    }
}
