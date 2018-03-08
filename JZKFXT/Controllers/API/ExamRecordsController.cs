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
        public IHttpActionResult GetExamRecords(string examBy = null, string name = null, int userID = 0)
        {
            var list = db.ExamRecords.AsQueryable();
            if (examBy == "type")
            {
                if (name == "FuJuPingGu")
                {
                    list = list.Where(a => a.Exam.Type == name && a.Evaluated == false && a.showArea == null);
                    var result = list.Select(
                    a => new
                    {
                        ID = a.Disabled.ID,
                        Name = a.Disabled.Name,
                        Sex = a.Disabled.Sex,
                        Category = a.Disabled.Category.Name,
                        Degree = a.Disabled.Degree.Name,
                        Exam = a.Exam,
                        State = a.State,
                        UserID = a.Disabled.UserID,
                    }).Where(x => x.UserID == userID).GroupBy(a => a.Exam.Name);
                    return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));
                }
                else if (name == "JiaZhiJiaoXingQi")
                {
                    list = list.Where(a => a.showArea != null && a.State != ExamState.待评估);
                    var result = list.Select(
                    a => new
                    {
                        ID = a.Disabled.ID,
                        Name = a.Disabled.Name,
                        Sex = a.Disabled.Sex,
                        Category = a.Disabled.Category.Name,
                        Degree = a.Disabled.Degree.Name,
                        Exam = a.Exam,
                        State = a.State,
                        showArea = a.showArea,
                        UserID = a.Disabled.UserID,
                    }).Where(x => x.UserID == userID).GroupBy(a => a.Exam.Name);
                    return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));
                }
                else if (name == "FuJuShenHe")
                {
                    list = list.Where(a => (a.State == ExamState.待审核 || a.State == ExamState.已审核) && a.Evaluated == false);
                    var result = list.Select(
                    a => new
                    {
                        ID = a.Disabled.ID,
                        Name = a.Disabled.Name,
                        Sex = a.Disabled.Sex,
                        Category = a.Disabled.Category.Name,
                        Degree = a.Disabled.Degree.Name,
                        Exam = a.Exam,
                        State = a.State,
                        UserID = a.Disabled.UserID,
                    }).Where(x => x.UserID == userID).GroupBy(a => a.Exam.Name);
                    return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));
                }
                else if (name == "JiaZhiJiaoXingQiShenHe")
                {
                    list = list.Where(a => a.showArea != null && (a.State == ExamState.待审核 || a.State == ExamState.已审核) && a.Evaluated == false);
                    var result = list.Select(
                    a => new
                    {
                        ID = a.Disabled.ID,
                        Name = a.Disabled.Name,
                        Sex = a.Disabled.Sex,
                        Category = a.Disabled.Category.Name,
                        Degree = a.Disabled.Degree.Name,
                        Exam = a.Exam,
                        State = a.State,
                        showArea = a.showArea,
                        UserID = a.Disabled.UserID,
                    }).Where(x => x.UserID == userID).GroupBy(a => a.Exam.Name);
                    return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));
                }
                else if (name == "FuJuFuWu")
                {
                    list = list.Where(a => (a.State == ExamState.已审核 || a.State == ExamState.已完成) && a.Evaluated == false);
                    var result = list.Select(
                     a => new
                     {
                         ID = a.Disabled.ID,
                         Name = a.Disabled.Name,
                         Sex = a.Disabled.Sex,
                         Category = a.Disabled.Category.Name,
                         Degree = a.Disabled.Degree.Name,
                         Exam = a.Exam,
                         State = a.State,
                         UserID = a.Disabled.UserID,
                     }).Where(x => x.UserID == userID).GroupBy(a => a.Exam.Name);
                    return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));
                }
                else if (name == "FuJuFuWuHuiFang")
                {
                    list = list.Where(a => a.State == ExamState.已完成 && a.Evaluated == false);
                    var result = list.Select(
                     a => new
                     {
                         ID = a.Disabled.ID,
                         Name = a.Disabled.Name,
                         Sex = a.Disabled.Sex,
                         Category = a.Disabled.Category.Name,
                         Degree = a.Disabled.Degree.Name,
                         Exam = a.Exam,
                         State = a.State,
                         UserID = a.Disabled.UserID,
                     }).Where(x => x.UserID == userID).GroupBy(a => a.Exam.Name);
                    return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));
                }
                else if (name == "JiGouPingGu")
                {
                    //list = list.Where(a => a.Evaluated == false && a.showArea == null);
                    //var result = list.Select(
                    //a => new
                    //{
                    //    ID = a.Disabled.ID,
                    //    Name = a.Disabled.Name,
                    //    Sex = a.Disabled.Sex,
                    //    Category = a.Disabled.Category.Name,
                    //    Degree = a.Disabled.Degree.Name,
                    //    Exam = a.Exam,
                    //    State = a.State,
                    //    UserID = a.Disabled.UserID,
                    //}).Where(x => x.UserID == userID).GroupBy(a => a.Exam.Name);
                    //return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));

                }
            }
            else if (examBy == "name")
            {
                if (name == "WuZhangAiGaiZao")
                {
                    list = list.Where(a => a.showArea != null && a.State != ExamState.待评估);
                    var result = list.Select(
                    a => new
                    {
                        ID = a.Disabled.ID,
                        Name = a.Disabled.Name,
                        Sex = a.Disabled.Sex,
                        Category = a.Disabled.Category.Name,
                        Degree = a.Disabled.Degree.Name,
                        Exam = a.Exam,
                        State = a.State,
                        showArea = a.showArea,
                    }).GroupBy(a => a.showArea);
                    return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));
                }
                else if (name == "WuZhangAiShenHe")
                {
                    list = list.Where(a => a.showArea != null && (a.State == ExamState.待审核 || a.State == ExamState.已审核) && a.Evaluated == false);
                    var result = list.Select(
                    a => new
                    {
                        ID = a.Disabled.ID,
                        Name = a.Disabled.Name,
                        Sex = a.Disabled.Sex,
                        Category = a.Disabled.Category.Name,
                        Degree = a.Disabled.Degree.Name,
                        Exam = a.Exam,
                        State = a.State,
                        showArea = a.showArea,
                    }).GroupBy(a => a.showArea);
                    return Ok(result.OrderByDescending(a => a.FirstOrDefault().ID));
                }
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

        //审核通过修改状态
        [HttpPut]
        [Route("api/ExamRecords/Modify")]
        public async Task<IHttpActionResult> ModifyExamRecords(IList<ExamRecord> record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var answer = record[0];

            ExamRecord examRecord = await db.ExamRecords.Where(e => e.ExamID == answer.ExamID && e.DisabledID == answer.DisabledID).FirstOrDefaultAsync();
            if (examRecord == null)
            {
                return NotFound();
            }
            if (examRecord.State == ExamState.待审核)
            {
                examRecord.State = ExamState.已审核;
            }
            else if (examRecord.State == ExamState.已审核)
            {
                examRecord.State = ExamState.已完成;
                examRecord.FinishTime = DateTime.Now;
            }
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpGet]
        [Route("api/ExamRecords/Select")]
        public async Task<IHttpActionResult> GetExamRecord(int ExamID, int DisabledID)
        {
            ExamRecord examRecord = await db.ExamRecords.Where(e => e.ExamID == ExamID && e.DisabledID == DisabledID).FirstOrDefaultAsync();
            if (examRecord == null)
            {
                return NotFound();
            }

            return Ok(examRecord);
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