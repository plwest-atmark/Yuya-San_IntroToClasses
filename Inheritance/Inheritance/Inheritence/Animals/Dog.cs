using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence.Animals
{
    class Dog : Animal  // See the "Cat" class for details
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Woof!");
        }
        public override void PerformAnimalAction()
        {
            Console.WriteLine("Chase Cat.");
        }
    }
}
