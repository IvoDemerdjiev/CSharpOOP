namespace OOPPrinciplesPartOne.SchoolClasses.Discipline
{
    using OOPPrinciplesPartOne.SchoolClasses.Interfaces;
    using System;

    public class Discipline : IName, IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length<1)
                {
                    throw new ArgumentException("The name of the discipline cannot be empty!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("The lectures cannot be less than 0");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The excersises cannot be less than 0");
                }
                this.numberOfExcercises = value;
            }
        }

        public string Comment { get; set; }
    }
}