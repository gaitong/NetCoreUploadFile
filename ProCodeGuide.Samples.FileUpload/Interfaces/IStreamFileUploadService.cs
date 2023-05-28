using Microsoft.AspNetCore.WebUtilities;

namespace DemoNetCoreUploadFile.Interfaces
{
    public interface IStreamFileUploadService
    {
        Task<bool> UploadFile(MultipartReader reader, MultipartSection section);
    }
}
