using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKayıtUygulaması
{
    
        public class Guncelle
        {
        public void PersonelGuncelle(Personel personel)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var mevcutPersonel = context.Personeller.Find(personel.ID);
                    if (mevcutPersonel == null)
                    {
                        throw new Exception("Güncellenmek istenen personel bulunamadı.");
                    }

                    mevcutPersonel.Ad = personel.Ad;
                    mevcutPersonel.SoyAd = personel.SoyAd;
                    mevcutPersonel.Cinsiyet = personel.Cinsiyet;
                    mevcutPersonel.TcNo = personel.TcNo;
                    mevcutPersonel.TelNo = personel.TelNo;
                    mevcutPersonel.IseGirisTarihi = personel.IseGirisTarihi;
                    mevcutPersonel.Meslegi = personel.Meslegi;
                    mevcutPersonel.MedeniDurum = personel.MedeniDurum;

                    context.SaveChanges();  
                }
            }
            catch (Exception ex)
            {
             
                throw new Exception("Personel güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
            }
        }
    


