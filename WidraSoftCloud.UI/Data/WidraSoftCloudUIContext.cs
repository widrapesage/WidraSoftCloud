using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WidraSoftCloud.UI.Models;

namespace WidraSoftCloud.UI.Data
{
    public class WidraSoftCloudUIContext : DbContext
    {
        public WidraSoftCloudUIContext (DbContextOptions<WidraSoftCloudUIContext> options)
            : base(options)
        {
        }

        public DbSet<WidraSoftCloud.UI.Models.Utilisateur> Utilisateur { get; set; }
        public DbSet<WidraSoftCloud.UI.Models.Pesage> Pesage { get; set; }
        public DbSet<WidraSoftCloud.UI.Models.PesageControle> PesageControle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Pesage>().HasKey(e => e.UniqueKey);
            modelbuilder.Entity<PesageControle>().HasKey(e => e.Id);
            
        }
    }
}
