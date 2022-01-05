using System.Collections.Generic;

namespace CarLab_API
{
    public class CarLot
    {
        public List<Car> Inventory { get; set; } = new List<Car>();
        public CarLot()
            {
            Inventory.Add(new Car("Ford", "F-150", 2021, "blue"));
            Inventory.Add(new Car("Chevy", "Colorado", 2021, "red"));
            Inventory.Add(new Car("Mercedes Benz", "Popemobile", 2021, "white"));
            Inventory.Add(new Car("Ford", "F-150", 2001, "black"));
            Inventory.Add(new Car("Chevy", "Colorado", 2012, "blue"));
            Inventory.Add(new Car("Rolls Royce", "Ghost", 2018, "black"));

        }
    }
}
