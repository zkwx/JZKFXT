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
    public class ExamRecordsController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/ExamRecords
        public IHttpActionResult GetExamRecords(string examBy = null, string name = null)
        {
            var list = db.ExamRecords.AsQueryable();
            if (examBy == "type")
            {
                list = list.Where(a => a.Exam.Type == name && a.Evaluated == false);
                var result = list.Select(
                a => new
                {
                    id = a.Disabled.ID,
                    name = a.Disabled.Name,
                    sex = a.Disabled.Sex,
                    category = a.Disabled.Category.Name,
                    degree = a.Disabled.Degree.Name,
                    exam = a.Exam,
                    state = a.State,
                }).GroupBy(a => a.exam.Name);
                return Ok(result.OrderByDescending(a => a.FirstOrDefault().id));
            }
            else if (examBy == "name")
            {
                list = list.Where(a => a.Exam.Name == name && a.Evaluated == false);
                var result = list.Select(
                a => new
                {
                    id = a.Disabled.ID,
                    name = a.Disabled.Name,
                    sex = a.Disabled.Sex,
                    category = a.Disabled.Category.Name,
                    degree = a.Disabled.Degree.Name,
                    exam = a.Exam,
                    state = a.State,
                });
                return Ok(result.OrderByDescending(a => a.id));
            }
            return Ok(list);
        }

        // GET: api/ExamRecords/5
        [ResponseType(typeof(ExamRecord))]
        public async Task<IHttpActionResult> GetExamRecord(int id)
        {
            ExamRecord examRecord = await db.ExamRecords.FindAsync(id);
            if (examRecord == null)
            {
                return NotFound();
            }

            return Ok(examRecord);
        }

        // PUT: api/ExamRecords/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutExamRecord(int id, ExamRecord examRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != examRecord.ID)
            {
                return BadRequest();
            }

            db.Entry(examRecord).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExamRecordExists(id))
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

        // POST: api/ExamRecords
        [ResponseType(typeof(ExamRecord))]
        public async Task<IHttpActionResult> PostExamRecord(ExamRecord examRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ExamRecords.Add(examRecord);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = examRecord.ID }, examRecord);
        }

        // DELETE: api/ExamRecords/5
        [ResponseType(typeof(ExamRecord))]
        public async Task<IHttpActionResult> DeleteExamRecord(int id)
        {
            ExamRecord examRecord = await db.ExamRecords.FindAsync(id);
            if (examRecord == null)
            {
                return NotFound();
            }

            db.ExamRecords.Remove(examRecord);
            await db.SaveChangesAsync();

            return Ok(examRecord);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExamRecordExists(int id)
        {
            return db.ExamRecords.Count(e => e.ID == id) > 0;
        }
    }
}