using DogAndPeoples.DAO;
using Microsoft.AspNetCore.Mvc;

namespace DogAndPeoples.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
