using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDeProcessosSeletivos.Controllers
{
    public class Fase2 : Controller
    {
        // GET: Fase2
        public ActionResult Index()
        {
            var Fase2 = new Fase2();

            return View(Fase2);
        }
    }
}