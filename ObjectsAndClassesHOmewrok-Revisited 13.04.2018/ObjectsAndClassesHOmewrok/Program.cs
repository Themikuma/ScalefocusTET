using System;

namespace ObjectsAndClassesHOmewrok
{
    public class Program
    {
        static void Main(string[] args)
        {

            var car = new Car();

            var human0 = new Human
            {
                Name = "Kaloqn",
                Age = 15
            };

            var human1 = new Human
            {
                Name = "Stamat",
                Age = 19
            };

            int immobilizerId = 1234521414;

            var key0 = new IgnitionKey()
            {
                ImmobilizerId = immobilizerId
            };

            var key1 = new IgnitionKey()
            {
                ImmobilizerId = 123
            };

            car.ImmobilizerId = immobilizerId;

            for(int i = 0; i < car.Tyres.Length; i++)
            {
                car.Tyres[i] = new Tyre()
                {
                    Size = 15,
                    Type = Global.SUMMER
                };
            }

            var engine = new Engine()
            {
                FuelType = Global.GASOLINE,
                IsRunning = false,
                Volume = 2,
                Gears = 5
            };

            car.Engine = engine;
            car.EnterTheCar(human0);
            car.InsertKey(key0);
            car.StartEngine();
            car.StartEngine();

            Console.ReadKey();

            car.StopEngine();

            Console.ReadKey();
            
        }
    }
}
