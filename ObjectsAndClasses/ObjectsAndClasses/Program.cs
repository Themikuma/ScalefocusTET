using System;
using Species;
namespace ObjectsAndClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Old School
            OldSchoolHuman geri = new OldSchoolHuman("female", "Gergana", "Arnaudova", "Green", 20, false);

            string geriInfo = geri.GetHumnaInfo();

            //Console.WriteLine($"This guy's name is: { gosho.name }");

            //gosho.name = "Gosho";

            //Console.WriteLine($"This guy's name is: { gosho.name }");

            Console.WriteLine($"Info for the following human is: { geriInfo } ");

            geri.SetAge(500);

            short geriAge = geri.GetAge();

            Console.WriteLine($"This is some extra private info about age: { geriAge }");
            #endregion Old School

            #region Modern approach
            ModernHuman gosho = new ModernHuman
            {
                Gender = "male",
                Age = 30,
                FirstName = "Georgi",
                LastName = "Spasov",
                EyeColor = "Brown",
                IsShy = false
            };

            ModernHuman gosho2 = new ModernHuman(); // this is also valid

            gosho.Age = 500;

            short goshoAge = gosho.Age;

            //gosho.Pet = new Pet
            //{
            //    Name = "Ivan",
            //    Type = "Kotarak",
            //    Color = "White"
            //};

            Console.WriteLine($"This is some extra private info about age: { goshoAge }");

            Console.WriteLine($"Modern human info: \n { gosho.GetHumnaInfo() }");
            #endregion Modern approach

            Console.ReadKey();
        }
    }
}
