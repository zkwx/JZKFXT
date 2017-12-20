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

        public Option(string optionText, string contentText,int? nextQuestionID, string assistiveDeviceID, string assistiveDeviceName)
        {
            OptionText = optionText;
            ContentText = contentText;
            NextQuestionID = nextQuestionID;
            AssistiveDeviceID = assistiveDeviceID;
            AssistiveDeviceName = assistiveDeviceName;
        }
        public Option(string optionText, string contentText, int? nextQuestionID, string NextQuestionNo,string assistiveDeviceID, string assistiveDeviceName)
        {
            OptionText = optionText;
            ContentText = contentText;
            NextQuestionID = nextQuestionID;
            NextQuestionNo = NextQuestionNo;
            AssistiveDeviceID = assistiveDeviceID;
            AssistiveDeviceName = assistiveDeviceName;
        }
        public int ID { get; set; }
        /// <summary>
        /// 问题ID
        /// </summary>
        public int QuestionID { get; set; }
        /// <summary>
        /// 问题ID
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
        /// 辅具编码
        /// </summary>
        public string AssistiveDeviceID { get; set; }
        public string AssistiveDeviceName { get; set; }
    }
}