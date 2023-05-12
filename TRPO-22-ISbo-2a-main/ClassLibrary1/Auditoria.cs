using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Auditoria
    {
        public string Name { get; }
        public Employee Employee { get; }
        public int NumberMest { get; }
        public int NumberOkon { get; }
        public List<Oborydovanie> Oborydovanie { get; }

        public Auditoria(string name, Employee employee, int numbermest, int numberokon, List<Oborydovanie> oborydovanie)
        {
            Name = name;
            Employee = employee;
            NumberMest = numbermest;
            NumberOkon = numberokon;
            Oborydovanie = oborydovanie;
        }
    }
}
