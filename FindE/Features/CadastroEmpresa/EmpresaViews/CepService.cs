using FindE.Features.Cep.Models;
using Newtonsoft.Json;

namespace FindE.Features.Cep.Services
{
    public class CepService
    {
        public Task<Endereco> RetornarEndereco(string cep)
        {
            var endereco = new Endereco();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://viacep.com.br/ws/");

                try
                {
                    var json = client.GetStringAsync($"{cep}/json");
                    endereco = JsonConvert.DeserializeObject<Endereco>(json.Result);
                }
                catch
                {
                    endereco.Erro = true;
                }
            }

            return Task.FromResult(endereco);
        }
    }
}
