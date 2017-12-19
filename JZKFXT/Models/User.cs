using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string userName, string password, string realName, int roleID, DateTime? createTime)
        {
            UserName = userName;
            Password = password;
            RealName = realName;
            RoleID = roleID;
            CreateTime = createTime;
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public int RoleID { get; set; }

        [JsonIgnore]
        public virtual Role Role { get; set; }//残疾人康复详情
        public DateTime? CreateTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
        
    }
}