using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WidraSoftCloud.UI.Shared
{
    public class LicenceAccess
    {
        private readonly WidraSoftCloud.UI.Data.WidraSoftCloudUIContext _context;
        int D { get; set; }
        int M { get; set; }
        int Y { get; set; }
        public int DaysLeft { get; set; }

        public LicenceAccess(WidraSoftCloud.UI.Data.WidraSoftCloudUIContext context)
        {
            _context = context;
        }
        public bool IsAuhtorized()
        {
            try
            {
                DateTime DateFin;
                var P = from p in _context.Parametre
                        select p;
                string DateDebut;
                DateDebut = (P.FirstOrDefault(e => e.TypeParametre == "VERSION").ParamInt1 / 10).ToString();
                DateDebut = DateDebut + "/" + (P.FirstOrDefault(e => e.TypeParametre == "VERSION").ParamInt2 / 10).ToString();
                DateDebut = DateDebut + "/" + (P.FirstOrDefault(e => e.TypeParametre == "VERSION").ParamInt3 / 100).ToString();
                var L = from l in _context.L
                        select l;
                if (L.FirstOrDefault().Type == "D")
                    DateFin = Convert.ToDateTime(DateDebut).Date.AddDays(7);
                else
                    DateFin = Convert.ToDateTime(DateDebut).Date.AddYears(1);
                DaysLeft =( DateFin - Convert.ToDateTime(DateDebut).Date).Days;
                

                if (DateFin <= DateTime.Now.Date)
                    return false;
                else
                    return true;
            }
            catch
            { 
                throw;
            }
        }

  
    }
}
