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
        public IHttpActionResult GetDisabledInfoes(string forListType = null, string examName = null)
        {
            try
            {
                var list = db.DisabledInfoes.AsQueryable();
                if (forListType == "精准康复入户")
                {
                    
                }
                if (forListType == "辅具上门评估")
                {
                    list = list.Where(a => a.ExamRecords.Count(b => b.Exam.Type == "辅具上门评估" && b.Evaluated == false) > 0);
                }
                if (forListType == "辅具上门评估")
                {
                    list = list.Where(a => a.ExamRecords.Count(b => b.Exam.Type == "辅具上门评估" && b.Evaluated == false) > 0);
                }
                var result = list.Select(
                        a => new
                        {
                            id = a.ID,
                            name = a.Name,
                            sex = a.Sex,
                            category = a.Category.Name,
                            degree = a.Degree.Name,
                            targetExamName = a.ExamRecords
                        });
                return Ok(result.OrderByDescending(a => a.id));
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
                            item.TargetExamName = item.Category.Name;
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
                if (disabledInfo.DisabledInfo_Details.Count() > 0)
                {
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
                }
                else
                {
                    //辅具上门添加

                }
                //更新到下一评估试卷
                if (disabledInfo.TargetExamName != null)
                {
                    bool exist;
                    Exam exam = await db.Exams.FirstOrDefaultAsync(a => a.Name == disabledInfo.TargetExamName);
                    if (exam != null)
                    {
                        bool exist = db.ExamRecords.Count(a => a.ExamID == exam.ID && a.DisabledInfoID == disabledInfo.ID) > 0;
                    }
                    else
                    {
                        bool exist = db.ExamRecords.Count(a => a.ExamName == disabledInfo.TargetExamName && a.DisabledInfoID == disabledInfo.ID) > 0;
                    }
                    if (!exist)
                    {
                        ExamRecord examRecord = new ExamRecord(exam.ID, disabledInfo.TargetExamName, disabledInfo.ID);
                    }
                }
                db.DisabledInfoes.Add(disabledInfo);
                await db.SaveChangesAsync();
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
    }
}