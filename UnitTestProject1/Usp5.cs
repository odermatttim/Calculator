using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBusinessLogic;
using CalculatorBusinessLogic.Fakes;
using CalculatorParsing;
using CalculatorParsing.Fakes;
using CalculatorUI;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParsingUnitTests
{
    [TestClass]
    public class Usp5
    {
        private StubIParsing parsingStub;
        private StubICalculation calculationStub;
        private CalculatorViewModel testee;
        private Collection<double> operandsCollection;
        private Collection<char> operatorsCollection;
        private string expectedErrorMessage;
        private const int irrelevantCalculationResult = 0;

        [TestInitialize]
        public void SetUp()
        {
            this.parsingStub = new StubIParsing();
            this.calculationStub = new StubICalculation();
            this.testee = new CalculatorViewModel(this.parsingStub, calculationStub);
        }

        [TestMethod]
        public void OptionOneValid()
        {
            operandsCollection = new Collection<double> { 4.395, 6 };
            operatorsCollection = new Collection<char> { '+' };
            expectedErrorMessage = string.Empty;

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "4.395 + 6";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Be(expectedErrorMessage);
        }

        [TestMethod]
        public void OptionTwoValid()
        {
            operandsCollection = new Collection<double> { 2, 6.43, 3 };
            operatorsCollection = new Collection<char> { '+', '-' };
            expectedErrorMessage = string.Empty;

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "2 + 6.43 - 3";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Be(expectedErrorMessage);
        }

        [TestMethod]
        public void OptionOneInvalid()
        {
            operandsCollection = new Collection<double> { 4.395, 6 };
            operatorsCollection = new Collection<char>();
            expectedErrorMessage = testee.ErrorMessages[1];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "4.395 6";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Contain(expectedErrorMessage);
        }

        [TestMethod]
        public void OptionTwoInvalid()
        {
            operandsCollection = new Collection<double> { 4.395 };
            operatorsCollection = new Collection<char> { '+' };
            expectedErrorMessage = testee.ErrorMessages[1];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "4.395 +";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Contain(expectedErrorMessage);
        }

        [TestMethod]
        public void OptionThreeInvalid()
        {
            operandsCollection = new Collection<double>();
            operatorsCollection = new Collection<char> { '-', '+' };
            expectedErrorMessage = testee.ErrorMessages[1];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "- +";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Contain(expectedErrorMessage);
        }
    }
}
