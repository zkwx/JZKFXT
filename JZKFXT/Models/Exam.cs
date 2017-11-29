using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 评估
    /// </summary>
    public class Exam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        /// <summary>
        /// 评估名称
        /// </summary>
        public string ExamName { get; set; }
        /// <summary>
        /// 题目列表
        /// </summary>
        public virtual ICollection<Question> Questions { get; set; }

    }
}