using System.Data;
using WebApplication1.Models;
using Dapper;


namespace WebApplication1;

public class CategoryRepo : ICategoryRepo
{
    private readonly IDbConnection _connection;

    public CategoryRepo(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public IEnumerable<Category> GetAllCategories()
    {
        return _connection.Query<Category>("SELECT * FROM Categories").ToList();
        
        // *** Alternative way ***
        // var categories = _connection.Query<Category>("SELECT * FROM Categories");
        // return categories;
    }
}