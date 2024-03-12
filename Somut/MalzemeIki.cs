using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using B211200039.Soyut;

namespace B211200039.Somut
{
    class MalzemeIki:Cisim
    {
        private static readonly Random random = new Random();
        public MalzemeIki(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = random.Next(hareketAlaniBoyutlari.Width - Width + 1);
        }

    }
}
