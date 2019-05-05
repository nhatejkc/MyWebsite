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
    public class GrammarsController : Controller
    {
        private MyWebsiteDbContext db = new MyWebsiteDbContext();

        // GET: Admin/Grammars
        public ActionResult Index()
        {
            var grammars = db.Grammars.Include(g => g.Lession);
            return View(grammars.ToList());
        }

        // GET: Admin/Grammars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grammar grammar = db.Grammars.Find(id);
            if (grammar == null)
            {
                return HttpNotFound();
            }
            return View(grammar);
        }

        // GET: Admin/Grammars/Create
        public ActionResult Create()
        {
            ViewBag.LessionId = new SelectList(db.Lessions, "Id", "Id");
            return View();
        }

        // POST: Admin/Grammars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,LessionId,GrammarShortDescription,GrammarDescription,PostOn,Modifie")] Grammar grammar)
        {
            if (ModelState.IsValid)
            {
                grammar.PostOn = DateTime.Now;
                db.Grammars.Add(grammar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LessionId = new SelectList(db.Lessions, "Id", "Id", grammar.LessionId);
            return View(grammar);
        }

        // GET: Admin/Grammars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grammar grammar = db.Grammars.Find(id);
            if (grammar == null)
            {
                return HttpNotFound();
            }
            ViewBag.LessionId = new SelectList(db.Lessions, "Id", "Id", grammar.LessionId);
            return View(grammar);
        }

        // POST: Admin/Grammars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,LessionId,GrammarShortDescription,GrammarDescription,PostOn,Modifie")] Grammar grammar)
        {
            if (ModelState.IsValid)
            {
                grammar.Modifie = DateTime.Now;
                db.Entry(grammar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LessionId = new SelectList(db.Lessions, "Id", "Id", grammar.LessionId);
            return View(grammar);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveItem(Grammar grammar)
        {
            if (ModelState.IsValid)
            {
                grammar.Modifie = DateTime.Now;
                db.Grammars.AddOrUpdate(grammar);
                //db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grammar);
        }
        public ActionResult DeleteItem(Grammar grammar)
        {
            var item = db.Grammars.Find(grammar.Id);
            db.Grammars.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Admin/Grammars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grammar grammar = db.Grammars.Find(id);
            if (grammar == null)
            {
                return HttpNotFound();
            }
            return View(grammar);
        }

        // POST: Admin/Grammars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grammar grammar = db.Grammars.Find(id);
            db.Grammars.Remove(grammar);
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
