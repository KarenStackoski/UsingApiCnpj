/*
    MODELS: propriedades Json, retiradas da api
    são como tabelas e campos de um banco de dados.

    aqui elas serão declaradas para serem usadas no projeto, como uma ponte entre a api e o projeto.
 */

using System.Text.Json.Serialization;

namespace UsingApiCnpj.Models
{
    public class AtividadePrincipalModel
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
