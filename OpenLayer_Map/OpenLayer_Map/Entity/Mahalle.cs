using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenLayer_Map.Entity
{
    public class Mahalle 
    {
        [Key]

        [Display(Name = "Id")]
        public int Id { get; set; }
        public string MahalleAdi { get; set; }
        public string Koordinatlar{ get; set; }  

    }
}