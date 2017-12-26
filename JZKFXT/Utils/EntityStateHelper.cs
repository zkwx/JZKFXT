using JZKFXT.DAL;
using JZKFXT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JZKFXT.Utils
{
    public class EntityStateHelper
    {
        public static void BindEntityState(BaseContext db, Disabled_Detail entity)
        {
            if (entity!=null)
            {
                if (entity.ID == 0)
                {
                    //有实体，无ID，新增
                    db.Entry(entity).State = EntityState.Added;
                }
                else
                {
                    //有实体，有ID，修改
                    db.Entry(entity).State = EntityState.Modified;
                }
            }
            else
            {
                if (entity.ID == 0)
                {
                    //无实体，有ID，删除
                    db.Entry(entity).State = EntityState.Deleted;
                }
            }
        }
    }
}