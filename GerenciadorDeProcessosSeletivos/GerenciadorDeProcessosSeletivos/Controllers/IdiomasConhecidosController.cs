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
    public class IdiomasConhecidosController : Controller
    {
        private PSeletivoContext db = new PSeletivoContext();

        // GET: IdiomasConhecidos
        public ActionResult Index()
        {
            return View(db.IdiomaConhecidoes.ToList());
        }

        // GET: IdiomasConhecidos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdiomaConhecido idiomaConhecido = db.IdiomaConhecidoes.Find(id);
            if (idiomaConhecido == null)
            {
                return HttpNotFound();
            }
            return View(idiomaConhecido);
        }

        // GET: IdiomasConhecidos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IdiomasConhecidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdiomaConhecidoId,Tipo,Nivel")] IdiomaConhecido idiomaConhecido)
        {
            if (ModelState.IsValid)
            {
                db.IdiomaConhecidoes.Add(idiomaConhecido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(idiomaConhecido);
        }

        // GET: IdiomasConhecidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdiomaConhecido idiomaConhecido = db.IdiomaConhecidoes.Find(id);
            if (idiomaConhecido == null)
            {
                return HttpNotFound();
            }
            return View(idiomaConhecido);
        }

        // POST: IdiomasConhecidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdiomaConhecidoId,Tipo,Nivel")] IdiomaConhecido idiomaConhecido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(idiomaConhecido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(idiomaConhecido);
        }

        // GET: IdiomasConhecidos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdiomaConhecido idiomaConhecido = db.IdiomaConhecidoes.Find(id);
            if (idiomaConhecido == null)
            {
                return HttpNotFound();
            }
            return View(idiomaConhecido);
        }

        // POST: IdiomasConhecidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IdiomaConhecido idiomaConhecido = db.IdiomaConhecidoes.Find(id);
            db.IdiomaConhecidoes.Remove(idiomaConhecido);
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
