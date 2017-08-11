using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorldCreator.DAL;
using WorldCreator.Models;

namespace WorldCreator.Controllers
{
    public class NPCsController : Controller
    {
        private RegionContext db = new RegionContext();

        // GET: NPCs
        public ActionResult Index()
        {
            return View(db.NPCs.ToList());
        }

        // GET: NPCs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPC nPC = db.NPCs.Find(id);
            if (nPC == null)
            {
                return HttpNotFound();
            }
            return View(nPC);
        }

        // GET: NPCs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NPCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NPCID,Name,Profession,Information")] NPC nPC)
        {
            if (ModelState.IsValid)
            {
                db.NPCs.Add(nPC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nPC);
        }

        // GET: NPCs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPC nPC = db.NPCs.Find(id);
            if (nPC == null)
            {
                return HttpNotFound();
            }
            return View(nPC);
        }

        // POST: NPCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NPCID,Name,Profession,Information")] NPC nPC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nPC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nPC);
        }

        // GET: NPCs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPC nPC = db.NPCs.Find(id);
            if (nPC == null)
            {
                return HttpNotFound();
            }
            return View(nPC);
        }

        // POST: NPCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NPC nPC = db.NPCs.Find(id);
            db.NPCs.Remove(nPC);
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
