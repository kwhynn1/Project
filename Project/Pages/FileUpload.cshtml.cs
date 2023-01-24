using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Services;

namespace Project.Pages
{
    public class FileUploadModel : PageModel
    {
        public string filePath;
        public string fileName;

        private readonly IImageUploadService imageUploadService;

        public FileUploadModel(IImageUploadService imageUploadService)
        {
            this.imageUploadService = imageUploadService;
        }

        public void OnGet()
        {
        }

        public async void OnPost(IFormFile file)
        {
            if (file != null)
            {
                filePath = await imageUploadService.UploadFileAsync(file);

            }
        }
    }
}
