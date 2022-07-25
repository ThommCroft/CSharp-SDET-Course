## Code Refactoring and Code Smells



#### Refactoring

Refactoring is the purpose of modifying the structure of your code without changing its behaviour. Refactoring is done to improve the design by making it easier to read and understand, eliminating duplicated or redundant code and making it easier to maintain. Before refactoring you need to test your code to make sure it passes, commit it to a Repo as a backup and then confidently change your code knowing you can revert back to the older version.

You should only refactor your code when:

-  Code is hard to understand 
- When duplication exists
- Before adding new functionality
- When adding new behaviour is not possible without major changes to the existing code
- From code reviews

You should not refactor code when:

- You are close to a deadline
- When the program, or method needs a complete re-write



#### Code Smells

A code smell is any characteristic in the code of a program that possibly indicates a problem. Determining what is and is not a code smell is subjective and varies by language, developer and development methodology.

Code Smells include:

- Dead code
- Duplicate code
- Inappropriate names for variables, classes and methods
- Large classes
- Long method parameter lists
- A class that is feature envy, usually means a new class needs to be created
- Data clumps
- Repeated Switch/ If-Else Statements