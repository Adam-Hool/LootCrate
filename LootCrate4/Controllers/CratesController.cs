using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LootCrate4.Models;

namespace LootCrate4.Controllers
{
    public class CratesController : Controller
    {
        private LootContext db = new LootContext();

        // GET: Crates
        public ActionResult Index()
        {
            return View(db.Crate.ToList());
        }

        // GET: Crates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crate crate = db.Crate.Find(id);
            if (crate == null)
            {
                return HttpNotFound();
            }
            return View(crate);
        }

        // GET: Crates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,crateName")] Crate crate)
        {
            if (ModelState.IsValid)
            {
                db.Crate.Add(crate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(crate);
        }

        // GET: Crates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crate crate = db.Crate.Find(id);
            if (crate == null)
            {
                return HttpNotFound();
            }
            return View(crate);
        }

        // POST: Crates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,crateName")] Crate crate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(crate);
        }

        // GET: Crates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crate crate = db.Crate.Find(id);
            if (crate == null)
            {
                return HttpNotFound();
            }
            return View(crate);
        }

        // POST: Crates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Crate crate = db.Crate.Find(id);
            db.Crate.Remove(crate);
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
