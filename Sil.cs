using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKayıtUygulaması
{
    public class Sil
    {
        public void PersonelSil(int personelID)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var personel = context.Personeller.Find(personelID);
                    if (personel == null)
                    {
                        throw new Exception("Silinecek personel bulunamadı.");
                    }

                    context.Personeller.Remove(personel);  
                    context.SaveChanges();  
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya uygun mesaj verebiliriz
                throw new Exception("Personel silinirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
