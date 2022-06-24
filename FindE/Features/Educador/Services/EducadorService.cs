using FindE.Data;
using FindE.Features.Educador.Models;
using Microsoft.EntityFrameworkCore;

namespace FindE.Features.Educador.Services
{
    public class EducadorService
    {
        private AppDbContext dbContext;

        public EducadorService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<EducadorModel>> ListarEducadores()
        {
            try
            {
                return await dbContext.Educador.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EducadorModel> InserirEducador(EducadorModel educador)
        {
            try
            {
                dbContext.Educador.Add(educador);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return educador;
        }

        public async Task<EducadorModel> AlterarEducador(EducadorModel educador)
        {
            try
            {
                if (dbContext.Educador.FirstOrDefault(c => c.Id == educador.Id) != null)
                {
                    dbContext.Educador.Update(educador);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return educador;
        }

        public async Task ApagarEducador(EducadorModel educador)
        {
            try
            {
                dbContext.Educador.Remove(educador);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EducadorModel> RetornarEducador(int IdEducador)
        {
            try
            {
                var conta = await dbContext.Educador.Where(c => c.Id == IdEducador).ToListAsync();
                return conta.Single();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
