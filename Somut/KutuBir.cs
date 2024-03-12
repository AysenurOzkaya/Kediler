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
    class KutuBir:Cisim
    {
        private static readonly Random randomk1 = new Random();
        public KutuBir(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = randomk1.Next(hareketAlaniBoyutlari.Width - Width + 1);
        }
    }
}
