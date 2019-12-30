using MixErp302.Bilgi;
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
using System.Xml.Linq;

namespace MixErp302
{
    public partial class frmAnaSayfa : Form
    {
        Formlar F = new Formlar();
        public static int AktarmaInt = -1; //fromlardaki aktarmadan sonra
        public int roleId = -1;
        
            public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            RoleKontrol();
            KurKontrol();
        }

        public static bool KontrolInternet()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (client.OpenRead("http://google.com"))
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void KurKontrol()
        {

            if (frmAnaSayfa.KontrolInternet()==true)
            {
                if (txtDolar.Text == "$" || txtDolar.Text == "")
                {
                    XElement kurlar = XElement.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
                    XElement dolar = (from s in kurlar.Elements()
                                      where s.Attribute("CurrencyCode")?.Value == "USD" // ?boş gelince hata vermesini engeller.
                                      select s).Single();
                    XElement euro = (from s in kurlar.Elements()
                                     where s.Attribute("CurrencyCode")?.Value == "EUR" // ?boş gelince hata vermesini engeller.
                                     select s).Single();

                    txtDolar.Text = dolar.Element("ForexSelling").Value.ToString();
                    txtEuro.Text = euro.Element("ForexSelling").Value.ToString();
                } 
            }
            else
            {
                txtDolar.Text = "İnternet";
                txtEuro.Text = "Yok";
            }
        }

        private void RoleKontrol()
        {
            if (roleId == 1) btnAdmin.Enabled = true;
            else btnAdmin.Enabled = false;
        }

        private void btnBilgiDiris_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void btbUrun_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            F.PersGiris();
        }


        private void btnCariGiris_Click(object sender, EventArgs e)
        {
            F.CariGiris();
        }

        

        private void btnUrunGiris_Click_1(object sender, EventArgs e)
        {
            F.UrunGiris();
        }

        private void btnUrunAlis_Click(object sender, EventArgs e)
        {
            F.UrunAlis();
        }

        private void btnUrunSatis_Click(object sender, EventArgs e)
        {
            F.UrunSatis();
        }

        private void btnUrunAlisListe_Click(object sender, EventArgs e)
        {
            F.UrunAlisNo();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKulGiris_Click(object sender, EventArgs e)
        {
            F.KulGiris();
        }

        private void btnUrunSatisListele_Click(object sender, EventArgs e)
        {
            
            F.UrunSatisNo();
        }

        private void btnStokGit_Click(object sender, EventArgs e)
        {
            F.UrunStokNo();
        }
    }
}
