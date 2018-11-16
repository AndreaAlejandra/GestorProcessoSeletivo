﻿using GerenciadorDeProcessosSeletivos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GerenciadorDeProcessosSeletivos.Context
{
    public class PSeletivoContext : DbContext
    {
        public PSeletivoContext() : base("PSeletivoContext")
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<ProcessoSeletivo> ProcessoSeletivo { get; set; }
        public DbSet<Fase> Fase{ get; set; }
        public DbSet<Etapa> Etapa { get; set; }
        public DbSet<NotaCandidato> NotaCandidato { get; set; }

        public System.Data.Entity.DbSet<GerenciadorDeProcessosSeletivos.Models.Dependente> Dependentes { get; set; }

        public System.Data.Entity.DbSet<GerenciadorDeProcessosSeletivos.Models.IdiomaConhecido> IdiomaConhecidoes { get; set; }
    }
}