using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    //残疾人康复详情
    public class DisabledInfo_Detail
    {
        public int ID { get; set; }
        public int? DisabledInfoID { get; set; }//残疾人信息ID
        public string Category { get; set; }//残疾类别
        public string Degree { get; set; }//残疾等级
        public int? RehabilitationID { get; set; }//康复需求ID
        public String Next { get; set; }//服务走向

        public virtual Rehabilitation Rehabilitation { get; set; }//残疾人信息
        public virtual DisabledInfo DisabledInfo { get; set; }//康复需求
    }
}