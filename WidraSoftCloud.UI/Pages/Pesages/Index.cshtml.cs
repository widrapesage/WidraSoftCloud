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
    public class IndexModel : PageModel
    {
        private readonly WidraSoftCloud.UI.Data.WidraSoftCloudUIContext _context;

        public IndexModel(WidraSoftCloud.UI.Data.WidraSoftCloudUIContext context)
        {
            _context = context;
        }

        public IList<Pesage> Pesage { get;set; }

        public async Task OnGetAsync()
        {
            Pesage = await _context.Pesage.ToListAsync();
        }
    }
}
