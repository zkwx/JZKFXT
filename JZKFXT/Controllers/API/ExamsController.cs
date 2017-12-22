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
    public class ExamsController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Exams
        public async Task<IHttpActionResult> GetExams(string targetExamName = null)
        {
            Exam exam = await db.Exams.Where(a => a.Name == targetExamName).FirstOrDefaultAsync();
            if (exam == null)
            {
                return NotFound();
            }
            var result = new
            {
                ID = exam.ID,
                Name = exam.Name,
                Questions = exam.Questions.ToDictionary(
                    a => a.QuestionNo,
                    a => new
                    {
                        ID = a.ID,
                        QuestionNo = a.QuestionNo,
                        QuestionText = a.QuestionText,
                        Multiple = a.Multiple,
                        IsFirst = a.IsFirst,
                        Answers = new List<Answer>(),
                        //根据选项查询下一题 键值对
                        QueryOptions = a.Options.ToDictionary(
                            b => b.ID,
                            b => new
                            {
                                NextQuestionNo = b.NextQuestionNo,
                                AssistiveDevices = b.AssistiveDevices,
                            }),
                        //checklist显示数组 不支持对象数组
                        Options = a.Options.Select(b => new
                        {
                            key = b.ID,
                            value = b.OptionText + "." + b.ContentText,
                        })
                    }
                )
            };
            return Ok(result);
        }

        // GET: api/Exams/5
        public async Task<IHttpActionResult> GetExam(int id)
        {
            Exam exam = await db.Exams.FindAsync(id);
            return Ok(exam);
        }
        // PUT: api/Exams/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutExam(int id, Exam exam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != exam.ID)
            {
                return BadRequest();
            }

            db.Entry(exam).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExamExists(id))
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

        // POST: api/Exams
        [ResponseType(typeof(Exam))]
        public async Task<IHttpActionResult> PostExam(Exam exam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Exams.Add(exam);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = exam.ID }, exam);
        }

        // DELETE: api/Exams/5
        [ResponseType(typeof(Exam))]
        public async Task<IHttpActionResult> DeleteExam(int id)
        {
            Exam exam = await db.Exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }

            db.Exams.Remove(exam);
            await db.SaveChangesAsync();

            return Ok(exam);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExamExists(int id)
        {
            return db.Exams.Count(e => e.ID == id) > 0;
        }
    }
}