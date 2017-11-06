using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    //残疾人信息
    public class DisabledInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }//姓名
        public int Sex { get; set; }//性别
        public string Tel { get; set; }//电话
        public string Guardian { get; set; }//监护人
        public int? Relationship { get; set; }//监护人关系
        public string Certificate { get; set; }//残疾人证
        public string IDNumber { get; set; }//身份证
        public int? Need { get; set; }//有无康复需求
        public int? DoorService { get; set; }//是否需要上门服务
        public string UserSignUrl { get; set; }//精准康复服务小组人员签字
        public string PatientSignUrl { get; set; }//残疾人或监护人签字
        public DateTime UpdateTime { get; set; }//修改时间
        public DateTime CreateTime { get; set; }//创建时间

        public Guid? UserID { get; set; }
        public Guid? PatientID { get; set; }

        public virtual User User { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<DisabledInfo_Detail> DisabledInfo_Details { get; set; }//残疾人康复详情
    }
}