using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B211200039.Interface;
using B211200039.Enum;
using System.Windows.Forms;

namespace B211200039.Somut
{
    //Ayşenur Özkaya B211200039
    class Oyun : IOyun
    {


        #region PanelveLabelAlani

        private Panel oyunalanipanel;
        private Label gorunmezlabel;

       


        #endregion

        #region OlusturmaTimerAlani

        private readonly Timer malzemeOlusturmaTimer = new Timer { Interval = 1100 };
        private readonly Timer kutuOlusturmaTimer = new Timer { Interval = 10000 };
        private readonly Timer malzemeOlusturma3Timer = new Timer { Interval = 1000 };
        private readonly Timer malzemeOlusturma2Timer = new Timer { Interval = 1050 };




        #endregion




        #region HareketEttirmeTimerAlani


        private Timer malzemeleriHareketEttir = new Timer { Interval = 40 };
        private readonly Timer kutuyuHareketEttir = new Timer { Interval = 40 };
        private readonly Timer malzemeleriHareketEttir3 = new Timer { Interval = 40 };
        private readonly Timer malzemeleriHareketEttir2 = new Timer { Interval = 40 };
        private readonly Timer hizlandirmaTimer = new Timer { Interval = 20000 };


        #endregion


        #region YakalamaTimerAlani

        private readonly Timer yakalanancik = new Timer { Interval = 50 };
        private readonly Timer yakalanancikK1 = new Timer { Interval = 50 };
        private readonly Timer yakalanancik3 = new Timer { Interval = 50 };
        private readonly Timer yakalanancik2 = new Timer { Interval = 50 };


        #endregion



        #region CisimSiniflarininNesneleri

        private Toplayici toplayici;
        private readonly List<MalzemeBir> _malzemebir = new List<MalzemeBir>();
        private readonly List<MalzemeIki> _malzemeiki = new List<MalzemeIki>();
        private readonly List<MalzemeUc> _malzemeuc = new List<MalzemeUc>();
        private readonly List<KutuBir> _kutubir = new List<KutuBir>();


        #endregion



        #region Degisgenler

        int Urunsayisi = 0;
        int KalanaGidenUrunsayisi;
        int SkoraGidenUrunSayisi;
        int K;
        int Malzemesayisi1;
        int Malzemesayisi2;
        int Malzemesayisi3;
        int UcuncuMalzeme = 0;
        int IkinciMalzeme = 0;
        int BirinciMalzeme = 0;
        int Malzemesayisi1y;
        int Malzemesayisi2y;
        int Malzemesayisi3y;
        int kutusayisi1;
        int kutusayisi1y;
        int m;
        int u;
        int l = 0;


        #endregion








        public Oyun(Panel OyunAlaniPanel, Label GorunmezLabel)
        {
            #region PanelVeLabelAtama

            oyunalanipanel = OyunAlaniPanel;

          

            gorunmezlabel = GorunmezLabel;

            

            #endregion

            #region CisimOlusturmaTickAtama

            kutuOlusturmaTimer.Tick += KutuOlusturmaTimer_Tick;
            malzemeOlusturmaTimer.Tick += MalzemeOlusturmaTimer_Tick;
            malzemeOlusturma3Timer.Tick += MalzemeOlusturma3Timer_Tick;
            malzemeOlusturma2Timer.Tick += MalzemeOlusturma2Timer_Tick;

            #endregion

            #region CisimHareketEttirmeTickAtama

            kutuyuHareketEttir.Tick += KutuyuHareketEttir_Tick;
            malzemeleriHareketEttir.Tick += MalzemeBirHareketEttir_Tick;
            malzemeleriHareketEttir3.Tick += MalzemeBirHareket3Ettir_Tick;
            malzemeleriHareketEttir2.Tick += MalzemeBirHareket2Ettir_Tick;
            hizlandirmaTimer.Tick += HizlandirmaTimer_Tick;


            #endregion

            #region YakalananCismiSilmekIçinTickAtama

            
            yakalanancikK1.Tick += Yakalanancikk1_Tick;
            yakalanancik.Tick += Yakalanancik_Tick;
            yakalanancik3.Tick += Yakalanancik3_Tick;
            yakalanancik2.Tick += Yakalanancik2_Tick;

            #endregion


        }


