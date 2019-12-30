using MixErp302.Data;
using MixErp302.Fonksiyonlar;
using MixErp302.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.Urun
{
    public partial class frmUrunAlis : Form
    {
        //2.işlem global alana db bağlantımızı ve gerekli olacak properity fieldlarımızı ekleriz
        MixErpDbEntities1 db = new MixErpDbEntities1();

        //3.islem numaralar sınıfında gerekli işlemi oluştur.
        Numaralar N = new Numaralar(); 
        int secimId = -1;
        int UrnAlisId = -1;
        bool edit = false; //güncelle ve kaydet için tek butonu iki şekilde kullanıyoruz.
        //9.işlem
        public string[] MyArray { get; set; }
        public frmUrunAlis()
        {
            InitializeComponent();
        }

        private void frmUrunAlis_Load(object sender, EventArgs e)
        {
            //1.işlem load eventi oluştur.

            //4.işlem numaralar sınıfında oluşturduğum metodu burada ilgili textbox için çalıştır.
            txtAlisGrupNo.Text = N.AlisGrupNo();

            //5.işlem Comboboxlar için Combo adında metod yaz ve bunu generate et.
            Combo();
        }

        private void Combo()
        {
            //6.işlem=> Cari adları için auto complete özelliğini açtığımız bir combobox doldurma yöntemi.
            txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCari.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = db.TblCaris.Select(x => x.CariAdi).Distinct();
            foreach(var cari in lst)
            {
                veri.Add(cari);
                txtCari.Items.Add(cari);
            }
            txtCari.AutoCompleteCustomSource = veri;
            //7.işlem=> Ödeme tipi için combobox doldur.

            txtOdemeTuru.DataSource = db.bOdemeTurleris.ToList();
            txtOdemeTuru.ValueMember = "Id";
            txtOdemeTuru.DisplayMember = "OdemeTipi";

            //8.işlem
            var srg = db.tblUrunlers.Select(x => x.UrunKodu); //Öğrennnnnnnnnnnnn
            foreach(var k in srg)
            {
                txtUrunKodu.Items.Add(k);
            }

            //10. işlem
            int dgv;
            dgv = txtUrunKodu.Items.Count;
            MyArray = new string[dgv];

            for(int i=0;i<dgv;i++)
            {
                MyArray[i] = txtUrunKodu.Items[i].ToString();
            }

                

                
        }

        private void liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) //11 datagridwiew şimşek
        {
            TextBox txt = e.Control as TextBox;
            if(liste.CurrentCell.ColumnIndex==0 && txt!=null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource.AddRange(MyArray);

            }
            else if(liste.CurrentCell.ColumnIndex!=0 && txt!=null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;
            }
        }

        private void liste_CellEndEdit(object sender, DataGridViewCellEventArgs e) //12
        {
            if(e.ColumnIndex==0)
            {
                string a = liste.CurrentRow.Cells[0].Value.ToString();
                var lst = (from s in db.tblUrunlers
                           where s.UrunKodu == a
                           select s).First();
                liste.CurrentRow.Cells[1].Value = lst.UrunAciklama;
                liste.CurrentRow.Cells[2].Value = lst.bBirim.BirimAdi;
            }
            if (e.ColumnIndex == 4)
            {
                if(liste.CurrentRow.Cells[3].Value!=null)
                {
                    Rowhesapla();
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (liste.CurrentRow.Cells[4].Value != null)
                {
                    Rowhesapla();
                }
            }
        }

        private void Rowhesapla()
        {
            if (liste.CurrentRow.Cells[3].Value!=null && liste.CurrentRow.Cells[4].Value!=null)
            {
                decimal a, b;
                a = Convert.ToDecimal(liste.CurrentRow.Cells[3].Value.ToString());
                b = Convert.ToDecimal(liste.CurrentRow.Cells[4].Value.ToString());
                liste.CurrentRow.Cells[5].Value = a * b * 0.18M;     //Decimal yapmak içim M koyduk F koyarsak float.   //cell[3]*cell[4] 

                decimal atop = 0;
                decimal ktop = 0;
                decimal gtop = 0;

                for (int i = 0; i < liste.RowCount; i++)
                {
                    atop += (Convert.ToDecimal(liste.Rows[i].Cells[3].Value) * Convert.ToDecimal(liste.Rows[i].Cells[4].Value)); //bunu bil!!!
                    ktop += Convert.ToDecimal(liste.Rows[i].Cells[5].Value);
                }
                gtop = atop + ktop;
                txtAraToplam.Text = atop.ToString();
                txtKdvToplam.Text = ktop.ToString();
                txtGenelToplam.Text = gtop.ToString();
            }
            else
            {
                MessageBox.Show("Adam gibi değer gir.");
                liste.CurrentRow.Cells[5].Value = "";
            }
            

;
        }
        void YeniKaydet()
        {
             

            var srch = new tblUrunAlisUst();
            srch.AlisGrupNo = txtAlisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.ATarihdate = Convert.ToDateTime(txtAlisTarihi.Text);
            srch.FaturaNo = txtFaturaNo.Text;
            srch.CariId = db.TblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.Vade = Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdemeTuru.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);

            db.tblUrunAlisUsts.Add(srch);
            db.SaveChanges();
            liste.AllowUserToAddRows = false; 




            tblUrunAlisAlt[] ualt = new tblUrunAlisAlt[liste.RowCount];
            for (int i = 0; i < liste.RowCount; i++)
            {
                ualt[i] = new tblUrunAlisAlt();
                ualt[i].Miktar = Convert.ToInt32(liste.Rows[i].Cells[4].Value.ToString());
                ualt[i].AlisGrupNo = txtAlisGrupNo.Text;
                ualt[i].BirimFiyat= Convert.ToDecimal(liste.Rows[i].Cells[3].Value.ToString());
                string brm = liste.Rows[i].Cells[2].Value.ToString();
                ualt[i].BirimId = db.bBirims.First(x => x.BirimAdi == brm).Id;
                string urn = liste.Rows[i].Cells[1].Value.ToString();
                ualt[i].UrunId = db.tblUrunlers.First(x => x.UrunAciklama == urn).Id;
                ualt[i].AToplam = Convert.ToDecimal(liste.Rows[i].Cells[3].Value)* Convert.ToDecimal(liste.Rows[i].Cells[4].Value);
                ualt[i].Kdv = Convert.ToDecimal(liste.Rows[i].Cells[5].Value);


                db.tblUrunAlisAlts.Add(ualt[i]);

                string uBarkot = liste.Rows[i].Cells[0].Value.ToString()+"/"+ liste.Rows[i].Cells[1].Value.ToString();
                var sKontrol = db.tblStokDurums.First(x => x.Barkod == uBarkot);
                

                decimal obFiyat;
                decimal ETopObFiyat;
                decimal YTopObFiyat;
                if (sKontrol.OBFiyat == null)
                {
                    obFiyat = 0;
                    ETopObFiyat = 0;
                }
                else
                {
                    obFiyat = sKontrol.OBFiyat.Value;
                    ETopObFiyat = obFiyat * sKontrol.Depo.Value;
                }
                YTopObFiyat = Convert.ToInt32(liste.Rows[i].Cells[3].Value) * Convert.ToInt32(liste.Rows[i].Cells[4].Value);

                decimal TopEYfiyat = ETopObFiyat + YTopObFiyat;
                int EAdet = sKontrol.Depo.Value;
                int YAdet = Convert.ToInt32(liste.Rows[i].Cells[4].Value);
                int TopEYAdet = EAdet + YAdet;
               decimal SonucBFiyat = TopEYfiyat / TopEYAdet;

                sKontrol.Ambar += 0;
                sKontrol.Depo += Convert.ToInt32(liste.Rows[i].Cells[4].Value);
                sKontrol.Raf += Convert.ToInt32(liste.Rows[i].Cells[4].Value);
                sKontrol.OBFiyat = SonucBFiyat;




                

            }
            db.SaveChanges();
                
          

            MessageBox.Show("Başarıyla Kaydedildi.");
        }

        void Guncelle()
        {
            var srch = db.tblUrunAlisUsts.First(x => x.AlisGrupNo == txtAlisGrupNo.Text);
            srch.AlisGrupNo = txtAlisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.ATarihdate = Convert.ToDateTime(txtAlisTarihi.Text);
            srch.FaturaNo = txtFaturaNo.Text;
            srch.CariId = db.TblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.Vade = Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdemeTuru.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);

           
            db.SaveChanges();
            liste.AllowUserToAddRows = false; 
            



            tblUrunAlisAlt[] ualt = new tblUrunAlisAlt[liste.RowCount];
            for (int i = 0; i<liste.RowCount; i++)
            {
                var altId = Convert.ToInt32(liste.Rows[i].Cells[6].Value);
                ualt[i] = db.tblUrunAlisAlts.First(x => x.AlisGrupNo == txtAlisGrupNo.Text && x.Id==altId);

                ualt[i].Miktar = Convert.ToInt32(liste.Rows[i].Cells[4].Value.ToString());
                ualt[i].AlisGrupNo = txtAlisGrupNo.Text;
                ualt[i].BirimFiyat= Convert.ToDecimal(liste.Rows[i].Cells[3].Value.ToString());
                string brm = liste.Rows[i].Cells[2].Value.ToString();
                ualt[i].BirimId = db.bBirims.First(x => x.BirimAdi == brm).Id;
                string urn = liste.Rows[i].Cells[1].Value.ToString();
                ualt[i].UrunId = db.tblUrunlers.First(x => x.UrunAciklama == urn).Id;
                ualt[i].AToplam = Convert.ToDecimal(liste.Rows[i].Cells[3].Value)* Convert.ToDecimal(liste.Rows[i].Cells[4].Value);
                ualt[i].Kdv = Convert.ToDecimal(liste.Rows[i].Cells[5].Value);

            }
            db.SaveChanges();
            MessageBox.Show("Başarıyla Güncellendi.");
        }

        private void btnkaydett_Click(object sender, EventArgs e)
        {
            if (edit && UrnAlisId > 0) Guncelle();
            else if(!edit) YeniKaydet();

        }

        protected override void OnLoad(EventArgs e)
        {
            //Buraya öyle bir kod yazacağımki değiştirmek istediğim kodun üzerine yazılarak onu manipule etmiş olacağım.
            var btnUrunAlisNo = new Button();
            btnUrunAlisNo.Size = new Size(25, txtAlisGrupNo.ClientSize.Height + 2);
            btnUrunAlisNo.Location = new Point(txtAlisGrupNo.ClientSize.Width - btnUrunAlisNo.Width, -1); //sanal butonun yerini belirlemek boyutunu.
            btnUrunAlisNo.Cursor = Cursors.Default;
            //btnUrunAlisNo.Image = Properties.Resources.arrow; içine indirdiğimiz arrow adındaki imageyi koyar.
            btnUrunAlisNo.Anchor = (AnchorStyles.Top | AnchorStyles.Right); 
            btnUrunAlisNo.Text=".."; //içine yazı yazar
            txtAlisGrupNo.Controls.Add(btnUrunAlisNo); 

            base.OnLoad(e);

            btnUrunAlisNo.Click += btnUrunAlisNo_Click;
        }
        Formlar F = new Formlar();

        private void btnUrunAlisNo_Click(object sender, EventArgs e) //sanal buton
        {
            int id = F.UrunAlisNo(true);
            if(id>0) //sonradan yaptık
            {
                Ac(id);
            }
            frmAnaSayfa.AktarmaInt = -1;
        }

        private void Ac(int id)
        {
            edit = true;
            UrnAlisId = id;
            string ustNo = id.ToString().PadLeft(7, '0');
            tblUrunAlisUst ust = db.tblUrunAlisUsts.First(x => x.AlisGrupNo ==ustNo);
            txtAlisGrupNo.Text = ust.AlisGrupNo;
            txtAraToplam.Text = ust.AraToplam.ToString();
            txtAlisTarihi.Text = ust.ATarihdate.ToString();
            txtCari.Text = ust.TblCari.CariAdi;
            txtFaturaNo.Text = ust.FaturaNo;
            txtGenelToplam.Text = ust.GenelToplam.ToString();
            txtKdvToplam.Text = ust.KdvToplam.ToString();
            txtOdemeTuru.Text = ust.bOdemeTurleri.OdemeTipi;
            txtVade.Text = ust.Vade.ToString();


            liste.Rows.Clear();
            liste.AllowUserToAddRows = false;

            int i = 0;
            var alt = (from s in db.tblUrunAlisAlts
                       where s.AlisGrupNo == ustNo
                       select s).ToList();
            foreach (var k in alt)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.tblUrunler.UrunKodu;
                liste.Rows[i].Cells[1].Value = k.tblUrunler.UrunAciklama;
                liste.Rows[i].Cells[2].Value = k.bBirim.BirimAdi;
                liste.Rows[i].Cells[3].Value = k.BirimFiyat;
                liste.Rows[i].Cells[4].Value = k.Miktar;
                liste.Rows[i].Cells[5].Value = k.Kdv;
                liste.Rows[i].Cells[6].Value = k.Id;
                i++;

            }
         


        }

        private void btnKapa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Yaz();
        }

        private void Yaz()
        {
            frmPrint pr = new frmPrint();
            pr.GrupNo = txtAlisGrupNo.Text;
            pr.HangiListe = "UrunAlis";
            pr.Show();

        }
    }
}
