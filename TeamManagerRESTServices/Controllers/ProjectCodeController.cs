using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TeamManagerRESTServices.Models;

namespace TeamManagerRESTServices.Controllers
{
    public class ProjectCodeController : ApiController
    {
        private TeamManager_NMOEntities db = new TeamManager_NMOEntities();

        // GET api/ProjectCode
        public IQueryable<tblProjectCode> GettblProjectCodes()
        {
            return db.tblProjectCodes;
        }

        // GET api/ProjectCode/5
        [ResponseType(typeof(tblProjectCode))]
        public IHttpActionResult GettblProjectCode(int id)
        {
            tblProjectCode tblprojectcode = db.tblProjectCodes.Find(id);
            if (tblprojectcode == null)
            {
                return NotFound();
            }

            //return Ok(tblprojectcode);
            return Json(tblprojectcode);
        }

        // PUT api/ProjectCode/5
        public IHttpActionResult PuttblProjectCode(int id, tblProjectCode tblprojectcode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblprojectcode.ProjectCodeID)
            {
                return BadRequest();
            }

            db.Entry(tblprojectcode).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblProjectCodeExists(id))
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

        // POST api/ProjectCode
        [ResponseType(typeof(tblProjectCode))]
        public IHttpActionResult PosttblProjectCode(tblProjectCode tblprojectcode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblProjectCodes.Add(tblprojectcode);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tblProjectCodeExists(tblprojectcode.ProjectCodeID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tblprojectcode.ProjectCodeID }, tblprojectcode);
        }

        // DELETE api/ProjectCode/5
        [ResponseType(typeof(tblProjectCode))]
        public IHttpActionResult DeletetblProjectCode(int id)
        {
            tblProjectCode tblprojectcode = db.tblProjectCodes.Find(id);
            if (tblprojectcode == null)
            {
                return NotFound();
            }

            db.tblProjectCodes.Remove(tblprojectcode);
            db.SaveChanges();

            return Ok(tblprojectcode);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblProjectCodeExists(int id)
        {
            return db.tblProjectCodes.Count(e => e.ProjectCodeID == id) > 0;
        }
    }
}