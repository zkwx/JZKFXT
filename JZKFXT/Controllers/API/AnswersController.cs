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
    public class AnswersController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Answers
        public IQueryable<Answer> GetAnswers(int ExamID, int DisabledID)
        {
            return db.Answers.Where(a => a.ExamID == ExamID && a.DisabledID == DisabledID);
        }

        // GET: api/Answers/5
        [ResponseType(typeof(Answer))]
        public async Task<IHttpActionResult> GetAnswer(int id)
        {
            Answer answer = await db.Answers.FindAsync(id);
            if (answer == null)
            {
                return NotFound();
            }

            return Ok(answer);
        }

        // PUT: api/Answers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAnswer(int id, Answer answer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != answer.ID)
            {
                return BadRequest();
            }

            db.Entry(answer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnswerExists(id))
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

        // POST: api/Answers
        [ResponseType(typeof(Answer))]
        public async Task<IHttpActionResult> PostAnswer(Answer answer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Answers.Add(answer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = answer.ID }, answer);
        }
        [Route("api/Answers/SaveAnswers")]
        public async Task<IHttpActionResult> PostAnswers(IList<Answer> answers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var answer = answers[0];
            var delAnswers = db.Answers.Where(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID);
            db.Answers.RemoveRange(delAnswers);
            db.Answers.AddRange(answers);

            var examRecord = await db.ExamRecords.FirstOrDefaultAsync(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID);
            if (examRecord != null)
            {
                if (examRecord.ExamID == 9 || examRecord.ExamID == 10)
                {
                    examRecord.State = ExamState.已完成;
                }
                else
                {
                    examRecord.State = ExamState.已评估;
                }
            }
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);

        }

        // DELETE: api/Answers/5
        [ResponseType(typeof(Answer))]
        public async Task<IHttpActionResult> DeleteAnswer(int id)
        {
            Answer answer = await db.Answers.FindAsync(id);
            if (answer == null)
            {
                return NotFound();
            }

            db.Answers.Remove(answer);
            await db.SaveChangesAsync();

            return Ok(answer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AnswerExists(int id)
        {
            return db.Answers.Count(e => e.ID == id) > 0;
        }
    }
}