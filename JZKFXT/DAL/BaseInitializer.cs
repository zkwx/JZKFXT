using JZKFXT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace JZKFXT.DAL
{
    public class BaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BaseContext>
    {
        protected override void Seed(BaseContext db)
        {
            var user = new User { UserName = "", Password = "", Role = "管理员",CreateTime=DateTime.Today,LastLoginTime= DateTime.Today };
            db.Users.Add(user);
            db.SaveChanges();
            Rehabilitation rehabilitation = new Rehabilitation
            {
                Code="010101",
                Category= "视力",
                CategoryDetail = "盲人",
                RehabilitationName = "白内障复明手术"
            };
            db.Rehabilitations.Add(rehabilitation);
            db.SaveChanges();
            //DisabledInfo disabledInfo = new DisabledInfo
            //{
            //    Name = "李腾",
            //    Sex = 0,
            //    Tel = "13000000000",
            //    Guardian = "",
            //    Relationship = 0,
            //    Certificate = "32030211111111111111",
            //    IDNumber = "320302111111111111",
            //    Need = 1
            //};
            //db.RehabilitationHomes.a(rehabilitationHome);
            //db.SaveChanges();
        }
    }
}