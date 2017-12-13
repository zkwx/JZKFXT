using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace JZKFXT.Utils
{
    /// <summary>
    /// 前台Ajax请求的统一返回结果类
    /// </summary>
    public class AjaxResult
    {
        public AjaxResult()
        {
        }
        /// <summary>
        /// 更改成功数量
        /// </summary>
        public int result = 0;
        /// <summary>
        /// 错误信息，或者成功信息
        /// </summary>
        public string message;
        /// <summary>
        /// 成功可能时返回的数据
        /// </summary>
        public object data;


        #region Error
        public static AjaxResult Error()
        {
            return new AjaxResult()
            {
                result = 0
            };
        }
        public static AjaxResult Error(string msg)
        {
            return new AjaxResult()
            {
                result = 0,
                message = msg
            };
        }
        public static AjaxResult Error(System.Exception ex)
        {
            string m = string.Empty;
            m = ex.Message;
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                if (ex.InnerException == null)
                {
                    m = ex.Message;
                }
            }
            return new AjaxResult()
            {
                result = 0,
                message = m
            };
        }
        #endregion

        #region Success
        public static AjaxResult Success()
        {
            return new AjaxResult()
            {
                result = 1
            };
        }
        public static AjaxResult Success(object d)
        {
            return new AjaxResult()
            {
                result = 1,
                data = d
            };
        }
        public static AjaxResult Success(object d, string msg)
        {
            return new AjaxResult()
            {
                result = 1,
                data = d,
                message = msg
            };
        }
        #endregion

        public override string ToString()
        {
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            string json = JsonConvert.SerializeObject(this, microsoftDateFormatSettings);
            return json;
        }
    }
}
