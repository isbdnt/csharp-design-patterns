using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            //you might read car model data from database
            CarFactory.AddCarModel("Audi Q3", new CarModel()
            {
                Brand = "Audi",
                Price = "$50,000",
            });
            CarFactory.AddCarModel("Audi A3", new CarModel()
            {
                Brand = "Audi",
                Price = "$40,000",
            });

            Car car1 = CarFactory.CreateCar("Audi A3");
            car1.Owner = "Ackerley";
            car1.Color = "Black";
            Car car2 = CarFactory.CreateCar("Audi A3");
            car2.Owner = "Maaravi";
            car2.Color = "Orange";
            Car car3 = CarFactory.CreateCar("Audi Q3");
            car3.Owner = "Maaravi";
            car3.Color = "Blue";
            Console.WriteLine("car1");
            Console.WriteLine(car1.ToString());
            Console.WriteLine();
            Console.WriteLine("car2");
            Console.WriteLine(car2.ToString());
            Console.WriteLine();
            Console.WriteLine("car3");
            Console.WriteLine(car3.ToString());
            Console.WriteLine();
            Console.WriteLine(car1.CarModel == car2.CarModel);
            Console.WriteLine(car1.CarModel == car3.CarModel);
        }
    }
}
