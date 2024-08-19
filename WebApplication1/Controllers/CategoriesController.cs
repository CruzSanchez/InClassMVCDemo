using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class CategoriesController : Controller
{
    private readonly ICategoryRepo _categoryRepo;

    public CategoriesController(ICategoryRepo categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }
    
    // GET
    public IActionResult Index()
    {
        var categories = _categoryRepo.GetAllCategories();
        
        return View(categories);
    }
}