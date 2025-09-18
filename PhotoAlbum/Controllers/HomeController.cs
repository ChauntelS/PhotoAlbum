using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhotoAlbum.Models;

namespace PhotoAlbum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Create a list of photos

            List<Photo> photoList = new List<Photo>();

            Photo photo1 = new Photo();
            photo1.Id = 1;
            photo1.Title = "Penny";
            photo1.Description = "My dog Penny";
            photo1.FileName = "penny.jpg";
            photo1.Creation = new DateTime(2025,09,18, 13,51,00);

            Photo photo2 = new Photo();
            photo2.Id = 2;
            photo2.Title = "Ozzy";
            photo2.Description = "My cat Ozzy";
            photo2.FileName = "Ozzy.jpg";
            photo2.Creation = DateTime.Now;

            photoList.Add(photo1);
            photoList.Add(photo2);

            _logger.Log(LogLevel.Information,"Number of Photos: " + photoList.Count);

            //Pass the list of photos to the view

            return View(photoList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Hello()
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
