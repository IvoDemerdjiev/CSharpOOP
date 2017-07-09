namespace OOPPrinciplesPartOne.SchoolClasses.People
{
    using Interfaces;
    using System;


  public  class Student : People , IName ,IComment
    {
        private int classNumber;

        public Student(string name,int classNumber):base (name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("The class number cannot be negative number");
                }
                this.classNumber = value;
            }
        }
    }
}
