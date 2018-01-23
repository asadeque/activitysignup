using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ActivitySignUp.Models;

namespace ActivitySignUp.Controllers
{
    public class ActivityUsersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ActivityUsers
        public ActionResult Index(string searchString, string sortOrder, string currentFilter)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name" : "";
            ViewBag.CurrentFilter = searchString;

            var activityUsers = db.ActivityUsers.OrderBy(s => s.FirstName);

            if (!String.IsNullOrEmpty(searchString))
            {
                activityUsers = activityUsers.Where(s => s.FirstName.Contains(searchString)
                                       || s.LastName.Contains(searchString)).OrderBy(s => s.FirstName);
            }
            switch (sortOrder)
            {
                case "name":
                    activityUsers = activityUsers.OrderByDescending(s => s.FirstName);
                    break;
                default:
                    activityUsers = activityUsers.OrderBy(s => s.FirstName);
                    break;
            }

            return View(activityUsers.ToList());
        }

        // GET: ActivityUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityUser activityUser = db.ActivityUsers.Find(id);
            if (activityUser == null)
            {
                return HttpNotFound();
            }
            return View(activityUser);
        }

        // GET: ActivityUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActivityUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,ActivityType,MobileNumber,Comments,Email,CreatedDate,UpdatedDate")] ActivityUser activityUser)
        {
            if (ModelState.IsValid)
            {
                db.ActivityUsers.Add(activityUser);
                activityUser.CreatedDate = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activityUser);
        }

        // GET: ActivityUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityUser activityUser = db.ActivityUsers.Find(id);
            if (activityUser == null)
            {
                return HttpNotFound();
            }
            return View(activityUser);
        }

        // POST: ActivityUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,ActivityType,MobileNumber,Comments,Email,CreatedDate,UpdatedDate")] ActivityUser activityUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activityUser).State = EntityState.Modified;
                activityUser.UpdatedDate = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activityUser);
        }

        // GET: ActivityUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityUser activityUser = db.ActivityUsers.Find(id);
            if (activityUser == null)
            {
                return HttpNotFound();
            }
            return View(activityUser);
        }

        // POST: ActivityUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActivityUser activityUser = db.ActivityUsers.Find(id);
            db.ActivityUsers.Remove(activityUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
