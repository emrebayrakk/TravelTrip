using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.sınıflar
{
    public class admin
    {
        [Key]
        public int ID { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}