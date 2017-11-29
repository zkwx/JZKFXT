using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 残疾等级
    /// 残疾等级分为1=一级，2=二级，3=三级，4=四级，5=未定级
    /// </summary>
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        public string Name { get; set; }
    }
}