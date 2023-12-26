using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
       public async Task <IViewComponentResult> InvokeAsync(PersonGrid grid)
        {
            PersonGrid model = new PersonGrid()
            {
                GridTitle = "Persons List",
                Persons = new List<Person>
                {
                    new Person() { PersonName = "John", JobTitle = "Engineer" },
                    new Person() { PersonName = "Billu", JobTitle = "Technician" },
                    new Person() { PersonName = "Sameer", JobTitle = "Donker" }
                }
            
            };
            ViewData["Grid"] = model;
            //strongly typed view components
            return View("Sample",grid); //invoke a partial Views/ Shared/Components/Grid/Default.cshtml

        }
    }
}
