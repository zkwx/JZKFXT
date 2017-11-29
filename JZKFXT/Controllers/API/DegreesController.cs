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
    public class DegreesController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Degrees
        public IHttpActionResult GetDegrees()
        {
            var result = db.Degrees.Select(a => new
            {
                key = a.ID,
                value = a.Name
            });
            return Json(result);
        }

        // GET: api/Degrees/5
        [ResponseType(typeof(Degree))]
        public async Task<IHttpActionResult> GetDegree(int id)
        {
            Degree degree = await db.Degrees.FindAsync(id);
            if (degree == null)
            {
                return NotFound();
            }

            return Ok(degree);
        }

        // PUT: api/Degrees/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDegree(int id, Degree degree)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != degree.ID)
            {
                return BadRequest();
            }

            db.Entry(degree).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DegreeExists(id))
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

        // POST: api/Degrees
        [ResponseType(typeof(Degree))]
        public async Task<IHttpActionResult> PostDegree(Degree degree)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Degrees.Add(degree);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = degree.ID }, degree);
        }

        // DELETE: api/Degrees/5
        [ResponseType(typeof(Degree))]
        public async Task<IHttpActionResult> DeleteDegree(int id)
        {
            Degree degree = await db.Degrees.FindAsync(id);
            if (degree == null)
            {
                return NotFound();
            }

            db.Degrees.Remove(degree);
            await db.SaveChangesAsync();

            return Ok(degree);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DegreeExists(int id)
        {
            return db.Degrees.Count(e => e.ID == id) > 0;
        }
    }
}