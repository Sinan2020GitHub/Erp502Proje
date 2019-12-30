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
    public partial class FrmPersonelGiris : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();
        Numaralar N = new Numaralar(); //numaraları oluşturduktan sonra yaptık.
        int secimId = -1; //güncelleme
        bool edit = false; //güncelleme
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }
            
        private void FrmPersonelGiris_Load(object sender, EventArgs e)
        {
            Combo(); //1
            Listele();
            txtPersonelNo.Text = N.PersonelNo(); //sıradaki no personelde gözüksün diye.
        }
        void Temizle() //güncellemeden sonra açtık
        {
            foreach(Control con in split2.Panel1.Controls)
            {
                if(con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Text = "";
                }
                //txtDogumTarih.Text = DateTime.Now.ToLongDateString();
                secimId = -1;
                edit = false;
                txtPersonelNo.Text = N.PersonelNo();//numaralarla ilgili
                txtDepartman.SelectedIndex = 0; //numaralarla ilgili
            }
        }
        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblPersonels select s).ToList(); //personel tablosunda kayıt varsa srg nin içine atıyor.
            foreach(var k in srg)
            {
                liste.Rows.Add(); //döngüde her seferinde satır oluşturur.
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.PersonelNo;
                liste.Rows[i].Cells[2].Value = k.Adi;
                liste.Rows[i].Cells[3].Value = k.Tel;
                liste.Rows[i].Cells[4].Value = k.blgDepartman.DepartmanAdi; //foreign key ile bağladığımiçin kolaylık
                i++;
                 
              
            }
            liste.AllowUserToAddRows = false; //kullanıcı yeni satır ekleyemesin
        }

        private void Combo()
        {
            txtDepartman.DataSource = db.blgDepartmen.ToList();
            txtDepartman.ValueMember = "Id"; //db den kulandığımız alan
            txtDepartman.DisplayMember = "DepartmanAdi"; //gösterilmesini istediğimiz alan
            //txtDepartman.SelectedIndex = -1; //başlangıçta boş getirsin
            txtDepartman.SelectedIndex = 0;
        }
        private void YeniKaydet() //2
        {
            tblPersonel pers = new tblPersonel();
            pers.Adi = txtAd.Text; //solda yazdığım sağdakine bilgi taşır
            pers.Adres = txtAdres.Text;
            pers.DepartmanId = db.blgDepartmen.First(x => x.DepartmanAdi == txtDepartman.Text).Id; //Firs tek bir kayıt getirir.
            pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);
            //pers.DogumTarih = Convert.ToDateTime(txtDogumTarih.Text); ikisi de aynı.Tarihli olanları hep böyle yapmalıyız.
            //Parse de null diye bi değer gelirse hata verir.Convertte 0 değeri vericek.
            pers.Email = txtEmail.Text;
            pers.İsBasTarih = Convert.ToDateTime(txtİsBasTarih.Text);
            pers.İsSonTarih = Convert.ToDateTime(txtİsSonTarih.Text);
            pers.PersonelNo = txtPersonelNo.Text;
            pers.TcNo = txtTc.Text;
            pers.Tel = txtTel.Text;

            db.tblPersonels.Add(pers);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı.");
            Listele();
            Temizle();
           
            
        }
        void Guncelle() //yukardan kopyala yapıştır.
        {
            tblPersonel pers = db.tblPersonels.Find(secimId);
            pers.Adi = txtAd.Text; //solda yazdığım sağdakine bilgi taşır
            pers.Adres = txtAdres.Text;
            pers.DepartmanId = db.blgDepartmen.First(x => x.DepartmanAdi == txtDepartman.Text).Id; //Firs tek bir kayıt getirir.
            pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);
            //pers.DogumTarih = Convert.ToDateTime(txtDogumTarih.Text); ikisi de aynı.Tarihli olanları hep böyle yapmalıyız.
            //Parse de null diye bi değer gelirse hata verir.Convertte 0 değeri vericek.
            pers.Email = txtEmail.Text;
            pers.İsBasTarih = Convert.ToDateTime(txtİsBasTarih.Text);
            pers.İsSonTarih = Convert.ToDateTime(txtİsSonTarih.Text);
            pers.PersonelNo = txtPersonelNo.Text;
            pers.TcNo = txtTc.Text;
            pers.Tel = txtTel.Text;

            
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı.");
            Listele();
            Temizle();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if(edit==false) YeniKaydet();
        }

        private void liste_DoubleClick(object sender, EventArgs e) //properitisten yaptık
        {
            Sec();
            if(secimId>0)
            {
                Ac(secimId);
            }
        }

        private void Ac(int secimId)
        {
            edit = true; //güncelleme işlemi yapabilmek için
            tblPersonel pers = db.tblPersonels.Find(secimId);
            txtAd.Text = pers.Adi;              //tersten yaptık güncelleme işlemi için bunlar.
            txtAdres.Text = pers.Adres;
            txtDepartman.Text = pers.blgDepartman.DepartmanAdi; //foreign key
            txtDogumTarih.Text = pers.DogumTarih.ToString();
            txtİsBasTarih.Text = pers.İsBasTarih.ToString();
            txtİsSonTarih.Text = pers.İsSonTarih.ToString();
            txtPersonelNo.Text = pers.PersonelNo;
            txtTc.Text = pers.TcNo;
            txtTel.Text = pers.Tel;
            txtEmail.Text = pers.Email;
        }

        private void Sec() //güncelleme için
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
            
            db.tblPersonels.Remove(db.tblPersonels.Find(secimId));
            db.SaveChanges();
            MessageBox.Show($"{secimId}'nolu kayıt silinmiştir.");
            Listele();
            Temizle();

            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
