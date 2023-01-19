using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Data;
using Project.Models;
using Project.Services;

namespace Project.Pages.Products
{
    public class CreateModel : PageModel
    {
        //public string filePath;
        //public string fileName;

        //private readonly IImageUploadService imageUploadService;

        private readonly ProjectContext _context;

        public CreateModel(ProjectContext context)
        {
            _context = context;
            //this.imageUploadService = imageUploadService;
           
        }

        public IActionResult OnGet()
        {
            //fileName = file.FileName;
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {


          if (!ModelState.IsValid)
            {
                return Page();
            }

            //if (file != null)
            //{
            //    filePath = await imageUploadService.UploadFileAsync(file);

            //}
      
            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
