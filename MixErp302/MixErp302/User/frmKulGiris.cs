using MixErp302.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.User
{
    public partial class frmKulGiris : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();
        int secimId = -1;
        bool edit = false;
        public frmKulGiris()
        {
            InitializeComponent();
        }

        private void frmKulGiris_Load(object sender, EventArgs e)
        {
           
            txtRole.SelectedIndex = 0;
        }

        void YeniKaydet()
        {
            tblUser user = new tblUser();
            user.KulAdi = txtKullanici.Text;
            user.Sifre = txtSifre.Text;
            user.Role = txtRole.SelectedIndex;

            db.tblUsers.Add(user);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı.");
            Listele();
            Temizle();
        }

        void Guncelle()
        {
            tblUser user = db.tblUsers.Find(secimId);
            user.KulAdi = txtKullanici.Text;
            user.Sifre = txtSifre.Text;
            user.Role = txtRole.SelectedIndex;

            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı.");
            Listele();
            Temizle();
        }

        private void btnkaydett_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false) YeniKaydet();
        }

        void Temizle()
        {
            foreach (Control con in split2.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox)
                {
                    con.Text = "";
                }
                //txtDogumTarih.Text = DateTime.Now.ToLongDateString();
                secimId = -1;
                edit = false;
                txtRole.SelectedIndex = 0;
            }
        }

        

        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }
        private void Ac(int id)
        {
            edit = true;
            var srg = db.tblUsers.Find(id);
            txtKullanici.Text = srg.KulAdi;
            txtSifre.Text = srg.Sifre;
            for(int i = 0; i < txtRole.Items.Count; i++)
            {
                if (srg.Role == i)
                {
                    txtRole.SelectedIndex =i;
                }
            }
            
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblUsers where s.KulAdi.Contains(txtBul.Text)
                       select s).ToList(); //personel tablosunda kayıt varsa srg nin içine atıyor.
            foreach (var k in srg)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.KulAdi;
                liste.Rows[i].Cells[2].Value = k.Sifre;
                liste.Rows[i].Cells[3].Value = k.Role;
                i++;


            }
            liste.AllowUserToAddRows = false; //kullanıcı yeni satır ekleyemesin
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtKullanici.Text!="" && secimId!=-1)
            {
                db.tblUsers.Remove(db.tblUsers.Find(secimId));
                db.SaveChanges();
                MessageBox.Show("silme başarılı");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("ilk olarak listeden kayıt secin");
            }
        }

        private void Sil()
        {
            db.tblUsers.Remove(db.tblUsers.Find(secimId));
            db.SaveChanges();
            MessageBox.Show($"{secimId}'nolu kayıt silinmiştir.");
            Listele();
            Temizle();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            int id = secimId;
            if (id > 0)
            {
                Ac(id);
            }
        }
    }
}