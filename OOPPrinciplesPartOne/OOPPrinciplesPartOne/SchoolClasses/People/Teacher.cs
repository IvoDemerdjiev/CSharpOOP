﻿namespace OOPPrinciplesPartOne.SchoolClasses.People
{
    using Interfaces;
    using System.Collections.Generic;
    using OOPPrinciplesPartOne.SchoolClasses.Discipline;

    public class Teacher : People , IName, IComment
    {
        private List<Discipline> disciplines;

        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
            }
            private set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}
