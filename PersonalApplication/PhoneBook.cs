using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace Personal_Organizer_Application
{
    public partial class PhoneBook : Form
    {
        public static List<Phone> telListe = new List<Phone>();
        public static List<Phone> KullaniciTelListe = new List<Phone>();
        public static string path = "phonebook.csv";
        User user = LoginedUser.getInstance().UserGetSet;
        public PhoneBook()
        {
            InitializeComponent();
        }
        private void PhoneBook_Load(object sender, EventArgs e)
        {
            Util.LoadPhoneBook(telListe, path);
        }
        private void BtnLists_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            KullaniciTelListe.Clear();
            for (int i = 0; i < telListe.Count(); i++)
            {
                if (telListe[i].Kullanici == user.KullaniciAdi)
                {
                    KullaniciTelListe.Add(telListe[i]);
                }
            }
            dataGridView1.DataSource = KullaniciTelListe;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (telListe.Any())
            {
                for (int i = 0; i < telListe.Count(); i++)
                {
                    if (MTxtNumber.Text == telListe[i].Numara)
                    {
                        if (telListe[i].Kullanici == user.KullaniciAdi)
                        {
                            MessageBox.Show("Kullanıcı Mevcut!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            counter++;
                            break;
                        }
                    }
                    else if (TxtName.Text == "" || TxtSurname.Text == "" || MTxtNumber.Text == "" || TxtAddress.Text == "" || TxtDescription.Text == "" || TxtEmail.Text == "")
                    {
                        MessageBox.Show("Lütfen Boşlukları Doldurun!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter++;
                        break;
                    }
                }
                if (counter != 1)
                {
                    if (Util.isEmailValid(TxtEmail.Text))
                    {
                        if (MTxtNumber.Text.Length == 14)
                        {
                            Phone numberAdd = new Phone(user.KullaniciAdi.ToString(), TxtName.Text, TxtSurname.Text, MTxtNumber.Text, TxtAddress.Text, TxtDescription.Text, TxtEmail.Text);
                            telListe.Add(numberAdd);
                            Util.SavePhoneBook(telListe, path);
                            MessageBox.Show("Başarılı kayıt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Hatalı Telefon Numarası!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Hatalı Eposta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (TxtName.Text == "" || TxtSurname.Text == "" || MTxtNumber.Text == "" || TxtAddress.Text == "" || TxtDescription.Text == "" || TxtEmail.Text == "")
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurun!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Util.isEmailValid(TxtEmail.Text))
                    {
                        if (MTxtNumber.Text.Length == 14)
                        {
                            Phone numberAdd = new Phone(user.KullaniciAdi.ToString(), TxtName.Text, TxtSurname.Text, MTxtNumber.Text, TxtAddress.Text, TxtDescription.Text, TxtEmail.Text);
                            telListe.Add(numberAdd);
                            Util.SavePhoneBook(telListe, path);
                            MessageBox.Show("Başarılı Kayıt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Hatalı Telefon Numarası!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Hatalı Eposta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MTxtNumber.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtAddress.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtDescription.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            for (int i = 0; i < telListe.Count; i++)
            {
                if (telListe[i].Numara == KullaniciTelListe[secilen].Numara && telListe[i].Kullanici == KullaniciTelListe[secilen].Kullanici)
                {
                    for (int j = 0; j < telListe.Count; j++)
                    {
                        if (MTxtNumber.Text == telListe[j].Numara)
                        {
                            if (MTxtNumber.Text == KullaniciTelListe[secilen].Numara)
                            {
                                if (Util.isEmailValid(TxtEmail.Text))
                                {
                                    if (MTxtNumber.Text.Length == 14)
                                    {
                                        telListe[i].Numara = MTxtNumber.Text;
                                        telListe[i].İsim = TxtName.Text;
                                        telListe[i].Soyisim = TxtSurname.Text;
                                        telListe[i].Adres = TxtAddress.Text;
                                        telListe[i].Tanim = TxtDescription.Text;
                                        telListe[i].Eposta = TxtEmail.Text;
                                        Util.SavePhoneBook(telListe, path);
                                        MessageBox.Show("Başarılı Güncelleme!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                    else
                                        MessageBox.Show("Hatalı Telefon Numarası!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                                else
                                    MessageBox.Show("Hatalı Eposta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Bu Numara Önceden Mevcut", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        if (j == telListe.Count - 1)
                        {
                            if (Util.isEmailValid(TxtEmail.Text))
                            {
                                if (MTxtNumber.Text.Length == 14)
                                {
                                    telListe[i].Numara = MTxtNumber.Text;
                                    telListe[i].İsim = TxtName.Text;
                                    telListe[i].Soyisim = TxtSurname.Text;
                                    telListe[i].Adres = TxtAddress.Text;
                                    telListe[i].Tanim = TxtDescription.Text;
                                    telListe[i].Eposta = TxtEmail.Text;
                                    Util.SavePhoneBook(telListe, path);
                                    MessageBox.Show("Başarılı Güncelleme!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                                else
                                    MessageBox.Show("Hatalı Telefon Numarası!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else
                                MessageBox.Show("Hatalı Eposta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            for (int i = 0; i < telListe.Count; i++)
            {
                if (telListe[i].Numara == KullaniciTelListe[secilen].Numara && telListe[i].Kullanici == KullaniciTelListe[secilen].Kullanici)
                {
                    telListe.RemoveAt(i);
                    Util.SavePhoneBook(telListe, path);
                    MessageBox.Show("Numara Silindi!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }

        private void LblSurname_Click(object sender, EventArgs e)
        {

        }

        private void LblNumber_Click(object sender, EventArgs e)
        {

        }

        private void LblAddress_Click(object sender, EventArgs e)
        {

        }
    }
}

