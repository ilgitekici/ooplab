using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace Personal_Organizer_Application
{
    public class User
    {
        private string kullaniciAdi;
        private string kullaniciSifre;
        private bool hatirla;
        private string kullaniciTipleri;
        private string isim;
        private string soyisim;
        private string telNo;
        private string adres;
        private string eposta;
        private string foto;
        private string maas;
        public User(string kullaniciAdi, string kullaniciSifre, bool hatirla, string kullaniciTipleri, string isim, string soyisim, string telNo, string adres, string eposta, string foto, string maas)
        {
            this.KullaniciAdi = kullaniciAdi;
            this.KullaniciSifre = kullaniciSifre;
            this.Hatirla = hatirla;
            this.KullaniciTipleri = kullaniciTipleri;
            this.isim = isim;
            this.Soyisim = soyisim;
            this.TelNo = telNo;
            this.Adres = adres;
            this.Eposta = eposta;
            this.Foto = foto;
            this.Maas = maas;
        }
        public User() { }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string KullaniciSifre { get => kullaniciSifre; set => kullaniciSifre = value; }
        public bool Hatirla { get => hatirla; set => hatirla = value; }
        public string KullaniciTipleri { get => kullaniciTipleri; set => kullaniciTipleri = value; }
        public string İsim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string TelNo { get => telNo; set => telNo = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Eposta { get => eposta; set => eposta = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Maas { get => maas; set => maas = value; }
        public bool IsValid(string txtId, string txtPassword, bool rememberMe)
        {
            return this.kullaniciAdi.Equals(txtId) && this.kullaniciSifre.Equals(Util.ComputeStringToSha256Hash(txtPassword));
        }
        public bool IsValid(string txtId, string txtPassword, string usertypes)
        {
            return this.kullaniciAdi.Equals(txtId) && this.kullaniciSifre.Equals(Util.ComputeStringToSha256Hash(txtPassword)) && (this.kullaniciTipleri.Equals(usertypes));
        }
        public string toString()
        {
            return kullaniciAdi + "," + kullaniciSifre + "," + (hatirla ? "1" : "0") + "," + kullaniciTipleri + "," + isim + "," + soyisim + "," + telNo + "," + adres + "," + eposta + "," + foto + "," + maas;
        }
        public Memento Save()
        {
            return new Memento
            {
                username = KullaniciAdi,
                accoundPassword = KullaniciSifre,
                name = İsim,
                surname = Soyisim,
                phoneNumber = TelNo,
                address = Adres,
                email = Eposta,
                photo = Foto
            };
        }
        public void Undo(Memento memento)
        {
            this.KullaniciAdi = memento.username;
            this.İsim = memento.name;
            this.Soyisim = memento.surname;
            this.TelNo = memento.phoneNumber;
            this.KullaniciSifre = memento.accoundPassword;
            this.Adres = memento.address;
            this.Eposta = memento.email;
            this.Foto = memento.photo;
        }
    }
    public class Memento
    {
        public string username { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNumber { get; set; }
        public string accoundPassword { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string photo { get; set; }
    }
    class CareTakerDatas
    {
        public Memento Memento { get; set; }
    }
}
