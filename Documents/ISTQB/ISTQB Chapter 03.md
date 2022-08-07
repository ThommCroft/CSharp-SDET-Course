## ISTQB

#### 3. Static Testing

##### Benefits of Static Testing:

Static testing (as opposed to dynamic testing) is a key principle of Early Testing. There is less chance of defects, reduced time and cost, and improved communication. It is also an important part of Security Testing. Testers need to have access to the documentation as soon as possible.

##### Defects found are easier to fix using Static testing:

Requirement defects (e.g. Inconsistencies, Ambiguities, Omissions, Inaccuracies and Redundancies), always validate user requirements early.

Design defects (e.g. Inefficient algorithms or database structures).

Coding defects (e.g.  Unreachable code, Duplicate code).

Deviations from Standards (e.g. Lack of adherence to coding standards).

Incorrect Interface Specifications (e.g. Different units of measurement used by the calling system than by the called system).

Security vulnerabilities (e.g. Susceptibility to buffer overflows).

Gaps or Inaccuracies in Test Basis, Traceability or Coverage (e.g. Missing tests for an acceptance criterion).

Maintainability defects (e.g. Improper modularisation, Poor reusability of components, Code that is difficult to analyse and modify without introducing new defects).

##### Review Types:

###### Informal

- No formal process.
- Not usually documented
- An inexpensive way to achieve limited benefits
- Maybe implemented as pair programming
- Checklists are optional

###### Walkthrough

- Led by the author of the document
- Prior preparation by reviewers
- Can vary widely in practice from formal to informal.
- The main purpose is to enable learning
- Scribe is mandatory
- Checklists are optional

###### Technical Review

- Gain consensus
- Prior preparation by individuals
- Scribe is mandatory
- Checklists are optional
- Usually performed as a peer review
- Led by facilitator/ moderator
- Checklists are optional
- Can also vary widely from formal to informal

###### Inspection

- Based on rules
- Checklist
- Entry and exit criteria
- Prior preparation is essential
- The main purpose is to find defects but secondary maybe process improvement
- Led by a trained facilitator/ moderator
- Metrics are collected and used for the improvement of the software development process

##### Review Meetings:

Occur during tech/ peer reviews and inspections.

###### Planning

- Define review criteria
- Define exit criteria
- Checking entry criteria
- Define roles
- Select personnel

###### Initiate Review

- Distributing documents
- Explain objectives
- Process
- Documents for Individual review

###### Individual Review (AKA preparation)

- Actual review
- Issues are recorded

###### Issue Communication and Analysis

- Note defects
- Evaluate issues
- Make decisions on this information

###### Fixing and Reporting

- Fix defects and record the updated status of defects
- Gather metrics
- Check if defects have been dealt with

##### Review Attendees:

###### Review Leader

- Responsible for the review and deciding who is going to be invited and where the meeting will take place.

###### Facilitator/ Moderator

- Mediates reviews and ensures the effective running of the review.

###### Management

- Plans and decides the execution of the reviews. Determines whether the review process objectives have been met and assigns staff and budget. Monitors costs and controls decisions.

###### Scribe

- Collates potential defects found during the individual review activity. Records new potential defects, open points, and decisions from the review meeting (when held).

###### Author

- Creator of the document in review. Helps with the understanding of the defects.

###### Reviewers

- Maybe SMEs, Stakeholders, etc. Identify potential defects in the work under review. May represent different perspectives (e.g. Testers, Programmers, BAs etc).

##### Applying Review Techniques:

###### Ad hoc

- Reviewers are given little/ no guidance. Little preparation is required. Go through work products sequentially to identify defects. Depends on review skills and may lead to duplicate issues being reported by different reviewers.

###### Checklist-based

- Systematic coverage of typical defects as effects detected based on the checklist. The checklist consists of a set of questions based on the potential defects, which may be derived from experience. The checklist is sent out at the review initiation by the facilitator.

###### Scenarios and Dry Runs

- Reviewers are provided with structured guidelines on how to read through the work product. They support the reviewers in performing the Dry Runs on the work product based on the expected usage of the product (if the work product is documented in a suitable format such as use cases).

###### Role-based

- Reviewers evaluate the product from the perspective of the individual stakeholder roles. Typical roles include specific end-user types (experienced, inexperienced, senior, child, etc), and specific roles in the organisation (user, administrator, system administrator, performance tester, etc).

###### Perspective-based

- Similar to Role-based. Requires the reviewers to attempt to use the work product under review to generate the product they would derive from it. For example, a tester would attempt to generate a draft acceptance test if performing a perspective-based reading on the requirements specification to see if all the necessary information was included. Further, in perspective-based reading, checklists are expected to be used. Most effective review technique.

##### Success Factors for Reviews:

###### Organisational Success Factors

- Participants have time to prepare clear objectives, checklists updated, scheduled on time, management support, and large documents reviewed in small pieces so the author is provided with early and frequent feedback on the defects (Quality Control exercised).

###### People-related Success Factors

- The right people present, adequate training provided (especially for more formal reviews), tester valued as a reviewer, culture of learning is promoted.

