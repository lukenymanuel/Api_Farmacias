using Api_farmacias.Model;
using Api_Farmacias.Model;

namespace Api_Farmancias.Repositorio.InterFace
{
    public interface IFarmaciaRepisitory
    {
         Task<List<Farmacia>> Farmancias();
         Task<Farmacia> BuscarFarmacia(int id);
        Task<Farmacia> AdicionarFarmacia(Farmacia farmancia);
        Task <Farmacia> Atualizar(Farmacia farmancia);
         Task<bool> Apagar(int id);
         Task<bool> SaveAllAsync();
    }
}