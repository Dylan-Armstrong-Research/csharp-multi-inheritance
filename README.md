# CSharp Multi Inheritance

**Please note: There is no muliple inheritance in C#. This is probably about as close as you will get to having multiple inheritance in C#.**

## How Does it Work?

- Uses a MultipleInheritance generic class with two public properties for the two objects.
- The two arguments for the MultipleInheritance class ARE the two classes you are inheriting from (as types)!
- Create new instances of those two classes in the constructor of the child class (which is inheriting `MultipleInheritance`) as Object1 and Object2 respectively.
- If using an abstract class, create a concrete class inheriting from that abstract class AND THEN use the concrete class as Object1 or Object2 in `MultipleInheritance`. Abstract classes do not work as they cannot be instantiated!
- Uses composition over inheritance for the MultipleInheritance class.
- Please note: There is NO polymorphism on Multiple Inherited classes in this case.


See `Examples/` folder for an example.

