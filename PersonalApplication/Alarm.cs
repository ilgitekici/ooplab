using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    public class Alarm
    {
        //Alarmları oluştuğu ve listesinin tutulduğu sınıf.
        public static List<Alarm> alarmList = new List<Alarm>();
        private string kullanici;
        private string tip;
        private string gun;
        private string vakit;
        private string ozet;
        private string aciklama;
        public static string path = "alarm.csv";
        //Alarm Sınıfın constructor u.
        public Alarm(string kullanici, string tip, string gun, string vakit, string ozet, string aciklama)
        {
            this.Kullanici = kullanici;
            this.Tip = tip;
            this.Gun = gun;
            this.Vakit = vakit;
            this.Ozet = ozet;
            this.Aciklama = aciklama;
        }
        //Alarm sınıfının alanlarına erişim ve işlem yapmamızı sağlayan özellikler.
        public string Kullanici { get => kullanici; set => kullanici = value; }
        public string Tip { get => tip; set => tip = value; }
        public string Gun { get => gun; set => gun = value; }
        public string Vakit { get => vakit; set => vakit = value; }
        public string Ozet { get => ozet; set => ozet = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
        public string toString()
        {
            return Kullanici + "," + Tip + "," + Gun + "," + Vakit + "," + Ozet + "," + Aciklama;
        }
    }
}
