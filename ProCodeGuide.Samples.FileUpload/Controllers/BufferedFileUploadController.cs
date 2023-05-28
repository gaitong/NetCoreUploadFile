using Microsoft.AspNetCore.Mvc;
using DemoNetCoreUploadFile.Interfaces;

namespace DemoNetCoreUploadFile.Controllers
{
    public class BufferedFileUploadController : Controller
    {
        readonly IBufferedFileUploadService _bufferedFileUploadService;

        public BufferedFileUploadController(IBufferedFileUploadService bufferedFileUploadService)
        {
            _bufferedFileUploadService = bufferedFileUploadService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(IFormFile file)
        {
            try
            {
                var res = await _bufferedFileUploadService.UploadFile(file);
                    ViewBag.Message = res;
            }
            catch (Exception ex)
            {
                //Log ex
                ViewBag.Message = "File Upload Failed";
            }
            return View();
        }
    }
}
