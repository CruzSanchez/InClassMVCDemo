using WebApplication1.Models;

namespace WebApplication1;

public interface ICategoryRepo
{
    public IEnumerable<Category> GetAllCategories();
}