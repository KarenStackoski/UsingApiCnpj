/*
    MODELS: propriedades Json, retiradas da api
    são como tabelas e campos de um banco de dados.

    aqui elas serão declaradas para serem usadas no projeto, como uma ponte entre a api e o projeto.
 */

using System.Text.Json.Serialization;

namespace UsingApiCnpj.Models
{
    public partial class CnpjModel
    {
        [JsonPropertyName("atividade_principal")]
        public List<AtividadePrincipalModel>? AtividadePrincipal { get; set; }

        [JsonPropertyName("data_situacao")]
        public string? DataSituacao { get; set; }

        [JsonPropertyName("complemento")]
        public string? Complemento { get; set; }

        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("atividades_secundarias")]
        public List<AtividadesSecundariaModel>? AtividadesSecundarias { get; set; }

        [JsonPropertyName("qsa")]
        public List<QsaModel>? Qsa { get; set; }

        [JsonPropertyName("situacao")]
        public string? Situacao { get; set; }

        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        [JsonPropertyName("numero")]
        public string? Numero { get; set; }

        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("municipio")]
        public string? Municipio { get; set; }

        [JsonPropertyName("uf")]
        public string? Uf { get; set; }

        [JsonPropertyName("porte")]
        public string? Porte { get; set; }

        [JsonPropertyName("abertura")]
        public string? Abertura { get; set; }

        [JsonPropertyName("natureza_juridica")]
        public string? NaturezaJuridica { get; set; }

        [JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        [JsonPropertyName("ultima_atualizacao")]
        public DateTime? UltimaAtualizacao { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("fantasia")]
        public string? Fantasia { get; set; }

        [JsonPropertyName("efr")]
        public string? Efr { get; set; }

        [JsonPropertyName("motivo_situacao")]
        public string? MotivoSituacao { get; set; }

        [JsonPropertyName("situacao_especial")]
        public string? SituacaoEspecial { get; set; }

        [JsonPropertyName("data_situacao_especial")]
        public string? DataSituacaoEspecial { get; set; }

        [JsonPropertyName("capital_social")]
        public string? CapitalSocial { get; set; }

        [JsonPropertyName("billing")]
        public BillingModel? Billing { get; set; }
        
    }
}
