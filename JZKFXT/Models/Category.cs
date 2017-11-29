using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 残疾类型 
    /// 残疾类型编号为：1=视力残疾，2=听力残疾，3=言语残疾，4=肢体残疾，5=智力残疾，6=精神残疾，7=多重残疾
    /// </summary>
    public class Category
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        public string Name { get; set; }
    }
}