using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDeProcessosSeletivos.Controllers
{
    public class ProcessoSeletivoController : Controller
    {
        // GET: ProcessoSeletivo
        public ActionResult Index()
        {
            var ProcessoSeletivo = new ProcessoSeletivoController();

            return View(ProcessoSeletivo);
        }
    }
}