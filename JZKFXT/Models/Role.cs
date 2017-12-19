using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    public class Role
    {
        public Role()
        {
        }

        public Role(int iD, string roleName, string description, string duty, string menuIDs)
        {
            ID = iD;
            RoleName = roleName;
            Description = description;
            Duty = duty;
            MenuIDs = menuIDs;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string Duty { get; set; }
        public string MenuIDs { get; set; }
    }
}