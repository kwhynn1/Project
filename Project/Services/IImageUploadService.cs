namespace Project.Services
{
    public interface IImageUploadService
    {
        public Task<string> UploadFileAsync(IFormFile file);
    }
}
