using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Person()
    {
        private int Age { get; set; }
        public void SetAge(int age)
        {
            Person person = new Person();
            person.Age = age;
        }

        public int GetAge(int age)
        { return age; }

    }
}
