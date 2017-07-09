namespace OOPPrinciplesPartOne.SchoolClasses.People
{
    using Interfaces;
    using System;

   public class People : IName, IComment
    {
        private string name;
        private string comment;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        private  set
            {
                if (value.Length<2)
                {
                    throw new ArgumentException("Name is too short or empty");
                }
                this.name = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
