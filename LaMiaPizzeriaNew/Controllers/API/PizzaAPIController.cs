using LaMiaPizzeriaNew.Database;
using LaMiaPizzeriaNew.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeriaNew.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPizza()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<GustiPizza> pizzas = db.GustiPizza.ToList();
                return Ok(pizzas);
            }
        }

        [HttpGet]
        public IActionResult SearchByName(string name)
        {
            using (PizzaContext db = new PizzaContext())
            {
                GustiPizza? pizzaToSearch = db.GustiPizza.Where(pizza => pizza.Name.Contains(name)).FirstOrDefault();

                if (pizzaToSearch != null)
                {
                    return Ok(pizzaToSearch);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpGet("{id}")]
        public IActionResult SearchById(int id)
        {
            using (PizzaContext db = new PizzaContext())
            {
                GustiPizza? pizzaToSearch = db.GustiPizza.Where(pizza => pizza.Id == id).FirstOrDefault();

                if (pizzaToSearch != null)
                {
                    return Ok(pizzaToSearch);
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
