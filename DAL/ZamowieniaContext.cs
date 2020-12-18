using System;
using ProjektZaliczenie.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektZaliczenie.DAL
{
    public class ZamowieniaContext:DbContext
    {
        public ZamowieniaContext():base("DefaultConnection")
        { }
        public DbSet<Zamowienia> Zamowienia { get; set; }
    }
}