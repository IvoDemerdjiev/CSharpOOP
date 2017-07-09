namespace OOPPrinciplesPartOne.StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private const int MinWorkHours = 6;
        private const int MaxWorkHours = 12;

        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Week salary cannot be negative");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < MinWorkHours || value > MaxWorkHours)
                {
                    throw new ArgumentOutOfRangeException("The Work Hours Per Day cannot be less than 6 and more than 12!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (WorkHoursPerDay * 7);
        }  
    }
}
