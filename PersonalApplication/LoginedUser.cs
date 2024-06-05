using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    class LoginedUser
    {
        //Kullanıcıları tutan sınıf.
        private User kullanici;
        private static LoginedUser girisKullanici;
        //Bu sınıfın özelliği.
        public User UserGetSet { get => kullanici; set => kullanici = value; }
        public static LoginedUser getInstance()
        {
            if (girisKullanici == null)
            {
                girisKullanici = new LoginedUser();
            }
            return girisKullanici;
        }
    }
}
