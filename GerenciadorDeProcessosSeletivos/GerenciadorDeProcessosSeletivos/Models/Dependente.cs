using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProcessosSeletivos.Models
{
    public class Dependente
    {
        public int DependenteId { get; set; }
        public TipoDependente TipoDependente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Cpf { get; set; }
        public bool Irrf { get; set; }
    }
}
