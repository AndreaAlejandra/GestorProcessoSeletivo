using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProcessosSeletivos.Models
{
    public class NotaCandidato
    {
        public int NotaCandidatoId { get; set; }
        public float Nota { get; set; }
        public Candidato Candidato { get; set; }
    }
}