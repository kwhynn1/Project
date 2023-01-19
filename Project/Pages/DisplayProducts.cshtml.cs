using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Pages
{
    public class DisplayProductsModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public DisplayProductsModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }

}

