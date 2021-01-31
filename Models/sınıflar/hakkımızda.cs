using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.sınıflar
{
    public class hakkımızda
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}