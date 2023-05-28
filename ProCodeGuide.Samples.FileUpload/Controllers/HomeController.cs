using Microsoft.AspNetCore.Mvc;
using DemoNetCoreUploadFile.Models;
using System.Diagnostics;
using DemoNetCoreUploadFile.Interfaces;

namespace DemoNetCoreUploadFile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFileManagementService _fileManagementService;

        public HomeController(ILogger<HomeController> logger,
            IFileManagementService fileManagementService)
        {
            _logger = logger;
            _fileManagementService = fileManagementService;
        }

        public IActionResult Index()
        {
            var files = _fileManagementService.GetAllFile();
            return View(files);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}