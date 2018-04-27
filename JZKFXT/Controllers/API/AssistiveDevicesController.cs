using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using JZKFXT.DAL;
using JZKFXT.Models;

namespace JZKFXT.Controllers.API
{
    public class AssistiveDevicesController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/AssistiveDevices
        public IQueryable<AssistiveDevice> GetAssistiveDevices()
        {
            return db.AssistiveDevices;
        }

        //根据辅具信息查询图片地址
        [HttpGet]
        [Route("api/AssistiveDevices/ShowImagePath")]
        public String picAddress(int id, string name, string type)
        {
            AssistiveDevice assistiveDevice = db.AssistiveDevices.Where(x => x.ID == id && x.Name == name && x.Type == type).FirstOrDefault();
            string imgName = assistiveDevice.Number + assistiveDevice.Name;
            var home = "~/Image/";
            var imgPath = "";
            var directory = "/Image/";
            string imgHome = HttpContext.Current.Server.MapPath(home);
            var ls = Directory.GetFiles(imgHome).ToList();
            if (assistiveDevice.Number != 0)
            {
                foreach (var l in ls)
                {
                    if (l.IndexOf(imgName) > -1)
                    {
                        imgPath = l;
                    }
                }
            }
            if (imgPath != "")
            {

                var fileName = imgPath.Split('\\').Last();
                var outUrl = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + directory + fileName;
                return outUrl;
            }
            else
            {
                return imgPath;
            }
        }


        // GET: api/AssistiveDevices/5
        [ResponseType(typeof(AssistiveDevice))]
        public async Task<IHttpActionResult> GetAssistiveDevice(int id)
        {
            AssistiveDevice assistiveDevice = await db.AssistiveDevices.FindAsync(id);
            if (assistiveDevice == null)
            {
                return NotFound();
            }

            return Ok(assistiveDevice);
        }

        // PUT: api/AssistiveDevices/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAssistiveDevice(int id, AssistiveDevice assistiveDevice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assistiveDevice.ID)
            {
                return BadRequest();
            }

            db.Entry(assistiveDevice).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssistiveDeviceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AssistiveDevices
        [ResponseType(typeof(AssistiveDevice))]
        public async Task<IHttpActionResult> PostAssistiveDevice(AssistiveDevice assistiveDevice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AssistiveDevices.Add(assistiveDevice);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AssistiveDeviceExists(assistiveDevice.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = assistiveDevice.ID }, assistiveDevice);
        }

        // DELETE: api/AssistiveDevices/5
        [ResponseType(typeof(AssistiveDevice))]
        public async Task<IHttpActionResult> DeleteAssistiveDevice(int id)
        {
            AssistiveDevice assistiveDevice = await db.AssistiveDevices.FindAsync(id);
            if (assistiveDevice == null)
            {
                return NotFound();
            }

            db.AssistiveDevices.Remove(assistiveDevice);
            await db.SaveChangesAsync();

            return Ok(assistiveDevice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssistiveDeviceExists(int id)
        {
            return db.AssistiveDevices.Count(e => e.ID == id) > 0;
        }
    }
}