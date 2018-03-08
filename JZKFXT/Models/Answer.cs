using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 答案：1OptionIds 2OptionIds 3OptionIds 4OptionIds 5Other 6Options 7Others
    /// </summary>
    public class Answer
    {
        public Answer()
        {
        }

        public Answer(int disabledID, int examID, string questionNo, string optionIDs, string other, string area)
        {
            DisabledID = disabledID;
            ExamID = examID;
            QuestionNo = questionNo;
            OptionIDs = optionIDs;
            Other = other;
            Area = area;
        }
        public int ID { get; set; }
        /// <summary>
        /// 评估对象ID
        /// </summary>
        public int DisabledID { get; set; }
        /// <summary>
        /// 评估ID
        /// </summary>
        public int ExamID { get; set; }
        /// <summary>
        /// 问题No
        /// </summary>
        public string QuestionNo { get; set; }
        /// <summary>
        /// 选择的选项ID
        /// </summary>
        public string OptionIDs { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string Other { get; set; }
        /// <summary>
        /// 转存
        /// </summary>
        public string Area { get; set; }
    }
}