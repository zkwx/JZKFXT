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

        public ExamRecord(int? examID, int disabledID, ExamState state)
        {
            ExamID = examID;
            DisabledID = disabledID;
            State = state;
        }

        public int ID { get; set; }
        /// <summary>
        /// 评估ID
        /// </summary>
        public int? ExamID { get; set; }
        /// <summary>
        /// 评估对象ID
        /// </summary>
        public int DisabledID { get; set; }
        /// <summary>
        /// 评估状态
        /// </summary>
        public ExamState State { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime? FinishTime { get; set; }
        /// <summary>
        /// 已机构评估
        /// </summary>
        public bool Evaluated { get; set; }
        //[JsonIgnore]
        public virtual Exam Exam { get; set; }
        [JsonIgnore]
        public virtual Disabled Disabled { get; set; }

    }
}