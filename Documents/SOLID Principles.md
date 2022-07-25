## SOLID Principles

The SOLID Principles are five principles of Object-oriented Programming class design. They are a set of rules and best practices to follow while designing a class structure.

#### Single Responsibility Principle:

Every object should have a single responsibility and all of its services should be aligned with that responsibility, this responsibility should be encapsulated within the object.

#### Open-Closed Principle:

Software entities such as classes, modules, and functions, should be open for extension but closed for modification. It is often better to make changes to classes by adding to or building on top of them, using subclasses or polymorphism, rather than modifying their code.

#### Liskov Substitution Principle:

Subclasses should substitute classes from which they are derived without breaking the program.

#### Interface Segregation Principle:

States that clients(Classes) should not be forced to depend on methods they do not use. If a class exposes many members who can be broken down into groups that serve different clients, you should consider creating separate interfaces for those members.

#### Dependency Inversion Principle:

High-level modules(Back-end) should not depend on Low-level modules(UI), but both should depend on shared abstractions. In addition, abstractions should not depend on details instead, details should depend on abstractions.