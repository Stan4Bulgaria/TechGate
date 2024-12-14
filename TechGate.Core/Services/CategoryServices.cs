using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGate.Core.Inferfaces;
using TechGate.Core.Models;
using TechGate.Data;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Core.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly TechGateDbContext _context;
        public CategoryServices(TechGateDbContext context)
        {
            _context = context;
        }

        public Task<int> AddCategoryAsync(AddCategoryFormViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryViewModel>> GetAllCategoriesAsync()
        {
            var categories = await _context.Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
            return categories;
        }

        public Task<CategoryViewModel?> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(int id, AddCategoryFormViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
