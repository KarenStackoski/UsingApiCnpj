/*
    REST -> chamadas para a api
 */

using System.Dynamic;
using System.Text.Json;
using UsingApiCnpj.DTO;
using UsingApiCnpj.Interfaces;
using UsingApiCnpj.Models;

namespace UsingApiCnpj.Rest
{
    public class ApiCnpjRest : IApiCnpj
    {
        public async Task<ResponseGeneric<CnpjModel>> BuscarEmpresaPorCnpj(string cnpj)
        {
            //requisição da empresa
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://receitaws.com.br/v1/cnpj/{cnpj}");

            var response = new ResponseGeneric<CnpjModel>();
            using (var client = new HttpClient()) 
            {
                var responseCnpjApi = await client.SendAsync(request); //ponto exato onde será feita a requisição
                var contentResponse = await responseCnpjApi.Content.ReadAsStringAsync(); //conteúdo da resposta
                var objectResponse = JsonSerializer.Deserialize<CnpjModel>(contentResponse);

                if (responseCnpjApi.IsSuccessStatusCode)
                {
                    response.HttpStatusCode = responseCnpjApi.StatusCode;
                    response.ReturnData = objectResponse;
                }
                else
                {
                    response.HttpStatusCode = responseCnpjApi.StatusCode;
                    response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
                return response;
            }
        }
    }
}
