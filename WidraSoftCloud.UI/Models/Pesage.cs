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
        public string SyncId { get; set; }
        public string UniqueKey { get; set; }
        public int PontId { get; set; }
        [Display(Name = "Pont")]
        public string LibellePont { get; set; }
        public int CamionId { get; set; }
        [Display(Name = "Camion")]
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
        public DateTime DateArrivee { get; set; }
        [Display(Name = "Poids Total (Kg)")]
        public int PoidsNet { get; set; }
        [Display(Name = "Agent pesée")]
        public string AgentPesee { get; set; }
        public int ProvenanceId { get; set; }
        [Display(Name = "Provenance")]
        public string LibelleProvenance { get; set; }
        [Display(Name = "Date synchronisation")]
        public DateTime DateSynchronisation { get; set; }

        }


}

