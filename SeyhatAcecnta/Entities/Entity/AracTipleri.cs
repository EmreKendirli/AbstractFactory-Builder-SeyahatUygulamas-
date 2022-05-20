using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entity
{
    public class AracTipleri:IEntity
    {
        [Key]
        public int AracTipiID { get; set; }
        public string UlasimAdi { get; set; }
    }
}
