using System;

namespace MakeCars
{    
    class MainCars
    {
        public static void Main {string[] args}
        {
            var car = new Cars {;}
            car.color = "Yellow";
            car.manufacturer = "Toyota";
            console.WriteLine('The car is a ' + car.color + ' ' + car.manufacturer);
        }
    }

    public class Cars
    {
        public string color { get; set; }
        public string manufacturer { get; set; }
    }
     
    
}