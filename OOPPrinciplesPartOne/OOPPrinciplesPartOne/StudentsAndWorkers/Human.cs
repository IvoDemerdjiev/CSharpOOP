namespace OOPPrinciplesPartOne.StudentsAndWorkers
{
    using System;

    public abstract class Human
    {

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("The first name cannot be null or empty!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("The first name cannot be null or empty!");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format(this.FirstName + " " + this.LastName);
        }
    }
}
