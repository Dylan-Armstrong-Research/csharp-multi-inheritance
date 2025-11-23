using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance.Examples
{
    public class Animal
    {
        private string name;
        private int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get => name;
        }

        public int Age
        {
            get => age;
        }
    }
}
