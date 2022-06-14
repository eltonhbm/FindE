using Newtonsoft.Json;

namespace FindE.Features.KenyeWest.Models
{
    public class Citacao
    {
        [JsonProperty("quote")]
        public string Frase { get; set; }
        public string Erro { get; set; }

    }
}
