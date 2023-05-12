using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Specialization
    {
        public string Name { get; }
        public string Reduction { get; }
        public Specialization(string named, string reduction)
        {
            Name = named;
            Reduction = reduction;
        }
    }
}
