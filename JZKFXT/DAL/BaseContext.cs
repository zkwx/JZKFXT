using JZKFXT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace JZKFXT.DAL
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("ConnectString")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Rehabilitation> Rehabilitations { get; set; }
        public DbSet<DisabledInfo> RehabilitationHomes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//防止生成复数表名
        }
    }
}