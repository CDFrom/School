using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Animal
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public void PrintMyName()
        {
            Console.WriteLine("I am {0}", Name);
        }
        public void PrintMyFood()
        {
            Console.WriteLine("My food is {0}", Food);
        }
    }

    class Dog : Animal
    {
        public string Sound { get; set; }
        public void MySound()
        {
            Console.WriteLine("My sound is {0}", Sound);
        }
    }

    class Puppy : Dog
    {
        public string Eyes { set; get; }
        public void MyEyes()
        {
            Console.WriteLine("My eyes are {0}", Eyes);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Name = "Max";
            a.Food = "Bone";
            a.PrintMyName();
            a.PrintMyFood();

            Dog husky = new Dog();
            husky.Name = "Mr. Husky";
            husky.Food = "Bone";
            husky.Sound = "Woof";
            husky.PrintMyName();
            husky.PrintMyFood();
            husky.MySound();


            Puppy charlie = new Puppy();
            charlie.Name = "Charlie";
            charlie.Food = "Meatloaf";
            charlie.Sound = "Woof";
            charlie.Eyes = "Bright";
            charlie.PrintMyName();
            charlie.PrintMyFood();
            charlie.MySound();
            charlie.MyEyes();
        }
    }

}
