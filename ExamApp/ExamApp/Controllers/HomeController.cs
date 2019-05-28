using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamApp.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ExamApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        private IHostingEnvironment _appEnvironment;
        public HomeController(ApplicationDbContext context, IHostingEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }

        public IActionResult BrowseFile(int id)
        {
            var file = db.Files.Single(r => r.Id == id);
            return View(file);
        }

        public IActionResult BrowseFiles()
        {
            return View(db.Files.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(NonDbFile loadedFile)
        {
            if (loadedFile.UploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + loadedFile.Name + Path.GetExtension(loadedFile.UploadedFile.FileName);
                if (db.Files.Where(r => r.Name == loadedFile.Name).Count() != 0) return RedirectToAction("BrowseFiles", "Home");
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await loadedFile.UploadedFile.CopyToAsync(fileStream);
                }
                UploadedFile file = new UploadedFile
                {
                    Name = loadedFile.Name,
                    Path = path,
                    Description = loadedFile.Description,
                    Text = loadedFile.Text,
                    ContentType = loadedFile.UploadedFile.ContentType,
                    AmountOfDownloads = 0
                };
                if(loadedFile.hasPass&&loadedFile.password!=null)
                {
                    file.hasPass = true;
                    file.password = loadedFile.password;
                }
                db.Files.Add(file);
                db.SaveChanges();
            }
            return RedirectToAction("BrowseFiles", "Home");
        }

        public async Task<IActionResult> Download(int id,string password)
        {
            var file = db.Files.Single(r => r.Id == id);
            if(file.hasPass==true)
            {
                if (file.password != password) return RedirectToAction("BrowseFiles", "Home", new { id });
            }
            var memory = new MemoryStream();
            using (var stream = new FileStream(_appEnvironment.WebRootPath + file.Path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            db.Files.Single(r => r.Id == id).AmountOfDownloads++;
            db.SaveChanges();
            return File(memory, file.ContentType, Path.GetFileName(_appEnvironment.WebRootPath + file.Path));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
