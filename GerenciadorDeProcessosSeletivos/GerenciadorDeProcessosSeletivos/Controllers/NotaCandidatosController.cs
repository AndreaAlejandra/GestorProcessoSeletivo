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
    public class NotaCandidatosController : Controller
    {
        private PSeletivoContext db = new PSeletivoContext();

        // GET: NotaCandidatos
        public ActionResult Index()
        {
            return View(db.NotaCandidato.ToList());
        }

        // GET: NotaCandidatos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotaCandidato notaCandidato = db.NotaCandidato.Find(id);
            if (notaCandidato == null)
            {
                return HttpNotFound();
            }
            return View(notaCandidato);
        }

        // GET: NotaCandidatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotaCandidatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NotaCandidatoId,Nota")] NotaCandidato notaCandidato)
        {
            if (ModelState.IsValid)
            {
                db.NotaCandidato.Add(notaCandidato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notaCandidato);
        }

        // GET: NotaCandidatos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotaCandidato notaCandidato = db.NotaCandidato.Find(id);
            if (notaCandidato == null)
            {
                return HttpNotFound();
            }
            return View(notaCandidato);
        }

        // POST: NotaCandidatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NotaCandidatoId,Nota")] NotaCandidato notaCandidato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notaCandidato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notaCandidato);
        }

        // GET: NotaCandidatos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotaCandidato notaCandidato = db.NotaCandidato.Find(id);
            if (notaCandidato == null)
            {
                return HttpNotFound();
            }
            return View(notaCandidato);
        }

        // POST: NotaCandidatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotaCandidato notaCandidato = db.NotaCandidato.Find(id);
            db.NotaCandidato.Remove(notaCandidato);
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
