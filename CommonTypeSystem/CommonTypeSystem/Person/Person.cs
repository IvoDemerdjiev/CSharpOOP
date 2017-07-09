namespace CommonTypeSystem.PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age=null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Age must be a positive number");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            string name = string.Format("Name: {0} ", this.Name);

            string age = string.Format("Age: {0}", this.Age == null ? "Age is not specified " : this.Age.ToString());

            return name + age;
        }
    }
}
