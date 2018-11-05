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
    public class CandidatosController : Controller
    {
        private PSeletivoContext db = new PSeletivoContext();

        // GET: Candidatos
        public ActionResult Index()
        {
            return View(db.Candidato.ToList());
        }

        // GET: Candidatos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidato candidato = db.Candidato.Find(id);
            if (candidato == null)
            {
                return HttpNotFound();
            }
            return View(candidato);
        }

        // GET: Candidatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Candidatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CandidatoId,AnalistaRH,DataCadastro,Cargo,PretSalarial,FonteRecrutamento,Disponibilidade,NomeCandidato,Sexo,Endereco,DataNascimento,LocalNascimento,EstadoCivil,Raca,Email,Telefone,Celular,RG,DataExpedicao,OrgaoEmissor,CPF,NomeMae,NomePai,PIS,PossuiDependente,QuantDependente,TrabalhouResource,OndeTrabalhou,Idioma,NivelIdioma,DependenteId,Dependente")] Candidato candidato)
        {
            if (ModelState.IsValid)
            {
                db.Candidato.Add(candidato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidato);
        }

        // GET: Candidatos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidato candidato = db.Candidato.Find(id);
            if (candidato == null)
            {
                return HttpNotFound();
            }
            return View(candidato);
        }

        // POST: Candidatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CandidatoId,AnalistaRH,DataCadastro,Cargo,PretSalarial,FonteRecrutamento,Disponibilidade,NomeCandidato,Sexo,Endereco,DataNascimento,LocalNascimento,EstadoCivil,Raca,Email,Telefone,Celular,RG,DataExpedicao,OrgaoEmissor,CPF,NomeMae,NomePai,PIS,PossuiDependente,QuantDependente,TrabalhouResource,OndeTrabalhou,Idioma,NivelIdioma,DependenteId,Dependente")] Candidato candidato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(candidato);
        }

        // GET: Candidatos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidato candidato = db.Candidato.Find(id);
            if (candidato == null)
            {
                return HttpNotFound();
            }
            return View(candidato);
        }

        // POST: Candidatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Candidato candidato = db.Candidato.Find(id);
            db.Candidato.Remove(candidato);
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
