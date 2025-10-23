using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooClassLibrary
{
    public class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } }
        public int Age { get { return age; } }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public void Work()
        {
            Console.WriteLine("I am now at work :(");
        }

        public override string ToString()
        {
            return $"I am {name} and I am {age} years old";
        }
    }
}
