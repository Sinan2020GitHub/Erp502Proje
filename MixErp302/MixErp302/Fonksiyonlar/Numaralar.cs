using MixErp302.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixErp302.Fonksiyonlar
{
    
   public class Numaralar
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();

        public string PersonelNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblPersonels orderby s.Id descending select s).First().PersonelNo); //Id ye göre büyükten küçüğe doğru sırala.
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); //Padleft soluna 7 hane olacak.0 ekle sonuna ne kadar gerekirse.
                return num; //tbl personele sağ tık show table data yaptık huniye tıkladık Id yi descending yaptık.
            }
            catch (Exception)
            {

                return "0000001"; 
            }

        }
        public string CariNo()
        {
            try
            {
                double numara = double.Parse((from s in db.TblCaris orderby s.Id descending select s).First().CariNo); //Id ye göre büyükten küçüğe doğru sırala.
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); //Padleft soluna 7 hane olacak.0 ekle sonuna ne kadar gerekirse.
                return num; //tbl personele sağ tık show table data yaptık huniye tıkladık Id yi descending yaptık.
            }
            catch (Exception)
            {

                return "0000001";
            }

        }
        public string UrunNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblUrunlers orderby s.Id descending select s).First().UrunKodu); //Id ye göre büyükten küçüğe doğru sırala.
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); //Padleft soluna 7 hane olacak.0 ekle sonuna ne kadar gerekirse.
                return num; //tbl personele sağ tık show table data yaptık huniye tıkladık Id yi descending yaptık.
            }
            catch (Exception)
            {

                return "0000001";
            }

        }
        public string AlisGrupNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblUrunAlisUsts orderby s.Id descending select s).First().AlisGrupNo); //Id ye göre büyükten küçüğe doğru sırala.
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); //Padleft soluna 7 hane olacak.0 ekle sonuna ne kadar gerekirse.
                return num; //tbl personele sağ tık show table data yaptık huniye tıkladık Id yi descending yaptık.

            }
            catch (Exception)
            {

                return "0000001";
            }

        }

        public string StokKod()
        {
            try
            {
                double numara = double.Parse((from s in db.tblStokDurums orderby s.Id descending select s).First().StokKodu); //Id ye göre büyükten küçüğe doğru sırala.
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); //Padleft soluna 7 hane olacak.0 ekle sonuna ne kadar gerekirse.
                return num; //tbl personele sağ tık show table data yaptık huniye tıkladık Id yi descending yaptık.

            }
            catch (Exception)
            {

                return "0000001";
            }

        }
        public string SatisGrupNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblUrunSatisUsts orderby s.Id descending select s).First().SatisGrupNo); //Id ye göre büyükten küçüğe doğru sırala.
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); //Padleft soluna 7 hane olacak.0 ekle sonuna ne kadar gerekirse.
                return num; //tbl personele sağ tık show table data yaptık huniye tıkladık Id yi descending yaptık.

            }
            catch (Exception)
            {

                return "0000001";
            }

        }




    }

}
