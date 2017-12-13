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

namespace JZKFXT.Controllers
{
    public class RehabilitationsController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Rehabilitations
        public IHttpActionResult GetRehabilitations(bool group = false)
        {
            try
            {
                var list = db.Rehabilitations;
                if (list.Count() > 0)
                {
                    if (group)
                    {
                        var VisionList = (from a in list where a.ID.ToString().StartsWith("101") select new { value = a.ID.ToString(), name = a.RehabilitationName, parent = (a.ID / 100).ToString() }).ToList();
                        VisionList.Add(new { value = "10101", name = "盲人", parent = "" });
                        VisionList.Add(new { value = "10102", name = "低视力", parent = "" });

                        var HearingList = (from a in list where a.ID.ToString().StartsWith("102") select new { value = a.ID.ToString(), name = a.RehabilitationName, parent = (a.ID / 100).ToString() }).ToList();
                        HearingList.Add(new { value = "10201", name = "0-6岁儿童", parent = "" });
                        HearingList.Add(new { value = "10202", name = "7—17岁儿童", parent = "" });
                        HearingList.Add(new { value = "10203", name = "成人", parent = "" });

                        var BodyList = (from a in list where a.ID.ToString().StartsWith("104") select new { value = a.ID.ToString(), name = a.RehabilitationName, parent = (a.ID / 100).ToString() }).ToList();
                        BodyList.Add(new { value = "10401", name = "0-6岁儿童", parent = "" });
                        BodyList.Add(new { value = "10402", name = "7—17岁儿童及成人", parent = "" });

                        var IntelligenceList = (from a in list where a.ID.ToString().StartsWith("105") select new { value = a.ID.ToString(), name = a.RehabilitationName, parent = (a.ID / 100).ToString() }).ToList();
                        IntelligenceList.Add(new { value = "10501", name = "0-6岁儿童", parent = "" });
                        IntelligenceList.Add(new { value = "10502", name = "7—17岁儿童及成人", parent = "" });

                        var SpiritList = (from a in list where a.ID.ToString().StartsWith("106") select new { value = a.ID.ToString(), name = a.RehabilitationName, parent = (a.ID / 100).ToString() }).ToList();
                        SpiritList.Add(new { value = "10601", name = "0-6岁孤独症儿童", parent = "" });
                        SpiritList.Add(new { value = "10602", name = "7-17孤独症", parent = "" });
                        SpiritList.Add(new { value = "10603", name = "成年精神残疾人", parent = "" });
                        var result = new
                        {
                            VisionList,
                            HearingList,
                            BodyList,
                            IntelligenceList,
                            SpiritList
                        };
                        return Ok(result);
                    }
                    return Ok(list);
                }
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/Rehabilitations/5
        [ResponseType(typeof(Rehabilitation))]
        public async Task<IHttpActionResult> GetRehabilitation(int id)
        {
            Rehabilitation rehabilitation = await db.Rehabilitations.FindAsync(id);
            if (rehabilitation == null)
            {
                return NotFound();
            }

            return Ok(rehabilitation);
        }

        // PUT: api/Rehabilitations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRehabilitation(int id, Rehabilitation rehabilitation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rehabilitation.ID)
            {
                return BadRequest();
            }

            db.Entry(rehabilitation).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RehabilitationExists(id))
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

        // POST: api/Rehabilitations
        [ResponseType(typeof(Rehabilitation))]
        public async Task<IHttpActionResult> PostRehabilitation(Rehabilitation rehabilitation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rehabilitations.Add(rehabilitation);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RehabilitationExists(rehabilitation.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = rehabilitation.ID }, rehabilitation);
        }

        // DELETE: api/Rehabilitations/5
        [ResponseType(typeof(Rehabilitation))]
        public async Task<IHttpActionResult> DeleteRehabilitation(int id)
        {
            Rehabilitation rehabilitation = await db.Rehabilitations.FindAsync(id);
            if (rehabilitation == null)
            {
                return NotFound();
            }

            db.Rehabilitations.Remove(rehabilitation);
            await db.SaveChangesAsync();

            return Ok(rehabilitation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RehabilitationExists(int id)
        {
            return db.Rehabilitations.Count(e => e.ID == id) > 0;
        }
    }
}