namespace OOPPrinciplesPartOne.AnimalHierarchy.Animals
{
    using System;
    using OOPPrinciplesPartOne.AnimalHierarchy.Gender;

    public class Tomcat : Animal, ISound
    {
        public Tomcat(int age, string name) : base(age, name, Gender.Male)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("miaoooo");
        }
    }
}
