using Microsoft.AspNetCore.Mvc;

namespace DemoNetCoreUploadFile.Services
{
    public class FileManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
