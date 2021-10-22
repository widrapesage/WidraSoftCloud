using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WidraSoftCloud.UI.Data;
using WidraSoftCloud.UI.Models;

namespace WidraSoftCloud.UI.Pages.Utilisateurs
{
    public class IndexModel : PageModel
    {
        private readonly WidraSoftCloud.UI.Data.WidraSoftCloudUIContext _context;

        public IndexModel(WidraSoftCloud.UI.Data.WidraSoftCloudUIContext context)
        {
            _context = context;
        }

        public IList<Utilisateur> Utilisateur { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchStringLogin { get; set; }
        public SelectList Noms { get; set; }
        public SelectList Prenoms { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UtilisateurNom { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UtilisateurPrenom { get; set; }



        public async Task OnGetAsync()
        {
            IQueryable<string> NomQuery = from u in _context.Utilisateur
                                          orderby u.Nom
                                          select u.Nom;
            IQueryable<string> PrenomQuery = from u in _context.Utilisateur
                                             orderby u.Prenom
                                             select u.Prenom;

            var utilisateurs = from u in _context.Utilisateur
                               select u;
            if (!string.IsNullOrEmpty(SearchStringLogin))
            {
                utilisateurs = utilisateurs.Where(s => s.Login.Contains(SearchStringLogin));
            }

            if (!string.IsNullOrEmpty(UtilisateurNom))
            {
                utilisateurs = utilisateurs.Where(s => s.Nom == UtilisateurNom);

            }

            if (!string.IsNullOrEmpty(UtilisateurPrenom))
            {
                utilisateurs = utilisateurs.Where(s => s.Prenom == UtilisateurPrenom);

            }
            Noms = new SelectList(await NomQuery.Distinct().ToListAsync());
            Prenoms = new SelectList(await PrenomQuery.Distinct().ToListAsync());
            Utilisateur = await utilisateurs.ToListAsync();
        }
    }
}
