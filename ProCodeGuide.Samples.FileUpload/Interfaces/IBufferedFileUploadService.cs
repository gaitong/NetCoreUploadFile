using Microsoft.AspNetCore.WebUtilities;

namespace DemoNetCoreUploadFile.Interfaces
{
    public interface IBufferedFileUploadService
    {
        Task<string> UploadFile(IFormFile file);
    }
}
