using Newtonsoft.Json;

namespace FindE.Features.ChuckNorris.Models
{
    public class Joke
    {
        [JsonProperty("value")]
        public string Piada { get; set; }
        public string Erro { get; set; }
    }
}
