using Newtonsoft.Json;
using FindE.Features.KenyeWest.Models;

namespace FindE.Features.KenyeWest.Services
{
    public class CitacaoService
    {
        public Task<Citacao> BuscarCitacao()
        {
            var citacao = new Citacao();

            using (var client = new HttpClient())
            { 
                try
                {
                    var json = client.GetStringAsync("https://api.kanye.rest/");
                    citacao = JsonConvert.DeserializeObject<Citacao>(json.Result);
                }
                catch (Exception ex)
                {
                    citacao.Erro = ex.Message;
                }
            }

            return Task.FromResult(citacao);
        }
    }
}
