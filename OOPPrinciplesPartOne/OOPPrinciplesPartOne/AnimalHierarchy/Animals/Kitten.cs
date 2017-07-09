namespace OOPPrinciplesPartOne.AnimalHierarchy.Animals
{
    using System;
    using OOPPrinciplesPartOne.AnimalHierarchy.Gender;

    public class Kitten: Animal, ISound
    {
        public Kitten(int age, string name) : base(age, name, Gender.Female)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("miaoooo");
        }
    }
}
