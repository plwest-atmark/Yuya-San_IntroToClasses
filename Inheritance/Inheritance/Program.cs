using Inheritence.Animals;
using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            // We will use the "base" class "Animal" to create a "List" of Animals.
            //
            // However, we do not want to create any "Animals", we want to create specific "types of animals"
            // 
            // In other words, we want to create dogs, cats and horses and store them all in the same list. 

            // This is what we call "Inheritence" and "Polymorphism"

            List<Animal> animals = new List<Animal>();  // Create a new list of the <Animal> type

            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Horse());

            // Our list now has 3 different types of animals.  They each do different things, but are "stored" in the same list.
            // They also function the same, so we can use the "base" class methods on ALL of them. However, what each of them do is different.

            foreach (Animal animal in animals) // Let's create a "breakpoint" here and see what is going on inside of the code.
            {
                Console.WriteLine(animal.AnimalName);

                // Notice that we are using the "Animal" type, but they are "Cat", "Dog" and "Horse".
                // We can do this because they are "children" of the "base" class Animal.
                animal.MakeAnimalSound();

                // Let's do the Animal Action for each of the Animals. What do you notice about them.  Look at the classes to
                // see how they are different.
                animal.PerformAnimalAction();

                // This will call the Sleep method. Since we did not "implement" it in the "child" classes, 
                //  the "base" class method will be used.
                animal.Sleep();

                Console.WriteLine();  // Create a new line so we can see a space between each animal in the console.
            }


        }
    }
}
