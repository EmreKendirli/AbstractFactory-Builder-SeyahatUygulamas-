using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entity
{
    public class UlasimArac:IEntity
    {
        [Key]
        public int UlasimId { get; set; }
        public string SirketAdi { get; set; }
        public int KalkisYeriID { get; set; }
        public int VarisYeriID { get; set; }
        public string KalkisSaati { get; set; }
        public string VarisSaati { get; set; }
        public int Ucret { get; set; }
        public int AracTipi { get; set; }
    }
}
