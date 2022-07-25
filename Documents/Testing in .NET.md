## Testing in .NET

Automated testing is a great way to ensure that application code is working in the way the creator intended. There are a few different ways to test the code of an application, these include, Unit Tests, Integration Tests and Load Tests.



#### Unit Tests

A Unit Test is a test that exercises individual components or methods, also known as a Unit of Work. Unit tests should only test the code within the developer's control. They do not test infrastructure concerns, such as interacting with databases, file systems, and network resources.

#### Integration Tests

An Integration Test differs from a unit test in how it exercises two or more components' ability to function together, also known as their "Integration". These tests operate on a broader spectrum of the system under test, whereas unit tests focus on individual components. Often, integration tests do include infrastructure concerns.

#### Load Tests

A Load Test aims to determine whether or not a system can handle a specified load, for example, the number of concurrent users using an application and the application's ability to handle interactions responsively.



#### Testing Considerations

There are best practices for writing tests that need to be followed. For example, Test Driven Development (TDD) is when a unit test is written before the code it's meant to check. TDD is like creating an outline for a book before you write it. It is meant to help developers write simpler, more readable, and efficient code.

Tests need to cover both good and bad paths to make sure the methods are giving the correct results.

Your main focus is Automated Unit Tests (70%), then Automated API, Integration and Component Tests (20%), and finally, Automated GUI Tests (10%).

Lay your testing methods out in the following pattern:

- Arrange - Declare the class a method is being tested from.
- Act - Call the method to be tested.
- Assert - Perform the test on the method.



#### FIRST

- Fast - The test should run fast.
- Isolated - The test should not rely on other tests (Stand-alone).
- Repeatable - The test should always give the same result no matter who is using the test.
- Self-checking - You do not need to check the results manually, the test is automatic.
- Timely (Thorough) - It should not take long to make the test and it should cover all edge cases.