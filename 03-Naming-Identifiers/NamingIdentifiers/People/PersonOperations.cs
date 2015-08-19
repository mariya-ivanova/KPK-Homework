using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class PersonOperations
    {
        public void createPerson(int number)
        {
            Person newPerson = new Person();
            newPerson.age = number;
            if (number % 2 == 0)
            {
                newPerson.name = "Pehso";
                newPerson.gender = Gender.male;
            }
            else
            {
                newPerson.name = "Mimi";
                newPerson.gender = Gender.female;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
