using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    static class CarFactory
    {
        static Dictionary<string, CarModel> carModels = new Dictionary<string, CarModel>();

        public static void AddCarModel(string modelName, CarModel carModel)
        {
            carModels.Add(modelName, carModel);
        }
        public static Car CreateCar(string modelName)
        {
            Car car = new Car();
            if (carModels.TryGetValue(modelName, out CarModel carModel))
            {
                car.CarModel = carModel;
            }
            return car;
        }
    }
}
