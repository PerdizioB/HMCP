using HandMadeCakes.Dto;
using HandMadeCakes.Models;

namespace HandMadeCakes.Services.Cake
{
    public interface ICakeInterface
    {

        Task<CakeModel> CriarCake(CakeCreateDto CakeCreateDto, IFormFile foto);
        Task<List<CakeModel>> GetCakes();
        Task<CakeModel> GetCakePorId(int id);
        Task<CakeModel> EditarCake(CakeModel Cake, IFormFile? foto);
        Task<CakeModel> RemoverCake(int id);
        Task<List<CakeModel>> GetCakesFiltro(string? pesquisar);
    }
}
