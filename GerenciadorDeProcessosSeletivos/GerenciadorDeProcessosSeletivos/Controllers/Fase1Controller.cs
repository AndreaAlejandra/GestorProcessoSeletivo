using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDeProcessosSeletivos.Controllers
{
    public class Fase1Controller : Controller
    {
        // GET: Fase1
        public ActionResult Index()
        {
            var fase1 = new Fase1Controller();

            return View(fase1);
        }
    }
}