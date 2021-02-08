using System;

namespace CSharpQuiz04
{
    class Program
    {
        static void Main(string[] args)
        {
            Firearm shotgun = new Firearm();
            Firearm rifle = new Firearm();
            Firearm pistol = new Firearm();
            Console.WriteLine("Quiz 04");
            shotgun.GetGun("Shotgun", "Boom");
            PrintGun(shotgun);

            pistol.GetGun("Pistol", "Pop");
            PrintGun(pistol);

            rifle.GetGun("Rifle", "Bang");
            PrintGun(rifle);

            Console.ReadKey();
        }

        public static void PrintGun(Firearm guns)
        {
            Console.WriteLine($"I am a {guns.Gun} and I go {guns.Sound}");
        }
       
    }
    class Firearm
    {
        public string Gun;
        public string Sound;
        public void GetGun(string type, string sound)
        {
            Gun = type;
            Sound = sound;
        }
     
    }
}
