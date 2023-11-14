using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesPageModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public void OnGet()
        {
            for (int i = 0; i <= 100; i++)
            {
                Categories.Add(new Category(i, $"Item {i}", i * 18.95M));
            }
        }
    }
}

public record Category(int Id, string Title, decimal Price);
