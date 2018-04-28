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
        public AssistiveDevice(int iD, string name, string type)
        {
            ID = iD;
            ParentAssistiveDeviceID = iD / 100;
            Name = name;
            Type = type;
        }
        public AssistiveDevice(int iD, string name, string type, int number)
        {
            ID = iD;
            ParentAssistiveDeviceID = iD / 100;
            Name = name;
            Type = type;
            Number = number;
        }
        public AssistiveDevice(int iD, string name, string type, int number, double price)
        {
            ID = iD;
            ParentAssistiveDeviceID = iD / 100;
            Name = name;
            Type = type;
            Number = number;
            Price = price;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        public int ParentAssistiveDeviceID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        //图片编号 图片名 = 图片编号 + Name
        public int Number { get; set; }
        //单价
        public double Price { get; set; }
    }
}