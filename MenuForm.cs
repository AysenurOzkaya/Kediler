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
    public partial class MenuForm : Form
    {

        SkorForm2 skorform = new SkorForm2();

        OyunForm oyunForm = new OyunForm();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void basla_Click(object sender, EventArgs e)
        {
            oyunForm.Show();
        }

        private void SureText_TextChanged(object sender, EventArgs e)
        {
            oyunForm.SureLabel.Text = SureText.Text;
        }

        private void KalanTextBox_TextChanged(object sender, EventArgs e)
        {
            oyunForm.GorunmezLabel.Text = KalanTextBox.Text;
            oyunForm.KalanLabel.Text = KalanTextBox.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            skorform.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sağ ve Sol yön tuşları toplayıcıyı hareket ettirir." +
                "P tuşu durdurur,Enter tuşu başlatır.", "Tuş Bilgisi");
        }

        private void OyuncuAdiTextBox_TextChanged(object sender, EventArgs e)
        {
            oyunForm.OyuncuLabel.Text = OyuncuAdiTextBox.Text;
        }
    }
}
