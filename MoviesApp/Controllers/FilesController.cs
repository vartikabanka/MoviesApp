using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

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
                var fileName = Path.GetFileName(file.FileName);
                var lastPart = fileName.Split('.').Where(x => !string.IsNullOrWhiteSpace(x)).LastOrDefault();
                if ((file.Length < 1048576) && ((String.Equals(lastPart,"pdf"))||(String.Equals(lastPart,"docx"))))
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "Files", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    ViewBag.fn = fileName.ToString();
                }
                else {
                    ViewBag.Message = "Allowed file size is upto 1 MB and allowed fily types are docx or pdf!";
                    return View();
                }

            }
            return View();
        }

    }
}
