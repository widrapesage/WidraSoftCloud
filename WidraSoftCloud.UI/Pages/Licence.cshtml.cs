using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WidraSoftCloud.UI.Pages
{
    public class LicenceModel : PageModel
    {
        private const int V = 1992;
        private readonly WidraSoftCloud.UI.Data.WidraSoftCloudUIContext _context;

        public LicenceModel(WidraSoftCloud.UI.Data.WidraSoftCloudUIContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int CodeA { get; set; }
        [BindProperty(SupportsGet = true)]
        public int I1 { get; set; }
        [BindProperty(SupportsGet = true)]
        public int I2 { get; set; }
        [BindProperty(SupportsGet = true)]
        public int I3 { get; set; }
        [BindProperty(SupportsGet = true)]
        public int I4 { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Type { get; set; }
        [BindProperty(SupportsGet = true)]
        public int NewCodeA { get; set; }
        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public String DateDebut { get; set;}
        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public String DateFin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int NewI1 { get; set; }
        [BindProperty(SupportsGet = true)]
        public int NewI2 { get; set; }
        [BindProperty(SupportsGet = true)]
        public int NewI3 { get; set; }
        [BindProperty(SupportsGet = true)]
        public int NewI4 { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UserMessage { get; set; }

        public DateTime GetDateDebut()
        {
            try
            {
                var P = from p in _context.Parametre
                        select p;
                string DateDebut;
                DateDebut = (P.FirstOrDefault(e => e.TypeParametre == "VERSION").ParamInt2 / 10).ToString();
                DateDebut = DateDebut + "/" + (P.FirstOrDefault(e => e.TypeParametre == "VERSION").ParamInt1 / 10).ToString();
                DateDebut = DateDebut + "/" + (P.FirstOrDefault(e => e.TypeParametre == "VERSION").ParamInt3 / 100).ToString();

                return Convert.ToDateTime(DateDebut).Date;

            }
            catch
            {
                throw;
            }
            
        }

        public DateTime GetDateFin(string type)
        {
            DateTime Datefin; 
            try
            {
                if (type == "D")
                     Datefin = GetDateDebut().AddDays(7);
                else
                     Datefin = GetDateDebut().AddYears(1);
            }
            catch
            {
                throw;
            }
            return Datefin.Date;

        }
        public Boolean CanUpdateLicence()
        {
            try
            {
                if (GetDateFin(Type) <= DateTime.Now.AddDays(6))
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }

        }
        public void OnGet()
        {
            try
            {
                var L = from l in _context.L
                        select l;
                if (L.Count() != 1)
                {
                    return;
                };
                CodeA = L.FirstOrDefault().CodeA;
                I1 = L.FirstOrDefault().I1;
                I2 = L.FirstOrDefault().I2;
                I3 = L.FirstOrDefault().I3;
                I4 = L.FirstOrDefault().I4;
                Type = L.FirstOrDefault().Type;
                DateDebut = GetDateDebut().ToString("dd/MM/yyyy");
                DateFin = GetDateFin(Type).ToString("dd/MM/yyyy");
            }
            catch
            {
                throw;
            }

        }

        public IActionResult OnPost()
        {
            try
            {
                int vl_code = (CodeA + I4 - I3 + I2 - I1) - V;
                if (NewCodeA == vl_code)
                {
                    var L = from l in _context.L
                            select l;
                    L.FirstOrDefault().CodeA = NewCodeA;
                    L.FirstOrDefault().I1 = NewI1;
                    L.FirstOrDefault().I2 = NewI2;
                    L.FirstOrDefault().I3 = NewI3;
                    L.FirstOrDefault().I4 = NewI4;
                    if (NewI1 == 1)
                        L.FirstOrDefault().Type = "D";
                    if (NewI1 == 2)
                        L.FirstOrDefault().Type = "N";
                    var P = from p in _context.Parametre
                            select p;
                    P = P.Where(e => e.TypeParametre == "VERSION");
                    P.FirstOrDefault().ParamInt2 = DateTime.Now.Date.Day * 10;
                    P.FirstOrDefault().ParamInt1 = DateTime.Now.Date.Month * 10;
                    P.FirstOrDefault().ParamInt3 = DateTime.Now.Date.Year * 100;

                    _context.SaveChanges();
                    UserMessage = "Nouvelle licence activée avec succès";
                    return RedirectToPage("./Password");
                }
                else
                {
                    UserMessage = "Le code entré est incorrect";
                    return Page();
                }

            }
            catch
            {
                throw;
            }
        }


    }
}
