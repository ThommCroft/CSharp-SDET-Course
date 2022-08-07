## MOQ



Moq (Pronounced Mock) is a framework that allows you to simulate dependencies at test time and monitor how the system under test interacts with them under various circumstances. Moq works by:

- In the test class, create a Moq instance for each dependency that the system under test relies on.
- Configure the Moqs various expectations and tell it what values to return under what circumstances.
- Inject those Moq instances when creating the system under test.
- Ask Moq to verify that all of its expectations were met.

