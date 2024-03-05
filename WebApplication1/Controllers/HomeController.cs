using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        
      
       
        public IActionResult Index()
        {

            return View();
        }

        

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult ToDo()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult UserOp()
        {

            return View();
        }

        public IActionResult ToDoUp()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
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
