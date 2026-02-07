using MiniShop6.Data;

namespace MiniShop6.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category obj);
        Task<Category> UpdateAsync(Category obj);
        Task<bool> DeleteAsync(int id);
        Task<Category> GetAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
