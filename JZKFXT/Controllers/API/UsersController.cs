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
using System.Web.Security;
using JZKFXT.Filter;

namespace JZKFXT.Controllers
{
    [WebApiExceptionFilterAttribute]
    public class UsersController : ApiController
    {
        private BaseContext db = new BaseContext();

        // GET: api/Users
        public async Task<IHttpActionResult> GetUsers(User user, bool login = false)
        {
            if (login)
            {
                User loginuser = await db.Users.FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);
                if (user == null)
                {
                    return NotFound();
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    loginuser.LastLoginTime = DateTime.Now;
                    await db.SaveChangesAsync();
                    return Ok(user);
                }
            }
            var result = db.Users;
            return Ok(result);
        }
        //登录
        [HttpGet]
        [Route("api/User")]
        public async Task<IHttpActionResult> GetUser(string UserName, string Password)
        {
            User loginuser = await db.Users.FirstOrDefaultAsync(u => u.UserName == UserName && u.Password == Password);
            if (loginuser == null)
            {
                return NotFound();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(loginuser.UserName, false);
                loginuser.LastLoginTime = DateTime.Now;
                await db.SaveChangesAsync();
                return Ok(loginuser);
            }
        }
        //修改
        [HttpPut]
        [Route("api/ChangeUser")]
        public async Task<IHttpActionResult> ChangeUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            User u = await db.Users.FirstOrDefaultAsync(x => x.ID == user.ID);
            if (u == null)
            {
                return NotFound();
            }
            else
            {
                u.RealName = user.RealName;
                u.Phone = user.Phone;
                u.Img = user.Img;
                try
                {
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return StatusCode(HttpStatusCode.NoContent);
            }
        }

        // GET: api/Users/5
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> GetUser(int id)
        {
            User user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUser(int id, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.ID)
            {
                return BadRequest();
            }

            db.Entry(user).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> PostUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            user.CreateTime = DateTime.Now;
            db.Users.Add(user);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = user.ID }, user);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> DeleteUser(int id)
        {
            User user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);
            await db.SaveChangesAsync();

            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserExists(int id)
        {
            return db.Users.Count(e => e.ID == id) > 0;
        }
    }
}