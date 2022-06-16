using Newtonsoft.Json;

namespace FindE.Features.Cep.Models
{
    public class Endereco
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("ddd")]
        public string Ddd { get; set; }
        [JsonProperty("erro")]
        public bool Erro { get; set; }
    }
}
