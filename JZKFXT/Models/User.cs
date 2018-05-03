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

        public User(string userName, string password, string realName, int? sex, string phone, string address, string idNumber, int roleID, DateTime? createTime, string img)
        {
            UserName = userName;
            Password = password;
            RealName = realName;
            Sex = sex;
            Phone = phone;
            Address = address;
            IDNumber = idNumber;
            RoleID = roleID;
            CreateTime = createTime;
            Img = img;
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }
        public int RoleID { get; set; }
        public int? Sex { get; set; }//性别
        public string Address { get; set; }//地址
        public string IDNumber { get; set; }//身份证

        [JsonIgnore]
        public virtual Role Role { get; set; }//残疾人康复详情
        public DateTime? CreateTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string Img { get; set; }//图片
    }
}