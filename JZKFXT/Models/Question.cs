using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 测试题目
    /// type：1单选 2多选 3单选下的选择 4多选下的选择 5填空  6身体部位图片选择 7上传图片
    /// 题目：1Options 2Options 3Options 4Options 5无  6前台js 7前台input
    /// 答案：1OptionIds 2OptionIds 3OptionIds 4OptionIds 5Other 6Options 7Others
    /// 
    /// </summary>
    public class Question
    {
        public Question()
        {
        }

        public Question(string questionNo, string questionText, int type, ICollection<Option> options)
        {
            QuestionNo = questionNo;
            QuestionText = questionText;
            Type = type;
            Options = options;
        }
        public Question(string questionNo, string questionText, int type)
        {
            QuestionNo = questionNo;
            QuestionText = questionText;
            Type = type;
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        /// <summary>
        /// 评估ID
        /// </summary>
        public int ExamID { get; set; }
        /// <summary>
        /// 题目号码
        /// </summary>
        public string QuestionNo { get; set; }
        /// <summary>
        /// 题目内容
        /// </summary>
        public string QuestionText { get; set; }
        /// <summary>
        /// 题目类型编号
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 选项列表
        /// </summary>
        public virtual ICollection<Option> Options { get; set; }//残疾人康复详情
        

        /// <summary>
        /// 评估
        /// </summary>
        [JsonIgnore]
        public virtual Exam Exam { get; set; }//残疾人康复详情


    }
}