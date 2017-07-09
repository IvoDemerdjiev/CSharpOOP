﻿namespace OOPPrinciplesPartOne.AnimalHierarchy.Animals
{
    using System;
    using System.Linq;
    using OOPPrinciplesPartOne.AnimalHierarchy.Gender;
    using System.Collections.Generic;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;

        public Animal(int age, string name, Gender gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be less than 0");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length<0)
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.name = value;
            }
        }

        public Gender Gender { get; private set; }

        public virtual void ProduceSound()
        {
            Console.WriteLine("I Produce Sound");
        }
    }
}
