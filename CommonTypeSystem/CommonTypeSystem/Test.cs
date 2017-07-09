namespace CommonTypeSystem
{
    using PersonClass;
    using StudentClass;
    using System;

    class Test
    {
        static void Main(string[] args)
        {
            var mathStudent = new Student("Ivan", "Ivanov", "Ivanov", 123456789, "Sofia, St grad", "0888888888", "Ivanov@abv.bg", 2, Specialty.AppliedMathematics, Faculty.MathematicsFaculty, University.TU);
            var lawStudent = new Student("Gosho", "Goshev", "Goshev", 987654321, "Sofia, Mladost", "0999999999", "Goshev@abv.bg", 2, Specialty.CivilLaw, Faculty.LawFaculty, University.SU);

            Console.WriteLine(mathStudent);

            Console.WriteLine();

            Console.WriteLine(mathStudent.MiddleName == lawStudent.MiddleName);

            Console.WriteLine();

            Console.WriteLine(mathStudent.MiddleName.GetHashCode());

            Console.WriteLine();

            Student newMathStudentWithClone = (Student)mathStudent.Clone();
            newMathStudentWithClone.FirstName = "Pesho";
            Console.WriteLine(newMathStudentWithClone.FirstName.CompareTo(mathStudent.FirstName) == 0 ? "names are equal - clone NOT successful!" : "names are not equal - successful clone!");

            Console.WriteLine();

            var students = new Student[]
            {
               
                new Student("Dimitar", "Dimitrov", "dimitrov", 987456321),
                new Student("Vasil", "Vasilev", "Vasilev", 123456987)

            };

            Array.Sort(students);
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.MiddleName + " " + student.LastName + " " + student.SocialSecurityNumber);
            }

            Console.WriteLine("Person:");

            var Jeko = new Person("Jeko");
            Console.WriteLine(Jeko);

            var Zdravko = new Person("Zdravko");
            Console.WriteLine(Zdravko);
        }
    }
}
