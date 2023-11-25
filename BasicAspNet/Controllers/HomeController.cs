using BasicAspNet.BusinessLayer.Interface;
using BasicAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicAspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService  _employeeService;

        public HomeController(IEmployeeService employeeService, ILogger<HomeController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var employee =await _employeeService.ListAsync();
            return View();
        }


        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}