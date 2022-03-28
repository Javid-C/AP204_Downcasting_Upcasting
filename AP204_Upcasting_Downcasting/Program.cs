using System;

namespace AP204_Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interface and Enum
            //Bravo bravo = new Bravo();
            //bravo.Total = 30;

            //bravo.Sell();


            //ISupermarketable supermarketable = bravo;
            //supermarketable.methodWithBody();



            //Console.WriteLine(Menu.Coffee);

            //Console.WriteLine((int)Weekdays.Tuesday);

            //foreach (var item in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{(byte)item}. {item}");
            //}

            //string numStr = Console.ReadLine();

            //int num;

            //bool result = int.TryParse(numStr, out num);

            //if (result)
            //{
            //    switch (num)
            //    {
            //        case (byte)Weekdays.Monday:
            //            Console.WriteLine(Weekdays.Monday);
            //            break;
            //        case (byte)Weekdays.Tuesday:
            //            Console.WriteLine(Weekdays.Tuesday);
            //            break;
            //        case (byte)Weekdays.Wednesday:
            //            Console.WriteLine(Weekdays.Wednesday);
            //            break;
            //        case (byte)Weekdays.Thursday:
            //            Console.WriteLine(Weekdays.Thursday);
            //            break;
            //        case (byte)Weekdays.Friday:
            //            Console.WriteLine(Weekdays.Friday);
            //            break;
            //        default:
            //            Console.WriteLine("Hefte sonlari baglidi");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun reqem daxil edin");
            //}


            //int parse = int.Parse("a5");


            //int num;

            //bool result = int.TryParse("a5", out num);

            //Console.WriteLine(result);


            #endregion


            //Human human = new Human();
            //human.Name = "Tural";

            //Teacher teacher = new Teacher("Programming");

            //human.Info();

            //teacher.Info();

            //human = teacher;

            //Console.WriteLine("After");

            //human.Info();

            //teacher.Info();


            //Samoyed samoyed = new Samoyed();

            //Dog dog = samoyed;

            //Dog sam = new Samoyed();
            //Console.WriteLine(sam.GetType());

            Samoyed samoyed = new Samoyed();

            LionFish lionFish = new LionFish();

            Animal animal = lionFish;
            Console.WriteLine(animal.GetType());

            // First method
            //LionFish lf = animal as LionFish;

            //Console.WriteLine(lf == null);
            //if (lf != null)
            //{
            //    lf.Poison = "Deadly";

            //    Console.WriteLine(lf.Poison);
            //}


            //Second method
            //if (animal is LionFish)
            //{
            //    LionFish lionFish1 = (LionFish)animal;
            //    lionFish1.Poison = "Deadly";
            //    Console.WriteLine(lionFish1.Poison);
            //}
            //else
            //{
            //    Console.WriteLine("Animal lionfish deyil");
            //}


            Manat manat = new Manat { Azn = 200 };

            Dollar dollar = (Dollar)manat;

            Console.WriteLine(dollar.Usd);




            Person person = new Person(20);
            Person person1 = new Person(30);

            Console.WriteLine(person<person1);
        }

        
    }

    class Manat
    {
        public double Azn;

        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar { Usd = manat.Azn / 2 };
        }

    }
    class Dollar
    {
        public double Usd;

    }

    class Person
    {
        public int Age;
        public Person(int age)
        {
            Age = age;
        }

        public static bool operator >(Person p1,Person p2)
        {
            return p1.Age > p2.Age;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Age == p2.Age;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Age != p2.Age;
        }
    }

    class Human
    {
        public string Name;

        

        public void Info()
        {
            Console.WriteLine(Name);
        }

    }

    class Teacher:Human
    {
        public string Profession;

        public Teacher(string profession)
        {
            Profession = profession;
        }

        public void Info()
        {
            Console.WriteLine(Profession);
        }
    }

    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Dog:Animal
    {
        public abstract void Bark();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }


    class Samoyed:Dog
    {
        public string Fur;

        public override void Bark()
        {
            Console.WriteLine("Bark");
        }

        public override void Eat()
        {
            Console.WriteLine("Pedigree");
        }
    }

    class LionFish : Fish
    {
        public string Poison;

        public override void Eat()
        {
            Console.WriteLine("Small fishes");
        }

        public override void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
