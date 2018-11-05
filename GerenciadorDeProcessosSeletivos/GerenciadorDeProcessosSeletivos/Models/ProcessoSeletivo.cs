using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GerenciadorDeProcessosSeletivos.Models
{
    public class ProcessoSeletivo
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public List<Candidato> Candidatos { get; set; }
        //public List<Fase1> Fases1 { get; set; }
        //public List<Fase2> Fases2 { get; set; }

    }
}