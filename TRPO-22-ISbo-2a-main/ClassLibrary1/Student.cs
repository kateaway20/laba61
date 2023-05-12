using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string Surname { get; }
        public string Name { get; }
        public string Middlename { get; }
        public DateTime DateOfBirth { get; }
        public Group Group{ get; }

        public Student(string surname, string name, string middlename, DateTime dateOfBirth, Group group)
        {
            Surname = surname;
            Name = name;
            Middlename = middlename;
            DateOfBirth = dateOfBirth;
            Group = group;
        }
        public Student(string surname, string name, string middlename, Group group)
        :this(surname,name, middlename, DateTime.Now,group)
        {
            
        }
    }
}
