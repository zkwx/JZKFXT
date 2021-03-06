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

        public ExamRecord(int? examID, int disabledID, ExamState state)
        {
            ExamID = examID;
            DisabledID = disabledID;
            State = state;
        }
        public ExamRecord(int? examID, int disabledID, ExamState state, int first)
        {
            ExamID = examID;
            DisabledID = disabledID;
            State = state;
            First = first;
        }
        public ExamRecord(int? examID, int disabledID, ExamState state, bool evaluated)
        {
            ExamID = examID;
            DisabledID = disabledID;
            State = state;
            Evaluated = evaluated;
        }
        public ExamRecord(int? examID, int disabledID, ExamState state, bool evaluated, int? nextID)
        {
            ExamID = examID;
            DisabledID = disabledID;
            State = state;
            Evaluated = evaluated;
            NextID = nextID;
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
        /// <summary>
        /// 展示区域
        /// </summary>
        public string ShowArea { get; set; }
        /// <summary>
        /// 展示试卷
        /// </summary>
        public int ShowExam { get; set; }
        /// <summary>
        /// 服务走向
        /// </summary>
        public int? NextID { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public int Auditor { get; set; }
        /// <summary>
        /// 完成人
        /// </summary>
        public int Complete { get; set; }
        /// <summary>
        /// 原本试卷id
        /// </summary>
        public int First { get; set; }
        //[JsonIgnore]
        public virtual Exam Exam { get; set; }
        [JsonIgnore]
        public virtual Disabled Disabled { get; set; }

    }
}