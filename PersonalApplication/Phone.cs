using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    public class Phone
    {
        private string kullanici;
        private string isim;
        private string soyisim;
        private string numara;
        private string adres;
        private string tanim;
        private string eposta;
        public Phone(string kullanici, string isim, string soyisim, string numara, string adres, string tanim, string eposta)
        {
            this.Kullanici = kullanici;
            this.İsim = isim;
            this.Soyisim = soyisim;
            this.Numara = numara;
            this.Adres = adres;
            this.Tanim = tanim;
            this.Eposta = eposta;
        }
        public string Kullanici { get => kullanici; set => kullanici = value; }
        public string İsim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Tanim { get => tanim; set => tanim = value; }
        public string Eposta { get => eposta; set => eposta = value; }
        public string toString()
        {
            return kullanici + "," + isim + "," + soyisim + "," + numara + "," + adres + "," + tanim + "," + eposta;
        }
    }
}
