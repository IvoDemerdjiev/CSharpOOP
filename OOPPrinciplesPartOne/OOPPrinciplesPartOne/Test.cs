namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    using OOPPrinciplesPartOne.StudentsAndWorkers;
    using System.Collections.Generic;
    using OOPPrinciplesPartOne.AnimalHierarchy.Animals;
    using OOPPrinciplesPartOne.AnimalHierarchy.Gender;
    class Test
    {
        static void Main(string[] args)
        {
          /*  List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivov", 4));
            students.Add(new Student("Lubomir", "Cvetanov", 4));
            students.Add(new Student("Dragan", "Draganov", 3));
            students.Add(new Student("Vasko", "Vasilev", 6));
            students.Add(new Student("Ivanka", "Ivanova", 5));
            students.Add(new Student("Kiril", "Kolev", 3));
            students.Add(new Student("Ivo", "Petrov", 2));
            students.Add(new Student("Martin", "Martinov", 2));
            students.Add(new Student("Polina", "Lozanova", 5));
            students.Add(new Student("Georgi", "Hristov", 6));

            var orderedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine("Students ordered by Grade: ");
            foreach (var st in students)
            {
                Console.WriteLine(st);
            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Ivov", 1223400, 12));
            workers.Add(new Worker("Lubomir", "Cvetanov", 232344, 8));
            workers.Add(new Worker("Dragan", "Draganov", 52223, 8));
            workers.Add(new Worker("Vasko", "Vasilev", 1212315, 6));
            workers.Add(new Worker("Ivanka", "Ivanova", 2234351, 10));
            workers.Add(new Worker("Kiril", "Kolev", 232321, 7));
            workers.Add(new Worker("Ivo", "Petrov", 4323123, 6));
            workers.Add(new Worker("Martin", "Martinov", 4523215, 7));
            workers.Add(new Worker("Polina", "Lozanova", 18300, 12));
            workers.Add(new Worker("Georgi", "Hristov", 76660, 11));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Workers ordered by MoneyPerHour: ");
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + " - Money per hour: " + worker.MoneyPerHour());
            }

            Console.WriteLine();
            Console.WriteLine();
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            var sortedHumans =
                from h in humans
                orderby h.FirstName ascending
                , h.LastName ascending
                select h;
            Console.WriteLine("Sorted humans:");
            foreach (var h in sortedHumans)
            {
                Console.WriteLine(h);
            }*/

            List<Animal> animals = new List<Animal>();
            animals.Add(new Kitten(4, "Nansi"));
            animals.Add(new Tomcat(5, "Tom"));
            animals.Add(new Cat(2, "Geri", Gender.Female));
            animals.Add(new Dog(1, "Rex", Gender.Male));
            animals.Add(new Frog(3, "Frog", Gender.Male));


            var avarageAge = animals.Sum(x => x.Age) / (double)animals.Count;
        }
    }
}
 