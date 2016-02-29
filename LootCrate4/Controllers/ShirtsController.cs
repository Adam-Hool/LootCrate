﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LootCrate4.Models;
using LootCrate4.CustomFilters;

namespace LootCrate4.Controllers
{
    public class ShirtsController : Controller
    {
        private LootContext db = new LootContext();

        // GET: Shirts
        public ActionResult Index()
        {
            return View(db.Shirts.ToList());
        }
        public ActionResult DisplaySearchResults(string searchText)
        {
            //var model = 
            return PartialView("Index", db.Shirts.ToList());
        }

        // GET: Shirts/Details/5

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shirt shirt = db.Shirts.Find(id);
            if (shirt == null)
            {
                return HttpNotFound();
            }
            return View(shirt);
        }

        // GET: Shirts/Create
        [AuthLog(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shirts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,size,superHeroName")] Shirt shirt)
        {
            if (ModelState.IsValid)
            {
                db.Shirts.Add(shirt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shirt);
        }

        // GET: Shirts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shirt shirt = db.Shirts.Find(id);
            if (shirt == null)
            {
                return HttpNotFound();
            }
            return View(shirt);
        }

        // POST: Shirts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,size,superHeroName")] Shirt shirt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shirt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shirt);
        }

        // GET: Shirts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shirt shirt = db.Shirts.Find(id);
            if (shirt == null)
            {
                return HttpNotFound();
            }
            return View(shirt);
        }

        // POST: Shirts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shirt shirt = db.Shirts.Find(id);
            db.Shirts.Remove(shirt);
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
