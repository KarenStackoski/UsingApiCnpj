/*
    MODELS: propriedades Json, retiradas da api
    são como tabelas e campos de um banco de dados.

    aqui elas serão declaradas para serem usadas no projeto, como uma ponte entre a api e o projeto.
 */

using System.Text.Json.Serialization;

namespace UsingApiCnpj.Models
{
    public class BillingModel
    {
        [JsonPropertyName("free")]
        public bool? Free { get; set; }

        [JsonPropertyName("database")]
        public bool? Database { get; set; }
    }   
}
