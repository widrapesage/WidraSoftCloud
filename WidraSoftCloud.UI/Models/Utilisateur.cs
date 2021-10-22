using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WidraSoftCloud.UI.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [Display(Name = "Date d'inscription")]
        [DataType(DataType.Date)]
        public DateTime DateEntree { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
