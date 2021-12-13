using System;
using System.ComponentModel.DataAnnotations;

namespace WidraSoftCloud.UI.Models
{
    public class PesageControle
    {
        public int Id { get; set; }
        public int PesageId { get; set; }
        public string SyncId { get; set; }
        public string UniqueKey { get; set; }
        public string CategorieCam { get; set; }
        public int PoidsTotalMaxAut { get; set; }
        public string Rang1 { get; set; }
        public int Poids1 { get; set; }
        public string Rang2 { get; set;}
        public int Poids2 { get; set; }
        public string Rang3 { get; set; }
        public int Poids3 { get; set; }
        public int Max1 { get; set; }
        public int Max2 { get; set; }
        public int Max3 { get; set; }
        public int Surcharge1 { get; set; }
        public int Surcharge2 { get; set; }
        public int Surcharge3 { get; set; }
        [Display(Name = "Date synchronisation")]
        public DateTime DateSynchronisation { get; set; }


    }
}
