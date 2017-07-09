namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Linq;
    using StudentGroup;

    class StudentsOrderAndGroup
    {

        public static Student[] filterStudents(Student[] students)
        {
            var filteredStudents = students
                .Where(st => string.Compare(st.FirstName, st.LastName) < 0)
                .ToArray();

            return filteredStudents;
        }


        static void Main()
        {
           
           var students = new[]
            {
                new Student("Pesho", "Peshov", 18),
                new Student( "Ivan",  "Ivanov", 26),
                new Student("Gosho", "Goshev",  28),
            };

            var filteredStudents = filterStudents(students);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            } 
            Console.WriteLine();

            var studentsAge = students
                .Where(st => st.Age >= 18 && st.Age <= 24)
                .Select(st => st.FirstName + " " + st.LastName);

            Console.WriteLine("Age between 18 and 24");

            foreach (var student in studentsAge)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Ordered students");

            var orderStudents = students
              .OrderByDescending(st => st.FirstName)
              .ThenByDescending(st => st.LastName);

            foreach (var student in orderStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            /*var studentsList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 121306006, "0123456789", 1, "ivan@abv.bg"),
                new Student("Pesho", "Peshev", 121306007, "0123456789", 3, "pesho@abv.bg"),
                new Student("Dimitar", "Dimitrov", 121306008, "0123456789", 4, "dimitar@gmail.com"),
            };

            
            studentsList[0].AddMark(4);
            studentsList[0].AddMark(4);
            studentsList[1].AddMark(6);
            studentsList[1].AddMark(5);
            studentsList[2].AddMark(6);
            studentsList[2].AddMark(4);

            var studetnsFromGroup2 = studentsList
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName)
                .ToList();

            foreach (var student in studetnsFromGroup2)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + "    Group: " + student.GroupNumber);
            }


            var secondListofStudentsGroup2 = studentsList.FindStudentsFromGroup2();

            foreach (var student in secondListofStudentsGroup2)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + "    Group: " + student.GroupNumber);
            }

            var extractedStudents = studentsList
                .Where(st => st.Email.Contains("abv.bg"))
                .ToList();

            foreach (var student in extractedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + "   email: " + student.Email);
            }

            Console.WriteLine();

            var studentFromSofia = studentsList
                .Where(st => st.TelNumber[0] == '0' && st.TelNumber[1] == '2')
                .ToList();

            foreach (var student in studentFromSofia)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + "   tel: " + student.TelNumber);
            }

            Console.WriteLine();


            var studentsWith6 = studentsList
                .Where(st => st.Marks.Contains(6))
                .ToList();

            var anonymousType = new
            {
                FullName = studentsWith6.Select(st => st.FirstName + " " + st.LastName),
                Marks = studentsWith6.Select(st => st.Marks)
            };


            Console.WriteLine("Students  that have at least one mark Excellent (6):");

            foreach (var name in anonymousType.FullName)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine();


            var weakStudents = studentsList.ExtraxtStudentsWithMark2();

            foreach (var student in weakStudents)
            {
                Console.Write(student.FirstName + " " + student.LastName + "   Marks: ");
                Console.WriteLine(string.Join(", ", student.Marks));
            }



            var studentsFrom06 = studentsList
                .Where(st => st.FacNumber.ToString().Substring(4, 2) == "06")
                .Select(st => st.Marks)
                .ToList();

            Console.WriteLine("Marks of students");

            foreach (var marks in studentsFrom06)
            {
                Console.WriteLine(string.Join(", ", marks));
            }

            Console.WriteLine();

            var groupedStudents = studentsList.GroupBy(st => st.GroupNumber);

            int i = 1;
            foreach (var students in groupedStudents)
            {
                Console.WriteLine("Group {0}:", i);
                foreach (var student in students)
                {
                    if (i == 0)
                    {
                        Console.Write(student.GroupNumber);
                    }
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
                Console.WriteLine();
                i++;
            }*/

            //studentsList.GroupedByGroupNumber();
        }
    }
}
