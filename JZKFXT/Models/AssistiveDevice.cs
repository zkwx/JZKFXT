﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    public class AssistiveDevice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        public string Name { get; set; }
    }
}