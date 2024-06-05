using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NLDTlession06CF.Models;

namespace NLDTlession06CF.Controllers
{
    public class NLDTBooksController : Controller
    {
        private NLDTBookStore db = new NLDTBookStore();

        // GET: NLDTBooks
        public ActionResult Index()
        {
            return View(db.NLDTBooks.ToList());
        }

        // GET: NLDTBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTBook nLDTBook = db.NLDTBooks.Find(id);
            if (nLDTBook == null)
            {
                return HttpNotFound();
            }
            return View(nLDTBook);
        }

        // GET: NLDTBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NLDTBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NLDTBookID,NLDTTitle,NLDTAuthor,NLDTYear,NLDTPulisher,NLDTPicture,NLDTCategoryID")] NLDTBook nLDTBook)
        {
            if (ModelState.IsValid)
            {
                db.NLDTBooks.Add(nLDTBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nLDTBook);
        }

        // GET: NLDTBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTBook nLDTBook = db.NLDTBooks.Find(id);
            if (nLDTBook == null)
            {
                return HttpNotFound();
            }
            return View(nLDTBook);
        }

        // POST: NLDTBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NLDTBookID,NLDTTitle,NLDTAuthor,NLDTYear,NLDTPulisher,NLDTPicture,NLDTCategoryID")] NLDTBook nLDTBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nLDTBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nLDTBook);
        }

        // GET: NLDTBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTBook nLDTBook = db.NLDTBooks.Find(id);
            if (nLDTBook == null)
            {
                return HttpNotFound();
            }
            return View(nLDTBook);
        }

        // POST: NLDTBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NLDTBook nLDTBook = db.NLDTBooks.Find(id);
            db.NLDTBooks.Remove(nLDTBook);
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
