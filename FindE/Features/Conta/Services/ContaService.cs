using FindE.Features.Conta.Models;

namespace FindE.Features.Conta.Services
{
    public class ContaService
    {
        public IEnumerable<ContaModel> RetornarContas()
        {
            var listaDeContas = new List<ContaModel>()
            {
                
                new ContaModel {Id = 1, Usuario = "eltonhbm", Senha = "************", Perfil = PerfilEnum.Empresa },
                new ContaModel {Id = 2, Usuario = "teste", Senha = "************", Perfil = PerfilEnum.Administrador },
                new ContaModel {Id = 3, Usuario = "guifeijon", Senha = "************", Perfil = PerfilEnum.Estagiario },
                new ContaModel {Id = 4, Usuario = "kaueh", Senha = "************", Perfil = PerfilEnum.Estagiario },
                new ContaModel {Id = 5, Usuario = "kaique-pacheco", Senha = "************", Perfil = PerfilEnum.Empresa },
                new ContaModel {Id = 6, Usuario = "jonjon", Senha = "************", Perfil = PerfilEnum.Estagiario },
                new ContaModel {Id = 7, Usuario = "geovani33", Senha = "************", Perfil = PerfilEnum.Administrador },
                new ContaModel {Id = 8, Usuario = "dudasnovinha", Senha = "************", Perfil = PerfilEnum.Estagiario },
                new ContaModel {Id = 9, Usuario = "rodrigo_876", Senha = "************", Perfil = PerfilEnum.Empresa },
                new ContaModel {Id = 10, Usuario = "celia79", Senha = "************", Perfil = PerfilEnum.Administrador },
                new ContaModel {Id = 11, Usuario = "matheus-ceara", Senha = "************", Perfil = PerfilEnum.Empresa },
                new ContaModel {Id = 12, Usuario = "leticia13", Senha = "************", Perfil = PerfilEnum.Estagiario }
            };

            return listaDeContas;
        }
    }
}
