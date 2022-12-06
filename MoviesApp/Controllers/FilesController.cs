using Microsoft.AspNetCore.Mvc;

namespace MoviesApp.Controllers
{
    public class FilesController : Controller
    {
        [HttpGet]
        public IActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            if (file == null)
            {
                ViewBag.Message = "Please select a file to upload!";
                return View();
            }
            else
            {
                
                var fileName=Path.GetFileName(file.FileName);
                var path=Path.Combine(Directory.GetCurrentDirectory(),"Files", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                   file.CopyTo(fileStream);
                }

                
                ViewBag.fn = path.ToString();
            }
            return View();
        }

    }
}
