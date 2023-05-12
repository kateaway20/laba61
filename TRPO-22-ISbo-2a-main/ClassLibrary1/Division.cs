using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Division
    {
        //https://docs.google.com/document/d/1XUtn0QpVUQmailvo24lJ3XjJT5NP0SPjzi_vPOF1N9A/edit
        
        public string Name { get; }
        public Employee Director { get; }
        public Organization Organization { get; }


        public Division(string name, Employee director, Organization organization)
        {
            Name = name;
            Director = director;
            Organization = organization;
        }
    }
}
