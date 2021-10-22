using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WidraSoftCloud.UI.Data;

namespace WidraSoftCloud.UI.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WidraSoftCloudUIContext(serviceProvider.GetRequiredService<DbContextOptions<WidraSoftCloudUIContext>>()))
            {
                if (context.Utilisateur.Any())
                {
                    return;
                }
                context.Utilisateur.Add(new Utilisateur
                {
                    Nom = "Manager",
                    Prenom = "Manager",
                    Login = "manager",
                    Password = "manager",
                    DateEntree = DateTime.Now.Date

                });
                context.SaveChanges();
            }
        }
    }
}
