using MixErp302.Data;
using MixErp302.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.Bilgi
{
    public partial class frmPersonelGiris : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        Numaralar N = new Numaralar();
        int secimId = -1;
        bool edit = false;
        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void frmPersonelGiris_Load(object sender, EventArgs e)
        {
            Combo();
            Listele();
            txtPersonelNo.Text = N.PersonelNo();
        }

        void Temizle()
        {
            foreach(Control con in split2.Panel1.Controls)
            {
                if(con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Text = "";
                }                        
            }
            secimId = -1;
            edit = false;
            txtPersonelNo.Text = N.PersonelNo();
            txtDepartman.SelectedIndex = 0;
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblPersonels
                       select s).ToList();
            foreach(var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.PersonelNo;
                Liste.Rows[i].Cells[2].Value = k.Adi;
                Liste.Rows[i].Cells[3].Value = k.Tel;
                Liste.Rows[i].Cells[4].Value = k.blgDepartman.DepartmanAdi;
                i++;
            }
            Liste.AllowUserToAddRows=false;
        }

        private void Combo()
        {
            txtDepartman.DataSource = db.blgDepartmen.ToList();
            txtDepartman.ValueMember = "Id";
            txtDepartman.DisplayMember = "DepartmanAdi";
            txtDepartman.SelectedIndex = 0;
        }
        private void YeniKaydet()
        {
            tblPersonel pers = new tblPersonel();
            pers.Adi = txtAd.Text;
            pers.Adres = txtAdres.Text;
            pers.DepartmanId = db.blgDepartmen.First(x => x.DepartmanAdi == txtDepartman.Text).Id;
            //pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);
            pers.DogumTarih = Convert.ToDateTime(txtDogumTarih.Text);
            pers.Email = txtEmail.Text;
            pers.IsBasTarih= Convert.ToDateTime(txtIsBasTarih.Text);
            pers.IsSonTarih= Convert.ToDateTime(txtIsSonTarih.Text);
            pers.PersonelNo = txtPersonelNo.Text;
            pers.TcNo = txtTc.Text;
            pers.Tel = txtTel.Text;
            db.tblPersonels.Add(pers);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarılı.");
            Listele();
            Temizle();
        }
        void Guncelle()
        {
            tblPersonel pers = db.tblPersonels.Find(secimId);
            pers.Adi = txtAd.Text;
            pers.Adres = txtAdres.Text;
            pers.DepartmanId = db.blgDepartmen.First(x => x.DepartmanAdi == txtDepartman.Text).Id;
            //pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);
            pers.DogumTarih = Convert.ToDateTime(txtDogumTarih.Text);
            pers.Email = txtEmail.Text;
            pers.IsBasTarih = Convert.ToDateTime(txtIsBasTarih.Text);
            pers.IsSonTarih = Convert.ToDateTime(txtIsSonTarih.Text);
            pers.PersonelNo = txtPersonelNo.Text;
            pers.TcNo = txtTc.Text;
            pers.Tel = txtTel.Text;   
            
            db.SaveChanges();
            MessageBox.Show("Güncelleme başarılı.");
            Listele();
            Temizle();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if(edit==false)YeniKaydet();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                Ac(secimId);
            }
        }

        private void Ac(int secimId)
        {
            edit = true;
            tblPersonel pers = db.tblPersonels.Find(secimId);
            txtAd.Text = pers.Adi;
            txtAdres.Text = pers.Adres;
            txtDepartman.Text = pers.blgDepartman.DepartmanAdi;
            txtDogumTarih.Text = pers.DogumTarih.ToString();
            txtIsBasTarih.Text = pers.IsBasTarih.ToString();
            txtIsSonTarih.Text = pers.IsSonTarih.ToString();
            txtPersonelNo.Text = pers.PersonelNo;
            txtTc.Text = pers.TcNo;
            txtTel.Text = pers.Tel;
            txtEmail.Text = pers.Email;
        }

        private void Sec()
        {
            try
            {
                secimId =Convert.ToInt32(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0)
            {
                Sil();
            }
        }

        private void Sil()
        {            
                db.tblPersonels.Remove(db.tblPersonels.Find(secimId));
                db.SaveChanges();
                MessageBox.Show($"{secimId}'nolu Kayıt silinmiştir.");
                Listele();
                Temizle();            
        }
    }
}
