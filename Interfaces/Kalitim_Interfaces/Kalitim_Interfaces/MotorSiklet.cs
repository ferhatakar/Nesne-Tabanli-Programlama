using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Kalitim_Interfaces.Interfaces;

namespace Kalitim_Interfaces
{
    public class MotorSiklet : IAraba
    {
        private string _Adres;
        public string _IAdres
        {
            get { return _Adres; }

            set { _Adres = value; }
        }

        private int _Hiz;
        public int _IHiz
        {
            get { return _Hiz; }

            set { _Hiz = value; }
        }

        private string _Marka;
        public string _IMarka
        {
            get { return _Marka; }

            set { _Marka = value; }
        }

        private string _renk;
        public string _IRenk
        {
            get { return _renk; }

            set { _renk = value; }
        }
       
        //Motorsiklet sınıfının kendi özelliği
        private string _model;
        public string Model
        {
            get { return _model;}
            set { _model = value; }
        }
    }
}
