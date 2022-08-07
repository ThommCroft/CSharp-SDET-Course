## ISTQB



#### 1.  The Fundamentals of Testing

##### Testing Objectives:

- Find and prevent defects
- Reduce the risk of software failure in operation
- Gain confidence about the level of quality
- Provide information for decision making
- To provide sufficient information to stakeholders to allow them to make informed decisions, especially regarding the level of quality of the test object.
- To reduce the level of risk of inadequate software quality, e.g. undetected failures occurring in operation
- To comply with contractual, legal, or regulatory requirements or standards, and/ or to verify the test object's compliance with such requirements or standards

##### Quality Assurance and Testing

###### Quality Management:

Ties testing and Quality Assurance together. Includes both Quality Assurance and Quality Control.

###### Quality Control:

Involves various activities, such as test activities that support the achievement of appropriate levels of quality. Test activities are part of the overall software development or maintenance process. Since Quality assurance is concerned with the proper execution of the entire process, Quality Assurance supports proper testing.

###### Quality Assurance:

Is typically focused on adherence to proper processes, as to provide confidence that the appropriate levels of quality will be achieved (i.e. Processes to prevent possible bugs during software development). When processes are carried out properly, the work products created by those processes are generally of higher quality, which contributes to defect prevention. In addition, the use of root cause analysis to detect and remove the causes of defects, along with the proper application of the findings of retrospective meetings to improve processes, is important for effective quality assurance.

###### Testing:

Is a way of checking that the way the system operates is correct and finding possible defects. Testing enables customers the possibility to see if the developed product meets their expectations on its design, compatibility, functionality, etc.

##### Debugging vs Testing

###### Debugging:

Debugging is used by developers to identify the cause of bugs or defects in code and correct them.

###### Testing:

Testers systematically explore a component or system with the main aim of finding and reporting defects.

##### Errors, Defects, Failures

A person can make an error (mistake), which leads to the introduction of a defect (fault or bug) in the software code or in some other related work product. If the defect in the code is executed this can lead to a failure.

##### Root Cause Analysis

By identifying the defect early in the life cycle, it is a lot easier to identify why it was there in the first place.

##### Principles of Testing

- Testing shows the presence of bugs, not the absence of bugs
- Exhaustive testing is important
- Early Testing
- Defect Clustering
- The pesticide paradox
- Testing is context dependant
- Absence of errors fallacy

##### Test Basis, Conditions, Cases, Procedures & Suite

- Test Basis: The body of knowledge used as the basis for test analysis and design
- Test Conditions: An aspect of the test basis that is relevant to achieving specific test objectives
- Test Case: A set of pre-conditions, inputs, actions (where applicable), expected results and past conditions, developed based on test conditions.
- Test Procedure: A sequence of test cases in execution order, and any associated actions that may be required to set up the initial pre-conditions and any wrap-up activities post-execution. Also referred to as "Test Script".
- Test Suite: A set of test scripts or test procedures to be executed in a specific test run.

##### Testing's Contributions to Success

- Having testers involved in requirements review allows early detection of defects in work products.
- Having testers work closely with system designers while the system is being designed can increase each party's understanding of the design and how to test it.
- Having testers work closely with developers while the code is under development can increase each party's understanding of the code and how to test it.
- Having testers verify and validate the software before release can detect failures that might otherwise have been missed.

##### The Psychology of Testing

Identifying defects during a static test such as a requirements review or user story refinement session, or identifying failures during dynamic test execution, may be perceived as criticism of the product and of its author. An element of human psychology called confirmation bias can make it difficult to accept information that disagrees with currently held beliefs.

##### Traceability between Test Basis and Test Work Products

For effective test monitoring and control (TMC), it is important to establish and maintain traceability throughout the test process between each element of the test basis and the various test work products associated with that element. In addition to the evaluation of test coverage, good traceability supports:

- Analysing the impact of changes
- Making testing auditable
- Meeting IT governance criteria
- Improving the understandability of test progress reports and test summary reports to include the status of elements of the test basis (e.g. requirements that passed their tests, requirements that failed their tests, and requirements that have pending tests).
- Relating the technical aspects of testing to  stakeholders in terms that they can understand
- Providing information to assess product quality, process capability, and project progress against business goals

##### The Test Process

There is no one universal software test process, but there are common sets of test activities without which, testing will be less likely to achieve its established objectives.

###### Test Planning (TP)

Define the objectives of testing and the approach that will be taken, specifying suitable test techniques and tasks, who does what, create test schedules for meeting a deadline, and define exit criteria (Test completion criteria).

Work Products:

- Test Plans
- Test Schedule

###### Test Monitoring & Control (TMC)

Monitoring involves the ongoing comparison of actual progress against the test plan using test monitoring metrics defined in the test plan. Control is any necessary action taken if there are any deviations (e.g. more tests may be needed). Supported by the evaluation of the exit criteria (Definition of Done).

Looking at exit criteria for test evaluation for a stage of testing may include:

- Check test results to see if the required test coverage has been achieved
- Determining the component or system quality, by looking at both test results and test logs
- See if more tests are required (e.g. if there are not enough tests to reach the level of risk coverage that is required).

Work Products:

- Test Progress Reports
- Test Summary Reports

###### Test Analysis (TA)

What is going to be tested?

Analyse test basis to identify testable features and define associated test conditions (i.e. what are we going to test in terms of measurable coverage criteria). Sometimes, test conditions produced as part of test analysis are used as test objectives in test charters.

Work Products:

- Test Conditions (Prioritised)
- Test Charters

###### Test Design (TD)

How to test

Design and prioritise test cases. Identify test data to support said test cases (derived from test conditions), identify test data to be used with test cases, design test environment, and capture bi-directional traceability between the test basis, test conditions, test cases and test procedures. Test conditions are further refined.

Work Products:

- Test cases and sets of test cases to exercise the test conditions defined in test analysis.
- Test data design/ identification
- Test environment design

###### Test Implementation (TI)

Is everything in place so that we can test?

Test design and test implementation tasks are often combined. Creating and prioritising test procedures, creating test suites from the test procedures, arranging the test suites within a test execution schedule, building the test environment, preparing test data, checking and updating the bi-directional traceability between the test basis, test conditions, test cases, test procedures and now include test suites.

Work Products:

- Test procedures and the sequencing of those test procedures
- Test Suites
- Creation and verification of the test environment and test data
- A test execution schedule

###### Test Execution (TE)

Executing tests and logging results.

Record the identification of what is being tested (e.g. test items or test objects, etc.). Comparing actual results with expected results, logging and reporting defects, analysing anomalies to establish their likely causes, retest and/ or regression test when defects have been corrected, repeating test activities either as a result of actions taken for an anomaly, or as part of the planned testing.

Work Products:

- Documentation of the status of individual test cases or test procedures (e.g. ready to run, pass, fail, blocked, deliberately skipped, etc)
- Defect report documentation

###### Test Completion (TC)

Collect data from completed test activities.

Finalising and archiving the test environment, test data, test infrastructure, and other testware for later reuse. Ensure defect reports are closed as necessary, analyse discrepancies to determine their cause, and hand over the testware to the maintenance teams, and lessons learnt (improve future tests).

Work Products:

- Test summary reports (for project stakeholders)
- Actionable items for improvement in subsequent projects (Lessons learnt)
- Finalised testware

