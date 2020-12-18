using System;
using ProjektZaliczenie.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektZaliczenie.DAL
{
    public class DostawaContext:DbContext
    {
        public DostawaContext():base("DefaultConnection")
        { }
        public DbSet<Dostawa> Dostawa{ get; set; }
    }
}