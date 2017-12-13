using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 残疾人残疾信息
    /// </summary>
    public class DisabledInfo_Detail
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }//残疾类别
        public int DegreeID { get; set; }//残疾等级
        public int? RehabilitationID { get; set; }//康复需求ID
        public int? NextID { get; set; }//服务走向
        public string TargetExamName { get; set; }//目标评估题目

        public int DisabledInfoID { get; set; }//残疾人基本信息ID

        [JsonIgnore]
        public virtual DisabledInfo DisabledInfo { get; set; }//残疾人基本信息
        [JsonIgnore]
        public virtual Category Category { get; set; }//残疾类别
        [JsonIgnore]
        public virtual Degree Degree { get; set; }//残疾等级
        [JsonIgnore]
        public virtual Rehabilitation Rehabilitation { get; set; }//康复需求
        [JsonIgnore]
        public virtual Next Next { get; set; }//残疾等级

    }
}