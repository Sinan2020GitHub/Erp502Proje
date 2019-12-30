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
    public partial class FrmPersonelCariGiris : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();
        Numaralar N = new Numaralar(); //numaraları oluşturduktan sonra yaptık.
        int secimId = -1; //güncelleme
        bool edit = false; //güncelleme
        

        public FrmPersonelCariGiris()
        {
            InitializeComponent();
        }

        private void FrmPersonelCariGiris_Load(object sender, EventArgs e)
        {
            Combo(); //1
            Listele();
            txtcarinoo.Text = N.CariNo(); //sıradaki no personelde gözüksün diye.
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
                txtcarinoo.Text = N.CariNo();//numaralarla ilgili
                txtcaritipid.SelectedIndex = 0; //numaralarla ilgili
            }
        }
        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.TblCaris select s).ToList(); //personel tablosunda kayıt varsa srg nin içine atıyor.
            foreach (var k in srg)
            {
                liste.Rows.Add(); //döngüde her seferinde satır oluşturur.
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.CariNo;
                liste.Rows[i].Cells[2].Value = k.CariAdi;
                liste.Rows[i].Cells[3].Value = k.Tel;
                liste.Rows[i].Cells[4].Value = k.blgCariTipi.CariTipi; //foreign key ile bağladığımiçin kolaylık
                i++;


            }
            liste.AllowUserToAddRows = false; //kullanıcı yeni satır ekleyemesin
        }



        private void Combo()
        {
            txtcaritipid.DataSource = db.blgCariTipis.ToList();
            txtcaritipid.ValueMember = "Id"; //db den kulandığımız alan
            txtcaritipid.DisplayMember = "CariTipi"; //gösterilmesini istediğimiz alan
            //txtDepartman.SelectedIndex = -1; //başlangıçta boş getirsin
            txtcaritipid.SelectedIndex = -1;

            txtsehirid.Items.Clear();
            var srg = (from s in db.illers select s).ToList();
            foreach(var k in srg)
            {
                txtsehirid.Items.Add(k.isim);
            }
        }
        private void YeniKaydet() //2
        {
            TblCari cari = new TblCari();
            cari.CariAdi = txtcariadii.Text; //solda yazdığım sağdakine bilgi taşır
            cari.Adres = txtadress.Text;
            cari.CariTipId = db.blgCariTipis.First(x => x.CariTipi == txtcaritipid.Text).Id; //Firs tek bir kayıt getirir.
            cari.SehirId = db.illers.First(x => x.isim == txtsehirid.Text).il_no;
            cari.Tel = txtcaritell.Text;
            //pers.DogumTarih = Convert.ToDateTime(txtDogumTarih.Text); ikisi de aynı.Tarihli olanları hep böyle yapmalıyız.
            //Parse de null diye bi değer gelirse hata verir.Convertte 0 değeri vericek.
            cari.VergiD = txtVergiDairesi.Text;
            cari.CariNo = txtcarinoo.Text;
            cari.VergiNoTc = txttcc.Text;
            cari.IlceId = db.ilcelers.First(x => x.isim == txtilceid.Text).ilce_no;
            
            

            db.TblCaris.Add(cari);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı.");
            Listele();
            Temizle();


        }

        

        void Guncelle() //yukardan kopyala yapıştır.
        {
            TblCari cari = db.TblCaris.Find(secimId);
            
            cari.CariAdi = txtcariadii.Text; //solda yazdığım sağdakine bilgi taşır
            cari.Adres = txtadress.Text;
            cari.CariTipId = db.blgCariTipis.First(x => x.CariTipi == txtcaritipid.Text).Id; //Firs tek bir kayıt getirir.
            cari.SehirId = db.illers.First(x => x.isim == txtsehirid.Text).il_no;
            cari.Tel = txtcaritell.Text;
            //pers.DogumTarih = Convert.ToDateTime(txtDogumTarih.Text); ikisi de aynı.Tarihli olanları hep böyle yapmalıyız.
            //Parse de null diye bi değer gelirse hata verir.Convertte 0 değeri vericek.
            cari.VergiD = txtVergiDairesi.Text;
            cari.CariNo = txtcarinoo.Text;
            cari.VergiNoTc = txttcc.Text;
            cari.IlceId = db.ilcelers.First(x => x.isim == txtilceid.Text).ilce_no;



            
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
            TblCari cari = db.TblCaris.Find(secimId);
            txtcariadii.Text =cari.CariAdi ;              //tersten yaptık güncelleme işlemi için bunlar.
            txtadress.Text = cari.Adres;
            txtcaritipid.Text = cari.blgCariTipi.CariTipi; //foreign key
            txtcarinoo.Text = cari.CariNo;
            txtcaritell.Text = cari.Tel;
            txtVergiDairesi.Text = cari.VergiD;
            txttcc.Text=cari.VergiNoTc;
            txtsehirid.Text = cari.iller.isim;
            txtilceid.Text = cari.ilceler.isim;

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

        private void btnSil_Click(object sender, EventArgs e) //güncelleme butonundan sonra
        {
            if (edit && secimId > 0)
            {
                Sil();
            }
        }

        private void Sil()
            {

            db.TblCaris.Remove(db.TblCaris.Find(secimId));
            db.SaveChanges();
            MessageBox.Show($"{secimId}'nolu kayıt silinmiştir.");
            Listele();
            Temizle();

        }

        private void txtsehirid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtilceid.Text = "";
            txtilceid.Items.Clear();
            int a = db.illers.First(x => x.isim == txtsehirid.Text).il_no;
            var srg = (from s in db.ilcelers where s.il_no == a select s).ToList();
            var lst = (from s in db.ilcelers where s.il_no == a select s).ToList();
            foreach(var k in lst)
            {
                txtilceid.Items.Add(k.isim);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
