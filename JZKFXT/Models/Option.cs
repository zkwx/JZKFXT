using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 答案
    /// </summary>
    public class Option
    {
        public Option()
        {
        }
        public Option(string optionText, string contentText, string nextQuestionNo, params int[] assistiveDeviceIds)
        {
            OptionText = optionText;
            ContentText = contentText;
            NextQuestionNo = nextQuestionNo;

            AssistiveDevices = new List<AssistiveDevice>();
            foreach (var item in assistiveDeviceIds)
            {
                AssistiveDevices.Add(new AssistiveDevice(item));
            }
            
        }
        public Option(string optionText, string contentText, int examID, string nextQuestionNo, ICollection<AssistiveDevice> assistiveDevices)
        {
            OptionText = optionText;
            ContentText = contentText;
            ExamID = examID;
            NextQuestionNo = nextQuestionNo;
            AssistiveDevices = assistiveDevices;
        }
        public int ID { get; set; }
        /// <summary>
        /// 试卷ID
        /// </summary>
        public int ExamID { get; set; }
        /// <summary>
        /// 问题ID
        /// </summary>
        public int QuestionID { get; set; }
        /// <summary>
        /// 问题
        /// </summary>
        [JsonIgnore]
        public virtual Question Question { get; set; }
        /// <summary>
        /// 选项名 如ABCD
        /// </summary>
        public string OptionText { get; set; }
        /// <summary>
        /// 选项描述文字
        /// </summary>
        public string ContentText { get; set; }
        public string NextQuestionNo { get; set; }
        /// <summary>
        /// 转到下一问题的ID
        /// </summary>
        public int? NextQuestionID { get; set; }
        /// <summary>
        /// 分数
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// 辅具集合
        /// </summary>
        public virtual ICollection<AssistiveDevice> AssistiveDevices { get; set; }

    }
}