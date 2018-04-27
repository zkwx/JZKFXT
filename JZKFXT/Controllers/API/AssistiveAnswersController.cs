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
    public class AssistiveAnswersController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/AssistiveAnswers
        public IQueryable<AssistiveAnswer> GetAssistiveAnswer(int ExamID, int DisabledID)
        {
            return db.AssistiveAnswer.Where(a => a.ExamID == ExamID && a.DisabledID == DisabledID);
        }

        // GET: api/AssistiveAnswers/5
        [ResponseType(typeof(AssistiveAnswer))]
        public IHttpActionResult GetAssistiveAnswer(int id)
        {
            AssistiveAnswer assistiveAnswer = db.AssistiveAnswer.Find(id);
            if (assistiveAnswer == null)
            {
                return NotFound();
            }

            return Ok(assistiveAnswer);
        }

        // PUT: api/AssistiveAnswers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAssistiveAnswer(int id, AssistiveAnswer assistiveAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assistiveAnswer.ID)
            {
                return BadRequest();
            }

            db.Entry(assistiveAnswer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssistiveAnswerExists(id))
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

        [Route("api/AssistiveAnswers/SaveAnswers")]
        public async Task<IHttpActionResult> PostAnswers(IList<AssistiveAnswer> answers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            bool flag = false;
            foreach (var a in answers)
            {
                if (a.ID != 0)
                {
                    flag = true;
                }
            }
            var answer = answers[0];
            if (flag)
            {
                var delAnswers = db.AssistiveAnswer.Where(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID);
                db.AssistiveAnswer.RemoveRange(delAnswers);
                db.AssistiveAnswer.AddRange(answers);
            }
            var examRecord = await db.ExamRecords.FirstOrDefaultAsync(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID && a.State == ExamState.已评估);

            if (examRecord != null)
            {
                examRecord.State = ExamState.待审核;
            }
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AssistiveAnswers
        [ResponseType(typeof(AssistiveAnswer))]
        public IHttpActionResult PostAssistiveAnswer(AssistiveAnswer assistiveAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AssistiveAnswer.Add(assistiveAnswer);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AssistiveAnswerExists(assistiveAnswer.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = assistiveAnswer.ID }, assistiveAnswer);
        }

        // DELETE: api/AssistiveAnswers/5
        [ResponseType(typeof(AssistiveAnswer))]
        public IHttpActionResult DeleteAssistiveAnswer(int id)
        {
            AssistiveAnswer assistiveAnswer = db.AssistiveAnswer.Find(id);
            if (assistiveAnswer == null)
            {
                return NotFound();
            }

            db.AssistiveAnswer.Remove(assistiveAnswer);
            db.SaveChanges();

            return Ok(assistiveAnswer);
        }

        [HttpPost]
        [Route("api/AssistiveAnswers/DeleteAnswers")]
        public async Task<IHttpActionResult> DeleteAnswers(IList<AssistiveAnswer> assistive)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var answer = assistive[0];

            var assAnswers = db.AssistiveAnswer.Where(a => a.ExamID == answer.ExamID && a.DisabledID == answer.DisabledID);
            db.AssistiveAnswer.RemoveRange(assAnswers);

            var answers = db.Answers.Where(b => b.ExamID == answer.ExamID && b.DisabledID == answer.DisabledID);
            db.Answers.RemoveRange(answers);

            var examRecord = await db.ExamRecords.FirstOrDefaultAsync(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID);
            if (examRecord != null)
            {
                examRecord.State = ExamState.待评估;
            }

            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssistiveAnswerExists(int id)
        {
            return db.AssistiveAnswer.Count(e => e.ID == id) > 0;
        }
    }
}