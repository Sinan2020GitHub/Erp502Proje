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
    public partial class frmUrunGiris : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();
        Numaralar N = new Numaralar();
        int secimId = -1;
        bool edit = false;
        
        public frmUrunGiris()
        {
            InitializeComponent();
        }

        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            ComboBox();
            Listele();
            
        }
        void Temizle() //güncellemeden sonra açtık
        {
            foreach (Control con in split2.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Text = "";
                }
                //txtDogumTarih.Text = DateTime.Now.ToLongDateString();
                secimId = -1;
                edit = false;
                txtKategoriId.SelectedIndex = 0;
            }
        }
        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblUrunlers where s.UrunKodu.Contains(txtBul.Text) || s.UrunAciklama.Contains(txtBul.Text) || s.TblCari.CariAdi.Contains(txtBul.Text) select s).ToList(); //personel tablosunda kayıt varsa srg nin içine atıyor.
            foreach (var k in srg)
            {
                liste.Rows.Add(); //döngüde her seferinde satır oluşturur.
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.UrunKodu;
                liste.Rows[i].Cells[2].Value = k.UrunAciklama;
                liste.Rows[i].Cells[3].Value = k.TblCari.CariAdi;
                liste.Rows[i].Cells[4].Value = k.bKategori.KategoriAdi; //foreign key ile bağladığımiçin kolaylık
                i++;


            }
            liste.AllowUserToAddRows = false; //kullanıcı yeni satır ekleyemesin
        }

        private void ComboBox()
        {
            txtKategoriId.DataSource = db.bKategoris.ToList();
            txtKategoriId.ValueMember = "Id";
            txtKategoriId.DisplayMember = "KategoriAdi";
            txtKategoriId.SelectedIndex = -1;

            txtMenseiId.DataSource = db.bMenseis.ToList();
            txtMenseiId.ValueMember = "Id";
            txtMenseiId.DisplayMember = "MenseiAdi";
            txtMenseiId.SelectedIndex = -1;

            txtBirimId.DataSource = db.bBirims.ToList();
            txtBirimId.ValueMember = "Id";
            txtBirimId.DisplayMember = "BirimAdi";
            txtBirimId.SelectedIndex = -1;

            txtCariId.DataSource = db.TblCaris.ToList();
            txtCariId.ValueMember = "Id";
            txtCariId.DisplayMember = "CariAdi";
            txtCariId.SelectedIndex = -1;
        }
        private void YeniKaydet() //2
        {
            var uKontrol = db.tblUrunlers.Where(x => x.UrunKodu.ToLower() == txtUrunKodu.Text.ToLower()).ToList();

            if (uKontrol.Count()==0)
            {
                tblUrunler urun = new tblUrunler();
                urun.UrunKodu = txtUrunKodu.Text; //solda yazdığım sağdakine bilgi taşır
                urun.UrunAciklama = txtUrunAciklama.Text;
                urun.KategoriId = db.bKategoris.First(x => x.KategoriAdi == txtKategoriId.Text).Id; //Firs tek bir kayıt 
                urun.MenseiId = db.bMenseis.First(x => x.MenseiAdi == txtMenseiId.Text).Id;
                urun.BirimId = db.bBirims.First(x => x.BirimAdi == txtBirimId.Text).Id;
                urun.CariId = db.TblCaris.First(x => x.CariAdi == txtCariId.Text).Id;


                db.tblUrunlers.Add(urun);
                db.SaveChanges();


                tblStokDurum stk = new tblStokDurum();
                stk.Ambar = 0;
                stk.Barkod = txtUrunKodu.Text + "/" + txtUrunAciklama.Text;
                stk.Depo = 0;
                stk.Raf = 0;
                stk.StokKodu = N.StokKod();
                stk.UrunId = db.tblUrunlers.First(x => x.UrunKodu == txtUrunKodu.Text).Id;
                db.tblStokDurums.Add(stk);
                db.SaveChanges();



                MessageBox.Show("Kayıt Başarılı.");
              
            }

            else
            {
                MessageBox.Show("Bu ürün daha önce kaydedilmiş.Lütfen kontrol ediniz...");
                txtUrunKodu.Text = "";
                return;
            }
            Listele();
            Temizle();


        }
        void Guncelle() //yukardan kopyala yapıştır.
        {
            tblUrunler urun = new tblUrunler();
            urun.UrunKodu = txtUrunKodu.Text; //solda yazdığım sağdakine bilgi taşır
            urun.UrunAciklama = txtUrunAciklama.Text;
            urun.KategoriId = db.bKategoris.First(x => x.KategoriAdi == txtKategoriId.Text).Id; //Firs tek bir kayıt 
            urun.MenseiId = db.bMenseis.First(x => x.MenseiAdi == txtMenseiId.Text).Id;
            urun.BirimId = db.bBirims.First(x => x.BirimAdi == txtBirimId.Text).Id;
            urun.CariId = db.TblCaris.First(x => x.CariAdi == txtCariId.Text).Id;


            
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

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                Ac(secimId);
            }
        }

        private void Ac(int secimId)
        {
            edit = true; //güncelleme işlemi yapabilmek için
            tblUrunler urun = db.tblUrunlers.Find(secimId);
            txtUrunKodu.Text = urun.UrunKodu;              //tersten yaptık güncelleme işlemi için bunlar.
            txtUrunAciklama.Text = urun.UrunAciklama;
            txtBirimId.Text = urun.bBirim.BirimAdi; //foreign key
            txtCariId.Text = urun.TblCari.CariAdi;
            txtKategoriId.Text = urun.bKategori.KategoriAdi;
            txtMenseiId.Text = urun.bMensei.MenseiAdi;
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
            MessageBox.Show($"{secimId}'nolu kayıt silinmiştir.");
            Listele();
            Temizle();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtCariId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBul_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnKapa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
