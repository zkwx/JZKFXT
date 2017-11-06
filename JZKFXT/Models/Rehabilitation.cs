using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    //康复需求基础资料
    public class Rehabilitation
    {
        public int ID { get; set; }
        public String Code { get; set; }//编码
        public String Category { get; set; }//残疾类别
        public String CategoryDetail { get; set; }//残疾详细类别
        public String RehabilitationName { get; set; }//康复需求

        public virtual ICollection<DisabledInfo_Detail> DisabledInfo_Details { get; set; }//残疾人康复详情列表

    }
}