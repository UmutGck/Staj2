using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenLayer_Map.Entity
{
    public class Kapi
    {
        [Key]

        [Display(Name = "Id")]
        public int Id { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public string KapiNo { get; set; }


    }
}