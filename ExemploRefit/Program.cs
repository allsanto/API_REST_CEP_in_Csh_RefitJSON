using Refit;
using System;
using System.Threading.Tasks;

namespace ExemploRefit
{
    class Program
    {
        // public static void Main(string[] args)
        static async Task Main(string[] args) // Usando de forma assincrona
        {
            try // Tratar um retorno de erro
            {
                // Host URL
                // RestService - Gera uma implementação IGitHubApique usa HttpClientpara fazer suas chamadas.
                // .For - Para passar a interface criada e o Host service
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu Cep: ");
                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultado informações do CEP: " + cepInformado);

                //Criar a chamada ao Refit, mais o método criado na interface
                var address = await cepClient.GetAddressAsync(cepInformado);

                Console.Write($"\nLogradouro: {address.Logradouro}\nBairro {address.Bairro}\nCidade: {address.Localidade}");
                Console.ReadKey();
            } catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de Cep: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
