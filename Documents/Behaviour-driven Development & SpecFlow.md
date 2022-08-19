## Behaviour-driven Development & SpecFlow

### Behaviour-driven Development(BDD)

BDD is a software development process that puts the feature behaviours first. A behaviour is how a feature operates within a well-defined scenario of inputs, actions, and outcomes. Behaviours are identified using a specification of requirements. Behaviour specifications become the requirements, acceptance criteria, and acceptance tests where the testing framework can directly automate the specifications. The most popular BDD test frameworks are Cucumber derivatives that write specifications in Gherkin Language (GIVEN, WHEN THEN).

Gherkin Example:

```gherkin
GIVEN I am on the products page
WHEN I click a products add button
THEN the product is added to my cart
```

### SpecFlow

SpecFlow is a Behaviour-driven Development framework for .NET which boosts a project's productivity by helping you write feature files and automation code in an IDE using C# and .NET methods. SpecFlow uses the Gherkin language to make the product's behaviours readable for developers, testers and stakeholders.