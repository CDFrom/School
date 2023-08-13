using System;

class Animal
{
    public string Name;
    public int Legs;

    public Animal()
    {
        Name = "Animal";
    }
}

class Dog : Animal
{
    public Dog()
    {
        Name = "Dog";
        Legs = 4;
    }
    public void Bark()
    {
        Console.WriteLine("Woof");
    }
    /* Well we could add a swim method to our dog class, but we could also add a swim method to the animal class and based off a boolean value we
     * have as false by default make true whenever a class inherits the ability to swim, and our method could be that if the value of swim is true
     * it would print something such as just keep swimming and if it was false it would write cannot swim.
     */
}

class Fish : Animal
{
    public Fish()
    {
        Name = "Fish";
        Legs = 0;
    }
    public void Swim()
    {
        Console.WriteLine("Just keep swimming");
    }
}
class Shark : Fish
{
    public Shark(): base()
    {
        Name = "Shark";
    }
    public void Eat(Animal lastAnimal)
    {
        //If shark is the first thing entered and lastAnimal is currently null
        if (lastAnimal == null)
        {
            Console.WriteLine("Shark ate nothing...");
        }
        else
        {
            Console.WriteLine("Shark ate {0}", lastAnimal.Name);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal lastAnimal = null;
        string input;
        while ((input = Console.ReadLine()) != "exit")
        {
            if (input == "animal")
            {
                var animal = new Animal();
                Console.WriteLine(animal.Name);
                lastAnimal = animal;
            }
            else if (input == "dog")
            {
                var dog = new Dog();
                Console.WriteLine(dog.Name + " " + dog.Legs);
                dog.Bark();
                lastAnimal = dog;
            }
            else if (input == "fish")
            {
                var fish = new Fish();
                Console.WriteLine(fish.Name + " " + fish.Legs);
                fish.Swim();
                lastAnimal = fish;
            }
            else if (input == "shark")
            {
                var shark = new Shark();
                Console.WriteLine(shark.Name + " " + shark.Legs);
                shark.Swim();
                shark.Eat(lastAnimal);
                lastAnimal = shark;
            }
        }
    }
}
