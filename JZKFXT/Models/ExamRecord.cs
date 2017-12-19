﻿using Newtonsoft.Json;
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

        public ExamRecord(int iD, int examID, int disabledInfoID, Exam exam, DisabledInfo disabledInfo)
        {
            ID = iD;
            ExamID = examID;
            DisabledInfoID = disabledInfoID;
            Exam = exam;
            DisabledInfo = disabledInfo;
        }

        public int ID { get; set; }
        /// <summary>
        /// 评估ID
        /// </summary>
        public int ExamID { get; set; }
        /// <summary>
        /// 评估对象ID
        /// </summary>
        public int DisabledInfoID { get; set; }

        [JsonIgnore]
        public virtual Exam Exam { get; set; }
        [JsonIgnore]
        public virtual DisabledInfo DisabledInfo { get; set; }

    }
}