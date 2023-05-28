using DemoNetCoreUploadFile.Interfaces;

namespace DemoNetCoreUploadFile.Services
{
    public class FileManagementService : IFileManagementService
    {
        public IEnumerable<string> GetAllFile()
        {
            var path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));

            string[] dirs = Directory.GetFiles(path);

            var filesName = new List<string>();

            foreach(var item in dirs)
            {
                var fName = Path.GetFileName(item);
                filesName.Add(fName);
            }

            return filesName;
        }
    }
}
