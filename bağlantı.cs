using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKayıtUygulaması
{
    internal class DatabaseContext:DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YUSUF\\SQLEXPRESS\\SQLDERS;Database=PersonelKayıtUygulamasıDb;Trusted_Connection=true; TrustServerCertificate=True");
        }
    }
}
