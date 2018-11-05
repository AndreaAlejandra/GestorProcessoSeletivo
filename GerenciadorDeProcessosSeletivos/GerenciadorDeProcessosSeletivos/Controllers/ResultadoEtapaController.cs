using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDeProcessosSeletivos.Controllers
{
    public class ResultadoEtapaController : Controller
    {
        // GET: ResultadoEtapa
        public ActionResult Index()
        {
            var ResultadoEtapas = new ResultadoEtapaController();

            return View(ResultadoEtapas);
        }
    }
}