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
    public class NextsController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Nexts
        public IHttpActionResult GetNexts()
        {
            var result = db.Nexts.Select(a => new
            {
                key = a.ID,
                value = a.Name
            });
            return Json(result);
        }
        // GET: api/Nexts/5
        [ResponseType(typeof(Next))]
        public async Task<IHttpActionResult> GetNext(int id)
        {
            Next next = await db.Nexts.FindAsync(id);
            if (next == null)
            {
                return NotFound();
            }

            return Ok(next);
        }

        // PUT: api/Nexts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutNext(int id, Next next)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != next.ID)
            {
                return BadRequest();
            }

            db.Entry(next).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NextExists(id))
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

        // POST: api/Nexts
        [ResponseType(typeof(Next))]
        public async Task<IHttpActionResult> PostNext(Next next)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Nexts.Add(next);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = next.ID }, next);
        }

        // DELETE: api/Nexts/5
        [ResponseType(typeof(Next))]
        public async Task<IHttpActionResult> DeleteNext(int id)
        {
            Next next = await db.Nexts.FindAsync(id);
            if (next == null)
            {
                return NotFound();
            }

            db.Nexts.Remove(next);
            await db.SaveChangesAsync();

            return Ok(next);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NextExists(int id)
        {
            return db.Nexts.Count(e => e.ID == id) > 0;
        }
    }
}