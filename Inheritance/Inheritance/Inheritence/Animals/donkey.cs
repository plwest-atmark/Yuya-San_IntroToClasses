﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence.Animals
{
    class Donkey : Animal
    {
        public Donkey() : base()
        {

        }

        public override void MakeAnimalSound()
        {
            Console.WriteLine("hee-haw!");
        }
        public override void PerformAnimalAction()
        {
            Console.WriteLine("live longer than Horse");
        }
    }
        
}
