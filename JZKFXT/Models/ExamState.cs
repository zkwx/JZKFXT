using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    public enum ExamState
    {
        待评估,
        已评估,
        待审核,
        已审核,
    }
}