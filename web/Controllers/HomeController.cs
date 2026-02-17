using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web.Models;
using web.Services;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebService _service;

        public HomeController(IWebService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Numbers());
        }

        [HttpPost]
        public IActionResult Index(Numbers numbers)
        {
            if (!ModelState.IsValid)
                return View("Index", numbers);

            var model = _service.AnalyzeValues(numbers.InputValues!);

            return View("Index", model);
        }
    }
}
