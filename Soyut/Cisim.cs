using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using B211200039.Enum;

namespace B211200039.Soyut
{
    //Ayşenur Özkaya B211200039

    class Cisim : PictureBox
    {
        public Size HareketAlaniBoyutlari { get; }

        public int HareketMesafesi { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }


        protected Cisim(Size hareketAlaniBoyutlari)
        {
            Image = Image.FromFile($@"gorseller\{GetType().Name}.png");
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;


        }


        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {

                case Yon.Saga:
                    return SagaHareketEttir();
                case Yon.Asagi:
                    return AsagiHareketEttir();
                case Yon.Sola:
                    return SolaHareketEttir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }
        }

        private bool SolaHareketEttir()
        {
            if (Left == 0) return true;

            var yeniLeft = Left - HareketMesafesi;
            var tasacakMi = yeniLeft < 0;
            Left = tasacakMi ? 0 : yeniLeft;

            return Left == 0;
        }

        private bool AsagiHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height) return true;

            var yeniBottom = Bottom + HareketMesafesi;
            var tasacakMi = yeniBottom > HareketAlaniBoyutlari.Height;

            Bottom = tasacakMi ? HareketAlaniBoyutlari.Height : yeniBottom;

            return Bottom == HareketAlaniBoyutlari.Height;
        }

        private bool SagaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;

            var yeniRight = Right + HareketMesafesi;
            var tasacakMi = yeniRight > HareketAlaniBoyutlari.Width;

            Right = tasacakMi ? HareketAlaniBoyutlari.Width : yeniRight;

            return Right == HareketAlaniBoyutlari.Width;
        }


    }
}

