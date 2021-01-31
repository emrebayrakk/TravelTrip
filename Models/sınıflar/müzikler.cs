using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.sınıflar
{
    public class müzikler
    {
        [Key]
        public int ID { get; set; }
        public string müzikBaslik { get; set; }
        public DateTime cikisTarih { get; set; }
        public string link { get; set; }


    }
}