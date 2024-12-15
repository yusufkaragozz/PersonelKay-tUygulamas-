using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKayıtUygulaması
{
   
    
        public class Personel
        {
            public int ID { get; set; }             
            public string Ad { get; set; }          
            public string SoyAd { get; set; }       
            public bool Cinsiyet { get; set; }      // Cinsiyet (true: Erkek, false: Kadın)
            public string TcNo { get; set; }        
            public string TelNo { get; set; }      
            public DateTime IseGirisTarihi { get; set; } 
            public string Meslegi { get; set; }     
            public bool MedeniDurum { get; set; }   // Medeni Durum (true: Evli, false: Bekar)
        }


    }

