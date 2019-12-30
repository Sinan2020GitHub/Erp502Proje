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

namespace MixErp302
{
    public partial class frmAnaSayfa : Form
    {
        Formlar F = new Formlar();
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            pnl4.Visible = false;
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            pnl4.Visible = false;
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = true;
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
            F.CarGiris();
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
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
    }
}
