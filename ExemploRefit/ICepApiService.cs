using Refit;
using System.Threading.Tasks;

namespace ExemploRefit
{ // Criamos uma interface para referenciar a rota que estamos chamando
  // A interface é a chamada da API
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        // A interface é uma task do nosso dominio
        Task<CepResponse> GetAddressAsync(string cep);
        // Recebo como parametro uma string que o usuario ira informa
    }
}
