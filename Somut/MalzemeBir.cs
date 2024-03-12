using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using B211200039.Soyut;

namespace B211200039.Somut
{
    //Ayşenur Özkaya B211200039
    class MalzemeBir:Cisim
    {
        private static readonly Random Random = new Random();
        public MalzemeBir(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = Random.Next(hareketAlaniBoyutlari.Width - Width + 1);
        }

    }
}
