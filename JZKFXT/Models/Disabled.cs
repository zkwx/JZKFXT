using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JZKFXT.Models
{
    /// <summary>
    /// 残疾人基本信息
    /// </summary>
    public class Disabled
    {
        public Disabled()
        {
        }

        public Disabled(string name, int? sex, string tel, string guardian, int? relationshipID, bool hasCertificate, string certificate, bool need, int? categoryID, int? degreeID, DateTime? createTime)
        {
            Name = name;
            Sex = sex;
            Tel = tel;
            Guardian = guardian;
            RelationshipID = relationshipID;
            HasCertificate = hasCertificate;
            Certificate = certificate;
            Need = need;
            CategoryID = categoryID;
            DegreeID = degreeID;
            CreateTime = createTime;
        }

        public int ID { get; set; }///
        public string Name { get; set; }//姓名
        public int? Sex { get; set; }//性别
        public string Tel { get; set; }//电话
        public string Guardian { get; set; }//监护人
        public int? RelationshipID { get; set; }//监护人关系
        public Relationship Relationship { get; set; }//监护人关系

        public bool HasCertificate { get; set; }//监护人关系

        public string Certificate { get; set; }//残疾人证
        public string IDNumber { get; set; }//身份证
        public bool Need { get; set; }//有无康复需求

        public string Nation { get; set; }//民族
        public int Height { get; set; }//身高
        public int Weight { get; set; }//体重
        public string Email { get; set; }//Email
        public string Address { get; set; }//地址

        public string DisabledSignUrl { get; set; }//残疾人或监护人签字
        public string UserSignUrl { get; set; }//精准康复服务小组人员签字
        public DateTime? UpdateTime { get; set; }//修改时间
        public DateTime? CreateTime { get; set; }//创建时间

        public int? CategoryID { get; set; }//残疾证残疾类型
        public int? DegreeID { get; set; }//残疾证残疾等级

        public virtual ICollection<Disabled_Detail> Disabled_Details { get; set; }//残疾人康复详情

        public int? UserID { get; set; }

        public virtual User User { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }//残疾人康复详情
        [JsonIgnore]
        public virtual Degree Degree { get; set; }//残疾人康复详情

        //评估列表
        [JsonIgnore]
        public virtual ICollection<Answer> Answers { get; set; }//评估选择

        //评估
        [JsonIgnore]
        public virtual ICollection<ExamRecord> ExamRecords { get; set; }//评估选择
    }
}