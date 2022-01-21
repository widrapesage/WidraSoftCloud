using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WidraSoftCloud.UI.Data;
using WidraSoftCloud.UI.Models;
using WidraSoftCloud.UI.Shared;
using Microsoft.Extensions.Configuration;

namespace WidraSoftCloud.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IConfiguration Configuration;

        public string UserMessage { get; set; } 
        public bool CanUpdateLicence { get; set; } 

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult OnGet()
        {
            var contextOptions = new DbContextOptionsBuilder<WidraSoftCloudUIContext>()
                .UseSqlServer(Configuration.GetConnectionString("WidraSoftCloudUIContext")).Options;
            var context = new WidraSoftCloudUIContext(contextOptions);
            LicenceAccess licenceAccess = new LicenceAccess(context);

            if (licenceAccess.CanUpdateLicence())
                CanUpdateLicence = true;
            else
                CanUpdateLicence = false;

            if (licenceAccess.IsAuhtorized())
            {
               // UserMessage = "Il vous reste " + licenceAccess.DaysLeft.ToString() + " jour(s) avant la fin de votre licence.";
                return Page();
            }
            else
            {
                UserMessage = "Licence WidraSoftCloud expirée.";
                return RedirectToPage("./Licence");                               
            }

        }
    }
}
