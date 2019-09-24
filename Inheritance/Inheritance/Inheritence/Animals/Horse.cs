using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence.Animals
{
    class Horse : Animal // See the "Cat" class for details
    {
        public Horse() : base()
        {

        }

        public override void MakeAnimalSound()
        {
            Console.WriteLine("Neeeeeh!");
        }
        public override void PerformAnimalAction()
        {
            Console.WriteLine("Swat flies with tail.");
        }
    }
}
