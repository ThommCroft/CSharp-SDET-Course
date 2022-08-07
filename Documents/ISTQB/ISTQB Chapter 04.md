## ISTQB

#### 4. Test Design Techniques

##### Test Design Process:

- Identify Test Conditions
- Specify Test Cases
- Specify Test Procedures

##### Key Terms:

###### Test Plan

- A document describing the scope, approach, resources and schedule of intended test activities.

###### Test Design Specification

- Specifies the test conditions for a test item, and the detailed test approach and identifies the associated high-level test cases.

###### Test Basis/ Base

- The body of knowledge which is used as the basis for test analysis and design.

###### Test Condition

- An aspect of the test basis that is relevant to achieving specific test objectives. Roughly defined as the aim/ goal of a certain test.

###### Test Case

- A set of preconditions, inputs, actions (where applicable), expected results and postconditions, developed based on test conditions.

###### Test Suite

- A set of test cases or test procedures to be executed in a specific test cycle.

###### Test Data

- Data created or selected to specify the execution preconditions and inputs to execute one or more test cases.

###### Test Coverage

- The degree to which specified coverage items have been determined or have been exercised by a test suite is expressed as a percentage, or simply, the percentage of test cases in the suite carried out.

###### Test Charter

- Documentation of the test activities in session-based exploratory testing.

###### Test Oracle

- A source to determine an expected result to compare with the actual result under test. E.g. the existing system (for a benchmark), other software, user manuals, or an individual's specialised knowledge, but should not be the code.

##### Black-box Testing

###### Smoke and Sanity Checks

- Smoke Tests check the system's health and do not aim to find defects. Verifies critical functions such as does this computer turn on without going up in flames.
- Sanity Tests make sure the bugs reported in previous builds are fixed before the release and before a regression test. Verifies new functionality.

###### Decision Table Testing

A decision table lists all the input conditions that can occur as boolean values and all the actions that can arise from them. Test cases can be derived from these tables.

###### Equivalence Class Partitioning/ Boundary Value Analysis

Equivalence Class Partitioning and Boundary Value Analysis share similarities and are sometimes used in tandem for better test coverage.

Equivalence Class Partitioning (ECP):

Sometimes it is impossible to test all values where there is a range in the input field. To overcome this, we can divide the data into equivalence classes and subsequently a test case can be designed for each equivalence class. This ensures we still have optimal test coverage without the need to excessively test.

Boundary Value Analysis (BVA):

BVA explores the boundary conditions of a program as more errors occur at the boundaries. As with ECP, data is divided into equivalence classes. Each boundary has a valid boundary value and an invalid boundary value.

###### State Transition Testing

When a system is represented as being in one state and transitioning from that state to another. The transformations are determined by the rules of the system. This means we can follow these rules to create a diagram that represents the change of transitions and thus a test to see if it works.

- States - How something exists at that time (TV On/ Off/ Standby)
- Transitions - The change from one state to another
- Input or Events - e.g. Press the power to off via a remote control
- Actions - The action that can result from a transition (able to watch TV)

###### Use Case Testing

Use cases describe actions between actors and systems. Step-by-step test cases are derived from use cases. For each Use Case:

- Actors - Whoever or whatever expects the service from the system
- Use cases - Shown as ovals and represents a function the system will perform as a response to a trigger from an actor
- Systems Boundary - A box around all the use cases. Helps to agree on the scope of the system.
- Associations - The lines that link actors to use cases. EXTEND: Next step is optional, INCLUDE: Next steps must be included.

##### White-box Testing

###### Decision and Statement Coverage

Decision (branch) Coverage (DC):

- Check if each possible branch from a decision point has been executed at least once.
  - I.e. the total number of test cases required to ensure each one of the possible branches from each decision point is executed at least once.

Decision condition Testing:

- A white-box test design technique in which test cases are designed to execute condition outcomes and decision outcomes.

Statement Coverage (SC):

- Check if each statement in the code has been executed at least once.
  - I.e. the total number of test cases required to execute each node at least once.

Statement Testing:

- A white-box test design technique in which test cases are designed to execute statements.

###### Finding out the DC and SC from Code and Pseudocode

Pseudocode is a simplified version of regular code that can be understood by those who are not familiar with coding languages.

From pseudocode control flows can be more easily created and from this, the number of test cases for total SC and DC for the code under test can be calculated.

##### Experienced Based Testing

###### Error Guessing

Error Guessing is a test design technique where the experience of the tester is used to anticipate what defects might be present in the component or system under test as a result of errors made, and to design tests specifically to expose them.

- Defect and Failure Lists
  - Can help identify areas that are susceptible to problems.
- Fault Attack
  - This approach is to list possible errors and design tests around them.

###### Exploratory Testing

An informal and reactive test design technique where the tester actively controls the design of the tests as those tests are performed and use information gained while testing to design new and better tests. Avoids Pesticide Paradox.

- Advantages:
  - It does not require much preparation
  - Useful when there is time pressure, lack of resources or inadequate specs
  - Testers report a large proportion of bugs via this method
- Disadvantages:
  - There is no review of testing planning, an experienced user of the system may not be an experienced tester.
  - Testers have to remember the exact steps they took to create a defect, otherwise, the reproduction may be difficult

###### Checklist-based Testing

Testers design, implement, and execute tests to cover test conditions found in a checklist.

As part of the analysis, testers create a new checklist or expand an existing checklist, but testers may also use an existing checklist without modification. Such checklists can be built based on experience. Checklists can be created to support various test types, including Functional and Non-functional Testing.

In the absence of detailed test cases, checklist-based testing can provide guidelines and a degree of consistency.