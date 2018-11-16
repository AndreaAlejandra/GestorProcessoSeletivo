using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GerenciadorDeProcessosSeletivos.Context;
using GerenciadorDeProcessosSeletivos.Models;

namespace GerenciadorDeProcessosSeletivos.Controllers
{
    public class FasesController : Controller
    {
        private PSeletivoContext db = new PSeletivoContext();

        // GET: Fases
        public ActionResult Index()
        {
            return View(db.Fase.ToList());
        }

        // GET: Fases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fase fase = db.Fase.Find(id);
            if (fase == null)
            {
                return HttpNotFound();
            }
            return View(fase);
        }

        // GET: Fases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FaseId,TipoFase,Status")] Fase fase)
        {
            if (ModelState.IsValid)
            {
                db.Fase.Add(fase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fase);
        }

        // GET: Fases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fase fase = db.Fase.Find(id);
            if (fase == null)
            {
                return HttpNotFound();
            }
            return View(fase);
        }

        // POST: Fases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FaseId,TipoFase,Status")] Fase fase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fase);
        }

        // GET: Fases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fase fase = db.Fase.Find(id);
            if (fase == null)
            {
                return HttpNotFound();
            }
            return View(fase);
        }

        // POST: Fases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fase fase = db.Fase.Find(id);
            db.Fase.Remove(fase);
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
