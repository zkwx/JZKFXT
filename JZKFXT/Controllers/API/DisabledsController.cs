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
    public class DisabledsController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Disableds
        public IHttpActionResult GetDisableds(string examBy = null, string name = null, string listType = null, int userID = 0)
        {
            try
            {
                var list = db.Disableds.AsQueryable();
                var result2 = list.Select(
                    a => new
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Sex = a.Sex,
                        Category = a.Category.Name,
                        Degree = a.Degree.Name,
                        ExamRecords = a.ExamRecords,
                        UserID = a.UserID,
                    });
                if (userID != 0)
                {
                    result2 = result2.Where(x => x.UserID == userID);
                }
                return Ok(result2.OrderByDescending(a => a.ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/Disableds/5
        [ResponseType(typeof(Disabled))]
        public async Task<IHttpActionResult> GetDisabled(int id)
        {
            Disabled Disabled = await db.Disableds.FindAsync(id);
            if (Disabled == null)
            {
                return NotFound();
            }

            return Ok(Disabled);
        }

        // PUT: api/Disableds/5
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
                string ExamName = null;
                //康复入户修改
                if (Disabled.Need)
                {
                    foreach (var item in Disabled.Disabled_Details)
                    {
                        if (item == null) continue;
                        item.DisabledID = Disabled.ID;
                        EntityStateHelper.BindEntityState(db, item);

                        var r = db.Rehabilitations.Find(item.RehabilitationID);
                        //条件1：功能障碍者在“精准康复入户”模块中康复需求选择“辅助器具适配及服务”、“辅助器具适配及适应训练”选项，且服务走向为“上门评估”的，其全部数据自动转到“辅具上门评估与适配模块”；
                        if (r.FuJu && item.NextID == 3)
                        {
                            //优先做肢体试题
                            if (ExamName != "肢体")
                            {
                                ExamName = db.Categories.Find(item.CategoryID).Name;
                            }
                        }
                    }
                }
                db.Entry(Disabled).State = EntityState.Modified;
                await db.SaveChangesAsync();
                SaveTargetExam(Disabled.ID, ExamName, ExamState.待评估);
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

        // POST: api/Disableds
        [ResponseType(typeof(Disabled))]
        public async Task<IHttpActionResult> PostDisabled(Disabled Disabled)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                string ExamName = null;
                //康复入户添加
                if (Disabled.Need)
                {
                    foreach (var item in Disabled.Disabled_Details)
                    {
                        if (item == null) continue;
                        var r = db.Rehabilitations.Find(item.RehabilitationID);
                        if (r.FuJu && item.NextID == 3)
                        {
                            //优先做肢体试题
                            if (ExamName != "肢体")
                            {
                                ExamName = db.Categories.Find(item.CategoryID).Name;
                            }
                        }
                    }
                }
                //更新到下一评估试卷
                Disabled.CreateTime = DateTime.Now;
                db.Disableds.Add(Disabled);
                await db.SaveChangesAsync();
                SaveTargetExam(Disabled.ID, ExamName, ExamState.待评估);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CreatedAtRoute("DefaultApi", new { id = Disabled.ID }, Disabled);
        }

        // DELETE: api/Disableds/5
        [ResponseType(typeof(Disabled))]
        public async Task<IHttpActionResult> DeleteDisabled(int id)
        {
            Disabled Disabled = await db.Disableds.FindAsync(id);
            if (Disabled == null)
            {
                return NotFound();
            }

            db.Disableds.Remove(Disabled);
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
            return db.Disableds.Count(e => e.ID == id) > 0;
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
        private void SaveTargetExam(int disabledID, string ExamName, ExamState state)
        {

            if (!string.IsNullOrEmpty(ExamName))
            {
                Exam exam = db.Exams.Single(a => a.Name == ExamName);
                bool exist = db.ExamRecords.Count(a => a.Exam.Name == ExamName && a.DisabledID == disabledID) > 0;
                if (!exist)
                {
                    ExamRecord examRecord = new ExamRecord(exam.ID, disabledID, state);
                    db.ExamRecords.Add(examRecord);
                    db.SaveChanges();
                }
            }
        }

        //登录用户所负责的患者(进行中)
        [HttpGet]
        [Route("api/Disabled/Conduct")]
        public int Conduct(int id)
        {
            var list = db.Disableds.Where(a => a.UserID == id).ToList();
            List<ExamRecord> records = new List<ExamRecord>();
            foreach (var item in list)
            {
                var rec = db.ExamRecords.Where(x => x.DisabledID == item.ID).ToList();
                if (rec.Count() > 0)
                {
                    foreach (var i in rec)
                    {
                        if (i.State != ExamState.已完成)
                        {
                            if (i.Evaluated != true)
                            {
                                records.Add(i);
                            }
                        }
                    }
                }
            }
            return records.Count();
        }
        //登录用户所负责的患者(完成)
        [HttpGet]
        [Route("api/Disabled/Finish")]
        public int Finish(int id)
        {
            var list = db.Disableds.Where(a => a.UserID == id).ToList();
            List<ExamRecord> records = new List<ExamRecord>();
            foreach (var item in list)
            {
                var rec = db.ExamRecords.Where(x => x.DisabledID == item.ID);
                if (rec.Count() > 0)
                {
                    foreach (var i in rec)
                    {
                        if (i.State == ExamState.已完成)
                        {
                            records.Add(i);
                        }
                        else
                        {
                            if (i.Evaluated == true)
                            {
                                records.Add(i);
                            }
                        }
                    }
                }
            }
            return records.Count();
        }
    }
}