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

namespace JZKFXT.Controllers.API
{
    public class DisabilityReasonsController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/DisabilityReasons
        public IHttpActionResult GetDisabilityReasons(int categoryID)
        {
            var result = db.DisabilityReasons
                .Where(a => a.CategoryID == categoryID)
                .Select(a => new
                {
                    key = a.ID,
                    value = a.Name
                });
            return Json(result);
        }

        // GET: api/DisabilityReasons/5
        [ResponseType(typeof(DisabilityReason))]
        public async Task<IHttpActionResult> GetDisabilityReason(int id)
        {
            DisabilityReason disabilityReason = await db.DisabilityReasons.FindAsync(id);
            if (disabilityReason == null)
            {
                return NotFound();
            }

            return Ok(disabilityReason);
        }

        // PUT: api/DisabilityReasons/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDisabilityReason(int id, DisabilityReason disabilityReason)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != disabilityReason.ID)
            {
                return BadRequest();
            }

            db.Entry(disabilityReason).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DisabilityReasonExists(id))
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

        // POST: api/DisabilityReasons
        [ResponseType(typeof(DisabilityReason))]
        public async Task<IHttpActionResult> PostDisabilityReason(DisabilityReason disabilityReason)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DisabilityReasons.Add(disabilityReason);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = disabilityReason.ID }, disabilityReason);
        }

        // DELETE: api/DisabilityReasons/5
        [ResponseType(typeof(DisabilityReason))]
        public async Task<IHttpActionResult> DeleteDisabilityReason(int id)
        {
            DisabilityReason disabilityReason = await db.DisabilityReasons.FindAsync(id);
            if (disabilityReason == null)
            {
                return NotFound();
            }

            db.DisabilityReasons.Remove(disabilityReason);
            await db.SaveChangesAsync();

            return Ok(disabilityReason);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DisabilityReasonExists(int id)
        {
            return db.DisabilityReasons.Count(e => e.ID == id) > 0;
        }
    }
}