        public void basla()
        {

            toplayiciolustur();

            ZamanlayicilerBaslat();
        }

        public void duraklat()
        {
            ZamanlayicilariDurdur();
        }

        


        #region CisimOlusturmaFonksiyonlari

        public void toplayiciolustur()
        {
            if (l == 0)
            {

                toplayici = new Toplayici(oyunalanipanel.Width, oyunalanipanel.Height, oyunalanipanel.Size);
                oyunalanipanel.Controls.Add(toplayici);
            }

            l++;
        }
        private void MalzemeIkiOLustur()
        {
            var malzemeiki = new MalzemeIki(oyunalanipanel.Size);
            _malzemeiki.Add(malzemeiki);
            oyunalanipanel.Controls.Add(malzemeiki);

        }
        private void KutuyuOlustur()
        {
            var kutubir = new KutuBir(oyunalanipanel.Size);
            _kutubir.Add(kutubir);
            oyunalanipanel.Controls.Add(kutubir);

        }
       
        private void MalzemeBirOlustur()
        {
            var malzemebir = new MalzemeBir(oyunalanipanel.Size);
            _malzemebir.Add(malzemebir);
            oyunalanipanel.Controls.Add(malzemebir);
        }
        private void MalzemeUcOlustur()
        {
            var malzemeuc = new MalzemeUc(oyunalanipanel.Size);
            _malzemeuc.Add(malzemeuc);
            oyunalanipanel.Controls.Add(malzemeuc);
        }


        #endregion


        #region CisimHarekeEttirmeFonksiyonlari


        public void toplayiciHareketEttir(Yon yon)
        {
            toplayici.HareketEttir(yon);
        }
        private void MalzemeBirHareketEttir()
        {



            foreach (var malzemebir in _malzemebir)
            {


                var carptimMi = malzemebir.HareketEttir(Yon.Asagi);
                if (!carptimMi) continue;



                _malzemebir.Remove(malzemebir);
                oyunalanipanel.Controls.Remove(malzemebir);
                break;


            }

        }
        private void KutuyuHareketEttir()
        {



            foreach (var kutubir in _kutubir)
            {


                var carptimMik1 = kutubir.HareketEttir(Yon.Asagi);
                if (!carptimMik1) continue;

                _kutubir.Remove(kutubir);
                oyunalanipanel.Controls.Remove(kutubir);
                break;


            }

        }

       
        private void MalzemeUcHareketEttir()
        {



            foreach (var malzemeuc in _malzemeuc)
            {


                var carptimMi3 = malzemeuc.HareketEttir(Yon.Asagi);
                if (!carptimMi3) continue;

                _malzemeuc.Remove(malzemeuc);
                oyunalanipanel.Controls.Remove(malzemeuc);
                break;


            }

        }

        private void MalzemeIkiHareketEttir()
        {



            foreach (var malzemeiki in _malzemeiki)
            {


                var carptimMi = malzemeiki.HareketEttir(Yon.Asagi);
                if (!carptimMi) continue;

                _malzemeiki.Remove(malzemeiki);
                oyunalanipanel.Controls.Remove(malzemeiki);
                break;


            }

        }


        #endregion




        #region CisimOlusturmaTimerlari

