using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WidraSoftCloud.UI.Data;
using WidraSoftCloud.UI.Models;

namespace WidraSoftCloud.UI.Pages.Pesages
{
    public class DetailsModel : PageModel
    {
        private readonly WidraSoftCloud.UI.Data.WidraSoftCloudUIContext _context;

        public DetailsModel(WidraSoftCloud.UI.Data.WidraSoftCloudUIContext context)
        {
            _context = context;
        }

        public Pesage Pesage { get; set; }
        public PesageControle Pesagecontrole { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            Pesage = await _context.Pesage.FirstOrDefaultAsync(m => m.UniqueKey == id);
            Pesagecontrole = await _context.PesageControle.FirstOrDefaultAsync(p => p.UniqueKey == id); 

            if (Pesage == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
