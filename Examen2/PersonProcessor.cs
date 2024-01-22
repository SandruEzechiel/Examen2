using Examen2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2

public static class PersonProcessor
{
    public static Person GetOldestPerson(Person[] people)
    {
        if (people == null || people.Length == 0)
        {
            return null;
        }

        Person oldestPerson = people[0];

        for (int i = 1; i < people.Length; i++)
        {
            if (people[i].Age > oldestPerson.Age)
            {
                oldestPerson = people[i];
            }
        }

        return oldestPerson;
    }
}
