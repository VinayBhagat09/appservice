using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("friend-list")]
        public IActionResult LoadFriendList()
        {
            PersonGrid personGrid = new PersonGrid()
            {
                GridTitle = "Employess",
                Persons = new List<Person>(){
                 new Person (){PersonName = "Yuvaraj" , JobTitle = "System Engineer"},
                 new Person ()  {PersonName = "Sudhir" , JobTitle = "Consultant"},
                  new Person () {PersonName = "Sunil" , JobTitle = "Manager"}
                 }
            };

            return ViewComponent("Grid",new { grid = personGrid});
        }
    }
}
