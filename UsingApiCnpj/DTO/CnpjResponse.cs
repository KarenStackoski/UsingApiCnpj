/*
    Resposta em relação a API
 */

using System.Text.Json.Serialization;
using UsingApiCnpj.Models;

namespace UsingApiCnpj.DTO
{
    public class CnpjResponse
    {  
       
        public List<AtividadePrincipalModel>? AtividadePrincipal { get; set; }
        public string? DataSituacao { get; set; }
        public string? Complemento { get; set; }
        public string? Tipo { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public List<AtividadesSecundariaModel>? AtividadesSecundarias { get; set; }
        [JsonIgnore]
        public List<QsaModel>? Qsa { get; set; }
        public string? Situacao { get; set; }
        public string? Bairro { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Cep { get; set; }
        public string? Municipio { get; set; }
        public string? Uf { get; set; }
        public string? Porte { get; set; }
        public string? Abertura { get; set; }
        public string? NaturezaJuridica { get; set; }
        public string? Cnpj { get; set; }
        public DateTime? UltimaAtualizacao { get; set; }
        public string? Status { get; set; }
        public string? Fantasia { get; set; }
        public string? Efr { get; set; }
        public string? MotivoSituacao { get; set; }
        public string? SituacaoEspecial { get; set; }
        public string? DataSituacaoEspecial { get; set; }
        public string? CapitalSocial { get; set; }
        [JsonIgnore]
        public BillingModel? Billing { get; set; }
    }
    
}
