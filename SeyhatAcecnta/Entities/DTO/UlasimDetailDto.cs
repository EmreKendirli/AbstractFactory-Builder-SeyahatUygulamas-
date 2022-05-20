using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTO
{
    public class UlasimDetailDto:IDto
    {
        [Key]
        public int UlasimId { get; set; }
        public string SirketAdi { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        public string KalkisSaati { get; set; }
        public string VarisSaati { get; set; }
        public int Ucret { get; set; }
        public string AracTipi { get; set; }
    }
}
