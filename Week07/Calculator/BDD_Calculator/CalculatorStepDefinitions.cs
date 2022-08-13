using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using CalculatorLib;

namespace BDD_Calculator
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private Calculator _calculator;
        private int _result;

        private Exception _exception;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [Given(@"I enter (.*) and (.*) in the calculator")]
        public void GivenIEnterAndInTheCalculator(int a, int b)
        {
            _calculator.Num1 = a;
            _calculator.Num2 = b;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _result = _calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide() // This logic should be in the Divide Method
        {
            try
            {
                _result = _calculator.Divide();
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
        }

        [Then(@"a DivideByZero Exception should thrown")]
        public void ThenADivideByZeroExceptionShouldThrown()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide());
        }

        [Then(@"the exception should have the message ""([^""]*)""")]
        public void ThenTheExceptionShouldHaveTheMessage(string expectedMessage) // Use a helper method from the Calculator class
        {
            Assert.IsNotNull(_exception);
            Assert.That(_exception.Message, Is.EqualTo(expectedMessage));
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }
    }
}
