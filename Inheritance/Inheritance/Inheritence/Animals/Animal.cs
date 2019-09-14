﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence.Animals
{
    abstract class Animal
    {
        #region Fields and Properties

        private string _animalName;
        public string AnimalName { get { return _animalName; }}
        public string Color { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        
        #endregion

        /// <summary>
        /// Constructor for the Animal Class, this is ALWAYS called when an animal is created
        /// </summary>
        public Animal(){
            this._animalName = this.ToString().Replace("Inheritence.Animals.","");
        }


        /// <summary>
        /// "Base" Method. This will be called when ANY child class is used.
        /// 
        /// This method cannot be overriden because it's not marked to be "virtual" or "abstract"
        /// </summary>
        public void Sleep()
        {
            Console.WriteLine("Zzz Zzz Zzz from 'Animal Base Class'");
        }

        /// <summary>
        /// This is a "virtual" method. This means that it can be "overridden" in the child classes, but
        /// if it is not, this will be used.
        /// </summary>
        public virtual void MakeAnimalSound()
        {
            Console.WriteLine("Raaaaaawwrrrrr from 'Animal Base Class'");
        }


        /// <summary>
        /// This is an "asbract" method and MUST be overriden in all child classes.  The compiler will
        /// show an error is this is not done in the child class.
        /// </summary>
        public abstract void PerformAnimalAction();

    }
}
