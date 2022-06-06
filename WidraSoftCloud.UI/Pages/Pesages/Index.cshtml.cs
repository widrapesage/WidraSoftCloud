using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WidraSoftCloud.UI.Data;
using WidraSoftCloud.UI.Models;

namespace WidraSoftCloud.UI.Pages.Pesages
{
    public class IndexModel : PageModel
    {
        private readonly WidraSoftCloud.UI.Data.WidraSoftCloudUIContext _context;

        public IndexModel(WidraSoftCloud.UI.Data.WidraSoftCloudUIContext context)
        {
            _context = context;
        }


        public IList<Pesage> Pesage { get;set; }
        
        public SelectList Ids { get; set; }
        public SelectList Ponts { get; set; }
        public SelectList Camions { get; set; }
        public SelectList Transporteurs { get; set; }
        public SelectList Produits { get; set; }
        public SelectList Destinations { get; set; }
        public SelectList Clients { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Provenances { get; set; }

       
        [BindProperty(SupportsGet = true)]
        public String Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Pont { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Camion { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Transporteur { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Produit { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Destination { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Client { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Categorie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Provenance { get; set; } 
        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; } = DateTime.Now;
        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]        
        public DateTime EndDate { get; set; } = DateTime.Now;
        [BindProperty(SupportsGet = true)]
        public bool IsDateFilterChecked { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            IQueryable<string> IdsQuery = from p in _context.Pesage
                                       orderby p.UniqueKey
                                          select p.UniqueKey;
            IQueryable<string> PontsQuery = from p in _context.Pesage
                                            orderby p.SyncId
                                            select p.SyncId;
            IQueryable<string> CamionsQuery = from p in _context.Pesage
                                              orderby p.LibelleCamion
                                              select p.LibelleCamion;
            IQueryable<string> TransporteursQuery = from p in _context.Pesage
                                                    orderby p.LibelleTransporteur
                                                    select p.LibelleTransporteur;
            IQueryable<string> ProduitsQuery = from p in _context.Pesage
                                               orderby p.LibelleProduit
                                               select p.LibelleProduit;
            IQueryable<string> DestinationsQuery = from p in _context.Pesage
                                                   orderby p.LibelleDestination
                                                   select p.LibelleDestination;
            IQueryable<string> ClientsQuery = from p in _context.Pesage
                                              orderby p.LibelleClient
                                              select p.LibelleClient;
            IQueryable<string> CategoriesQuery = from p in _context.Pesage
                                                 orderby p.CategorieCam
                                                 select p.CategorieCam;
            IQueryable<string> ProvenancesQuery = from p in _context.Pesage
                                                  orderby p.LibelleProvenance
                                                  select p.LibelleProvenance;
            IQueryable<DateTime> DatesQuery = from p in _context.Pesage
                                                  orderby p.DateArrivee
                                                  select p.DateArrivee;


            var pesages = from p in _context.Pesage
                          select p;

            if (Request.Cookies["UsernameCookie"] == null)
            {
                return RedirectToPage("/Password");
            }

            if (!string.IsNullOrEmpty(Id))
            {
                pesages = pesages.Where(p => p.UniqueKey == Id);
            }

            if (!string.IsNullOrEmpty(Pont))
            {
               pesages = pesages.Where(p => p.SyncId == Pont);
            }

            if (!string.IsNullOrEmpty(Camion))
            {
                pesages = pesages.Where(p => p.LibelleCamion == Camion);
            }

            if (!string.IsNullOrEmpty(Transporteur))
            {
                pesages = pesages.Where(p => p.LibelleTransporteur == Transporteur);
            }

            if (!string.IsNullOrEmpty(Produit))
            {
                pesages = pesages.Where(p => p.LibelleProduit == Produit);
            }

            if (!string.IsNullOrEmpty(Destination))
            {
                pesages = pesages.Where(p => p.LibelleDestination == Destination);
            }

            if (!string.IsNullOrEmpty(Client))
            {
                pesages = pesages.Where(p => p.LibelleClient == Client);
            }

            if (!string.IsNullOrEmpty(Categorie))
            {
                pesages = pesages.Where(p => p.CategorieCam == Categorie);
            }

            if (!string.IsNullOrEmpty(Provenance))
            {
                pesages = pesages.Where(p => p.LibelleProvenance == Provenance);
            }

            if (IsDateFilterChecked)
            {
                pesages = pesages.Where(p => p.DateArrivee >= StartDate).Where(p => p.DateArrivee <= EndDate);
            }

            Ids = new SelectList(await IdsQuery.Distinct().ToListAsync());
            Ponts = new SelectList(await PontsQuery.Distinct().ToListAsync());
            Camions = new SelectList(await CamionsQuery.Distinct().ToListAsync());
            Transporteurs = new SelectList(await TransporteursQuery.Distinct().ToListAsync());
            Produits = new SelectList(await ProduitsQuery.Distinct().ToListAsync());
            Destinations = new SelectList(await DestinationsQuery.Distinct().ToListAsync());
            Clients = new SelectList(await ClientsQuery.Distinct().ToListAsync());
            Categories = new SelectList(await CategoriesQuery.Distinct().ToListAsync());
            Provenances = new SelectList(await ProvenancesQuery.Distinct().ToListAsync());
            Pesage = await pesages.ToListAsync();
            
            return @Page();
        }

        public  FileResult OnPostExport()
        {
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[10] { new DataColumn("SyncId"),
                                    new DataColumn("UniqueKey"),
                                    new DataColumn("Id"),
                                    new DataColumn("LibellePont"), 
                                    new DataColumn("LibelleCamion"), 
                                    new DataColumn("LibelleProduit"), 
                                    new DataColumn("LibelleClient"), 
                                    new DataColumn("CategorieCam"), 
                                    new DataColumn("DateArrivee"), 
                                    new DataColumn("DateSynchronisation")
                                });

            var pesages = from p in _context.Pesage
                          select p;

            foreach (var pesage in pesages)
            {
                dt.Rows.Add(pesage.SyncId, pesage.UniqueKey, pesage.Id, pesage.LibellePont, pesage.LibelleCamion,
                         pesage.LibelleProduit, pesage.LibelleClient, pesage.CategorieCam, pesage.DateArrivee, pesage.DateSynchronisation );
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return  File(stream.ToArray() , "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "WidraSoftCloud-Pesages.xlsx");
                }
            }
        }
    }
}
