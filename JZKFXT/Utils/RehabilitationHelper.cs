using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace JZKFXT.Utils
{
    public class RehabilitationHelper
    {
        /// <summary>
        /// 通过ID获取残疾类别名称
        /// </summary>
        /// <param name="CategoryID">等级ID</param>
        /// <returns></returns>
        public static string GetCategoryName(int? CategoryID)
        {
            //DegreeList:[{key: 0, value: '一级'},{key: 1, value: '二级'},{key: 2, value: '三级'},
            //{ key: 3, value: '四级'},{key: 4, value: '未定级'}],
            switch (CategoryID)
            {
                case 0:
                    return "视力";
                case 1:
                    return "听力";
                case 2:
                    return "言语";
                case 3:
                    return "肢体";
                case 4:
                    return "智力";
                case 5:
                    return "精神";
                case 6:
                    return "未评定";
                default:
                    return "未评定"; 
            }
        }
        /// <summary>
        /// 通过ID获取残疾等级名称
        /// </summary>
        /// <param name="DegreeID">等级ID</param>
        /// <returns></returns>
        public static string GetDegreeName(int? DegreeID)
        {
            //DegreeList:[{key: 0, value: '一级'},{key: 1, value: '二级'},{key: 2, value: '三级'},
            //{ key: 3, value: '四级'},{key: 4, value: '未定级'}],
            switch (DegreeID)
            {
                case 0:
                    return "一级";
                case 1:
                    return "二级";
                case 2:
                    return "三级";
                case 3:
                    return "四级";
                case 4:
                    return "未定级";
                default:
                    return "未定级";
            }
        }
    }
}
