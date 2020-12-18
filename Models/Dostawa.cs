using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektZaliczenie.Models
{
    public class Dostawa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Uzupełnij pole dostawca")]
        [Display(Name ="Dostawca")]
        public string Dostawca { get; set; }
        [Required(ErrorMessage = "Uzupełnij pole opis")]
        public string Opis { get; set; }
        [StringLength(40,ErrorMessage ="Maksymalna długość wpisu to 40 znaków.")]
        public string Uwagi { get; set; }

    }
}