using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entity
{
    public class YerTipi:IEntity
    {
        [Key]
        public int YerTipiID { get; set; }
        public string YerAdi { get; set; }
    }
}
