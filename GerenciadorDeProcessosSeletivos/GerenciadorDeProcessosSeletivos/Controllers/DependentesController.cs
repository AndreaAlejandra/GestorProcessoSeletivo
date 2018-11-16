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
    public class DependentesController : Controller
    {
        private PSeletivoContext db = new PSeletivoContext();

        // GET: Dependentes
        public ActionResult Index()
        {
            return View(db.Dependentes.ToList());
        }

        // GET: Dependentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependente dependente = db.Dependentes.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            return View(dependente);
        }

        // GET: Dependentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dependentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DependenteId,TipoDependente,Nome,DataNascimento,Cpf,Irrf")] Dependente dependente)
        {
            if (ModelState.IsValid)
            {
                db.Dependentes.Add(dependente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dependente);
        }

        // GET: Dependentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependente dependente = db.Dependentes.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            return View(dependente);
        }

        // POST: Dependentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DependenteId,TipoDependente,Nome,DataNascimento,Cpf,Irrf")] Dependente dependente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dependente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dependente);
        }

        // GET: Dependentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependente dependente = db.Dependentes.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            return View(dependente);
        }

        // POST: Dependentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dependente dependente = db.Dependentes.Find(id);
            db.Dependentes.Remove(dependente);
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
