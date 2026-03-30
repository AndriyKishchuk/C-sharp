using Projekt_10.Models;

namespace Projekt_10
{
    public interface IOrderService
    {
        Task<List<DTOModel>> GetAllAsync();
        Task<DTOModel?> GetByIdAsync(int id);
        Task<DTOModel> CreateAsync(DTOModel order);
        Task<DTOModel?> UpdateAsync(int id, DTOModel order);
        Task<bool> DeleteAsync(int id);
    }
}
