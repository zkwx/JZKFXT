using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public string Categories { get; set; }
        public string Certificate { get; set; }

        public DateTime? CreateTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
        
    }
}