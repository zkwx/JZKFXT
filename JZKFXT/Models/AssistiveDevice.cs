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
        public AssistiveDevice(int iD, string name, string type, string picName)
        {
            ID = iD;
            ParentAssistiveDeviceID = iD / 100;
            Name = name;
            Type = type;
            PicName = picName;
        }
        public AssistiveDevice(int iD, string name, string type, string picName, double price, string comments)
        {
            ID = iD;
            ParentAssistiveDeviceID = iD / 100;
            Name = name;
            Type = type;
            PicName = picName;
            Price = price;
            Comments = comments;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //去掉自增标识
        public int ID { get; set; }
        public int ParentAssistiveDeviceID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        //图片名称
        public string PicName { get; set; }
        //单价
        public double Price { get; set; }
        //简介
        public string Comments { get; set; }
    }
}