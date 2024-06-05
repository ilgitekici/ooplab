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
    public partial class Reminder : Form
    {
        public static List<Alarm> alarmListe = new List<Alarm>();
        public static List<Alarm> kullaniciAlarmListe = new List<Alarm>();
        public static string path = "reminder.csv";
        User user = LoginedUser.getInstance().UserGetSet;
        public Reminder()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }
        string type;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if ((rdoMeeting.Checked == false && rdoTask.Checked == false) || dateTimePicker1.Checked == false || mtxtTime.Text == "" || txtSummary.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Lütfen Boşlukları Doldurun", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdoMeeting.Checked == true) type = "Meeting";
                if (rdoTask.Checked == true) type = "Task";
                Alarm reminderadd = new Alarm(user.KullaniciAdi.ToString(), type, dateTimePicker1.Text, mtxtTime.Text, txtSummary.Text, txtDescription.Text);
                alarmListe.Add(reminderadd);
                Util.SaveReminder(alarmListe, path);
                MessageBox.Show("Kayıt Başarılı!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int secilen = dgvRemainderList.SelectedCells[0].RowIndex;
            for (int i = 0; i < alarmListe.Count; i++)
            {
                if (alarmListe[i].Aciklama == kullaniciAlarmListe[secilen].Aciklama && alarmListe[i].Kullanici == kullaniciAlarmListe[secilen].Kullanici && kullaniciAlarmListe[i].Ozet== kullaniciAlarmListe[secilen].Ozet && kullaniciAlarmListe[i].Vakit == kullaniciAlarmListe[secilen].Vakit && kullaniciAlarmListe[i].Gun== kullaniciAlarmListe[secilen].Gun && kullaniciAlarmListe[i].Tip == kullaniciAlarmListe[secilen].Tip)
                {
                    alarmListe.RemoveAt(i);
                    Util.SaveReminder(alarmListe, path);
                    MessageBox.Show("Hatırlatıcı Silindi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int secilen = dgvRemainderList.SelectedCells[0].RowIndex;
            for (int i = 0; i < alarmListe.Count; i++)
            {
                if (alarmListe[i].Aciklama == kullaniciAlarmListe[secilen].Aciklama && alarmListe[i].Kullanici == kullaniciAlarmListe[secilen].Kullanici && alarmListe[i].Ozet == kullaniciAlarmListe[secilen].Ozet && alarmListe[i].Vakit == kullaniciAlarmListe[secilen].Vakit && alarmListe[i].Gun == kullaniciAlarmListe[secilen].Gun && alarmListe[i].Tip == kullaniciAlarmListe[secilen].Tip)
                {
                    if (rdoMeeting.Checked == true)
                    {
                        alarmListe[i].Tip = "Meeting";
                    }
                    if (rdoTask.Checked == true)
                    {
                        alarmListe[i].Tip = "Task";
                    }
                    alarmListe[i].Gun = dateTimePicker1.Text;
                    alarmListe[i].Vakit = mtxtTime.Text;
                    alarmListe[i].Ozet = txtSummary.Text;
                    alarmListe[i].Aciklama = txtDescription.Text;
                    Util.SaveReminder(alarmListe, path);
                    MessageBox.Show("Güncelleme Başarılı!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            dgvRemainderList.DataSource = null;
            kullaniciAlarmListe.Clear();
            for (int i = 0; i < alarmListe.Count(); i++)
            {
                if (alarmListe[i].Kullanici == user.KullaniciAdi)
                {
                    kullaniciAlarmListe.Add(alarmListe[i]);
                }
            }
            dgvRemainderList.DataSource = kullaniciAlarmListe;
            dgvRemainderList.Columns[0].Visible = false;
        }
        private void Reminder_Load(object sender, EventArgs e)
        {
            Util.LoadReminder(alarmListe, path);
        }
        private void dgvRemainderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvRemainderList.SelectedCells[0].RowIndex;
            if (dgvRemainderList.Rows[secilen].Cells[1].Value.ToString() == "Meeting")
            {
                rdoMeeting.Checked = true;
            }
            if (dgvRemainderList.Rows[secilen].Cells[1].Value.ToString() == "Task")
            {
                rdoTask.Checked = true;
            }
            dateTimePicker1.Text = dgvRemainderList.Rows[secilen].Cells[2].Value.ToString();
            mtxtTime.Text = dgvRemainderList.Rows[secilen].Cells[3].Value.ToString();
            txtSummary.Text = dgvRemainderList.Rows[secilen].Cells[4].Value.ToString();
            txtDescription.Text = dgvRemainderList.Rows[secilen].Cells[5].Value.ToString();
        }
        private void Day_TimeShow_Tick(object sender, EventArgs e)
        {
            lblShowTime.Text = DateTime.Now.ToLongDateString() + Environment.NewLine + DateTime.Now.ToLongTimeString();
        }
    }
}
