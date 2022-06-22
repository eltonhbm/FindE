using FindE.Features.Conta.Models;
using FindE.Features.Conta.Services;
using Microsoft.EntityFrameworkCore;

namespace FindE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<ContaModel> Conta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContaModel>().HasData(ListarContas());
            base.OnModelCreating(modelBuilder);
        }

        private List<ContaModel> ListarContas()
        {
            var listaDeContas = new List<ContaModel>()
            {

                new ContaModel {Id = 1, Usuario = "sistema", Senha = sha256Service.CalcularHashSha256("pTech017Sbr"), Perfil = PerfilEnum.Administrador }
            };

            return listaDeContas;
        }
    }
}
