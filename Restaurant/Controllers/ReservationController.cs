using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;


namespace Restaurant.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        static List<Reservation> reservations;
        private readonly ILogger<ReservationController> _logger;

        public ReservationController(ILogger<ReservationController> logger)
        {
            _logger = logger;
            reservations = new List<Reservation>
            {
                new Reservation
                {
                    ReserveId = 1,
                    ReserveName = "John Jonson",
                    Date = DateTime.Now,
                    MenuItems = new List<MenuItem>
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
                        }
                    }
                },
                new Reservation
                {
                    ReserveId = 2,
                    ReserveName = "Amy Ames",
                    Date = DateTime.Now,
                    MenuItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Id= 3,
                            Name = "Chickenburger and Salad",
                            Price = 7.50
                        },
                        new MenuItem
                        {
                            Id = 4,
                            Name = "Root Beer",
                            Price = 1.50
                        }
                    }
                }
            };
        }
               
        [HttpGet]
        public List<Reservation> Get()
        {
           var reservations = new List<Reservation>();
            return reservations;
        }

        [HttpPost]
        public List<Reservation> Post()
        {
            var reservations = new List<Reservation>();
            return reservations;
        }

        [HttpPut]
        public List<Reservation> Put()
        {
            var reservations = new List<Reservation>();
            return reservations;
        }

        [HttpDelete]
        public List<Reservation> Delete()
        {
            var reservations = new List<Reservation>();
            return reservations;   
        }
    }

}
