using MixErp302.Bilgi;
using MixErp302.Urun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.Fonksiyonlar
{
    public class Formlar
    {
        #region Bilgi Giriş
        public void PersGiris()
        {
            frmPersonelGiris pers = new frmPersonelGiris();
            pers.MdiParent = frmAnaSayfa.ActiveForm;
            pers.WindowState = FormWindowState.Maximized;
            pers.Show();
        }
        public void CarGiris()
        {
            frmCariGiris car = new frmCariGiris();
            car.MdiParent = frmAnaSayfa.ActiveForm;
            car.WindowState = FormWindowState.Maximized;
            car.Show();
        }
        public void UrunGiris()
        {
            frmUrun urn = new frmUrun();
            urn.MdiParent = frmAnaSayfa.ActiveForm;
            urn.WindowState = FormWindowState.Maximized;
            urn.Show();
        }
        #endregion

        #region Ürün İşlemleri
        public void UrunAlis()
        {
            frmUrunAlis ualis = new frmUrunAlis();
            ualis.MdiParent = frmAnaSayfa.ActiveForm;
            ualis.WindowState = FormWindowState.Maximized;
            ualis.Show();
        }
        public void UrunSatis()
        {
            frmUrunSatis usatis = new frmUrunSatis();
            usatis.MdiParent = frmAnaSayfa.ActiveForm;
            usatis.WindowState = FormWindowState.Maximized;
            usatis.Show();
        }

        #endregion

        
    }
}
