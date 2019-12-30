using MixErp302.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.User
{
    public partial class frmApGiris : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();

        public frmApGiris()
        {
            InitializeComponent();
        }

        private void frmApGiris_Load(object sender, EventArgs e)
        {
            
        }

        void GirisKontrol()
        {
            try
            {
                int srg = (from s in db.tblUsers
                           where s.KulAdi == txtKulAdi.Text &&
                           s.Sifre == txtSifre.Text
                           select s).First().Id;
                if (srg > 0)
                {
                    frmAnaSayfa ana = new frmAnaSayfa();
                    ana.WindowState = FormWindowState.Maximized;
                    ana.roleId = db.tblUsers.Find(srg).Role.Value;
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız."); 
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisKontrol();
        }
    }
}
