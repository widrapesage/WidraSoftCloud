using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WidraSoftCloud.UI.Models;

namespace WidraSoftCloud.UI
{
    public class PasswordModel : PageModel
    {
        private readonly WidraSoftCloud.UI.Data.WidraSoftCloudUIContext _context;

        public PasswordModel(WidraSoftCloud.UI.Data.WidraSoftCloudUIContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string UserLogin { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UserPassword { get; set; }
        [BindProperty]
        public Utilisateur Utilisateur { get; set; }
        public  IActionResult OnPost()
        {
            var utilisateurs = from u in _context.Utilisateur
                               select u;
            if (!string.IsNullOrEmpty(UserLogin) || !string.IsNullOrEmpty(UserPassword))
            {
                utilisateurs =  utilisateurs.Where(e => (e.Login == UserLogin) && (e.Password == UserPassword));
                if (utilisateurs.Any())
                {
                    return RedirectToPage("./Home");
                }
                else
                {
                   
                    return Page();
                    
                }
            }
            else
            {
                return Page();
            }
        }
        
    }
}
 