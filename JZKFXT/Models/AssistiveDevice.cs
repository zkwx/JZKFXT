using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JZKFXT.Models
{
    public class AssistiveDevice
    {
        public AssistiveDevice()
        {
        }
        public AssistiveDevice(int iD)
        {
            ID = iD;
        }
        public AssistiveDevice(int iD, string name, string type)
        {
            ID = iD;
            ParentAssistiveDeviceID = iD/100;
            Name = name;
            Type = type;
        }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        public int ParentAssistiveDeviceID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        //[JsonIgnore]
        //public virtual AssistiveDevice ParentAssistiveDevice { get; set; }//残疾人康复详情
    }
}