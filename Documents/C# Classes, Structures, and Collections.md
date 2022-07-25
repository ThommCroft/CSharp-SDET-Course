## C# Classes, Structures, and Collections



#### Class:

Class and Object are the basic concepts of Object-oriented Programming that revolve around real-life entities. A class is a user-defined blueprint from which objects are created. A class combines the fields and methods into a single unit. In C# classes support Polymorphism, Inheritance and provide the concept of derived and base classes.

#### Structures (Struct):

A Structure is a value type that encapsulates data and its related functions. Structure types have value semantics, that is, a variable of a structure type contains an instance of the type. By default, variable values are copied on assignment passing an argument to a method and returning a method result. For structure type variables, an instance of the type is copied. You use Structure types to design small data-centric types that provide little or no behaviour, for example, .NET uses Structure types to represent a number (Integer and Real), a Boolean value, a Unicode character, and a time instance.

#### Collections:

Collection classes are specialised classes for data storage and retrieval. These classes provide support for Stacks, Queues, Lists, and Hash Tables. Most collection classes implement the same interfaces. Collection classes serve various purposes, such as allocating memory dynamically to elements and accessing a list of items on the basis of an index. These classes create collections of Objects of the Object class, which is the base class for all data types in C#.

- ##### Array List:

  - Represents an ordered collection of an object that can be indexed individually. This is an alternative to an Array. However, unlike an Array, you can add and remove items from the list at a specified position using an index and the array resizes itself automatically. It also allows dynamic memory allocation, adding, searching, and sorting items in the list.

- ##### Hash table:

  - Uses a key to access the elements in the collection. A hash table is used when you need to access elements by using a key to identify a useful key value. Each item in the hash table has a Key/ Value pair. The key is used to access the items in the collection.

- ##### Sorted List:

  - Uses a key as well as an index to access the items in a list. A Sorted List is a combination of an array and a hash table. It contains a list of items that can be accessed using a key or an index. If you access items using an index, it is an Array List, and if you access items using a key, it is a Hash Table. The collection of items is always sorted by key value.

- ##### Stack:

  - Represents a Last-in, First-out collection of objects. Stacks are used when you need LIFO access to items. When you add an item to the list, it is called pushing and when you remove an item, it is called popping.

- ##### Queue:

  - Represents a First-in, First-out collection of Objects. Queues are used when you need FIFO access to items. When you add an item to the list, it is called enqueue and when you remove an item, it is called dequeue.

- ##### Bit Array:

  - Is a Binary representation of an array of values, 1 and 0. Bit Array is used when you need to store bits but do not know the number of bits in advance. You can access items from the Bit Array collection by using an integer index, which starts from zero.



#### Value Types:

Value type variables can be assigned a value directly. They are derived from the class System.Value.Type. The value types directly contain data, some examples are Integer, Character and Float, which store numbers, alphabets and floating point numbers, respectively. When you declare an integer type, the system allocates memory to store the value.



#### Reference Types:

Reference Types do not contain the actual data stored in a variable, but they do contain a reference to the variables. Reference Types refer to a memory location. Using multiple variables, the reference types can refer to a memory location, if the data in the memory location is changed by one of the variables, the other variable automatically reflects this change in value. Examples of built-in reference types are; Object, Dynamic and String.