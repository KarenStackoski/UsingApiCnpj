/*
    MODELS: propriedades Json, retiradas da api
    são como tabelas e campos de um banco de dados.

    aqui elas serão declaradas para serem usadas no projeto, como uma ponte entre a api e o projeto.
 */

using System.Text.Json.Serialization;

namespace UsingApiCnpj.Models
{
    public class QsaModel
    {
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("qual")]
        public string? Qual { get; set; }

        [JsonPropertyName("nome_rep_legal")]
        public string? NomeRepLegal { get; set; }

        [JsonPropertyName("qual_rep_legal")]
        public string? QualRepLegal { get; set; }
    }
    
}
