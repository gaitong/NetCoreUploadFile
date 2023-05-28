namespace DemoNetCoreUploadFile.Interfaces
{
    public interface IFileManagementService
    {
        IEnumerable<string> GetAllFile();
        void DeleteFile(string filename);
        byte[] DownloadFile(string filename);
    }
}
