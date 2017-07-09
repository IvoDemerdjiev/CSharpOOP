namespace OOPPrinciplesPartOne.AnimalHierarchy.Animals
{
    using System;
    using OOPPrinciplesPartOne.AnimalHierarchy.Gender;

    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, Gender gender) : base(age, name, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
