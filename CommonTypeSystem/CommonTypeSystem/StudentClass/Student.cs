namespace CommonTypeSystem.StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable
    { 

        public Student(string firstName, string middleName, string lastName, ulong ssn)
                : this(firstName, middleName, lastName, ssn, string.Empty, string.Empty, string.Empty, 0, 0, 0, 0)
        {
        }

        public Student(string firstName, string middleName, string lastName, ulong ssn, string address, string phone, string email, int course, Specialty specialty, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = ssn;
            this.Address = address;
            this.MobilePhone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName { get; set; } 

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public ulong SocialSecurityNumber { get; private set; }


        public string Address { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public int Course { get; private set; }

        public Specialty Specialty { get; private set; }

        public Faculty Faculty { get; private set; }

        public University University { get; private set; }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        public object Clone()
        {
            Student clone = new Student(this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber, this.Address, this.MobilePhone, this.Email, this.Course, this.Specialty, this.Faculty, this.University);

            return clone;
        }

        public int CompareTo(object other)
        {
            var studentName = this.FirstName + this.MiddleName + this.LastName;

            var otherStudent = other as Student;
            var otherStudentName = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;

            if (studentName.CompareTo(otherStudentName) == 0)
            {
                return this.SocialSecurityNumber.CompareTo(otherStudent.SocialSecurityNumber);
            }

            return studentName.CompareTo(otherStudentName);
        }

        public override bool Equals(object obj)
        {
            var objAsStudent = obj as Student;

            if (objAsStudent == null)
            {
                return false;
            }

            if (!this.FirstName.Equals(objAsStudent.FirstName)) return false;
            if (!this.MiddleName.Equals(objAsStudent.MiddleName)) return false;
            if (!this.LastName.Equals(objAsStudent.LastName)) return false;
            if (!this.SocialSecurityNumber.Equals(objAsStudent.SocialSecurityNumber)) return false;
            if (!this.Address.Equals(objAsStudent.Address)) return false;
            if (!this.MobilePhone.Equals(objAsStudent.MobilePhone)) return false;
            if (!this.Email.Equals(objAsStudent.Email)) return false;
            if (!this.Course.Equals(objAsStudent.Course)) return false;
            if (!this.Specialty.Equals(objAsStudent.Specialty)) return false;
            if (!this.Faculty.Equals(objAsStudent.Faculty)) return false;
            if (!this.University.Equals(objAsStudent.University)) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return (this.SocialSecurityNumber.GetHashCode() + this.MobilePhone.GetHashCode());
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Student Infomation");
            info.AppendLine(string.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            info.AppendLine(string.Format("SSN: {0}", this.SocialSecurityNumber));
            info.AppendLine(string.Format("Address: {0}", this.Address));
            info.AppendLine(string.Format("Mobile Phone: {0}", this.MobilePhone));
            info.AppendLine(string.Format("Email: {0}", this.Email));
            info.AppendLine(string.Format("Course: {0}", this.Course));
            info.AppendLine(string.Format("Specialty: {0}", this.Specialty));
            info.AppendLine(string.Format("Faculty: {0}", this.Faculty));
            info.AppendLine(string.Format("University: {0}", this.University));

            return info.ToString();
        }
    }
}