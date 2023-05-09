/*
    Response Generic é onde tera a resposta da api da consulta.

    T -> tipo de dados que é retornado na resposta
 */

using System.Dynamic;
using System.Net;

/*
    Todas as respostas genéricas do Http estarão aqui

     a dto serve como uma proteção para a camada mais interna, tendo apenas o que for necessário para a tranferencua de informações
 */

namespace UsingApiCnpj.DTO
{
    public class ResponseGeneric<T> where T : class
    {
        //retorna o código http da resposta
        public HttpStatusCode? HttpStatusCode { get; set; }
        //retorna os dados
        public T? ReturnData { get; set; }
        //retorna o erro
        public ExpandoObject? ReturnError { get; set; }
    }
}
