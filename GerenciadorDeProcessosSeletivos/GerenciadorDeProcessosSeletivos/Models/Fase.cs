using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProcessosSeletivos.Models
{
    public class Fase
    {
        public int FaseId { get; set; }
        public TipoFase TipoFase { get; set; }
        public List<Etapa> Etapas { get; set; }
        public List<Candidato> CandidatosParticipantes { get; set; }
        public Status Status { get; set; }
    }
}