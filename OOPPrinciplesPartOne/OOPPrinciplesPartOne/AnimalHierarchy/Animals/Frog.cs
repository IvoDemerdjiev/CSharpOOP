namespace OOPPrinciplesPartOne.AnimalHierarchy.Animals
{
    using System;
    using OOPPrinciplesPartOne.AnimalHierarchy.Gender;

    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Gender gender) : base(age, name, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kwak");
        }
    }
}
