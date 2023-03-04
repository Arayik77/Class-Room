using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    internal class Human
    {
        public void PersonName(string personName)
        {
            Console.WriteLine("Person name word count is " + personName.Length);
        }

        public void PersonSurname(string personSurname)
        {
            Console.WriteLine("Person name word count is " + personSurname.Length);
        }
    }
}
