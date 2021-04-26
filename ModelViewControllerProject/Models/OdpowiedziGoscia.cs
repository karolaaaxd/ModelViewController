using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ModelViewControllerProject.Models
{
    public class OdpowiedziGoscia
    {
        [Required(ErrorMessage = "UPS, musisz podać imię")]

        public string Imie { get; set; }
        [Required(ErrorMessage = "Proszę wpisz adres e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Podałeś nieprawidłowy adres e-mail")]
        public string Email { get; set; }
       
        [Required(ErrorMessage = "Wskaż właściwą odpowiedź, to dla nas ważne")]
        public bool Odpowiedz { get; set; }
    }
}