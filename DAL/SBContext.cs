using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SB_App.Models;
using System.Data.Entity;

namespace SB_App.DAL
{
    public class SprintbizContext : DbContext
    {
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Tax> Tax { get; set; }

        public System.Data.Entity.DbSet<SB_App.Models.Service> Services { get; set; }

        public System.Data.Entity.DbSet<SB_App.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<SB_App.Models.Organization> Organizations { get; set; }
    }
}