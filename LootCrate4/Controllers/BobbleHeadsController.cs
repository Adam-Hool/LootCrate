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
    public class BobbleHeadsController : Controller
    {
        private LootContext db = new LootContext();

        // GET: BobbleHeads
        public ActionResult Index()
        {
            return View(db.BobbleHeads.ToList());
        }
        public ActionResult DisplaySearchResults(string searchText)
        {
            return PartialView("Index", db.BobbleHeads.ToList());
        }

        // GET: BobbleHeads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BobbleHead bobbleHead = db.BobbleHeads.Find(id);
            if (bobbleHead == null)
            {
                return HttpNotFound();
            }
            return View(bobbleHead);
        }

        // GET: BobbleHeads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BobbleHeads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,superHeroName")] BobbleHead bobbleHead)
        {
            if (ModelState.IsValid)
            {
                db.BobbleHeads.Add(bobbleHead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bobbleHead);
        }

        // GET: BobbleHeads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BobbleHead bobbleHead = db.BobbleHeads.Find(id);
            if (bobbleHead == null)
            {
                return HttpNotFound();
            }
            return View(bobbleHead);
        }

        // POST: BobbleHeads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,superHeroName")] BobbleHead bobbleHead)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bobbleHead).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bobbleHead);
        }

        // GET: BobbleHeads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BobbleHead bobbleHead = db.BobbleHeads.Find(id);
            if (bobbleHead == null)
            {
                return HttpNotFound();
            }
            return View(bobbleHead);
        }

        // POST: BobbleHeads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BobbleHead bobbleHead = db.BobbleHeads.Find(id);
            db.BobbleHeads.Remove(bobbleHead);
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
