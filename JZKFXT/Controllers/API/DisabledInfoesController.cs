using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using JZKFXT.DAL;
using JZKFXT.Models;
using JZKFXT.Utils;
using System.Text;

namespace JZKFXT.Controllers
{
    public class DisabledInfoesController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/DisabledInfoes
        public IHttpActionResult GetDisabledInfoes(bool forList = false, bool forFuJuShangMen = false)
        {
            try
            {
                var list = from a in db.DisabledInfoes select a;
                if (forFuJuShangMen)
                {
                    //条件1：功能障碍者在“精准康复入户”模块中康复需求选择“辅助器具适配及服务”、“辅助器具适配及适应训练”选项，且服务走向为“上门评估”的，其全部数据自动转到“辅具上门评估与适配模块”；
                    list = list.Where(a => a.Need && a.DisabledInfo_Details.Any(b => b.Rehabilitation.FuJu && b.Next.ID == 3));
                    var result = list.Select(
                        a => new
                        {
                            name = a.Name,
                            detials = a.DisabledInfo_Details.Where(b => b.Rehabilitation.FuJu && b.Next.ID == 3)
                            .Select(b => new
                            {
                                ID = b.ID,
                                Category = b.Category,
                                Degree = b.Degree,
                                Next = b.Next
                                //FuJu = b.Rehabilitation.FuJu,
                                //Next = b.Next.ID
                            })
                        });
                    return Json(result);
                }
                if (forList)
                {
                    var result = list.ToList().Select(
                        a => new
                        {
                            src = "http://placeholder.qiniudn.com/60x60/3cc51f/ffffff",
                            title = a.Name,
                            desc = BindDesc(a),
                            url = "/KangFuRuHuDetail/" + a.ID
                        });
                    return Json(result);
                }
                else if (forFuJuShangMen)
                {

                }
                return Json(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/DisabledInfoes/5
        [ResponseType(typeof(DisabledInfo))]
        public async Task<IHttpActionResult> GetDisabledInfo(int id)
        {
            DisabledInfo disabledInfo = await db.DisabledInfoes.FindAsync(id);
            if (disabledInfo == null)
            {
                return NotFound();
            }

            return Ok(disabledInfo);
        }

        // PUT: api/DisabledInfoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDisabledInfo(int id, DisabledInfo disabledInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != disabledInfo.ID)
            {
                return BadRequest();
            }
            try
            {
                if (disabledInfo.DisabledInfo_Details!=null)
                {
                    foreach (var item in disabledInfo.DisabledInfo_Details)
                    {
                        if (item == null) continue;
                        EntityStateHelper.BindEntityState(db, item);
                        item.DisabledInfoID = disabledInfo.ID;
                    }
                }
                db.Entry(disabledInfo).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (!DisabledInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw ex;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DisabledInfoes
        [ResponseType(typeof(DisabledInfo))]
        public async Task<IHttpActionResult> PostDisabledInfo(DisabledInfo disabledInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.DisabledInfoes.Add(disabledInfo);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CreatedAtRoute("DefaultApi", new { id = disabledInfo.ID }, disabledInfo);
        }

        // DELETE: api/DisabledInfoes/5
        [ResponseType(typeof(DisabledInfo))]
        public async Task<IHttpActionResult> DeleteDisabledInfo(int id)
        {
            DisabledInfo disabledInfo = await db.DisabledInfoes.FindAsync(id);
            if (disabledInfo == null)
            {
                return NotFound();
            }

            db.DisabledInfoes.Remove(disabledInfo);
            await db.SaveChangesAsync();

            return Ok(disabledInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DisabledInfoExists(int id)
        {
            return db.DisabledInfoes.Count(e => e.ID == id) > 0;
        }

        private string BindDesc(DisabledInfo d)
        {
            StringBuilder desc = new StringBuilder();
            try
            {
                foreach (var item in d.DisabledInfo_Details)
                {
                    if (item != null)
                    {
                        desc.Append(item.Category.Name).Append(item.Degree.Name);
                        if (item.Rehabilitation != null)
                        {
                            desc.Append("-").Append(item.Rehabilitation.RehabilitationName).Append(item.Next.Name);
                        }
                        desc.Append("<br>");
                    }
                }
                //if (d.Vision != null)
                //{
                //    desc.Append(d.Vision.Category.Name).Append(d.Vision.Degree.Name);
                //    if (d.Vision.Rehabilitation != null)
                //    {
                //        desc.Append("-").Append(d.Vision.Rehabilitation.RehabilitationName).Append(d.Vision.Next.Name);
                //    }
                //    desc.Append("<br>");
                //}
                //if (d.Hearing != null)
                //{
                //    desc.Append(d.Hearing.Category.Name).Append(d.Hearing.Degree.Name);
                //    if (d.Hearing.Rehabilitation != null)
                //    {
                //        desc.Append("-").Append(d.Hearing.Rehabilitation.RehabilitationName).Append(d.Hearing.Next.Name);
                //    }
                //    desc.Append("<br>");
                //}
                //if (d.Speaking != null)
                //{
                //    desc.Append(d.Speaking.Category.Name).Append(d.Speaking.Degree.Name);
                //    if (d.Speaking.Rehabilitation != null)
                //    {
                //        desc.Append("-").Append(d.Speaking.Rehabilitation.RehabilitationName).Append(d.Speaking.Next.Name);
                //    }
                //    desc.Append("<br>");
                //}
                //if (d.Body != null)
                //{
                //    desc.Append(d.Body.Category.Name).Append(d.Body.Degree.Name);
                //    if (d.Body.Rehabilitation != null)
                //    {
                //        desc.Append("-").Append(d.Body.Rehabilitation.RehabilitationName).Append(d.Body.Next.Name);
                //    }
                //    desc.Append("<br>");
                //}
                //if (d.Intelligence != null)
                //{
                //    desc.Append(d.Intelligence.Category.Name).Append(d.Intelligence.Degree.Name);
                //    if (d.Intelligence.Rehabilitation != null)
                //    {
                //        desc.Append("-").Append(d.Intelligence.Rehabilitation.RehabilitationName).Append(d.Intelligence.Next.Name);
                //    }
                //    desc.Append("<br>");
                //}
                //if (d.Spirit != null)
                //{
                //    desc.Append(d.Spirit.Category.Name).Append(d.Spirit.Degree.Name);
                //    if (d.Spirit.Rehabilitation != null)
                //    {
                //        desc.Append("-").Append(d.Spirit.Rehabilitation.RehabilitationName).Append(d.Spirit.Next.Name);
                //    }
                //    desc.Append("<br>");
                //}
                return desc.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}