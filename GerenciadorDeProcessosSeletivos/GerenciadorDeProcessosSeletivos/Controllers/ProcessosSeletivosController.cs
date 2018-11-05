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
    public class ProcessosSeletivosController : Controller
    {
        private PSeletivoContext db = new PSeletivoContext();

        // GET: ProcessosSeletivos
        public ActionResult Index()
        {
            return View(db.ProcessoSeletivo.ToList());
        }

        // GET: ProcessosSeletivos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProcessoSeletivo processoSeletivo = db.ProcessoSeletivo.Find(id);
            if (processoSeletivo == null)
            {
                return HttpNotFound();
            }
            return View(processoSeletivo);
        }

        // GET: ProcessosSeletivos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProcessosSeletivos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Cargo")] ProcessoSeletivo processoSeletivo)
        {
            if (ModelState.IsValid)
            {
                db.ProcessoSeletivo.Add(processoSeletivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(processoSeletivo);
        }

        // GET: ProcessosSeletivos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProcessoSeletivo processoSeletivo = db.ProcessoSeletivo.Find(id);
            if (processoSeletivo == null)
            {
                return HttpNotFound();
            }
            return View(processoSeletivo);
        }

        // POST: ProcessosSeletivos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Cargo")] ProcessoSeletivo processoSeletivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(processoSeletivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(processoSeletivo);
        }

        // GET: ProcessosSeletivos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProcessoSeletivo processoSeletivo = db.ProcessoSeletivo.Find(id);
            if (processoSeletivo == null)
            {
                return HttpNotFound();
            }
            return View(processoSeletivo);
        }

        // POST: ProcessosSeletivos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProcessoSeletivo processoSeletivo = db.ProcessoSeletivo.Find(id);
            db.ProcessoSeletivo.Remove(processoSeletivo);
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
