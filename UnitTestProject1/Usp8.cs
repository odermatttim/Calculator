using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBusinessLogic;
using CalculatorBusinessLogic.Fakes;
using CalculatorLogic;
using CalculatorParsing;
using CalculatorParsing.Fakes;
using CalculatorUI;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParsingUnitTests
{
    [TestClass]
    public class Usp8
    {
        private StubIParsing parsingStub;
        private StubICalculation calculationStub;
        private CalculatorViewModel testee;
        private string expectedErrorMessage;
        private const int irrelevantCalculationResult = 0;
        
        [TestInitialize]
        public void SetUp()
        {
            this.parsingStub = new StubIParsing();
            this.calculationStub = new StubICalculation();
            this.testee = new CalculatorViewModel(this.parsingStub, this.calculationStub);
        }

        [TestMethod]
        public void ErrorMessageShowsFirstHint()
        {
            expectedErrorMessage = testee.ErrorMessages[0];
            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => new Collection<double> { 1.5, 2 };
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => new Collection<char>();
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1.5 2";
            testee.StartCalculation();

            // Assert
            testee.ErrorMessage.Should().Contain(expectedErrorMessage);
        }

        [TestMethod]
        public void ErrorMessageShowsSecondHint()
        {
            expectedErrorMessage = testee.ErrorMessages[1];
            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => new Collection<double> { 1.5 , 2, 4};
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => new Collection<char> {'+'};
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1.5 2 + 4";
            testee.StartCalculation();

            // Assert
            testee.ErrorMessage.Should().Contain(expectedErrorMessage);
        }
    }
}
