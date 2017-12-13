using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 康复需求
    /// </summary>
    public class Rehabilitation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        /// <summary>
        /// 残疾类别ID
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// 残疾类别
        /// </summary>
        public String Category { get; set; }
        /// <summary>
        /// 残疾详细类别
        /// </summary>
        public String CategoryDetail { get; set; }
        /// <summary>
        /// 康复需求
        /// </summary>
        public String RehabilitationName { get; set; }
        /// <summary>
        /// 康复需求是否含有辅助器具适配
        /// </summary>
        public bool FuJu { get; set; }
    }
}