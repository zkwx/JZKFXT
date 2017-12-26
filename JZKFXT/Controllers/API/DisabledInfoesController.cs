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
    public class DisabledesController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Disabledes
        public IHttpActionResult GetDisabledes(string examBy = null, string name = null, string listType = null)
        {
            try
            {
                var list = db.Disabledes.AsQueryable();
                if (examBy == "type")
                {
                    var DisabledIds = db.ExamRecords.Where(a => a.Exam.Type == name && a.Evaluated == false).Select(a => a.DisabledID);
                    list = list.Where(a => DisabledIds.Contains(a.ID));
                    var result = list.Select(
                    a => new
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Sex = a.Sex,
                        Category = a.Category.Name,
                        Degree = a.Degree.Name,
                        CurrentExam = a.ExamRecords.FirstOrDefault(b => b.Exam.Type == name)
                    }).GroupBy(a => a.CurrentExam.Exam.Name);
                    return Ok(result);
                }
                else if (examBy == "name")
                {
                    var DisabledIds = db.ExamRecords.Where(a => a.Exam.Name == name && a.Evaluated == false).Select(a => a.DisabledID);
                    list = list.Where(a => DisabledIds.Contains(a.ID));
                    var result = list.Select(
                    a => new
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Sex = a.Sex,
                        Category = a.Category.Name,
                        Degree = a.Degree.Name,
                        CurrentExam = a.ExamRecords.FirstOrDefault(b => b.Exam.Name == name)
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

        // GET: api/Disabledes/5
        [ResponseType(typeof(Disabled))]
        public async Task<IHttpActionResult> GetDisabled(int id)
        {
            Disabled Disabled = await db.Disabledes.FindAsync(id);
            if (Disabled == null)
            {
                return NotFound();
            }

            return Ok(Disabled);
        }

        // PUT: api/Disabledes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDisabled(int id, Disabled Disabled)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Disabled.ID)
            {
                return BadRequest();
            }
            try
            {
                if (Disabled.Disabled_Details != null)
                {
                    foreach (var item in Disabled.Disabled_Details)
                    {
                        if (item == null) continue;
                        //条件1：功能障碍者在“精准康复入户”模块中康复需求选择“辅助器具适配及服务”、“辅助器具适配及适应训练”选项，且服务走向为“上门评估”的，其全部数据自动转到“辅具上门评估与适配模块”；
                        if (string.IsNullOrEmpty(item.TargetExamName) && item.Rehabilitation.FuJu && item.NextID == 3)
                        {
                            var categoryName = db.Categories.Find(item.CategoryID).Name;
                            Disabled.TargetExamName = categoryName;
                        }
                        EntityStateHelper.BindEntityState(db, item);
                        item.DisabledID = Disabled.ID;
                    }
                }
                db.Entry(Disabled).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (!DisabledExists(id))
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

        // POST: api/Disabledes
        [ResponseType(typeof(Disabled))]
        public async Task<IHttpActionResult> PostDisabled(Disabled Disabled)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                //康复入户添加
                if (Disabled.Need)
                {
                    foreach (var item in Disabled.Disabled_Details)
                    {
                        if (item == null) continue;
                        var r = db.Rehabilitations.Find(item.RehabilitationID);
                        if (string.IsNullOrEmpty(item.TargetExamName) && r.FuJu && item.NextID == 3)
                        {
                            var categoryName = db.Categories.Find(item.CategoryID).Name;
                            Disabled.TargetExamName = categoryName;
                        }
                    }
                }
                //更新到下一评估试卷
                db.Disabledes.Add(Disabled);
                await db.SaveChangesAsync();
                SaveTargetExam(Disabled);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CreatedAtRoute("DefaultApi", new { id = Disabled.ID }, Disabled);
        }

        // DELETE: api/Disabledes/5
        [ResponseType(typeof(Disabled))]
        public async Task<IHttpActionResult> DeleteDisabled(int id)
        {
            Disabled Disabled = await db.Disabledes.FindAsync(id);
            if (Disabled == null)
            {
                return NotFound();
            }

            db.Disabledes.Remove(Disabled);
            await db.SaveChangesAsync();

            return Ok(Disabled);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DisabledExists(int id)
        {
            return db.Disabledes.Count(e => e.ID == id) > 0;
        }

        private string BindDesc(Disabled d)
        {
            StringBuilder desc = new StringBuilder();
            try
            {
                foreach (var item in d.Disabled_Details)
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
        private void SaveTargetExam(Disabled Disabled)
        {

            if (string.IsNullOrEmpty(Disabled.TargetExamName))
            {
                Exam exam = db.Exams.Single(a => a.Name == Disabled.TargetExamName);
                bool exist = db.ExamRecords.Count(a => a.Exam.Name == Disabled.TargetExamName && a.DisabledID == Disabled.ID) > 0;
                if (!exist)
                {
                    ExamRecord examRecord = new ExamRecord(exam.ID, Disabled.ID,ExamState.待评估);
                    db.ExamRecords.Add(examRecord);
                    db.SaveChanges();
                }
            }
        }
    }
}