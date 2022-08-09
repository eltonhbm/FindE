using FindE.Data;
using FindE.Features.Candidato.Models;
using Microsoft.EntityFrameworkCore;

namespace FindE.Features.Candidato.Services

{
    public class CandidatoService
    {
        private AppDbContext dbContext;
        public class CandidatoServices
        {
            private AppDbContext dbContext;

            public CandidatoServices(AppDbContext dbContext)
            {
                this.dbContext = dbContext;
            }

            public async Task<List<CandidatoModel>> ListarCandidato()
            {
                try
                {
                    return await dbContext.Candidato.ToListAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task<CandidatoModel> InserirCandidato(CandidatoModel candidato)
            {
                try
                {
                    dbContext.Candidato.Add(candidato);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }

                return candidato;
            }

            public async Task<CandidatoModel> AlterarCandidato(CandidatoModel candidato)
            {
                try
                {
                    if (dbContext.Candidato.FirstOrDefault(c => c.Id == candidato.Id) != null)
                    {
                        dbContext.Candidato.Update(candidato);
                        await dbContext.SaveChangesAsync();
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                return candidato;
            }

            public async Task ApagarCandidato(CandidatoModel candidato)
            {
                try
                {
                    dbContext.Candidato.Remove(candidato);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task<CandidatoModel> RetornarCandidato(int IdCandidato)
            {
                try
                {
                    var candidato = await dbContext.Candidato.Where(c => c.Id == IdCandidato).ToListAsync();
                    return candidato.Single();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
