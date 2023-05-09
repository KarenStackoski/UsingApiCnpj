using AutoMapper;
using UsingApiCnpj.DTO;
using UsingApiCnpj.Models;

namespace UsingApiCnpj.Mappings
{
    public class CnpjMapping : Profile
    {
        public CnpjMapping() //construtor do mapper
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<CnpjResponse, CnpjModel>();
            CreateMap<CnpjModel, CnpjResponse>();
        }
    }
}
