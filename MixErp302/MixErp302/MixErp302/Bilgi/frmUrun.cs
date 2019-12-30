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
    public partial class frmUrun : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        Numaralar N = new Numaralar();
        int secimId = -1;
        bool edit = false;
        public frmUrun()
        {
            InitializeComponent();
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            Listele();
            Combo();
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
            //txtCariId.SelectedIndex = 0;
        }


        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblUrunlers
                       where s.UrunKodu.Contains(txtBul.Text) || s.UrunAciklama.Contains(txtBul.Text) || s.bKategori.KategoriAdi.Contains(txtBul.Text) || s.tblCari.CariAdi.Contains(txtBul.Text)
                       select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.UrunKodu;
                Liste.Rows[i].Cells[2].Value = k.UrunAciklama;
                Liste.Rows[i].Cells[3].Value = k.tblCari.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.bKategori.KategoriAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void Combo()
        {
            txtCariId.Items.Clear();
            txtCariId.DataSource = db.tblCaris.ToList();
            txtCariId.ValueMember = "Id";
            txtCariId.DisplayMember = "CariAdi";
            txtCariId.SelectedIndex = 0;

            txtKategoriId.Items.Clear();
            txtKategoriId.DataSource = db.bKategoris.ToList();
            txtKategoriId.ValueMember = "Id";
            txtKategoriId.DisplayMember = "KategoriAdi";
            txtKategoriId.SelectedIndex = 0;

            txtMenseiId.Items.Clear();
            txtMenseiId.DataSource = db.bMenseis.ToList();
            txtMenseiId.ValueMember = "Id";
            txtMenseiId.DisplayMember = "MenseiAdi";
            txtMenseiId.SelectedIndex = 0;

            txtBirimId.Items.Clear();
            txtBirimId.DataSource = db.bBirims.ToList();
            txtBirimId.ValueMember = "Id";
            txtBirimId.DisplayMember = "BirimAdi";
            txtBirimId.SelectedIndex = 0;
        }
        private void YeniKaydet()
        {
            tblUrunler urn = new tblUrunler();
            urn.UrunAciklama = txtUrunAciklama.Text;
            urn.UrunKodu = txtUrunKodu.Text;
            urn.CariId = db.tblCaris.First(x => x.CariAdi == txtCariId.Text).Id;
            //pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);

            urn.KategoriId = db.bKategoris.First(x => x.KategoriAdi == txtKategoriId.Text).Id;
            urn.BirimId = db.bBirims.First(x => x.BirimAdi == txtBirimId.Text).Id;
            urn.MenseiId = db.bMenseis.First(x => x.MenseiAdi == txtMenseiId.Text).Id;

            db.tblUrunlers.Add(urn);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarılı.");
            Listele();
            Temizle();
        }
        void Guncelle()
        {
            tblUrunler urn = db.tblUrunlers.Find(secimId);
            urn.UrunAciklama = txtUrunAciklama.Text;
            urn.UrunKodu = txtUrunKodu.Text;
            urn.CariId = db.tblCaris.First(x => x.CariAdi == txtCariId.Text).Id;
            //pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);

            urn.KategoriId = db.bKategoris.First(x => x.KategoriAdi == txtKategoriId.Text).Id;
            urn.BirimId = db.bBirims.First(x => x.BirimAdi == txtBirimId.Text).Id;
            urn.MenseiId = db.bMenseis.First(x => x.MenseiAdi == txtMenseiId.Text).Id;

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
            tblUrunler urn = db.tblUrunlers.Find(secimId);
            txtUrunKodu.Text = urn.UrunKodu;
            txtUrunAciklama.Text = urn.UrunAciklama;
            txtCariId.Text = urn.tblCari.CariAdi;

            txtMenseiId.Text = urn.bMensei.MenseiAdi;
            txtKategoriId.Text = urn.bKategori.KategoriAdi;
            txtBirimId.Text = urn.bBirim.BirimAdi;
            
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
            db.tblUrunlers.Remove(db.tblUrunlers.Find(secimId));
            db.SaveChanges();
            MessageBox.Show($"{secimId}'nolu Kayıt silinmiştir.");
            Listele();
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
