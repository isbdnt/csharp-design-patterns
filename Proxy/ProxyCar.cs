using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyCar : ICar
    {
        private Driver driver;
        private ICar realCar;

        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            realCar = new Car();
        }

        public void DriveCar()
        {
            if (driver.Age < 16)
                Console.WriteLine("Sorry, the driver is too young to drive.");
            else
                realCar.DriveCar();
        }
    }

}
