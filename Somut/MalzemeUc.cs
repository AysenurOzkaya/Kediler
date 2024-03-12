using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using B211200039.Soyut;

namespace B211200039.Somut
{
    class MalzemeUc:Cisim
    {
        private static readonly Random random2 = new Random();
        public MalzemeUc(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = random2.Next(hareketAlaniBoyutlari.Width - Width + 1);
        }
    }
}

