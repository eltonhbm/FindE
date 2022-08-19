using FindE.Data;
using FindE.Features.Vaga.Models;
using Microsoft.EntityFrameworkCore;

namespace FindE.Features.Vaga.Services

{
    public class VagaService
    {
        private AppDbContext dbContext;

        public VagaService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<VagaModel>> ListarVaga()
        {
            try
            {
                return await dbContext.Vaga.Include(e => e.Empresa).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<VagaModel> InserirVaga(VagaModel vaga)
        {
            try
            {
                dbContext.Vaga.Add(vaga);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                vaga.Mensagem = ex.InnerException.Message;
                throw;
            }

            return vaga;
        }

        public async Task<VagaModel> AlterarVaga(VagaModel vaga)
        {
            try
            {
                if (dbContext.Vaga.FirstOrDefault(c => c.Id == vaga.Id) != null)
                {
                    dbContext.Vaga.Update(vaga);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return vaga;
        }

        public async Task ApagarVaga(VagaModel vaga)
        {
            try
            {
                dbContext.Vaga.Remove(vaga);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<VagaModel> RetornarVaga(int IdVaga)
        {
            try
            {
                var vaga = await dbContext.Vaga.Where(c => c.Id == IdVaga).ToListAsync();
                return vaga.Single();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}