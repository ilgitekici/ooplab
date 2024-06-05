using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_Application
{
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }
        public string path = "mydb.csv";
        public int flag = 0;
        Stack<CareTakerDatas> undoStack = new Stack<CareTakerDatas>();
        Stack<CareTakerDatas> redoStack = new Stack<CareTakerDatas>();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            User user = LoginedUser.getInstance().UserGetSet;
            txtUserName.Text = user.KullaniciAdi;
            TxtUserType.Text = user.KullaniciTipleri;
            TxtName.Text = user.İsim;
            TxtSurname.Text = user.Soyisim;
            MTxtPhoneNumber.Text = user.TelNo;
            TxtSalary.Text = user.Maas;
            if (user.Adres.Contains("#"))
            {
                user.Adres = user.Adres.Replace("#", ",");
            }
            TxtAddress.Text = user.Adres;
            TxtEmail.Text = user.Eposta;
            PicPhoto.Image = Util.Base64ToImage(user.Foto);
            if (user.KullaniciTipleri == "Admin" || user.KullaniciTipleri == "*Admin" || user.KullaniciTipleri == "admin")
            {
                btnAdmin.Enabled = true;
                btnAdmin.BackColor = Color.Green;
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = LoginedUser.getInstance().UserGetSet;
            user.Hatirla = false;
            Util.SaveCsv(LoginForm.userList, LoginForm.path);
            this.Close();
        }
        private void btnYedekle_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TSV Dosyası|*.tsv";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                for (int i = 0; i < LoginForm.userList.Count; i++)
                {
                    User user = LoginForm.userList[i];
                    Kayit.WriteLine(user.KullaniciAdi + "\t" + user.KullaniciSifre + "\t" + user.Hatirla);
                }
                Kayit.Close();
            }
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management management = new Management();
            if (management.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void BtnPhoneBook_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PhoneBook frm = new PhoneBook();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void btnNoteBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteBook frm = new NoteBook();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            User user = LoginedUser.getInstance().UserGetSet;
            List<User> userList = new List<User>();
            Util.LoadCsv(userList, path);
            int counter = 0;
            int count = 0;
            for (int i = 0; i < userList.Count; i++)
            {
                if (txtUserName.Text == user.KullaniciAdi)
                {
                    break;
                }
                else if (userList[i].KullaniciAdi == txtUserName.Text)
                {
                    counter++;
                    break;
                }
            }
            if (counter != 1)
            {
                user.KullaniciAdi = txtUserName.Text;
                if (TxtPassword.Text != "")
                {
                    user.KullaniciSifre = Util.ComputeStringToSha256Hash(TxtPassword.Text);
                }
                user.İsim = TxtName.Text;
                user.Soyisim = TxtSurname.Text;
                if (TxtAddress.Text.Contains(","))
                {
                    TxtAddress.Text = TxtAddress.Text.Replace(",", "#");
                }
                user.Adres = TxtAddress.Text;
                if (Util.isEmailValid(TxtEmail.Text))
                {
                    user.Eposta = TxtEmail.Text;
                    if (MTxtPhoneNumber.Text.Length == 14)
                    {
                        user.TelNo = MTxtPhoneNumber.Text;
                        TxtPassword.Text = "";
                        if (TxtAddress.Text.Contains("#"))
                            TxtAddress.Text = TxtAddress.Text.Replace("#", ",");
                        MessageBox.Show("Güncelleme Başarılı!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        count++;
                        MessageBox.Show("Hatalı Telefon Numarası!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    count++;
                    MessageBox.Show("Hatalı Eposta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string photo;
                if (flag > 0)
                {
                    photo = Util.ImageToBase64(PicPhoto.ImageLocation);
                    if (count == 0)
                    {
                        user.Foto = photo;
                    }
                    else
                    {
                        PicPhoto.Image = Util.Base64ToImage(user.Foto);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Mevcut", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnImagePath_Click(object sender, EventArgs e)
        {
            flag++;
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            PicPhoto.ImageLocation = file.FileName;
        }
        private void LogOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)26)
            {
                undoRedoOperations(undoStack, redoStack);
            }
            else if (e.KeyChar == (char)25)
            {
                undoRedoOperations(redoStack, undoStack);
            }
            else
            {
                CareTakerDatas datas = new CareTakerDatas();
                User tempUser = new User(txtUserName.Text, TxtPassword.Text, false, "", TxtName.Text, TxtSurname.Text, MTxtPhoneNumber.Text, TxtAddress.Text, TxtEmail.Text, "", "");
                if (flag == 0)
                {
                    tempUser.Foto = LoginedUser.getInstance().UserGetSet.Foto;
                }
                else
                    tempUser.Foto = Util.ImageToBase64(PicPhoto.ImageLocation);
                datas.Memento = tempUser.Save();
                undoStack.Push(datas);
            }
        }
        private void undoRedoOperations(Stack<CareTakerDatas> mainStack, Stack<CareTakerDatas> backUpStack)
        {
            if (mainStack.Count > 0)
            {
                User tempUser = new User();
                CareTakerDatas taker = mainStack.Pop();
                CareTakerDatas oldtaker = new CareTakerDatas();
                tempUser.Undo(taker.Memento);
                txtUserName.Text = tempUser.KullaniciAdi;
                TxtPassword.Text = tempUser.KullaniciSifre;
                TxtSurname.Text = tempUser.İsim;
                TxtName.Text = tempUser.Soyisim;
                MTxtPhoneNumber.Text = tempUser.TelNo;
                TxtAddress.Text = tempUser.Adres;
                TxtEmail.Text = tempUser.Eposta;
                PicPhoto.Image = Util.Base64ToImage(tempUser.Foto);
                oldtaker.Memento = tempUser.Save();
                backUpStack.Push(oldtaker);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryCalculator frm = new SalaryCalculator();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void btnRemainder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reminder frm = new Reminder();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
