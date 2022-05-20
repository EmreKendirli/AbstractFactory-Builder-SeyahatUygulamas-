using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTO
{
    public class KonaklamaDetailDto:IDto
    {

        [Key]
        public int KonaklamaID { get; set; }
        public string SirketAdi { get; set; }
        public string KonaklamaTipi { get; set; }
        public int ucret { get; set; }
        public string TatilYeri { get; set; }
    }

}
