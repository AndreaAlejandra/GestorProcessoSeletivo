using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProcessosSeletivos.Models
{
    public class Fase1
    {
        public List<Etapa> Etapas { get; set; }
        public List<Candidato> Candidatos { get; set; }

    }
}