using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektZaliczenie.Models
{
    public class Zamowienia
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Uzupełnij pole uzytkownik")]
        [Display(Name ="Uzytkownik")]
        public string Uzytkownik { get; set; }
        [Required(ErrorMessage = "Uzupełnij pole opis")]
        public string Opis { get; set; }

    }
}