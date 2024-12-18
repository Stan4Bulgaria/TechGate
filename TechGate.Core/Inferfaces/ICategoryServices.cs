using TechGate.Core.Models;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Core.Inferfaces
{
    public interface ICategoryServices
    {
        Task<IEnumerable<CategoryViewModel>> GetAllCategoriesAsync();
        Task<CategoryViewModel?> GetCategoryByIdAsync(int id);
        Task<int> AddCategoryAsync(AddCategoryFormViewModel model);
        Task<bool> UpdateCategoryAsync(int id, AddCategoryFormViewModel model);
        Task<bool> DeleteCategoryAsync(int id);
    }
}
