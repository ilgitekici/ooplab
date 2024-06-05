using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_Application
{
    public partial class Management : Form
    {
        public static Management mana;
        public Management()
        {
            mana = this;
            InitializeComponent();
        }
        private void Management_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LoginForm.userList;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = LoginedUser.getInstance().UserGetSet;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if (secilen == 0 && user.KullaniciTipleri != "*Admin")
            {
                MessageBox.Show("Admin Değiştirilemez!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TxtRegisterNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtUsername.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtPassword.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtUsertypes.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if ((LoginForm.userList[secilen].KullaniciTipleri == "*Admin"))
            {
                MessageBox.Show("*Admin silinemez !!! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoginForm.userList.RemoveAt(secilen);
                Util.SaveCsv(LoginForm.userList, LoginForm.path);
                MessageBox.Show("Siliniyor................");
                List();
                deleteText();
            }
        }
        private void BtnLists_Click(object sender, EventArgs e)
        {
            List();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Kayıt olunması için gereken onayın alınması için atılan sayaç
            int accept = 0;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                if (TxtUsername.Text == LoginForm.userList[i].KullaniciAdi &&
                    (TxtPassword.Text) == LoginForm.userList[i].KullaniciSifre &&
                    LoginForm.userList[i].KullaniciTipleri == TxtUsertypes.Text)
                {
                    MessageBox.Show("Kullanıcı Mevcut!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                else if (TxtUsername.Text == "" || TxtPassword.Text == "")
                {
                    MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre Girin!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                else if (TxtUsertypes.Text == "*Admin")
                {
                    MessageBox.Show("*Admin mevcut! 1 tane var olabilir", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                if (TxtUsertypes.Text != "Admin" && TxtUsertypes.Text != "admin" && TxtUsertypes.Text != "user" && TxtUsertypes.Text != "part-time-user")
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Tipi Yok", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    accept++;
                    break;
                }
            }
            if (accept == 0)
            {
                if (LoginForm.userList[0].KullaniciTipleri == "*Admin")
                {
                    User user = LoginForm.userList[int.Parse(TxtRegisterNo.Text)];
                    user.KullaniciAdi = TxtUsername.Text;
                    user.KullaniciSifre = (TxtPassword.Text);
                    user.KullaniciTipleri = TxtUsertypes.Text;
                    Util.SaveCsv(LoginForm.userList, LoginForm.path);
                    MessageBox.Show("Güncelleniyor..............");
                    deleteText();
                }
                else
                {
                    MessageBox.Show("*Admin ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void List()
        {
            Util.LoadCsv(LoginForm.userList, LoginForm.path);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LoginForm.userList;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }
        private void deleteText()
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtUsertypes.Text = "";
            TxtRegisterNo.Text = "";
        }
    }
}
