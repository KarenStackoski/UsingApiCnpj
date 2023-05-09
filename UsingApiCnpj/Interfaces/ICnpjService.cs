using UsingApiCnpj.DTO;
using UsingApiCnpj.Models;

namespace UsingApiCnpj.Interfaces
{
    public interface ICnpjService
    {
        Task<ResponseGeneric<CnpjResponse>> BuscarEmpresaPorCnpj(string cnpj);
    }
}
