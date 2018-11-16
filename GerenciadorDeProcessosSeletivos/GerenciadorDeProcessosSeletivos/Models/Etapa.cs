using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProcessosSeletivos.Models
{
    public class Etapa
    {
        public int EtapaId { get; set; }
        public TipoEtapa Tipo { get; set; }
        public List<NotaCandidato> NotasCandidato { get; set;}
    }
}