using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using LootCrate4.Models;

namespace LootCrate4.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;
        public UserController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }
        // GET: User
        public ActionResult Index()
        {
            //var currentUser = manager.FindById(User.Identity.GetUserId());
            //return View(db.Users.ToList().Where(User => User.Id == currentUser.Id));
            return View(/*db.Users.ToList()*/);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,IsDone")] User User)
        {
            var currentUser = (System.Web.HttpContext.Current.User.Identity.GetUserId());
            if (ModelState.IsValid)
            {
                User.AspNetUser = currentUser;
                db.User.Add(User);
                db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(User);
        }

    }
}