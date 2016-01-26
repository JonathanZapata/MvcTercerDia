using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcTercerDia.Models
{
    public class Customer
    {
        [Required(ErrorMessage="Código del Cliente es Requerido")]
        public string Código { get; set; }
        [StringLength(70)]
        public string Nombre { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }
        [Range(10, 25)]
        public int Age { get; set; }
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPass { get; set; }
    }
}