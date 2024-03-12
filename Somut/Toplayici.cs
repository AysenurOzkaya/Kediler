using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B211200039.Soyut;
using System.Drawing;

namespace B211200039.Somut
{
    //Ayşenur Özkaya B211200039
    class Toplayici:Cisim
    {
        public Toplayici(int panelGenisligi, int Panelyukseklik, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {

            HareketMesafesi = Width;
            Center = panelGenisligi / 2;
            Bottom = Panelyukseklik;
            Top = Panelyukseklik - this.Height;

        }


        public MalzemeBir YakalandiMi(List<MalzemeBir> malzemeBir)
        {

            foreach (var mlzmBr in malzemeBir)
            {
                var yakalandiMi = mlzmBr.Bottom > Top && mlzmBr.Right > Left && mlzmBr.Left < Right;
                if (yakalandiMi) return mlzmBr;

            }
            return null;
        }
        public KutuBir YakalandiMik1(List<KutuBir> kutubir)
        {
            foreach (var mlzmBr in kutubir)
            {
                var yakalandiMik1 = mlzmBr.Bottom > Top && mlzmBr.Right > Left && mlzmBr.Left < Right;
                if (yakalandiMik1) return mlzmBr;
            }
            return null;
        }
        

        public MalzemeIki YakalandiMi2(List<MalzemeIki> malzemeİki)
        {
            foreach (var mlzmBr in malzemeİki)
            {
                var yakalandiMi2 = mlzmBr.Bottom > Top && mlzmBr.Right > Left && mlzmBr.Left < Right;
                if (yakalandiMi2) return mlzmBr;
            }
            return null;
        }

        public MalzemeUc YakalandiMi3(List<MalzemeUc> malzemeUc)
        {
            foreach (var mlzmBr in malzemeUc)
            {
                var yakalandiMi3 = mlzmBr.Bottom > Top && mlzmBr.Right > Left && mlzmBr.Left < Right;
                if (yakalandiMi3) return mlzmBr;
            }
            return null;
        }
    }
}
