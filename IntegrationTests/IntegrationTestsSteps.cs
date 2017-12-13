using System;
using CalculatorBusinessLogic;
using CalculatorLogic;
using CalculatorParsing;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace IntegrationTests
{
    [Binding]
    public class IntegrationTestsSteps
    {
        private string input;
        private string result;
        static readonly Calculation calculation = new Calculation();
        static readonly Parsing parsing = new Parsing();
        SequenceLogic testee = new SequenceLogic(parsing, calculation);

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string input)
        {
            this.input = input;
        }

        [When(@"I press Calculate")]
        public void WhenIPressCalculate()
        {
            this.result = this.testee.Calculate(this.input);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string expectedResult)
        {
            this.result.Should().Be(expectedResult);
        }

        [Then(@"the result should be null")]
        public void ThenTheMessageShouldBeOnTheMessagebox()
        {
            this.result.Should().Be(null);
        }
    }
}
