using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProcessosSeletivos.Models
{
    public class Etapa
    {
        public TipoEtapa Tipo { get; set; }
        public List<ResultadoEtapa> ResultadosEtapa { get; set;}


    }
}