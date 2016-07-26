using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WelpCodeFirst.Models
{
    public class BusinessesController : Controller
    {
        private WelpCodeFirstContext db = new WelpCodeFirstContext();

        // GET: Businesses
        public ActionResult Index()
        {
            var businesses = db.Businesses.Include(b => b.BusinessType).Include(b => b.User);
            return View(businesses.ToList());
        }

        // GET: Businesses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Business business = db.Businesses.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        // GET: Businesses/Create
        public ActionResult Create()
        {
            ViewBag.BusinessTypeID = new SelectList(db.BusinessTypes, "BusinessTypeID", "TypeName");
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName");
            return View();
        }

        // POST: Businesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BusinessID,BusinessTypeID,UserID,BusinessName,Address,Hours,Phone,Menu")] Business business)
        {
            if (ModelState.IsValid)
            {
                db.Businesses.Add(business);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusinessTypeID = new SelectList(db.BusinessTypes, "BusinessTypeID", "TypeName", business.BusinessTypeID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", business.UserID);
            return View(business);
        }

        // GET: Businesses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Business business = db.Businesses.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusinessTypeID = new SelectList(db.BusinessTypes, "BusinessTypeID", "TypeName", business.BusinessTypeID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", business.UserID);
            return View(business);
        }

        // POST: Businesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BusinessID,BusinessTypeID,UserID,BusinessName,Address,Hours,Phone,Menu")] Business business)
        {
            if (ModelState.IsValid)
            {
                db.Entry(business).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusinessTypeID = new SelectList(db.BusinessTypes, "BusinessTypeID", "TypeName", business.BusinessTypeID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", business.UserID);
            return View(business);
        }

        // GET: Businesses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Business business = db.Businesses.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        // POST: Businesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Business business = db.Businesses.Find(id);
            db.Businesses.Remove(business);
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
