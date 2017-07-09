namespace OOPPrinciplesPartOne.StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private const int LowestGrade = 2;
        private const int HighestGrade = 6;

        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < LowestGrade || value > HighestGrade)
                {
                    throw new ArgumentOutOfRangeException("The grade cannot be less than 2 or more than 6!");
                }
                this.grade = value;
            }
        }
    }
}