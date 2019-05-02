using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWebsite.Core;
using MyWebsite.Core.Models;

namespace MyWebsite.Presentation.Areas.Admin.Controllers
{
    public class QuestionItemsController : Controller
    {
        private MyWebsiteDbContext db = new MyWebsiteDbContext();

        // GET: Admin/QuestionItems
        public ActionResult Index()
        {
            var questionItems = db.QuestionItems.Include(q => q.Question);
            return View(questionItems.ToList());
        }

        // GET: Admin/QuestionItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionItem questionItem = db.QuestionItems.Find(id);
            if (questionItem == null)
            {
                return HttpNotFound();
            }
            return View(questionItem);
        }

        // GET: Admin/QuestionItems/Create
        public ActionResult Create()
        {
            ViewBag.QuestionId = new SelectList(db.Questions, "Id", "Id");
            return View();
        }

        // POST: Admin/QuestionItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,QuestionId,Title")] QuestionItem questionItem)
        {
            if (ModelState.IsValid)
            {
                db.QuestionItems.Add(questionItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.QuestionId = new SelectList(db.Questions, "Id", "Id", questionItem.QuestionId);
            return View(questionItem);
        }

        // GET: Admin/QuestionItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionItem questionItem = db.QuestionItems.Find(id);
            if (questionItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.QuestionId = new SelectList(db.Questions, "Id", "Id", questionItem.QuestionId);
            return View(questionItem);
        }

        // POST: Admin/QuestionItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,QuestionId,Title")] QuestionItem questionItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.QuestionId = new SelectList(db.Questions, "Id", "Id", questionItem.QuestionId);
            return View(questionItem);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveItem(QuestionItem questionItem)
        {
            if (ModelState.IsValid)
            {
                db.QuestionItems.AddOrUpdate(questionItem);
                //db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(questionItem);
        }
        public ActionResult DeleteItem(int id)
        {
            var item = db.QuestionItems.Find(id);
            db.QuestionItems.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Admin/QuestionItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionItem questionItem = db.QuestionItems.Find(id);
            if (questionItem == null)
            {
                return HttpNotFound();
            }
            return View(questionItem);
        }

        // POST: Admin/QuestionItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuestionItem questionItem = db.QuestionItems.Find(id);
            db.QuestionItems.Remove(questionItem);
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
