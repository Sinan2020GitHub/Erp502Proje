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
    public partial class frmCariGiris : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        Numaralar N = new Numaralar();
        int secimId = -1;
        bool edit = false;

        public frmCariGiris()
        {
            InitializeComponent();
        }

        private void frmCariGiris_Load(object sender, EventArgs e)
        {
            Combo();
            Listele();
            txtCariNo.Text = N.CariNo();
        }

        void Temizle()
        {
            foreach (Control con in split2.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Text = "";
                }
            }
            secimId = -1;
            edit = false;
            txtCariNo.Text = N.PersonelNo();
            txtCariId.SelectedIndex = 0;
        }


        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblCaris
                       select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.CariNo;
                Liste.Rows[i].Cells[2].Value = k.CariAdi;
                Liste.Rows[i].Cells[3].Value = k.Tel;
                Liste.Rows[i].Cells[4].Value = k.blgCariTipi.CariTipi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void Combo()
        {
            txtCariId.Items.Clear();
            txtCariId.DataSource = db.blgCariTipis.ToList();
            txtCariId.ValueMember = "Id";
            txtCariId.DisplayMember = "CariTipi";
            txtCariId.SelectedIndex = 0;

            txtSehir.Items.Clear();
            var srg = (from s in db.illers                      
                       select s).ToList();
            foreach (var k in srg)
            {
                txtSehir.Items.Add(k.isim);
            }
        }

        private void txtSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIlce.Text = "";
            txtIlce.Items.Clear();   
                int a = db.illers.First(x => x.isim == txtSehir.Text).il_no;
                var srg = (from s in db.ilcelers
                           where s.il_no == a
                           select s).ToList();
                foreach (var k in srg)
                {
                    txtIlce.Items.Add(k.isim);
                } 
        }

        private void YeniKaydet()
        {
            tblCari car = new tblCari();
            car.CariAdi = txtCariAd.Text;
            car.Adres = txtAdres.Text;
            car.CariTipId = db.blgCariTipis.First(x => x.CariTipi == txtCariId.Text).Id;
            //pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);
            
            car.VergiD = txtVergiD.Text;
            car.VergiNoTc = txtVergiNoTc.Text;
            car.Tel = txtTel.Text;
            
            car.CariNo = txtCariNo.Text;
            car.SehirId = db.illers.First(x => x.isim == txtSehir.Text).il_no;
            car.IlceId = db.ilcelers.First(x => x.isim == txtIlce.Text).ilce_no;
            
            
            db.tblCaris.Add(car);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarılı.");
            Listele();
            Temizle();
        }
        void Guncelle()
        {
            tblCari car = db.tblCaris.Find(secimId);
            car.CariAdi = txtCariAd.Text;
            car.Adres = txtAdres.Text;
            car.CariTipId = db.blgCariTipis.First(x => x.CariTipi == txtCariId.Text).Id;
            //pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);

            car.VergiD = txtVergiD.Text;
            car.VergiNoTc = txtVergiNoTc.Text;
            car.Tel = txtTel.Text;

            car.CariNo = txtCariNo.Text;
            car.SehirId = db.illers.First(x => x.isim == txtSehir.Text).il_no;
            car.IlceId = db.ilcelers.First(x => x.isim == txtIlce.Text).ilce_no;

            db.SaveChanges();
            MessageBox.Show("Güncelleme başarılı.");
            Listele();
            Temizle();
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
            tblCari car = db.tblCaris.Find(secimId);
            txtCariAd.Text = car.CariAdi;
            txtAdres.Text = car.Adres;
            txtCariId.Text = car.blgCariTipi.CariTipi;

            txtSehir.Text = car.iller.isim;
            txtIlce.Text = car.ilceler.isim;
            txtVergiNoTc.Text = car.VergiNoTc;
            txtTel.Text = car.Tel;
            txtVergiD.Text = car.VergiD;
        }

        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false) YeniKaydet();
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
            db.tblCaris.Remove(db.tblCaris.Find(secimId));
            db.SaveChanges();
            MessageBox.Show($"{secimId}'nolu Kayıt silinmiştir.");
            Listele();
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
