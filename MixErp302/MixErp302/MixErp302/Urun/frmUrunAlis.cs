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

namespace MixErp302.Urun
{
    public partial class frmUrunAlis : Form
    {
        //2.işlem global alana db bağlantımızı ve gerekli olacak property ve field larımızı ekleriz.
        MixErpDbEntities db = new MixErpDbEntities();

        //3.işlem Numaralar sınıfında gerekli metodu oluştur.
        Numaralar N = new Numaralar();
        int secimId = -1;
        bool edit = false;

        //9.işlem::
        public string[] MyArray { get; set; }
        

        


        public frmUrunAlis()
        {
            InitializeComponent();
        }

        private void frmUrunAlis_Load(object sender, EventArgs e)
        {
            //1.işlem Load event i oluşturulur.
            //4.işlem  Numaralar sınıfında oluşturduğum metodu burada ilgili textBox için çalıştır.
            txtAlisGrupNo.Text = N.AlisGrupNo();

            //5.işlem ==ComboBox lar için combo adında metod yaz ve bunu generate et.
            Combo();
        }

        private void Combo()
        {
            //6.işlem= Cari adları için autocomplete özelliğini açtığımız bir combobox doldurma yöntemi
            txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource; //a yazınca otomatik tamamlama yapar.
            txtCari.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = db.tblCaris.Select(x => x.CariAdi).Distinct();
            foreach (var cari in lst)
            {
                veri.Add(cari);
                txtCari.Items.Add(cari);

            }
            txtCari.AutoCompleteCustomSource = veri;

            //7.işlem Ödeme tipi için comboBox ı doldur.

            txtOdeme.DataSource = db.bOdemeTurleris.ToList();
            txtOdeme.ValueMember = "Id";
            txtOdeme.DisplayMember = "OdemeTipi";

            //8.işlem=

            var srg = db.tblUrunlers.Select(x => x.UrunKodu);

            foreach (var k in srg)
            {
                txtUKod.Items.Add(k);
            }

            //10.işlem==
            int dgv;
            dgv = txtUKod.Items.Count;
            MyArray = new string[dgv];

            for(int i = 0; i < dgv; i++)
            {
                MyArray[i] = txtUKod.Items[i].ToString();
            }

        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox; //datagridwiev in içindeki özellikleri getirir.
            if(Liste.CurrentCell.ColumnIndex==0 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource.AddRange(MyArray);
            }else if (Liste.CurrentCell.ColumnIndex!=0 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;
            }

        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string a = Liste.CurrentRow.Cells[0].Value.ToString();
                var lst = (from s in db.tblUrunlers
                           where s.UrunKodu == a
                           select s).First();

                Liste.CurrentRow.Cells[1].Value = lst.UrunAciklama;
                Liste.CurrentRow.Cells[2].Value = lst.bBirim.BirimAdi;
            }

          
            if (e.ColumnIndex == 4 )
            {
                if (Liste.CurrentRow.Cells[3].Value!=null)
                {
                    RHesapla(); 
                }

            }

            if (e.ColumnIndex == 3)
            {
                if (Liste.CurrentRow.Cells[4].Value != null)
                {
                    RHesapla();
                }

            }

        }

        private void RHesapla()
        {
            

            if (Liste.CurrentRow.Cells[3].Value!=null && Liste.CurrentRow.Cells[4].Value!=null)
            {
                decimal a, b;

               
                decimal atop = 0;
                decimal ktop = 0;
                decimal gtop = 0;
                a = Convert.ToDecimal(Liste.CurrentRow.Cells[3].Value.ToString());
                b = Convert.ToDecimal(Liste.CurrentRow.Cells[4].Value.ToString());

                Liste.CurrentRow.Cells[5].Value = a * b * 018M;  //decimal e cevirir.     //cell[3]*cell[4]
                                                                 //cell[3]*cell[4]

                for (int i = 0; i < Liste.RowCount-1; i++)
                {
                     

                    atop +=Convert.ToDecimal(Liste.Rows[i].Cells[3].Value) * Convert.ToDecimal(Liste.Rows[i].Cells[4].Value);
                    ktop += Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);
                }
                gtop = atop + ktop;
                txtAraToplam.Text = atop.ToString();
                txtKdvToplam.Text = ktop.ToString();
                txtGenelToplam.Text = gtop.ToString();

                
            }
            else
            {
                MessageBox.Show("Düzgün değer girin");
                Liste.CurrentRow.Cells[5].Value = "";
            }

            
        }

        void YeniKaydet(){



            var srch = new tblUrunAlisUst();
            srch.AlisGrupNo = txtAlisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.ATarih = Convert.ToDateTime(txtAlisTarih.Text);
            srch.FaturaNo = txtFaturaNo.Text;
            srch.CariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.Vade = Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdeme.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);
            db.tblUrunAlisUsts.Add(srch);
            db.SaveChanges();



            Liste.AllowUserToAddRows = false;
            tblUrunAlisAlt[] ualt = new tblUrunAlisAlt[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                ualt[i] = new tblUrunAlisAlt();
                ualt[i].Miktar = Convert.ToInt32(Liste.Rows[i].Cells[4].Value.ToString());
                ualt[i].AlisGrupNo = txtAlisGrupNo.Text;
                ualt[i].BFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value.ToString());

                string brm = Liste.Rows[i].Cells[2].Value.ToString();
                ualt[i].BirimId = db.bBirims.First(x => x.BirimAdi == brm).Id;

                string urn = Liste.Rows[i].Cells[1].Value.ToString();
                ualt[i].UrunId = db.tblUrunlers.First(x => x.UrunAciklama ==urn).Id;

                ualt[i].AToplam = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value) * Convert.ToDecimal(Liste.Rows[i].Cells[4].Value);
                ualt[i].Kdv = Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);


                db.tblUrunAlisAlts.Add(ualt[i]);

            }
            db.SaveChanges();
            MessageBox.Show("Başarıyla kaydedildi...");

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }
    }
}
