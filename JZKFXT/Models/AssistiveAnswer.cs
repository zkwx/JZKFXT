using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 辅具选择存储
    /// </summary>
    public class AssistiveAnswer
    {
        public AssistiveAnswer()
        {
        }

        public AssistiveAnswer(int iD, string name, string type, int disabledID, int examID, string optionIDs)
        {
            ID = iD;
            Name = name;
            Type = type;
            DisabledID = disabledID;
            ExamID = examID;
            OptionIDs = optionIDs;
        }
        public AssistiveAnswer(int iD, string name, string type, int disabledID, int examID, string optionIDs, int number)
        {
            ID = iD;
            Name = name;
            Type = type;
            DisabledID = disabledID;
            ExamID = examID;
            OptionIDs = optionIDs;
            Number = number;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        /// <summary>
        /// 辅具ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 辅具名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 辅具类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 评估对象ID
        /// </summary>
        public int DisabledID { get; set; }
        /// <summary>
        /// 评估ID
        /// </summary>
        public int ExamID { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public double Total { get; set; }
        /// <summary>
        /// 选择的选项ID
        /// </summary>
        public string OptionIDs { get; set; }

    }
}