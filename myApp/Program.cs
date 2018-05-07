using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car ("Red", "Toyota");
            SaloonCar saloonCar1 = new SaloonCar (2);
            SaloonCar saloonCar2 = new SaloonCar (3, "Nissan");
            SaloonCar saloonCar3 = new SaloonCar (4, "Ford", "Purple");
            Console.WriteLine("The car1 is a " + car1.color + " " + car1.manufacturer);
            Console.WriteLine("The SaloonCar1 has " + saloonCar1.numberOfSeats + " seats");
            Console.WriteLine("The SaloonCar2 is a " + saloonCar2.manufacturer + " with " + saloonCar2.numberOfSeats + " seats");
            Console.WriteLine("The SaloonCar3 is a " + saloonCar3.color + " " + saloonCar3.manufacturer + " with " + saloonCar3.numberOfSeats + " seats");
        }
    }

    public class Car
    {
        public Car (string _color = null, string _manufacturer = null) {          
            this.color = _color; 
            this.manufacturer = _manufacturer;          
        }
        
        public string color { get; set; }
        public string manufacturer { get; set; }
    }

    public class SaloonCar : Car
    {
        public SaloonCar (int _numberOfSeats) {
            this.numberOfSeats = _numberOfSeats;
        }

        public SaloonCar (int _numberOfSeats, string _manufacturer) {
            this.numberOfSeats = _numberOfSeats;
            this.manufacturer = _manufacturer;
        }

        public SaloonCar (int _numberOfSeats, string _manufacturer, string _color) {
            this.numberOfSeats = _numberOfSeats;
            this.manufacturer = _manufacturer;
            this.color = _color;
        }

        public int numberOfSeats { get; set; }
    }

}
