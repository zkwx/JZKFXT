
using JZKFXT.Migrations;
using JZKFXT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace JZKFXT.DAL
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("ConnectString")
        {
            Database.SetInitializer<BaseContext>(new CreateDatabaseIfNotExists<BaseContext>());
            //Database.SetInitializer<BaseContext>(new MigrateDatabaseToLatestVersion<BaseContext, Configuration>());
            Database.Log = new Action<string>(q => Debug.WriteLine(q));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Next> Nexts { get; set; }
        public DbSet<Rehabilitation> Rehabilitations { get; set; }
        public DbSet<DisabledInfo> DisabledInfoes { get; set; }
        public DbSet<DisabledInfo_Detail> DisabledInfo_Details { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<ExamRecord> ExamRecords { get; set; }
        public System.Data.Entity.DbSet<JZKFXT.Models.DisabilityReason> DisabilityReasons { get; set; }


        public System.Data.Entity.DbSet<JZKFXT.Models.Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//防止生成复数表名
        }

        public System.Data.Entity.DbSet<JZKFXT.Models.AssistiveDevice> AssistiveDevices { get; set; }
    }
}