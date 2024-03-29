﻿using FindE.Features.Estagiario.Models;
using FindE.Features.Conta.Models;
using FindE.Features.Educador.Models;
using FindE.Features.Empresa.Models;
using FindE.Features.Candidato.Models;
using FindE.Features.Vaga.Models;
using FindE.Features.Conta.Services;
using Microsoft.EntityFrameworkCore;

namespace FindE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<ContaModel> Conta { get; set; }
        public DbSet<EducadorModel> Educador { get; set; }
        public DbSet<EstagiarioModel> Estagiario { get; set; }
        public DbSet<EmpresaModel> Empresa { get; set; }
        public DbSet<CandidatoModel> Candidato { get; set; }
        public DbSet<VagaModel> Vaga { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContaModel>().HasData(DadosIniciais());
            base.OnModelCreating(modelBuilder);
        }

        private List<ContaModel> DadosIniciais()
            => new() { new ContaModel { Id = 1, Usuario = "sistema",
                Senha = sha256Service.CalcularHashSha256("pTech017Sbr"),
                Perfil = PerfilEnum.Administrador } };
    }
}
