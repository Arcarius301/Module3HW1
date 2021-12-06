using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW1
{
    public class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(object obj)
        {
            {
                Person person = obj as Person;
                if (person != null)
                {
                    return Age.CompareTo(person.Age);
                }
                else
                {
                    throw new ArgumentException("Object is not a Person");
                }
            }
        }
    }
}
