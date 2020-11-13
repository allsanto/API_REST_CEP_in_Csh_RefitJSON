using Newtonsoft.Json;

namespace ExemploRefit
{
    public class CepResponse
    {
        [JsonProperty("cep")] // Para referenciar o cep maiusculo
        public string Cep { get; set; }
        [JsonProperty("logradouro")] // Para referenciar o logradouro maiusculo
        public string Logradouro { get; set; }
        [JsonProperty("complemento")] // Para referenciar o complemento maiusculo
        public string Complemento { get; set; }
        [JsonProperty("bairro")] // Para referenciar o bairro maiusculo
        public string Bairro { get; set; }
        [JsonProperty("localidade")] // Para referenciar o localidade maiusculo
        public string Localidade { get; set; }
        [JsonProperty("uf")] // Para referenciar o uf maiusculo
        public string Uf { get; set; }
        [JsonProperty("unidade")] // Para referenciar o unidade maiusculo
        public string Unidade { get; set; }
        [JsonProperty("ibge")] // Para referenciar o ibge maiusculo
        public string Ibge { get; set; }
        [JsonProperty("gia")] // Para referenciar o gia maiusculo
        public string Gia { get; set; }
    }
}
