## ISTQB

#### 5. Test Management

##### Test Organisation:

###### Roles within a Project Team

- Project Manager
- Quality Assurance manager
- Developers
- Business and Domain Experts (SME, Business Analyst)
- Infrastructure personnel (Database Designers, etc.)
- IT Operations (Help Desk, Merge Functionality, etc.)
- Tester
- Test Manager

###### Test Manager vs Tester

The Tester does the tests and the Test Manager leads and reports.

Test Manager:

- Can take many forms such as Project Manager, Development Manager, QA Manager, Manager of Test Group
- Develop or review a test policy and test strategy for the organisation. Manage costs and time.
- Plan the test activities and understand test objectives
- Write and update Test Plans
- Initiate the analysis, design, implementation, and execution of tests monitors test progress and results and check the status of the exit criteria
- Create Test progress reports for stakeholders
- Introduce suitable metrics for measuring test progress and evaluating the quality of the testing and the product
- Creates decisions on the implementation of test environments
- Supports the selection and implementation of tools to support the test progress

Tester:

- Can take many forms such as Developer, Business Analyst, User, SME, and Specialists
- Analyse, Review, and access requirements, User Stories and acceptance criteria, specifications, and models for testability
- Reviews and contributes to the test plans
- Designs and implements test cases and test procedures and create test data
- Creates test execution schedules
- Executes tests, evaluates the results, and documents deviations from the expected results
- Designs and sets up, and verifies the test environments
- Uses appropriate tools to facilitate the test process

###### Independence

The more removed you are from the code, the less biased you will be when testing the code. There are several levels of independent testing within an organisation, these are:

- Developer
- Independent Testers within the development team
- Independent test team or group within the organisation
- Independent Testers from the business or user community
- Independent Test Specialists in usability, security, etc.
- Independent Testers external to the organisation

The advantages and disadvantages of having independent testers are:

Advantages:

- See defects that others who are closer to the project may not. They should be unbiased
- Can verify assumptions made during the specification and implementation phases

Disadvantages:

- Can be seen as not part of the project and suffer from isolation
- Can be easily blamed for delays and targeted as delivery bottlenecks
- Developers may no longer feel responsible for their mistakes

##### Test Planning and Estimation:

###### Purpose of a Test Plan

- Determine objectives, scope, and who is doing what
- Timescale and budget of a project
- Selecting metrics for test monitoring and control

###### Test Strategies

Analytical:

- Based on some type of analysis, e.g. Risk or Requirements-based

Model-based:

- Tests are designed based on some model of some required aspect of the product such as a function, a business process, an internal structure, or a non-functional characteristic

Methodological:

- Checklists and Failure-based

Process Compliant:

- Involves analysing, designing, and implementing tests based on external rules and standards, such as those specified by industry-specific standards

Reactive:

- Heuristic, exploratory testing, and exploratory techniques are usually used

Directed/ Consultative:

- Technology and/ or business domain experts outside or within the test team

Regression Averse:

- Highly automated. Avoids regression of existing capabilities

###### Entry and Exit Criteria

Entry and exit criteria should be defined for each test level and test type and will differ based on the test objectives.

Entry Criteria:

- Specific conditions or ongoing activities that must be present before a process can begin.
  - E.g. availability of the test environment

Exit Criteria:

- What conditions must be achieved to declare a test level or a set of tests complete.
  - E.g. Planned tests have been executed

###### Test Execution Schedule

A schedule for the execution of test suites within a test cycle. Test cases would be ordered to run based on their priority levels, usually, be executing the test cases with the highest priority first. However, this practice may not work if the test cases have dependencies or the features being tested have dependencies.

###### Factors Influencing Test Effort

- Product Characteristics (e.g. Test base quality, size of the product, product risks)
- Development Process Characteristics (e.g. Tools used, test approach, time)
- People Characteristics (e.g. Skills)
- Test Results (e.g. Number and severity of defects)

##### Test Monitoring and Control:

###### Purpose of Test Reports

The purpose of test reporting is to summarise and communicate test activity information, both during and after the test activity (e.g. Test Level).

###### Test Progress Reports:

- Summary of tests performed
- What occurred during a test period
- Deviations from the plan
- Status of testing and product quality for the exit criteria or definition of done
- Factors that have blocked or continue to block progress
- Metrics of defects, test cases, test coverage, activity progress, and resource consumption
- Residual risks
- Reusable test work products produced

##### Configuration Management:

The purpose of configuration management is to establish and maintain the integrity of the products (components, data and documentation) of the software or system through the project and product life cycle. During the defect management process, some of the reports may turn out to describe false positives, not actual failures due to defects.

For testing, configuration management may involve ensuring the following:

- All items of testware are identified, version controlled, tracked for changes, related to each other and related to development items (test objects) so that traceability can be maintained throughout the test process
- All identified documents and software items are referenced unambiguously in test documentation

For the tester, configuration management helps to uniquely identify (and reproduce) the tested item, test documents, the tests and the test harness(es).

During test planning, the configuration management procedures and infrastructure (tools) should be chosen, documented and implemented.

##### Defect Management:

Defect management is the process of recognising, investigating, taking action and disposing of defects. A defect is anything when the actual result is differing from the expected result. An example of the contents of a defect report can be found in ISO standards (ISO/ IEC/ IEEE 29119-3) called incident reports.

Defect reports include:

- Test incident report identifier and date
- Title and a short summary (include screenshot)
- Incident description (Expected results, Actual results, Anomalies, Date and Time, Procedure step, Attempts to repeat, Testers comments, Observers comments)
- Impact
- Urgency to fix
- State of the defect report (e.g. open, deferred, duplicate, waiting to be fixed, awaiting confirmation testing, re-opened, closed)
- Conclusions, recommendations and approvals

###### Risk Management

Risk:

- A factor that could result in future negative consequences is usually expressed as impact and likelihood

Risk Analysis:

- The process of assessing identified risks to estimate their impact and probability of occurrence (Likelihood)

Product Risk:

- The possibility that the system or software might fail to satisfy or fulfil some reasonable expectation of the customer, user, or stakeholder. (Some authors call Product Risk, Quality Risk). Affects the Quality of the product, I.e. software is not performing as intended

Project Risk:

- A risk related to management and control of the (test) project, e.g. lack of staffing, strict deadlines, changing requirements, political issues, supplier contract, etc.

Risk-based testing:

- Risk-based Testing is the idea that we can organise our testing efforts in a way that reduces the residual level of product risk (i.e. mitigate risk) when the system is deployed (e.g. tailor the test approaches, test coverage required, prioritise testing).

