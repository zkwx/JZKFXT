using JZKFXT.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace JZKFXT.Controllers.API
{
    public class FileController : ApiController
    {
        // GET: api/File
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/File/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/File
        public IHttpActionResult Post()
        {
            try
            {
                var fileType = HttpContext.Current.Request["fileType"];
                string url = "";
                string directory = "/Files/avatar/";
                string root = HttpContext.Current.Server.MapPath(directory);
                //获取客户端文件
                string fileName = "";
                HttpFileCollection files = HttpContext.Current.Request.Files;
                foreach (string f in files.AllKeys)
                {
                    HttpPostedFile file = files[f];
                    fileName = file.FileName;
                    if (file.ContentLength >= 1024 * 1024 * 20)
                    {
                        throw new Exception("上传文件大小不能超过 20 MB！");
                    }

                    if (string.IsNullOrEmpty(file.FileName) == false)
                    {
                        Directory.CreateDirectory(root);
                        url = root + file.FileName;
                        file.SaveAs(url);
                    }
                }
                var outUrl = HttpContext.Current.Request.Url.Scheme+"://" + HttpContext.Current.Request.Url.Authority + directory + fileName;
                return Json(outUrl);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        // PUT: api/File/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/File/5
        public void Delete(int id)
        {
        }
    }
}
