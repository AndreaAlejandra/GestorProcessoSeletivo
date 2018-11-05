using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDeProcessosSeletivos.Controllers
{
    public class ResultadoCandidatoController : Controller
    {
        // GET: ResultadoCandidato
        public ActionResult Index()
        {
            var resultadoCandidato = new ResultadoCandidatoController();

            return View(resultadoCandidato);
        }
    }
}