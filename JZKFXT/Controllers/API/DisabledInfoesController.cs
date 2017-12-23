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
using JZKFXT.Utils;
using System.Text;
using System.Linq.Expressions;

namespace JZKFXT.Controllers
{
    public class DisabledInfoesController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/DisabledInfoes
        public IHttpActionResult GetDisabledInfoes(string examType = null, string examName = null, string listType = null)
        {
            try
            {
                var list = db.DisabledInfoes.AsQueryable();
                if (examType != null)
                {
                    var disabledInfoIds = db.ExamRecords.Where(a => a.Exam.Type == examType && a.Evaluated == false).Select(a => a.DisabledInfoID);
                    list = list.Where(a => disabledInfoIds.Contains(a.ID));
                    var result = list.Select(
                    a => new
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Sex = a.Sex,
                        Category = a.Category.Name,
                        Degree = a.Degree.Name,
                        CurrentExam = a.ExamRecords.FirstOrDefault(b => b.Exam.Type == examType)
                    });
                    return Ok(result.OrderByDescending(a => a.ID));
                }
                else if (examName != null)
                {
                    var disabledInfoIds = db.ExamRecords.Where(a => a.Exam.Name == examName && a.Evaluated == false).Select(a => a.DisabledInfoID);
                    list = list.Where(a => disabledInfoIds.Contains(a.ID));
                    var result = list.Select(
                    a => new
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Sex = a.Sex,
                        Category = a.Category.Name,
                        Degree = a.Degree.Name,
                        CurrentExam = a.ExamRecords.FirstOrDefault(b => b.Exam.Name == examName)
                    });
                    return Ok(result.OrderByDescending(a => a.ID));
                }
                var result2 = list.Select(
                    a => new
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Sex = a.Sex,
                        Category = a.Category.Name,
                        Degree = a.Degree.Name,
                        ExamRecords = a.ExamRecords
                    });
                return Ok(result2.OrderByDescending(a => a.ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/DisabledInfoes/5
        [ResponseType(typeof(DisabledInfo))]
        public async Task<IHttpActionResult> GetDisabledInfo(int id)
        {
            DisabledInfo disabledInfo = await db.DisabledInfoes.FindAsync(id);
            if (disabledInfo == null)
            {
                return NotFound();
            }

            return Ok(disabledInfo);
        }

        // PUT: api/DisabledInfoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDisabledInfo(int id, DisabledInfo disabledInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != disabledInfo.ID)
            {
                return BadRequest();
            }
            try
            {
                if (disabledInfo.DisabledInfo_Details != null)
                {
                    foreach (var item in disabledInfo.DisabledInfo_Details)
                    {
                        if (item == null) continue;
                        //条件1：功能障碍者在“精准康复入户”模块中康复需求选择“辅助器具适配及服务”、“辅助器具适配及适应训练”选项，且服务走向为“上门评估”的，其全部数据自动转到“辅具上门评估与适配模块”；
                        if (string.IsNullOrEmpty(item.TargetExamName) && item.Rehabilitation.FuJu && item.NextID == 3)
                        {
                            var categoryName = db.Categories.Find(item.CategoryID).Name;
                            disabledInfo.TargetExamName = categoryName;
                        }
                        EntityStateHelper.BindEntityState(db, item);
                        item.DisabledInfoID = disabledInfo.ID;
                    }
                }
                db.Entry(disabledInfo).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (!DisabledInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw ex;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DisabledInfoes
        [ResponseType(typeof(DisabledInfo))]
        public async Task<IHttpActionResult> PostDisabledInfo(DisabledInfo disabledInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                //康复入户添加
                if (disabledInfo.Need)
                {
                    foreach (var item in disabledInfo.DisabledInfo_Details)
                    {
                        if (item == null) continue;
                        var r = db.Rehabilitations.Find(item.RehabilitationID);
                        if (string.IsNullOrEmpty(item.TargetExamName) && r.FuJu && item.NextID == 3)
                        {
                            var categoryName = db.Categories.Find(item.CategoryID).Name;
                            disabledInfo.TargetExamName = categoryName;
                        }
                    }
                }
                //更新到下一评估试卷
                db.DisabledInfoes.Add(disabledInfo);
                await db.SaveChangesAsync();
                SaveTargetExam(disabledInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CreatedAtRoute("DefaultApi", new { id = disabledInfo.ID }, disabledInfo);
        }

        // DELETE: api/DisabledInfoes/5
        [ResponseType(typeof(DisabledInfo))]
        public async Task<IHttpActionResult> DeleteDisabledInfo(int id)
        {
            DisabledInfo disabledInfo = await db.DisabledInfoes.FindAsync(id);
            if (disabledInfo == null)
            {
                return NotFound();
            }

            db.DisabledInfoes.Remove(disabledInfo);
            await db.SaveChangesAsync();

            return Ok(disabledInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DisabledInfoExists(int id)
        {
            return db.DisabledInfoes.Count(e => e.ID == id) > 0;
        }

        private string BindDesc(DisabledInfo d)
        {
            StringBuilder desc = new StringBuilder();
            try
            {
                foreach (var item in d.DisabledInfo_Details)
                {
                    if (item != null)
                    {
                        desc.Append(item.Category.Name).Append(item.Degree.Name);
                        if (item.Rehabilitation != null)
                        {
                            desc.Append("-").Append(item.Rehabilitation.RehabilitationName).Append(item.Next.Name);
                        }
                        desc.Append("<br>");
                    }
                }
                return desc.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SaveTargetExam(DisabledInfo disabledInfo)
        {

            if (string.IsNullOrEmpty(disabledInfo.TargetExamName))
            {
                Exam exam = db.Exams.Single(a => a.Name == disabledInfo.TargetExamName);
                bool exist = db.ExamRecords.Count(a => a.Exam.Name == disabledInfo.TargetExamName && a.DisabledInfoID == disabledInfo.ID) > 0;
                if (!exist)
                {
                    ExamRecord examRecord = new ExamRecord(exam.ID, disabledInfo.ID);
                    db.ExamRecords.Add(examRecord);
                    db.SaveChanges();
                }
            }
        }
    }
}