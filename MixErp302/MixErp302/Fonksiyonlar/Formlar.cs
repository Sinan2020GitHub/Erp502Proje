using MixErp302.Bilgi;
using MixErp302.Urun;
using MixErp302.ÜRÜN;
using MixErp302.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.Fonksiyonlar
{
    public class Formlar //claslar win formu kullanamıyor.
    {
        #region BİLGİ GİRİŞ
        public void PersGiris()
        {
            FrmPersonelGiris pers = new FrmPersonelGiris();
            pers.MdiParent = frmAnaSayfa.ActiveForm; //gri alanda formumu oluştursun
            pers.WindowState = FormWindowState.Maximized;   //tüm ekranı kaplaması için
            pers.Show();

        }
        public void CariGiris()
        {
            FrmPersonelCariGiris cari = new FrmPersonelCariGiris();
            cari.MdiParent = frmAnaSayfa.ActiveForm;
            cari.WindowState = FormWindowState.Maximized;
            cari.Show();
        }
        public void UrunGiris()
        {
            frmUrunGiris urun = new frmUrunGiris();
            urun.MdiParent = frmAnaSayfa.ActiveForm;
            urun.WindowState = FormWindowState.Maximized;
            urun.Show();
        }

        #endregion
        #region ÜRÜN İŞLEMLERİ
        public void UrunAlis()
        {
            frmUrunAlis ualis = new frmUrunAlis();
            ualis.MdiParent = frmAnaSayfa.ActiveForm; //gri alanda formumu oluştursun
            ualis.WindowState = FormWindowState.Maximized;   //tüm ekranı kaplaması için
            ualis.Show();

        }
        public void UrunSatis()
        {
            frmUrunSatis usatis = new frmUrunSatis();
            usatis.MdiParent = frmAnaSayfa.ActiveForm; //gri alanda formumu oluştursun
            usatis.WindowState = FormWindowState.Maximized;   //tüm ekranı kaplaması için
            usatis.Show();

        }
        public void KulGiris()
        {
            frmKulGiris kgir = new frmKulGiris();
            kgir.MdiParent = frmAnaSayfa.ActiveForm; //gri alanda formumu oluştursun
            kgir.WindowState = FormWindowState.Maximized;   //tüm ekranı kaplaması için
            kgir.Show();

        }

        public int UrunAlisNo(bool secim=false)
        {
            var frm = new frmUrunAlisListe();
            if(secim)
            {
                frm.Secim = true; 
                frm.ShowDialog(); //ayrı bir pencere gibi açar öncekini kapatmadan
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            return frmAnaSayfa.AktarmaInt;
        }

        public int UrunSatisNo(bool secim = false)
        {
            var frm = new frmUrunSatisListe();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog(); //ayrı bir pencere gibi açar öncekini kapatmadan
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            return frmAnaSayfa.AktarmaInt;
        }

        public int UrunStokNo(bool secim = false)
        {
            var frm = new StokDurumGoster();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog(); //ayrı bir pencere gibi açar öncekini kapatmadan
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            return frmAnaSayfa.AktarmaInt;
        }

        #endregion
    }

}
