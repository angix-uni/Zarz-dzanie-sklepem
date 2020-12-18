using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjektZaliczenie.Controllers
{
    public class ZamowieniaController : Controller
    {
            private DAL.ZamowieniaContext db = new DAL.ZamowieniaContext();

            // GET: Zamowienie
            public ActionResult Index()
            {
                return View(db.Zamowienia.ToList());
            }

            // GET: Zamowienie/Details/5
            public ActionResult Details(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            Models.Zamowienia zamowienia = db.Zamowienia.Find(id);
                if (zamowienia == null)
                {
                    return HttpNotFound();
                }
                return View(zamowienia);
            }
        // GET: Zamowienie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zamowienie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Uzytkownik,Opis")] Models.Zamowienia zamowienia)
        {
            if (ModelState.IsValid)
            {
                db.Zamowienia.Add(zamowienia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zamowienia);
        }


        // GET: Zamowienie/Delete/5
        public ActionResult Delete(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            Models.Zamowienia zamowienia = db.Zamowienia.Find(id);
                if (zamowienia == null)
                {
                    return HttpNotFound();
                }
                return View(zamowienia);
            }

            // POST: Zamowienie/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public ActionResult DeleteConfirmed(int id)
            {
            Models.Zamowienia zamowienia = db.Zamowienia.Find(id);
                db.Zamowienia.Remove(zamowienia);
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