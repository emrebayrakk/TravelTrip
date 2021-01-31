using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTrip.Models.sınıflar
{
    public class context: DbContext
    {
        public DbSet<admin> admins { get; set; }
        public DbSet<adresblog> adresblogs { get; set; }
        public DbSet<blog> blogs { get; set; }
        public DbSet<hakkımızda> hakkımızdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<yorumlar> yorumlars { get; set; }
        public DbSet<kitaplar> kitaplars { get; set; }
        public DbSet<filmDizi> filmDizis { get; set; }
        public DbSet<müzikler> müziklers { get; set; }



    }
}