using System;
using ProjektZaliczenie.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektZaliczenie.DAL
{
    public class ZasobyContext:DbContext
    {
        public ZasobyContext():base("DefaultConnection")
        { }
        public DbSet<Produkt> Zasoby { get; set; }
    }
}