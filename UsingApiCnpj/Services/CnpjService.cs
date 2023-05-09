/*
    Serviços da API
 */

using AutoMapper;
using UsingApiCnpj.DTO;
using UsingApiCnpj.Interfaces;

namespace UsingApiCnpj.Services
{
    public class CnpjService : ICnpjService
    {
        private readonly IMapper _mapper;
        private readonly IApiCnpj _apiCnpj;

        public CnpjService(IMapper mapper, IApiCnpj cnpjApi) //construtor
        {
            _mapper = mapper;
            _apiCnpj = cnpjApi;
        }

        public async Task<ResponseGeneric<CnpjResponse>> BuscarEmpresaPorCnpj(string cnpj)
        {
            var buscaCnpj = await _apiCnpj.BuscarEmpresaPorCnpj(cnpj);
            return _mapper.Map<ResponseGeneric<CnpjResponse>>(buscaCnpj);
        }
    }
}
