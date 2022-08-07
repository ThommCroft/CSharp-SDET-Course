## ISTQB

#### 2. Life Cycles

##### Characteristics of Good Testing in Software Development Life Cycles

- There is a corresponding test activity for every development activity.
- Each test level has a specific objective.
- Test analysis and design for a given test level begin during the corresponding development activity.
- Testers participate in discussions regarding defining and refining requirements and design and review work products as soon as drafts are available (Principles of early testing).

##### Sequential Life Cycles:

###### Waterfall:

pros:

- Enforces discipline at each stage
- Has a defined start and end
- Progress can be easily identified
- Emphasis on requirements before code is written means no time wasted and can improve quality

Cons:

- Estimations of time/ cost will be difficult
- Requirements (there for tests) will change
- Division of labour is unrealistic
- What was asked to be created may not be feasible

###### V-Model

Pros:

- Higher chance of success as test plans are developed earlier
- Defects are found earlier
- Works very well on smaller projects

Cons:

- Quite rigid in execution
- No early prototype
- Test documents have to be updated along the way

Important: There is also a 5th Testing Level in the V-Model, System Integration Testing

##### Incremental Life Cycles:

###### AGILE (e.g. Scrum, Kanban, RUP, Spiral)

Pros:

- Small and frequent improvements
- Fast Development
- Team skill improvement

Cons:

- Light documentation
- Formal records of change may not be created
- Regression testing may get out of control

##### Test Levels:

###### Unit

Tests individual units or pieces of code for a system

- Test Driven Development

###### Integration

Tests are performed to ensure that two modules operate together correctly

- Incremental:
  - Top Down (using stubs)
  - Bottom Up (using drivers)
  - Hybrid
- Big Bang Testing

###### System

Tests systems end-to-end. Requires controlled environment.

- Functional & Non-functional tests

###### Acceptance

Tests are performed to determine whether the product indeed satisfies its specifications and user story requirements.

- Alpha Testing
  - Pre-release of the product is tested by the end-user on the developers' site
- Beta Testing
  - Pre-release of the product is tested by the end-user on the users' site

- Contract & Regulation Acceptance Testing
- Operational Acceptance Testing

| Test Level  |                          Test basis                          |                     Typical Test Objects                     |                 Typical Defects and Failures                 |
| :---------: | :----------------------------------------------------------: | :----------------------------------------------------------: | :----------------------------------------------------------: |
|    Unit     | Code, Data Models, Detailed Design, Component Specification. | Components, Units or modules, Code and data structures, Classes, Database modules. | Incorrect functionality, data flow problems, and Incorrect code and logic. |
| Integration | Software and system design, Sequence diagrams, Interface and communication protocol specifications, Use cases, Architecture at the component or system level, Workflow, and External interface definitions. | Subsystems, Databases, Infrastructure, Interfaces, APIs, Microservices. | Inconsistent message structures between systems, Incorrect data, missing data, incorrect data encoding, Interface mismatch, Failures in communication between systems and Unhandled or improperly handled communication failures between systems. |
|   System    | System and software requirement specifications, Risk analysis reports, Use cases, Epics and user stores, Models of system behaviour, State diagrams, and System and user manuals. | Applications, Hardware/ software systems, Operating systems, Systems under test, System configuration and configuration data. | Incorrect calculations, Incorrect or unexpected system functional or non-functional behaviour, Incorrect control and/ or data flows within the system, Failure to properly and completely carry out end-to-end function tasks, Failure of the system to work properly in the production environment, and Failure of the system to work as described in the system and user manuals. |
| Acceptance  | Business processes, User or business requirements, Regulations, Legal contracts and standards, Use cases, System or user documentation, Installation procedures, and Risk analysis reports. | The system under test, System configuration and configuration data, Business processes for a fully integrated system, Recovery systems and hot sites, Operational and maintenance processes, Forms, Reports, and Existing and converted production data. | System workflows do not meet business or user requirements, Business rules are not implemented correctly, System does not satisfy contractual or regulatory requirements, Non-functional failures such as security vulnerabilities, inadequate performance efficiency under high loads, or improper operations on a supported platform. |

##### Test Types:

###### Functional

Looks at the specific functionality of a system. Also called Specification-based Testing and Black-box Testing. Can be performed at all test levels.

- Smoke Testing
- Sanity Testing
- Suitability Testing
- Accuracy Testing
- Compliance Testing

###### Non-functional

Testing of the quality characteristics of the components or system. Can make use of Black-box Testing. Can be performed at all test levels.

- Efficiency Testing
- Maintainability Testing
- Load Testing
- Performance Testing
- Compatibility Testing
- Scalability Testing
- Stress Testing
- Security Testing

###### Structural

How the code makes the functionality work. Also called White-box Testing. Can be performed at all test levels.

- Statement Coverage
- Decision Coverage

###### Change Related

Carried out after a defect has been fixed. Can be performed at all test levels.

- Regression Testing
- Re-testing

##### Change Related Testing:

###### Confirmation Testing (AKA Re-testing)

After a defect has been fixed, the software should be re-tested to confirm that the original defect has been removed.

###### Regression Testing

- Carried out on every other part of the system to check that a fixed defect hasn't changed other parts of the system.
- Repeated testing of already tested programs
- Performed when the software or the environment is changed
- Based on risk
- Regression testing is used in agile and is automated
- Regression test suites are run many times and generally evolve slowly, so regression testing is a strong candidate for automation. Automation of these tests should start early in the project.

###### What is Change-Related Maintenance Testing?

- It is testing that is done on a system in a live environment when software has undergone:
  - Modification
  - Migration
  - Retirement
  - Hotfixes
- It is very high risk
- Impact analysis (Risk) and metrics from previous projects are very important in this area:
  - They help estimate the amount of re-testing and regression testing
  - What are the possible consequences?
  - What are will remain unchanged?

