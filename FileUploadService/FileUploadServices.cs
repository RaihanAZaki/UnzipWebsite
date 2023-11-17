namespace TesterZip.FileUploadServices
{
    public class FileUploadService : IFileUploadService
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;
        public FileUploadService(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this.environment = environment;
        }
        public async Task<string> UploadFileAsync(IFormFile file)
        {
            var filePath = Path.Combine(environment.ContentRootPath, @"wwwroot\zip", file.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return filePath;


        }
    }
}
