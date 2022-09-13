using FindE.Data;
using FindE.Features.Empresa.Models;
using Microsoft.EntityFrameworkCore;

namespace FindE.Features.Empresa.Services
{
    public class EmpresaService
    {
        private AppDbContext dbContext;

        public EmpresaService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<EmpresaModel>> ListarEmpresa()
        {
            try
            {
                return await dbContext.Empresa.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmpresaModel>> ListarEmpresa(string filtro)
        {
            try
            {
                var listagem = await dbContext.Empresa.ToListAsync();
                return listagem.Where(e => e.Nome.ToLower().Contains(filtro.ToLower())).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<EmpresaModel>> ListarEmpresa(string filtro)
        {
            try
            {
                return await dbContext.Empresa.Where(e => e.Nome.ToLower().Contains(filtro.ToLower())).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EmpresaModel> InserirEmpresa(EmpresaModel empresa)
        {
            try
            {
                dbContext.Empresa.Add(empresa);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return empresa;
        }

        public async Task<EmpresaModel> AlterarEmpresa(EmpresaModel empresa)
        {
            try
            {
                if (dbContext.Empresa.FirstOrDefault(c => c.Id == empresa.Id) != null)
                {
                    dbContext.Empresa.Update(empresa);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return empresa;
        }

        public async Task ApagarEmpresa(EmpresaModel empresa)
        {
            try
            {
                dbContext.Empresa.Remove(empresa);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EmpresaModel> RetornarEmpresa(int IdEmpresa)
        {
            try
            {
                var empresa = await dbContext.Empresa.Where(c => c.Id == IdEmpresa).ToListAsync();
                return empresa.Single();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
