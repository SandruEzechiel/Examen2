using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2

    
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }

    
    public int Age
    {
        get
        {
          return DateTime.Now.Year - YearOfBirth;
        }
    }
}