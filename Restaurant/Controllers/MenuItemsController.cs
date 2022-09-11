using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;


namespace Restaurant.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private List<MenuItem> menuItem;

        private readonly ILogger<MenuItemsController> _logger;

        public MenuItemsController(ILogger<MenuItemsController> logger)
        {
            _logger = logger;
            menuItem = new List<MenuItem>
            {
                new MenuItem
                {
                    Id = 1,
                    Name = "Cheeseburger and Fries",
                    Price = 9.00
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Coca-Cola",
                    Price = 1.50
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Chickenburger and Salad",
                    Price = 7.50
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Root Beer",
                    Price = 1.50
                }
            };
        }

        [HttpGet]
        public List<MenuItem> Get()
        {
            var menuItem = new List<MenuItem>();
            return menuItem;
        }
        [HttpPost]
        public List<MenuItem> Post()
        {
            var menuItem = new List<MenuItem>();
            return menuItem;
        }

        [HttpPut]
        public List<MenuItem> Put()
        {
            var menuItem = new List<MenuItem>();
            return menuItem;
        }

        [HttpDelete]
        public List<MenuItem> Delete()
        {
            var menuItem = new List<MenuItem>();
            return menuItem;
        }

    }
}
