using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektZaliczenie.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Uzupełnij pole nazwa")]
        [Display(Name ="Nazwa")]
        public string Nazwa { get; set; }
        [Required(ErrorMessage = "Uzupełnij pole opis")]
        public string Opis { get; set; }
        [Display(Name = "Dział")]
        public string Dział { get; set; }
        [StringLength(40,ErrorMessage ="Maksymalna długość wpisu to 40 znaków.")]
        public string Uwagi { get; set; }

    }
}