using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance.Examples
{
    public class Steve : MultipleInheritance<Animal, Human>
    {
        public Steve(string name, int age)
        {
            Object1 = new Animal(name, age);
            Object2 = new Human(name, age);
        }

        public void Speak()
        {
            Console.WriteLine(Object1.Name + " " + Object2.Age);
        }
    }
}
