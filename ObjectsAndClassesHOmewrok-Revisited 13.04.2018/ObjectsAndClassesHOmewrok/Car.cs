using System;

namespace ObjectsAndClassesHOmewrok
{
    public class Car
    {
        public int ImmobilizerId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Tyre[] Tyres = new Tyre[4];
        public IgnitionKey IgnitionKey { set; get; }
        public Engine Engine { set; get; }
        public Human Driver { set; get; }

        public void EnterTheCar(Human human)
        {
            Driver = human;

            if (Driver.Age >= 18)
            {
                Console.WriteLine("You are allowed to drive!");
            }
            else
            {
                Console.WriteLine("You are not allowed to drive!");
            }

            if (AreTyresOk())
            {
                Console.WriteLine("Let's roll!");
            }
            else
            {
                Console.WriteLine("I am afraid to drive with these tyres!");
            }
        }

        public bool AreTyresOk()
        {
            if(Global.SEASON == Global.WINTER) { 
                for(int i =0; i< Tyres.Length; i++)
                {
                    if(Tyres[i].Type != Global.SEASON)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void InsertKey(IgnitionKey key)
        {
            IgnitionKey = key;
        }

        public void  StartEngine()
        {
            if (IgnitionKey != null && ImmobilizerId == IgnitionKey.ImmobilizerId)
            {
                if (!Engine.IsRunning)
                {
                    Console.WriteLine("Everything is OK");
                    Engine.IsRunning = true;
                }
                else
                {
                    Console.WriteLine("Engine is already running!");
                }
            }
            else
            {
                Console.WriteLine("Ignition Key is not from this car");
            }
        }

        public void StopEngine()
        {
            if (Engine.IsRunning)
            {
                Engine.IsRunning = false;
                Console.WriteLine("Engine is stopped!");
            }
            else
            {
                Console.WriteLine("Engine is already stopped.");
            }
        }
    }
}



