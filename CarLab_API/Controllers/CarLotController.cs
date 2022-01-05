using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarLab_API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CarLotController : ControllerBase
    {
        CarLot inv = new CarLot();
        //public List<Car> = new List<Car>
        public List<Car> listOfCars { get; set; } = new List<Car>();
        [HttpGet]
        public List<Car> GetAllCars()
        {
            return inv.Inventory;
        }

        [HttpGet("GetCarByIndex/{index}")]
        public Car GetCarByIndex(int index)
        {
            Car clownCar = new Car("Clown", "Premium", 2050, "rainbow");
            try
            {
                return inv.Inventory[index];
            }
            catch 
            {
                return clownCar;
            }
        }

        [HttpGet("SearchMake/{search}")]
        public List<Car> SearchMake(string search)
        {
            List<Car> listOfCarsByMake = new List<Car>();
            foreach(Car c in inv.Inventory)
            {
                if(search.ToLower().Trim() == c.Make.ToLower().Trim())
                {
                    listOfCarsByMake.Add(c);
                }
            }
            return listOfCarsByMake;
        }

        [HttpGet("SearchColor/{search}")]
        public List<Car> SearchColor(string search)
        {
            List<Car> listOfCarsByColor = new List<Car>();
            foreach (Car c in inv.Inventory)
            {
                if (search.ToLower() == c.Color.ToLower())
                {
                    listOfCarsByColor.Add(c);
                }
            }
            return listOfCarsByColor;
        }

    }
}
