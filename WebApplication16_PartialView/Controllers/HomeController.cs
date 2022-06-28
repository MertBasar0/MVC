using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication16_PartialView.Models;

namespace WebApplication16_PartialView.Controllers
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
            var sliders = new List<SliderVM>();
            sliders.Add(new SliderVM { Name = "Slider-1", Url = "slider-1.jpg" });
            sliders.Add(new SliderVM { Name = "Slider-2", Url = "slider-2.jpg" });
            sliders.Add(new SliderVM { Name = "Slider-3", Url = "slider-3.jpg" });

            return View(sliders);
        }

        public IActionResult Privacy()
        {
            var sliders = new List<SliderVM>();
            sliders.Add(new SliderVM { Name = "Slider-1", Url = "slider-1.jpg" });
            sliders.Add(new SliderVM { Name = "Slider-2", Url = "slider-2.jpg" });
            sliders.Add(new SliderVM { Name = "Slider-3", Url = "slider-3.jpg" });

            return View(sliders);
            //
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}