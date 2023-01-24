using Microsoft.AspNetCore.Hosting;

namespace Project.Services
{
    public class ImageUploadService : IImageUploadService
    {
        public const string UPLOAD_FOLDER = "images\\";

        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;

        public ImageUploadService(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this.environment = environment;
        }
        public async Task<string> UploadFileAsync(IFormFile file)
        {
            var filePath = Path.Combine(
                environment.ContentRootPath, "wwwroot\\" + UPLOAD_FOLDER, file.FileName);
            
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            
            return UPLOAD_FOLDER + file.FileName;
        }
    }
}
