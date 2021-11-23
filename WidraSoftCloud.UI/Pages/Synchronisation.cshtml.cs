using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WidraSoftCloud.UI.Pages
{
    public class SynchronisationModel : PageModel
    {
        private readonly WidraSoftCloud.UI.Data.WidraSoftCloudUIContext _context;

        public SynchronisationModel(WidraSoftCloud.UI.Data.WidraSoftCloudUIContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
    }
}
