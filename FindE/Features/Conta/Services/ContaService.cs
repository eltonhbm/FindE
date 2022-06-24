using FindE.Data;
using FindE.Features.Conta.Models;
using Microsoft.EntityFrameworkCore;

namespace FindE.Features.Conta.Services
{
    public class ContaService
    {
        private AppDbContext dbContext;

        public ContaService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<ContaModel>> ListarContas()
        {
            return await dbContext.Conta.ToListAsync();
        }

        public async Task<ContaModel> InserirConta(ContaModel conta)
        {
            try
            {
                dbContext.Conta.Add(conta);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return conta;
        }

        public async Task<ContaModel> AlterarConta(ContaModel conta)
        {
            try
            {
                if (dbContext.Conta.FirstOrDefault(c => c.Id == conta.Id) != null)
                {
                    dbContext.Conta.Update(conta);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return conta;
        }

        public async Task ApagarConta(ContaModel conta)
        {
            try
            {
                dbContext.Conta.Remove(conta);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ContaModel> RetornarConta(int IdConta)
        {
            var conta = await dbContext.Conta.Where(c => c.Id == IdConta).ToListAsync();
            return conta.Single();
        }
    }
}
