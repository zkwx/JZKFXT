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
    /// </summary>
    public class Question
    {
        public Question()
        {
        }

        public Question(string questionNo, string questionText, bool isFirst, bool multiple, ICollection<Option> options)
        {
            QuestionNo = questionNo;
            QuestionText = questionText;
            IsFirst = isFirst;
            Multiple = multiple;
            Options = options;
        }
        public Question(string questionNo, string questionText, bool isFirst, bool multiple, bool nextMultiple, ICollection<Option> options)
        {
            QuestionNo = questionNo;
            QuestionText = questionText;
            IsFirst = isFirst;
            Multiple = multiple;
            NextMultiple = nextMultiple;
            Options = options;
        }
        public Question(string questionNo, string questionText,bool isWrite)
        {
            QuestionNo = questionNo;
            QuestionText = questionText;
            IsWrite = isWrite;
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
        /// 是否第一个问题
        /// </summary>
        public bool IsFirst { get; set; }
        /// <summary>
        /// 是否多选
        /// </summary>
        public bool Multiple { get; set; }
        /// <summary>
        /// 是否多选
        /// </summary>
        public bool IsWrite { get; set; }
        /// <summary>
        /// 是否进一步多选
        /// </summary>
        public bool NextMultiple { get; set; }
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