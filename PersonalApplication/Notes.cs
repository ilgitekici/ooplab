using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    public class Notes
    {
        //Bu sınıfın özel alanları.
        private string kullaniciAdi;
        private string notlar;
        //Bu sınıfın constructor u.
        public Notes(string user, string note)
        {
            this.kullaniciAdi = user;
            this.notlar = note;
        }
        //Bu sınıfın özellikleri.
        public string Username { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Note { get => notlar; set => notlar = value; }
        //Bu sınıfın notları stringe çeviren metodu.
        public string toString()
        {
            return kullaniciAdi + "," + notlar;
        }
    }
}
