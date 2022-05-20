using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entity
{
    public class SeyhatBilgi:IEntity
    {
        [Key]
        public int SeyhatBilgisiID { get; set; }
        public int KullaniciId { get; set; }
        public int KonaklamaID { get; set; }
        public int UlasimID { get; set; }
        public DateTime RezervasyonBaslangic { get; set; }
        public DateTime RezervasyonBitis { get; set; }
        public int ToplamUcret { get; set; }
    }
}
