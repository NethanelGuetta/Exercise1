using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Animal()
    {
        protected string species { get; set; }

        public void GetSpecies()
        { Console.WriteLine(); }

    }

    public class Dog : Animal
    {

        public string SetSpecies(string spec)
        {

            return species = spec;

        }


    }
}
