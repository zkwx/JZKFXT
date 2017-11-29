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
    /// 致残原因
    /// </summary>
    public class DisabilityReason
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}