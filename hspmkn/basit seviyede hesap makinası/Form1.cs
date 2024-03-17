using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basit_seviyede_hesap_makinası
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekranTemizlenecekMi;
        int _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (EkranLabel.Text=="0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "1";

        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "2";

        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "6";
                


        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            {
                EkranLabel.Text = "";
            }

            EkranLabel.Text += "0";  

        }

        private void artıButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }


        private void essittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(EkranLabel.Text);
            int sonuc=0;
            switch (_islem) {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi; 
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case 'x':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;

            }

            EkranLabel.Text = Convert.ToString(sonuc);

                


        }

        private void eksiButton_Click(object sender, EventArgs e)
        {

            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);

        }

        private void carpıButton_Click(object sender, EventArgs e)
        {

            _islem = 'x';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {

            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void rakamcButton_Click(object sender, EventArgs e)
        {

            EkranLabel.Text = "0";
        }
    }
}
