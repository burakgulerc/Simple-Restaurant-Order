using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeRestoran.Models
{
    public class Siparis : BaseEntity
    {
     
       
        public AraSicak AraSicak { get; set; }
        public AnaYemek AnaYemek { get; set; }
        public Icecek Icecek { get; set; }
        public Tatli Tatli { get; set; }


      

        
        public void TutarHesapla()
        {
            // property'lerin olduğu bir liste oluştur, listedeki property boşsa Fiyat toplamında kullanma.

            List<BaseEntity> baseEntities = new List<BaseEntity> { AraSicak, AnaYemek, Icecek, Tatli };

            foreach (BaseEntity entity in baseEntities)
            {
                if(entity != null)
                {
                    Fiyat += entity.Fiyat;
                }
            }

        }

        //public void SiparisKontrolEt()
        //{
        //    List<BaseEntity> baseEntities = new List<BaseEntity> { AraSicak, AnaYemek, Icecek, Tatli};
        //    foreach (BaseEntity item in baseEntities)
        //    {
        //        if (item == null)
        //        {
        //            System.Windows.Forms.MessageBox.Show("En az 1 ürün girmeden sipariş veremezsiniz.");
        //        }
        //    }
        //}

        public override string ToString()
        {
            return $"Masa {Isim} için sipariş, {AraSicak}, {AnaYemek}, {Tatli} ,{Icecek}, Toplam => {Fiyat:C2}";
        }

    }
}
