using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace GerenciadorDeProcessosSeletivos.Models
{
    public class ProcessoSeletivo
    {
        [Key]
        public int Id { get; set; }
        public string Cargo { get; set; }
        public List<Candidato> Candidatos { get; set; }
        public List<Fase> Fases { get; set; }
        public Status Status { get; set; }
    }
}