using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WidraSoftCloud.UI.Models
{
    public class Pesage
    {
        
        public int Id { get; set; }
        [Display(Name = "SYNC_ID")]
        public string SyncId { get; set; }
        [Display(Name = "KEY")]
        public string UniqueKey { get; set; }
        public int PontId { get; set; }
        [Display(Name = "Pont")]
        public string LibellePont { get; set; }
        public int CamionId { get; set; }
        [Display(Name = "Matricule Tracteur")]
        public string LibelleCamion { get; set; }
        public string Flux { get; set; }
        public int TransporteurId { get; set; }
        [Display(Name = "Transporteur")]
        public string LibelleTransporteur { get; set; }
        public int ProduitId { get; set; }
        [Display(Name = "Produit")]
        public string LibelleProduit {get;set;}
        public int DestiprovenId { get; set; }
        [Display(Name = "Destination")]
        public string LibelleDestination { get; set; }
        public int ClientFourniId { get; set; }
        [Display(Name = "Client")]
        public string LibelleClient { get; set; }
        [Display(Name = "Catégorie")]
        public string CategorieCam { get; set; }
        public string Observations { get; set; }
        [Display(Name = "Date d'arrivée")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateArrivee { get; set; }
        [Display(Name = "Poids Total (Kg)")]
        public int PoidsNet { get; set; }
        [Display(Name = "Agent pesée")]
        public string AgentPesee { get; set; }
        public int ProvenanceId { get; set; }
        [Display(Name = "Provenance")]
        public string LibelleProvenance { get; set; }
        public int? RemorqueId { get; set; }
        [Display(Name = "Matricule Remorque")]
        public string LibelleRemorque { get; set; }
        [Display(Name = "Date synchronisation")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateSynchronisation { get; set; }

        }


}

