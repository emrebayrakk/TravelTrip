using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.sınıflar
{
    public class filmDizi
    {
        [Key]
        public int ID { get; set; }
        public string diziBaslik { get; set; }
        public string diziYorum { get; set; }
        public string diziImage { get; set; }
        
    }
}