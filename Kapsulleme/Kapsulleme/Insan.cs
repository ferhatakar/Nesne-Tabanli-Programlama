using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kapsulleme
{
    public class Insan
    {
        private string _adi;
        private int _yas;
        private string _meslek;
        public bool _status=true;
        //Adi Kapsulü 
        public string Adi
        {
            get { return _adi;}//_adi olan özel değişkeni geri getirir.
            set { _adi = value; } //gönderdiğimiz değeri uygular

        }

        public int Yas
        {
            get { return _yas; }
            set {
                if (value < 0 || value>100)
                {
                    MessageBox.Show("Yaş Değerini 1 ile 100 arasında bir değer Giriniz." + Environment.NewLine + "Değer: " + value, "Yaş Değerini Yanlış Girdiniz.");
                    _status = false;//Yanlış Girildi ise Ekrana Yazdırtma
                }
                else
                {
                    _yas = value;
                }
            }
        }

        public string Meslek
        {
            get { return _meslek;}
            set { _meslek = value; }
        }
        
    }
}
