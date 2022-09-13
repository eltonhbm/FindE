using FindE.Data;
using FindE.Features.Estagiario.Models;
using Microsoft.EntityFrameworkCore;

namespace FindE.Features.Estagiario.Services;

public class EstagiarioService
{
    private AppDbContext dbContext;

    public EstagiarioService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<EstagiarioModel>> ListarEstagiarios()
    {
        try
        {
            return await dbContext.Estagiario.ToListAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }


    public async Task<List<EstagiarioModel>> ListarEstagiarios(string filtro)
    {
        try
        {
            var listagem = await dbContext.Estagiario.ToListAsync();

            return listagem.Where(e => e.Nome.ToLower().Contains(filtro.ToLower())).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<EstagiarioModel> InserirEstagiario(EstagiarioModel estagiario)
    {
        try
        {
            dbContext.Estagiario.Add(estagiario);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }

        return estagiario;
    }

    public async Task<EstagiarioModel> AlterarEstagiario(EstagiarioModel estagiario)
    {
        try
        {
            if (dbContext.Estagiario.FirstOrDefault(c => c.Id == estagiario.Id) != null)
            {
                dbContext.Estagiario.Update(estagiario);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }

        return estagiario;
    }

    public async Task ApagarEstagiario(EstagiarioModel estagiario)
    {
        try
        {
            dbContext.Estagiario.Remove(estagiario);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<EstagiarioModel> RetornarEstagiario(int IdEstagiario)
    {
        try
        {
            var estagiarios = await dbContext.Estagiario.Where(c => c.Id == IdEstagiario).ToListAsync();
            return estagiarios.Single();
        }
        catch (Exception)
        {
            throw;
        }
    }
}