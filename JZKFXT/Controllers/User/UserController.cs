using JZKFXT.DAL;
using JZKFXT.Models;
using JZKFXT.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace JZKFXT.Controllers
{
    public class UserController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET api/values
        public string Get()
        {
            return AjaxResult.Success(new string[] { "value1", "value2" }).ToString();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]User user)
        {
            try
            {
                User loginuser = db.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
                if (loginuser != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    loginuser.LastLoginTime = DateTime.Now;
                    db.SaveChanges();
                    return AjaxResult.Success(loginuser,"登录成功").ToString();
                }
                else
                {
                    return AjaxResult.Error("登录失败").ToString();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return "ERROR";
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}
