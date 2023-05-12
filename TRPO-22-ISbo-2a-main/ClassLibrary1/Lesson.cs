using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Lesson
    {
        public string Date { get; }
        public Discipline Disciplina { get; }
        public Employee Sotrudnik { get; }
        public Auditoria Auditoria { get; }
        public Group Group { get; }
        public Para Para { get; }
        public Class14 VidZanyatia { get; }

        public Lesson(string date, Discipline disciplina, Employee sotrudnik, Auditoria auditoria, Group group, Para para, Class14 vidzanyatia)
        {
            Date = date;
            Disciplina = disciplina;
            Sotrudnik = sotrudnik;
            Auditoria = auditoria;
            Group = group;
            Para = para;
            VidZanyatia = vidzanyatia;
        }
    }
}
