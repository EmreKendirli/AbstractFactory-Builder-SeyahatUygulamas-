using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entity
{
    public class KonaklamaBilgi:IEntity
    {
        [Key]
        public int KonaklamaID { get; set; }
        public string SirketAdi { get; set; }
        public int YerTipiID { get; set; }
        public int ucret { get; set; }
        public int SirketYeriID { get; set; }
    }
}
