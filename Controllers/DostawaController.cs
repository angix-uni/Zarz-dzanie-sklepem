using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjektZaliczenie.DAL;
using ProjektZaliczenie.Models;

namespace ProjektZaliczenie.Controllers
{
    public class DostawaController : Controller
    {
        private DostawaContext db = new DostawaContext();

        // GET: Dostawa
        public ActionResult Index()
        {
            return View(db.Dostawa.ToList());
        }

        // GET: Dostawa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dostawa dostawa = db.Dostawa.Find(id);
            if (dostawa == null)
            {
                return HttpNotFound();
            }
            return View(dostawa);
        }

        // GET: Dostawa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dostawa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Dostawca,Opis,Uwagi")] Dostawa dostawa)
        {
            if (ModelState.IsValid)
            {
                db.Dostawa.Add(dostawa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dostawa);
        }

        // GET: Dostawa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dostawa dostawa = db.Dostawa.Find(id);
            if (dostawa == null)
            {
                return HttpNotFound();
            }
            return View(dostawa);
        }

        // POST: Dostawa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Dostawca,Opis,Uwagi")] Dostawa dostawa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dostawa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dostawa);
        }

        // GET: Dostawa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dostawa dostawa = db.Dostawa.Find(id);
            if (dostawa == null)
            {
                return HttpNotFound();
            }
            return View(dostawa);
        }

        // POST: Dostawa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dostawa dostawa = db.Dostawa.Find(id);
            db.Dostawa.Remove(dostawa);
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