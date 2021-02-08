using System;

namespace CsharpProgex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse Eddy = new Horse();
            Horse Miles = new Horse();
            Horse Ray = new Horse();
            Horse Lola = new Horse();

            Horse.NameHorse();

            Eddy.NameHorse2("Eddy", "Woof", "pork");
            Speak(Eddy);
            Eat(Eddy);

            Miles.NameHorse2("Miles", "Meow", "lemons");
            Speak(Miles);
            Eat(Miles);

            Ray.NameHorse2("Ray", "Hello", "grass");
            Speak(Ray);
            Eat(Ray);

            Lola.NameHorse2("Lola", "Yo", "broccolli");
            Speak(Lola);
            Eat(Lola);

            Cow Bessie = new Cow();
            Cow Ryan = new Cow();
            Cow Tobin = new Cow();
            Cow Lindsay = new Cow();

            Cow.NameCow();

            Bessie.NameCow2("Bessie", "Moo", "Burgers");
            CowSpeak(Bessie);
            CowEat(Bessie);

            Ryan.NameCow2("Ryan", "Boo", "steak");
            CowSpeak(Ryan);
            CowEat(Ryan);

            Tobin.NameCow2("Tobin", "Dude", "nothing");
            CowSpeak(Tobin);
            CowEat(Tobin);

            Lindsay.NameCow2("Lindsay", "nothing", "gravy");
            CowSpeak(Lindsay);
            CowEat(Lindsay);

            Dog Ralph = new Dog();
            Dog Zulu = new Dog();
            Dog Cami = new Dog();
            Dog Bodhi = new Dog();

            Dog.NameDog();

            Zulu.NameDog2("Zulu", "Ruff", "chicken fingers");
            DogSpeak(Zulu);
            DogEat(Zulu);

            Ralph.NameDog2("Ralph", "Why", "dog food");
            DogSpeak(Ralph);
            DogEat(Ralph);

            Cami.NameDog2("Cami", "Hi!", "everything");
            DogSpeak(Cami);
            DogEat(Cami);

            Bodhi.NameDog2("Bodhi", "Vaya con Dios", "Meatball subs");
            DogSpeak(Bodhi);
            DogEat(Bodhi);

            Duck Donald = new Duck();
            Duck Daffy = new Duck();
            Duck Sammy = new Duck();
            Duck Ty = new Duck();

            Duck.NameDuck();

            Donald.NameDuck2("Donald", "Quack", "duck");
            DuckSpeak(Donald);
            DuckEat(Donald);

            Daffy.NameDuck2("Daffy", "Yuck", "bugs");
            DuckSpeak(Daffy);
            DuckEat(Daffy);

            Sammy.NameDuck2("Sammy", "Rahn stahp", "hearts");
            DuckSpeak(Sammy);
            DuckEat(Sammy);

            Ty.NameDuck2("Ty", "Nananana", "sushi");
            DuckSpeak(Ty);
            DuckEat(Ty);
        }

        public static void Speak(Horse words)
        {
            Console.WriteLine($"My name is {words.Name} and I say {words.Voice}");
        }

        public static void Eat(Horse food)
        {
            Console.WriteLine($"I am {food.Name} and I like to eat {food.Food}");
        }

        public static void CowSpeak(Cow words)
        {
            Console.WriteLine($"My name is {words.Name} and I say {words.Voice}");
        }

        public static void CowEat(Cow food)
        {
            Console.WriteLine($"I am {food.Name} and I like to eat {food.Food}");
        }

        public static void DogSpeak(Dog words)
        {
            Console.WriteLine($"My name is {words.Name} and I say {words.Voice}");
        }

        public static void DogEat(Dog food)
        {
            Console.WriteLine($"I am {food.Name} and I like to eat {food.Food}");
        }

        public static void DuckSpeak(Duck words)
        {
            Console.WriteLine($"My name is {words.Name} and I say {words.Voice}");
        }

        public static void DuckEat(Duck food)
        {
            Console.WriteLine($"I am {food.Name} and I like to eat {food.Food}");
        }
    }

    class Horse
    {
        public string Name;
        public string Voice;
        public string Food;

        public static void NameHorse()
        {
            Console.WriteLine("Default name of horse is Horse");
        }

        public void NameHorse2(string name, string voice, string food)
        {
            Name = name;
            Voice = voice;
            Food = food;
        }
    }

    class Dog
    {
        public string Name;
        public string Voice;
        public string Food;

        public static void NameDog()
        {
            Console.WriteLine("Default name of dog is Dog");
        }

        public void NameDog2(string name, string voice, string food)
        {
            Name = name;
            Voice = voice;
            Food = food;
        }
    }

    class Duck
    {
        public string Name;
        public string Voice;
        public string Food;

        public static void NameDuck()
        {
            Console.WriteLine("Default name of duck is Duck");
        }

        public void NameDuck2(string name, string voice, string food)
        {
            Name = name;
            Voice = voice;
            Food = food;
        }
    }

    class Cow
    {
        public string Name;
        public string Voice;
        public string Food;

        public static void NameCow()
        {
            Console.WriteLine("Default name of cow is Cow");
        }

        public void NameCow2(string name, string voice, string food)
        {
            Name = name;
            Voice = voice;
            Food = food;
        }
    }
}
