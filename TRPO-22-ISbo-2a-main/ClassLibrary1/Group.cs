using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

        public class Group
        {
            //group
            public string Name { get; }
            public string Abbreviation { get; }
            public int Number { get; }
            public int YearOfAdmission { get; }
            public Specialization Speciality { get; }
            public Employee HomeroomTeacher { get; }

            public Group(string name, string abbreviation, int number, int yearOfAdmission, Specialization speciality, Employee homeroomTeacher)
            {
                this.Name = name;
                this.Abbreviation = abbreviation;
                this.Number = number;
                this.YearOfAdmission = yearOfAdmission;
                Speciality = speciality;
                HomeroomTeacher = homeroomTeacher;

            }
        }
    
}
