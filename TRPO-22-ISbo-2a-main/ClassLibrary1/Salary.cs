using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class Salary
 {
     public string Name { get; }
     public string Sal { get; }
     public Division Division { get; }
     
     
     public Salary(string name, string salary, Division division)
     {
         this.Name = name;
         this.Sal = salary;
         this.Division = division;
     }
 }
}
