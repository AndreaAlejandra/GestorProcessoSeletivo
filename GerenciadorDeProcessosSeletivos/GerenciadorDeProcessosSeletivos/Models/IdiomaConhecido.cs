﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProcessosSeletivos.Models
{
    public class IdiomaConhecido
    {
        public int IdiomaConhecidoId { get; set; }
        public TipoIdioma Tipo { get; set; }
        public NivelIdioma Nivel { get; set; }

    }
}