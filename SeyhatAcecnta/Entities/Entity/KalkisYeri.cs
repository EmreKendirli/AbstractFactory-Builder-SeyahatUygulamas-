using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entity
{
    public class KalkisYeri:IEntity
    {
        [Key]
        public int KalkisYeriID { get; set; }
        public string KalkisYerAdi { get; set; }
    }
}
