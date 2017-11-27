using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleGuestBook.Models;

namespace SimpleGuestBook.Controllers
{
    public class HomeController : Controller
    {
        GuestBookModel db = new GuestBookModel();

        public ActionResult Index()
        {
            var entries = db.GuestbookEntries;
            return View(entries);
        }
        
        [HttpPost]
        public ActionResult Create(GuestbookEntry entry)
        {
            entry.DateAdded = DateTime.Now;
            db.GuestbookEntries.Add(entry);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}