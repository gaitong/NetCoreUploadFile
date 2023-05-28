using DemoNetCoreUploadFile.Interfaces;

namespace DemoNetCoreUploadFile.Services
{
    public class FileManagementService : IFileManagementService
    {
        private string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
        public IEnumerable<string> GetAllFile()
        {
            string[] dirs = Directory.GetFiles(path);

            var filesName = new List<string>();

            foreach(var item in dirs)
            {
                var fName = Path.GetFileName(item);
                filesName.Add(fName);
            }

            return filesName;
        }

        public byte[] DownloadFile(string filename)
        {
            var pathfile = Path.Combine(path, filename);
            byte[] fileBytes = System.IO.File.ReadAllBytes(pathfile);
            return fileBytes;
        }
        public void DeleteFile(string filename)
        {
            File.Delete(Path.Combine(path, filename));
        }
    }
}
