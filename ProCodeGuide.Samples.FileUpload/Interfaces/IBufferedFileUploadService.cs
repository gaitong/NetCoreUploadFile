using Microsoft.AspNetCore.WebUtilities;

namespace DemoNetCoreUploadFile.Interfaces
{
    public interface IBufferedFileUploadService
    {
        Task<bool> UploadFile(IFormFile file);
    }
}
