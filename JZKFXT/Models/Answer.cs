using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 答案
    /// </summary>
    public class Answer
    {
        public int ID { get; set; }
        /// <summary>
        /// 评估ID
        /// </summary>
        public int ExamID { get; set; }
        /// <summary>
        /// 问题ID
        /// </summary>
        public int QuestionID { get; set; }
        /// <summary>
        /// 选择的选项ID
        /// </summary>
        public string OptionIDs { get; set; }
        /// <summary>
        /// 评估对象ID
        /// </summary>
        public int DisabledInfoID { get; set; }

        /// <summary>
        /// 其他
        /// </summary>
        public string Other { get; set; }
    }
}