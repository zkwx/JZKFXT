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
        public IQueryable<Answer> GetAnswers(int ExamID, int DisabledID, int FirstExam = 0)
        {
            if (ExamID == 9 || ExamID == 10 || ExamID == 11)
            {
                return db.Answers.Where(a => a.ExamID == ExamID && a.DisabledID == DisabledID && a.FirstExam == FirstExam);
            }
            else
            {
                return db.Answers.Where(a => a.FirstExam == ExamID && a.DisabledID == DisabledID);
            }
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

        [HttpPost]
        [Route("api/Answers/SaveAnswers")]
        public async Task<IHttpActionResult> PostAnswers(IList<Answer> answers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //试卷编号
            var ans = new List<int>();
            //试卷的第一题
            var ansList = new List<Answer>();
            foreach (var a in answers)
            {
                if (ans.IndexOf(a.ExamID) == -1)
                {
                    ans.Add(a.ExamID);
                    ansList.Add(a);
                }
            }

            foreach (var item in ansList)
            {
                var answer = item;
                foreach (var it in answers)
                {
                    if (it.Area != null && it.ExamID == item.ExamID && it.DisabledID == item.DisabledID)
                    {
                        answer = it;
                    }
                }

                var delAnswers = db.Answers.Where(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID && a.FirstExam == answer.FirstExam);
                db.Answers.RemoveRange(delAnswers);
                foreach (var addAns in answers)
                {
                    if (answer.DisabledID == addAns.DisabledID && answer.ExamID == addAns.ExamID)
                    {
                        db.Answers.Add(addAns);
                    }
                }

                var examRecord = await db.ExamRecords.FirstOrDefaultAsync(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID);
                if (examRecord != null)
                {
                    if (examRecord.ExamID == 9 || examRecord.ExamID == 10 || examRecord.ExamID == 11)
                    {
                        examRecord = await db.ExamRecords.FirstOrDefaultAsync(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID && a.First == answer.FirstExam);
                        if (examRecord.ExamID == 9)
                        {
                            examRecord.State = ExamState.待回访;
                        }
                        else if (examRecord.ExamID == 10 || examRecord.ExamID == 11)
                        {
                            examRecord.State = ExamState.已完成;
                            examRecord.FinishTime = DateTime.Now;
                            examRecord = await db.ExamRecords.FirstOrDefaultAsync(b => b.DisabledID == answer.DisabledID && b.ExamID == examRecord.First);
                            examRecord.State = ExamState.已完成;
                        }
                    }
                    else
                    {
                        examRecord.State = ExamState.已评估;
                        examRecord.Evaluated = false;
                        if (answer.Area != null)
                        {
                            examRecord.ShowArea = answer.Area;
                        }
                        if (answer.ShowExam != 0)
                        {
                            examRecord.ShowExam = answer.ShowExam;
                        }
                    }
                }
                else
                {
                    var newRecord = new ExamRecord(answer.ExamID, answer.DisabledID, 0);
                    db.ExamRecords.Add(newRecord);
                    db.SaveChanges();
                    var record = await db.ExamRecords.FirstOrDefaultAsync(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.ExamID);
                    if (record.ExamID == 9)
                    {
                        record.State = ExamState.待回访;
                    }
                    else if (record.ExamID == 10 || record.ExamID == 11)
                    {
                        record.State = ExamState.已完成;
                        examRecord.FinishTime = DateTime.Now;
                    }
                    else
                    {
                        record.State = ExamState.已评估;
                        record.Evaluated = false;
                        record.NextID = 3;
                        record.First = answer.FirstExam;
                    }
                    var fisExam = await db.ExamRecords.FirstOrDefaultAsync(a => a.DisabledID == answer.DisabledID && a.ExamID == answer.FirstExam);
                    if (answer.Area != null)
                    {
                        fisExam.ShowArea = answer.Area;
                    }
                    if (answer.ShowExam != 0)
                    {
                        fisExam.ShowExam = answer.ShowExam;
                    }

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