using System;

namespace Species
{   
    //This is an example of old school approach to encapsulation
    public class OldSchoolHuman
    {
        //unlike the properties, fields could (preferably) be starting with lower case 
        private string gender = "Male";
        private string firstName = "";
        private string lastName = "";
        private string eyeColor = "";
        private short age = 0;
        private bool isShy = false;

        public OldSchoolHuman(string gender, string firstName, string lastName, string eyeColor, short age, bool isShy)
        {
            Console.WriteLine("Old school human has been created!!!");

            this.gender = gender;
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
            this.isShy = isShy;
        }

        #region Old School
        public short GetAge()
        {
            if (isShy)
            {
                Console.WriteLine("I am shy, won't tell you!");

                return 0;
            }

            return age;
        }

        public void SetAge(short age)
        {
            if(age > 0 && age < 200)
            {
                this.age = age;
            }
        }
        #endregion Old School



        public string GetHumnaInfo()
        {
            return $"Human info is:" +
                $"\n Gender: { gender }" +
                $"\n Full name: { firstName } { lastName }" +
                $"\n Eye color: { eyeColor }" +
                $"\n Age: { age }";
        }
    }


    //This is an example of modern approach to encapsulation
    public class ModernHuman
    {

        //Properties in C# must be capitalized by convention
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EyeColor { get; set; }
        public Pet Pet { set; get; }

        private short age = 0;

        public short Age
        {
            get
            {
                if (IsShy)
                {
                    Console.WriteLine("I am shy, won't tell you!");

                    return 0; //default value
                }
                return age;
            }

            set
            {
                //just a small sanity check
                Console.WriteLine($"New age value is: {value}");

                if (value > 0 && value < 200)
                {
                    age = value;
                }
            }
        }
        public bool IsShy { get; set; }

        public ModernHuman()
        {
            Console.WriteLine("Modern human has been created!!!");
        }

        public string GetHumnaInfo()
        {

            var petInfo = "This human doesn't own a pet."; 

            //Pay attention to this - not assigned properties are null by default
            //Leaving out unassigned properties (being null) will result in crash, when calling any of their own properties or methods
            if(Pet != null)
            {
                petInfo = Pet.GetPetInfo();
            }

            return $"Human info is:" +
                $"\n Gender: { Gender }" +
                $"\n Full name: { FirstName } { LastName }" +
                $"\n Eye color: { EyeColor }" +
                $"\n Age: { Age }" +
                $"\n Human pet info: " +
                $"\n { petInfo }";
        }
    }

    //This is an example of when setters and getters might not be needed
    public class Coordinates
    {
        public long x = 0;
        public long y = 0;
        public long z = 0;
    }
}
