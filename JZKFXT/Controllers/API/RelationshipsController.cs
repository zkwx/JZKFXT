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
    public class RelationshipsController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Relationships
        public IQueryable<Relationship> GetRelationships()
        {
            return db.Relationships;
        }

        // GET: api/Relationships/5
        [ResponseType(typeof(Relationship))]
        public async Task<IHttpActionResult> GetRelationship(int id)
        {
            Relationship relationship = await db.Relationships.FindAsync(id);
            if (relationship == null)
            {
                return NotFound();
            }

            return Ok(relationship);
        }

        // PUT: api/Relationships/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRelationship(int id, Relationship relationship)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != relationship.ID)
            {
                return BadRequest();
            }

            db.Entry(relationship).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RelationshipExists(id))
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

        // POST: api/Relationships
        [ResponseType(typeof(Relationship))]
        public async Task<IHttpActionResult> PostRelationship(Relationship relationship)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Relationships.Add(relationship);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = relationship.ID }, relationship);
        }

        // DELETE: api/Relationships/5
        [ResponseType(typeof(Relationship))]
        public async Task<IHttpActionResult> DeleteRelationship(int id)
        {
            Relationship relationship = await db.Relationships.FindAsync(id);
            if (relationship == null)
            {
                return NotFound();
            }

            db.Relationships.Remove(relationship);
            await db.SaveChangesAsync();

            return Ok(relationship);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RelationshipExists(int id)
        {
            return db.Relationships.Count(e => e.ID == id) > 0;
        }
    }
}