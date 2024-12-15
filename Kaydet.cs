using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKayıtUygulaması
{
  
        public class Kaydet
        {
        public void PersonelEkle(Personel personel)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Personeller.Add(personel);
                    context.SaveChanges();  
                }
            }
            catch (Exception ex)
            {
             
                throw new Exception("Personel kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
            
        
    

    

