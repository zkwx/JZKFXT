namespace JZKFXT.Migrations
{
    using JZKFXT.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JZKFXT.DAL.BaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(JZKFXT.DAL.BaseContext db)
        {
            var user = new User { UserName = "", Password = "", Role = "����Ա", CreateTime = DateTime.Today, LastLoginTime = DateTime.Today };
            db.Users.Add(user);
            db.SaveChanges();
            Rehabilitation rehabilitation = new Rehabilitation
            {
                Code = "010101",
                Category = "����",
                CategoryDetail = "ä��",
                RehabilitationName = "�����ϸ�������"
            };
            db.Rehabilitations.Add(rehabilitation);
            db.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
