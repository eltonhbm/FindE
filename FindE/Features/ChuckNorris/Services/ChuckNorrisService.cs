using FindE.Features.ChuckNorris.Models;
using Newtonsoft.Json;

namespace FindE.Features.ChuckNorris.Services
{
    public class ChuckNorrisService
    {
        public Task<Joke> RetornarPiada()
        {
            var joke = new Joke();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://api.chucknorris.io/");

                try
                {
                    var json = client.GetStringAsync("jokes/random");
                    joke = JsonConvert.DeserializeObject<Joke>(json.Result);
                }
                catch (Exception ex)
                {
                    joke.Erro = ex.Message;
                }
            }

            return Task.FromResult(joke);
        }
    }
}
