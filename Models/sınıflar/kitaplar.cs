using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.sınıflar
{
    public class kitaplar
    {
        [Key]
        public int ID { get; set; }
        public string kitapBaslik { get; set; } 
        public string kitapAciklama { get; set; }
        public string kitapImage { get; set; }
      
    }
}