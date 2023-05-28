using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using DemoNetCoreUploadFile.Interfaces;
using System.IO;

namespace DemoNetCoreUploadFile.Services
{
    public class BufferedFileUploadLocalService : IBufferedFileUploadService
    {
        public async Task<string> UploadFile(IFormFile file)
        {
            string path = "";
            try
            {
                if (file.Length > 0)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    string[] dirs = Directory.GetFiles(path);
                    var filesName = new List<string>();

                    foreach (var item in dirs)
                    {
                        var fName = Path.GetFileName(item);
                        filesName.Add(fName);
                    }

                    using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);

                        var isReplace = filesName.FirstOrDefault(m => m == file.FileName);

                        if(isReplace != null)
                        {
                            return "Replace File Upload Successful";
                        }
                        else
                        {
                            return "File Upload Successful";
                        }
                    }
                }
                else
                {
                    return "File Upload Successful";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
    }
}