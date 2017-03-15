using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace MyFirstDotNetCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly EnvironmentConfig _configuration;

        public HomeController(IOptions<EnvironmentConfig> configuration)
        {
            _configuration = configuration.Value;
        }

        public IActionResult Index()
        {
            ViewData["Weight"] = _configuration.Weight;
            ViewData["Time"] = _configuration.Time;
            ViewData["Height"] = _configuration.Height;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
