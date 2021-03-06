﻿using System;
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
                        Disabled_Details = a.Disabled_Details,
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

        [HttpGet]
        [Route("api/Disableds/Exam")]
        public IHttpActionResult GetDisExamRecords(string ExamName = null, int DisabledID = 0, int userID = 0)
        {
            try
            {
                var list = db.ExamRecords.AsQueryable();
                var result2 = list.Select(a => new
                {
                    ID = a.ID,
                    Exam = a.Exam,
                    ExamID = a.ExamID,
                    Disabled = a.Disabled,
                    DisabledID = a.DisabledID,
                    Auditor = a.Auditor,
                    Complete = a.Complete,
                    FinishTime = a.FinishTime,
                    NextID = a.NextID,
                    ShowArea = a.ShowArea,
                    State = a.State,
                });
                Exam exam = db.Exams.Single(a => a.Name == ExamName);
                if (exam != null)
                {
                    result2 = result2.Where(x => x.ExamID == exam.ID);
                }
                if (DisabledID != 0)
                {
                    result2 = result2.Where(x => x.DisabledID == DisabledID);
                }
                if (userID != 0)
                {
                    result2 = result2.Where(x => x.Disabled.UserID == userID);
                }
                return Ok(result2);
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

        [HttpGet]
        [Route("api/Disableds/SaveUserSign")]
        public async Task<IHttpActionResult> SaveUserSignUrl(int disabledID, string userSignUrl)
        {
            Disabled Disabled = await db.Disableds.FindAsync(disabledID);
            if (Disabled == null)
            {
                return NotFound();
            }
            try
            {
                Disabled.UserSignUrl = userSignUrl;
                db.SaveChanges();
                return Ok(disabledID);
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        [HttpPut]
        [Route("api/Disableds/SaveUserInfo")]
        public async Task<IHttpActionResult> SaveUserInfo(int id, Disabled Disabled)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Disabled.ID)
            {
                return BadRequest();
            }

            db.Entry(Disabled).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
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
                Boolean flag = false;
                int? nextID = null;
                var state = ExamState.待评估;
                //康复入户修改
                if (Disabled.Need)
                {

                    foreach (var item in Disabled.Disabled_Details)
                    {
                        if (item == null) continue;
                        var detail = db.Disabled_Details.Where(x => x.DisabledID == Disabled.ID).FirstOrDefault();
                        db.Disabled_Details.Remove(detail);
                        await db.SaveChangesAsync();
                        if (detail.NextID != item.NextID)
                        {
                            item.ID = 0;
                        }
                        item.DisabledID = Disabled.ID;
                        EntityStateHelper.BindEntityState(db, item);
                        var r = db.Rehabilitations.Find(item.RehabilitationID);
                        //条件1：功能障碍者在“精准康复入户”模块中康复需求选择“辅助器具适配及服务”、“辅助器具适配及适应训练”选项，且服务走向为“上门评估”的，其全部数据自动转到“辅具上门评估与适配模块”；
                        //if (r.FuJu && item.NextID == 3)
                        nextID = item.NextID;
                        if (r.FuJu || item.NextID == 3)
                        {
                            //优先做肢体试题
                            if (ExamName != "肢体")
                            {
                                ExamName = db.Categories.Find(item.CategoryID).Name;
                                state = ExamState.待评估;
                            }
                        }
                        else if (item.NextID == 1)
                        {
                            ExamName = db.Categories.Find(item.CategoryID).Name;
                            flag = true;
                            state = ExamState.待审核;
                        }
                        else if (item.NextID == 2)
                        {
                            ExamName = db.Categories.Find(item.CategoryID).Name;
                            flag = true;
                            state = ExamState.待完成;
                        }
                    }
                }
                Disabled.UpdateTime = DateTime.Now;
                db.Entry(Disabled).State = EntityState.Modified;
                await db.SaveChangesAsync();
                if (ExamName == "肢体")
                {
                    //3、偏瘫  4、脑瘫  5、脊髓  6、肢体综合  
                    string[] list = { "偏瘫", "脑瘫", "脊髓", "肢体" };
                    foreach (var item in list)
                    {
                        SaveTargetExam(Disabled.ID, item, state, flag, nextID);
                    }
                }
                else
                {
                    SaveTargetExam(Disabled.ID, ExamName, state, flag, nextID);
                }
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
                Boolean flag = false;
                int? nextID = 0;
                var state = ExamState.待评估;
                //康复入户添加
                if (Disabled.Need)
                {
                    foreach (var item in Disabled.Disabled_Details)
                    {
                        if (item == null) continue;
                        var r = db.Rehabilitations.Find(item.RehabilitationID);
                        //if (r.FuJu && item.NextID == 3)
                        nextID = item.NextID;
                        if (r.FuJu || item.NextID == 3)
                        {
                            //优先做肢体试题
                            if (ExamName != "肢体")
                            {
                                ExamName = db.Categories.Find(item.CategoryID).Name;
                                state = ExamState.待评估;
                            }
                        }
                        else if (item.NextID == 1)
                        {
                            ExamName = db.Categories.Find(item.CategoryID).Name;
                            flag = true;
                            state = ExamState.待审核;
                        }
                        else if (item.NextID == 2)
                        {
                            ExamName = db.Categories.Find(item.CategoryID).Name;
                            flag = true;
                            state = ExamState.待完成;
                        }
                    }
                }
                //更新到下一评估试卷
                Disabled.CreateTime = DateTime.Now;
                db.Disableds.Add(Disabled);
                await db.SaveChangesAsync();
                if (ExamName == "肢体")
                {
                    //3、偏瘫  4、脑瘫  5、脊髓  6、肢体综合  
                    string[] list = { "偏瘫", "脑瘫", "脊髓", "肢体" };
                    foreach (var item in list)
                    {
                        SaveTargetExam(Disabled.ID, item, state, flag, nextID);
                    }
                }
                else
                {
                    SaveTargetExam(Disabled.ID, ExamName, state, flag, nextID);
                }
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
            var flag = true;
            Disabled Disabled = await db.Disableds.FindAsync(id);
            if (Disabled == null)
            {
                return NotFound();
            }
            var list = db.ExamRecords.Where(x => x.DisabledID == id);
            foreach (var item in list)
            {
                if (item.State != 0)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                db.ExamRecords.RemoveRange(list);
                var li = db.Disabled_Details.Where(x => x.DisabledID == id);
                db.Disabled_Details.RemoveRange(li);
                db.Disableds.Remove(Disabled);
                await db.SaveChangesAsync();
                return StatusCode(HttpStatusCode.NoContent);
            }
            else
            {
                return Ok(Disabled.ID);
            }
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
        private void SaveTargetExam(int disabledID, string ExamName, ExamState state, Boolean flag, int? nextID)
        {
            if (!string.IsNullOrEmpty(ExamName))
            {
                Exam exam = db.Exams.Single(a => a.Name == ExamName);
                bool exist = db.ExamRecords.Count(a => a.Exam.Name == ExamName && a.DisabledID == disabledID) > 0;
                if (!exist)
                {
                    bool f = true;
                    string[] list = { "偏瘫", "脑瘫", "脊髓", "肢体" };
                    foreach (var item in list)
                    {
                        if (exam.Name == item)
                        {
                            f = false;
                        }
                    }
                    if (f)
                    {
                        var num = db.ExamRecords.Count(x => x.DisabledID == disabledID && x.State == ExamState.待评估);
                        var record = db.ExamRecords.Where(x => x.DisabledID == disabledID && x.State == ExamState.待评估);
                        if (num == 1 || num == 4)
                        {
                            db.ExamRecords.RemoveRange(record);
                        }
                        var examRecord = new ExamRecord(exam.ID, disabledID, state, flag, nextID);
                        db.ExamRecords.Add(examRecord);
                    }
                    else
                    {
                        var num = db.ExamRecords.Count(x => x.DisabledID == disabledID && x.State == ExamState.待评估);
                        var record = db.ExamRecords.Where(x => x.DisabledID == disabledID && x.State == ExamState.待评估);
                        if (num == 1)
                        {
                            bool t = false;
                            foreach (var item in list)
                            {
                                if (record.FirstOrDefault().Exam.Name == item)
                                {
                                    t = true;
                                }
                            }
                            if (!t)
                            {
                                db.ExamRecords.RemoveRange(record);
                            }
                        }
                        var examRecord = new ExamRecord(exam.ID, disabledID, state, flag, nextID);
                        var user = db.Disableds.Where(x => x.ID == disabledID).FirstOrDefault();
                        db.ExamRecords.Add(examRecord);
                    }

                }
                else
                {
                    var examRecord = db.ExamRecords.FirstOrDefault(x => x.DisabledID == disabledID && x.ExamID == exam.ID);
                    //转存机构审核
                    if (nextID == 1)
                    {
                        if ((examRecord.State == ExamState.待评估 && examRecord.NextID == 3) || (examRecord.State == ExamState.待完成 && examRecord.NextID == 2))
                        {
                            examRecord.DisabledID = disabledID;
                            examRecord.ExamID = exam.ID;
                            examRecord.State = state;
                            examRecord.Evaluated = flag;
                            examRecord.NextID = nextID;
                        }
                    }
                    //转存康复服务机构
                    else if (nextID == 2)
                    {
                        if ((examRecord.State == ExamState.待评估 && examRecord.NextID == 3) || (examRecord.State == ExamState.待审核 && examRecord.NextID == 1))
                        {
                            examRecord.DisabledID = disabledID;
                            examRecord.ExamID = exam.ID;
                            examRecord.State = state;
                            examRecord.Evaluated = flag;
                            examRecord.NextID = nextID;
                        }
                    }
                    //转存上门评估
                    else if (nextID == 3)
                    {
                        if ((examRecord.State == ExamState.待审核 && examRecord.NextID == 1) || (examRecord.State == ExamState.待完成 && examRecord.NextID == 2))
                        {
                            examRecord.DisabledID = disabledID;
                            examRecord.ExamID = exam.ID;
                            examRecord.State = state;
                            examRecord.Evaluated = flag;
                            examRecord.NextID = nextID;
                        }
                    }
                }
                db.SaveChanges();
            }
        }
    }
}