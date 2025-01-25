using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
     class Animal
    {
        public string name;
        public string species;
        public int age;
        public string specialfeatures;
        public int numbers;


        public Animal(string name, string species, int age, string specialfeatures, int numbers)
        {
            this.name = name;
            this.species = species;
            this.age = age;
            this.specialfeatures = specialfeatures;
            this.numbers = numbers;
        }
    }
}
