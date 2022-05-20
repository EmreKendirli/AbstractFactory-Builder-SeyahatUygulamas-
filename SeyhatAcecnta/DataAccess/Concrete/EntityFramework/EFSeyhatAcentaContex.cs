using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFSeyhatAcentaContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7T5TN1B;Database=SeyhatRezervasyon;Trusted_Connection=true");
        }
        public DbSet<Kullanici> KullaniciBilgileri { get; set; }
        public DbSet<UlasimArac> UlasimAraclari { get; set; }
        public DbSet<AracTipleri> AracTipleri { get; set; }
        public DbSet<KalkisYeri> KalkisYerleri { get; set; }
        public DbSet<VarisYeri> VarisYerleri { get; set; }
        public DbSet<KonaklamaBilgi> KonaklamaYerleri { get; set; }
        public DbSet<SeyhatBilgi> SeyhatBilgileri  { get; set; }
        public DbSet<YerTipi> YerTipleri  { get; set; }



    }
}
