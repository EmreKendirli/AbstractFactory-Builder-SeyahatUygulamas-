using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entity
{
    public class VarisYeri:IEntity
    {
        [Key]
        public int VarisYeriID { get; set; }
        public string VarisYeriAdi { get; set; }

    }
}