        private void MalzemeOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            MalzemeBirOlustur();


        }
        private void KutuOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            KutuyuOlustur();


        }
      

        private void MalzemeOlusturma2Timer_Tick(object sender, EventArgs e)
        {

            MalzemeIkiOLustur();

        }
        private void MalzemeOlusturma3Timer_Tick(object sender, EventArgs e)
        {

            MalzemeUcOlustur();

        }

        #endregion




        #region CisimHareketEttirmeTimer

        private void HizlandirmaTimer_Tick(object sender, EventArgs e)
        {
            m++;


            if (m >= 3)
            {
                malzemeleriHareketEttir.Interval = 10;
                malzemeleriHareketEttir2.Interval = 10;
                malzemeleriHareketEttir3.Interval = 10;
                malzemeOlusturmaTimer.Interval = 1070;
                malzemeOlusturma2Timer.Interval = 1020;
                malzemeOlusturma3Timer.Interval = 970;

               
            }

            if (m < 3)
            {
                malzemeleriHareketEttir.Interval -= 10;
                malzemeleriHareketEttir2.Interval -= 10;
                malzemeleriHareketEttir3.Interval -= 10;
                malzemeOlusturmaTimer.Interval -= 10;
                malzemeOlusturma2Timer.Interval -= 10;
                malzemeOlusturma3Timer.Interval -= 10;

               
            }
        }
        private void MalzemeBirHareketEttir_Tick(object sender, EventArgs e)
        {

            MalzemeBirHareketEttir();


        }
        private void KutuyuHareketEttir_Tick(object sender, EventArgs e)
        {
            KutuyuHareketEttir();


        }
       
        private void MalzemeBirHareket2Ettir_Tick(object sender, EventArgs e)
        {

            MalzemeIkiHareketEttir();

        }
        private void MalzemeBirHareket3Ettir_Tick(object sender, EventArgs e)
        {

            MalzemeUcHareketEttir();

        }


        #endregion





        #region YakalaniCikartmaTimer

        private void Yakalanancik_Tick(object sender, EventArgs e)
        {
            YakalaniCikarVeSay();

        }
        private void Yakalanancikk1_Tick(object sender, EventArgs e)
        {
            YakalaniCikarVeSayK1();
        }
       

        private void Yakalanancik3_Tick(object sender, EventArgs e)
        {
            YakalaniCikarVeSay3();
        }
        private void Yakalanancik2_Tick(object sender, EventArgs e)
        {
            YakalaniCikarVeSay2();
        }


        #endregion



        #region YakalaniCikarVeSayFonksiyonlari

        public void YakalaniCikarVeSay()
        {
            var yakalana = toplayici.YakalandiMi(_malzemebir);

            if (yakalana != null)
            {
                _malzemebir.Remove(yakalana);
                oyunalanipanel.Controls.Remove(yakalana);

                Malzemesayisi1++;
                Malzemesayisi1y++;


            }


            if (yakalana == null)
            {
                Malzemesayisi1 += 0;
                Malzemesayisi1y += 0;
                Urunsayisi += 0;
            }


        }
        public void YakalaniCikarVeSayK1()
        {
            var yakalanak1 = toplayici.YakalandiMik1(_kutubir);

            if (yakalanak1 != null)
            {
                _kutubir.Remove(yakalanak1);
                oyunalanipanel.Controls.Remove(yakalanak1);


                int[] supris = { 5, -5 };

                Random rnd = new Random();

                int suprisindex = rnd.Next(supris.Length); 

                u = supris[suprisindex];


                kutusayisi1 += u;
                kutusayisi1y++;
            }


            if (yakalanak1 == null)
            {
                kutusayisi1 += 0;
                kutusayisi1y += 0;

            }

        }
        
        public void YakalaniCikarVeSay3()
        {
            var yakalana3 = toplayici.YakalandiMi3(_malzemeuc);

            if (yakalana3 != null)
            {
                _malzemeuc.Remove(yakalana3);
                oyunalanipanel.Controls.Remove(yakalana3);

                Malzemesayisi3++;
                Malzemesayisi3y++;



            }


            if (yakalana3 == null)
            {
                Malzemesayisi3 += 0;
                Malzemesayisi3y += 0;
                Urunsayisi += 0;
            }

        }
        public void YakalaniCikarVeSay2()
        {
            var yakalana2 = toplayici.YakalandiMi2(_malzemeiki);

            if (yakalana2 != null)
            {
                _malzemeiki.Remove(yakalana2);
                oyunalanipanel.Controls.Remove(yakalana2);

                Malzemesayisi2++;
                Malzemesayisi2y++;

            }
            if (yakalana2 == null)
            {
                Malzemesayisi2 += 0;
                Malzemesayisi2y += 0;
                Urunsayisi += 0;
            }

        }

        #endregion




        #region ZamanlayicilarBaslatVeDurdurFonksiyonlari


        private void ZamanlayicilerBaslat()
        {

            #region CisimOlusturmaTimerBaslatma

            malzemeOlusturmaTimer.Start();
            kutuOlusturmaTimer.Start();
            malzemeOlusturma3Timer.Start();
            malzemeOlusturma2Timer.Start();

            #endregion

            #region CisimleriHareketEttirenTimerBaslatma

            malzemeleriHareketEttir.Start();
            kutuyuHareketEttir.Start();
           
            malzemeleriHareketEttir3.Start();
            malzemeleriHareketEttir2.Start();
            hizlandirmaTimer.Start();
            #endregion

            #region YakalanaCismiSilenTimerBaslatma

            yakalanancik.Start();
            yakalanancikK1.Start();
            yakalanancik3.Start();
            yakalanancik2.Start();

            #endregion


        }

        private void ZamanlayicilariDurdur()
        {
            #region CisimOlusturmaTimerDurdurma

            malzemeOlusturmaTimer.Stop();
            kutuOlusturmaTimer.Stop();
            malzemeOlusturma3Timer.Stop();
            malzemeOlusturma2Timer.Stop();

            #endregion

            #region CisimleriHareketEttirenTimerDurdurma

            malzemeleriHareketEttir.Stop();
            kutuyuHareketEttir.Stop();
            malzemeleriHareketEttir3.Stop();
            malzemeleriHareketEttir2.Stop();
            hizlandirmaTimer.Stop();
            #endregion

           

        }


        #endregion



        public int UrunOlustur()
        {

            KalanaGidenUrunsayisi = Urunsayisi;
            SkoraGidenUrunSayisi = Urunsayisi;


            if (Malzemesayisi3 != 0)
            {
                if (Malzemesayisi3 % 3 == 0)
                {
                    UcuncuMalzeme++;

                    Malzemesayisi3 = 0;
                }

                else Urunsayisi += 0;
            }


            if (Malzemesayisi2 != 0)
            {
                if (Malzemesayisi2 % 2 == 0)
                {

                    IkinciMalzeme++;
                    Malzemesayisi2 = 0;

                }
                else Urunsayisi += 0;
            }

            if (Malzemesayisi1 != 0)
            {
                if (Malzemesayisi1 % 1 == 0)
                {

                    BirinciMalzeme++;
                    Malzemesayisi1 = 0;
                }
                else Urunsayisi += 0;
            }

            if (UcuncuMalzeme != 0 && IkinciMalzeme != 0 && BirinciMalzeme != 0)
            {




                Urunsayisi++;

                BirinciMalzeme -= 1;
                IkinciMalzeme -= 1;
                UcuncuMalzeme -= 1;

            }



            return Urunsayisi;

        }

        #region Sayma fonksiyonlari

        public int say1()
        {
            return Malzemesayisi1y;
        }
        public int say2()
        {
            return Malzemesayisi2y;
        }
        public int say3()
        {
            return Malzemesayisi3y;
        }
        public int sayk1()
        {
            return kutusayisi1y;
        }
      
        public int sayKalanUrun()
        {
            return K;
        }
        #endregion


        public int KalanUrunHesapla()
        {

            int Cıkarilan = Convert.ToInt32(gorunmezlabel.Text);
            if (Cıkarilan >= KalanaGidenUrunsayisi)
            {
                int Kalan = Cıkarilan - KalanaGidenUrunsayisi;
                K = Kalan;
            }


            if (Cıkarilan < KalanaGidenUrunsayisi)
            {
                K = 0;
            }

            return K;
        }




        public int SkorHesapla()
        {

            
           

            int Skor;
            Skor = SkoraGidenUrunSayisi * 10 + kutusayisi1 - K * 10;


            return Skor;

        }

      


    }
}
