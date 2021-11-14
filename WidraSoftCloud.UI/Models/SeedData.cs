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
        public static void Initialize_Utilisateur(IServiceProvider serviceProvider)
        {
            using (var context = new WidraSoftCloudUIContext(serviceProvider.GetRequiredService<DbContextOptions<WidraSoftCloudUIContext>>()))
            {
                try
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
                catch
                {
                    throw;
                }              
            }
        }

        public static void Initialize_Parametre(IServiceProvider serviceProvider)
        {
            using (var context = new WidraSoftCloudUIContext(serviceProvider.GetRequiredService<DbContextOptions<WidraSoftCloudUIContext>>()))
            {
                try
                {
                    if (context.Parametre.Any())
                    {
                        return;
                    }
                    context.Parametre.Add(new Parametre
                    {
                        TypeParametre = "VERSION",
                        ParamInt1 = DateTime.Now.Date.Day * 10,
                        ParamInt2 =  DateTime.Now.Date.Month * 10,
                        ParamInt3 =  DateTime.Now.Date.Year * 100
                    });
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public static void Initialize_L(IServiceProvider serviceProvider)
        {
            using (var context = new WidraSoftCloudUIContext(serviceProvider.GetRequiredService<DbContextOptions<WidraSoftCloudUIContext>>()))
            {
                try
                {
                    if (context.L.Any())
                    {
                        return;
                    }
                    context.L.Add(new L
                    {
                        Type = "D",
                        CodeA = 65540992,
                        I1 = 1,
                        I2 = 6,
                        I3 = 74,
                        I4 = 3,
                        Etat = "Actif"
                    });
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
