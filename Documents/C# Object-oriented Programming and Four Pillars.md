## **C# Object-oriented Programming and Four Pillars**



#### Object-oriented Programming (OOP):

OOP is a programming paradigm using the concept of objects which can contain data and code. In C#, an object is a block of memory that has been allocated and configured according to a Class, Struct, or Record.

In OOP, four principles are used, Abstraction, Encapsulation, Inheritance, and Polymorphism.

#### Four Pillars of Object-oriented Programming:

##### Abstraction:

Abstractions' are used to hide details or any unnecessary implementations of data. Using the abstract modifier indicates that the object has a missing or incomplete implementation and that it is intended to be used as a base for other fields, methods, or classes to derive from. Abstract classes cannot be instantiated on their own and they can only contain abstract methods and accessors.

##### Encapsulation:

Encapsulation is sometimes referred to as the First Pillar or Principle of OOP. A class or struct can specify how accessible each member is to code outside of it. Methods and variables that aren't intended to be used from outside of the class or assembly can be hidden to limit the potential for coding errors or malicious exploits.

##### Inheritance:

Inheritance enables you to create new classes that reuse, extend and modify the behaviour defined in other classes. The class wholes members are inherited is known as the Base Class, and the class that inherits those members is called the Derived Class. A derived class can have only one direct base class, however, inheritance is transitive.

##### Polymorphism:

Polymorphism enables you to present the same interface for differing operations, even though they operate on different data types. A derived class can override members of its base class which use the Virtual or abstract keyword and define new behaviour.



##### Interfaces:

An Interface contains definitions for a group of related functionalities that a non-abstract class or a struct must implement (Contract). An interface may define static methods, which must have an implementation and it may define a default implementation for members. An interface cannot declare instance data such as fields, auto-implemented properties, or property-like events.