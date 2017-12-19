using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 服务走向
    /// </summary>
    public class Next
    {
        public Next()
        {
        }

        public Next(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        public string Name { get; set; }

    }
}