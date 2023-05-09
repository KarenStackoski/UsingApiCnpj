using UsingApiCnpj.DTO;
using UsingApiCnpj.Models;

namespace UsingApiCnpj.Interfaces
{
    public interface IApiCnpj
    {
        Task<ResponseGeneric<CnpjModel>> BuscarEmpresaPorCnpj(string cnpj);
    }
}
