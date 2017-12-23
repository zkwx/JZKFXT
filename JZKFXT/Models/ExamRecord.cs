using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 评估记录
    /// </summary>
    public class ExamRecord
    {
        public ExamRecord()
        {
        }

        public ExamRecord(int? examID, int disabledInfoID)
        {
            ExamID = examID;
            DisabledInfoID = disabledInfoID;
        }

        public int ID { get; set; }
        /// <summary>
        /// 评估ID
        /// </summary>
        public int? ExamID { get; set; }
        /// <summary>
        /// 评估对象ID
        /// </summary>
        public int DisabledInfoID { get; set; }
        /// <summary>
        /// 已完成评估
        /// </summary>
        public bool Done { get; set; }
        /// <summary>
        /// 已机构评估
        /// </summary>
        public bool Evaluated { get; set; }
        //[JsonIgnore]
        public virtual Exam Exam { get; set; }
        [JsonIgnore]
        public virtual DisabledInfo DisabledInfo { get; set; }

    }
}