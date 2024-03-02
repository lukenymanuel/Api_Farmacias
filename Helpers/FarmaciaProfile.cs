using Api_Farmacias.Model;
using AutoMapper;

namespace Api_Farmacias.Helpers
{
    public class FarmaciaProfile : Profile
    {
        public FarmaciaProfile()
        {
            CreateMap<Farmacia,FarmaciaDTO>();// aqui ja faz todo o mapeamento, sem ter de instaniar em cada metodo
            //aqui ele tira os dado da farmacia e mapeia direto para o farmaciaDTO
            CreateMap<FarmaciaDTO,Farmacia>();
        }
        
    }
}