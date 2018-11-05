using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDeProcessosSeletivos.Controllers
{
    public class EtapasController : Controller
    {
        // GET: Etapas
        public ActionResult Index()
        {
            var Etapas = new EtapasController();

            return View(Etapas);
        }
    }
}