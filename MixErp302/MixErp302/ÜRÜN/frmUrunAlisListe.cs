﻿using MixErp302.Data;
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
    public partial class frmUrunAlisListe : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();
        int secimId = -1; //güncelleme
        public bool Secim = false;
        public frmUrunAlisListe()
        {
            InitializeComponent();
        }

        private void frmUrunAlisListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblUrunAlisUsts select s).ToList();
            foreach (var k in srg)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.AlisGrupNo;
                liste.Rows[i].Cells[1].Value = k.TblCari.CariAdi;
                liste.Rows[i].Cells[2].Value = k.ATarihdate;
                i++;

            }
            liste.AllowUserToAddRows = false;
        }

        

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapatt_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && secimId>0)
            {
                frmAnaSayfa.AktarmaInt = secimId;
                Close();
            }
        }

        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(liste.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        
    }
}
