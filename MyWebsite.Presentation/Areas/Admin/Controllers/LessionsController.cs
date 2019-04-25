﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWebsite.Core;
using MyWebsite.Core.Models;

namespace MyWebsite.Presentation.Areas.Admin.Controllers
{
    public class LessionsController : Controller
    {
        private MyWebsiteDbContext db = new MyWebsiteDbContext();

        // GET: Admin/Lessions
        public ActionResult Index()
        {
            return View(db.Lessions.ToList());
        }

        // GET: Admin/Lessions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lession lession = db.Lessions.Find(id);
            if (lession == null)
            {
                return HttpNotFound();
            }
            return View(lession);
        }

        // GET: Admin/Lessions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Lessions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MainConent,SoundLession,Sound,LessionShortDescription,PostOn,Modifie")] Lession lession)
        {
            if (ModelState.IsValid)
            {
                db.Lessions.Add(lession);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lession);
        }

        // GET: Admin/Lessions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lession lession = db.Lessions.Find(id);
            if (lession == null)
            {
                return HttpNotFound();
            }
            return View(lession);
        }

        // POST: Admin/Lessions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MainConent,SoundLession,Sound,LessionShortDescription,PostOn,Modifie")] Lession lession)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lession).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lession);
        }

        // GET: Admin/Lessions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lession lession = db.Lessions.Find(id);
            if (lession == null)
            {
                return HttpNotFound();
            }
            return View(lession);
        }

        // POST: Admin/Lessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lession lession = db.Lessions.Find(id);
            db.Lessions.Remove(lession);
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
