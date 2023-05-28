using DemoNetCoreUploadFile.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoNetCoreUploadFile.Controllers
{
    public class FileManagementController : Controller
    {
        private readonly IFileManagementService _fileManagementService;

        public FileManagementController(IFileManagementService fileManagementService)
        {
            _fileManagementService = fileManagementService;
        }

        public IActionResult DownloadFile(string filename)
        {
            var byteArr = _fileManagementService.DownloadFile(filename);

            return File(byteArr, System.Net.Mime.MediaTypeNames.Application.Octet, filename);
        }

        public IActionResult DeleteFile(string filename)
        {
            _fileManagementService.DeleteFile(filename);

            return RedirectToAction("index", "home");
        }
    }
}
