using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorBusinessLogic;
using CalculatorBusinessLogic.Fakes;
using CalculatorParsing;
using CalculatorParsing.Fakes;
using CalculatorUI;
using FluentAssertions;
using Microsoft.QualityTools.Testing.Fakes.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParsingUnitTests
{
    [TestClass]
    public class Usp6
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
        public void ShowNoMessageboxOne()
        {
            operandsCollection = new Collection<double> { 1, 2 };
            operatorsCollection = new Collection<char> { '+' };
            expectedErrorMessage = string.Empty;

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1 + 2";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Be(expectedErrorMessage);
        }

        [TestMethod]
        public void ShowNoMessageboxTwo()
        {
            operandsCollection = new Collection<double> { 2, 3.5 };
            operatorsCollection = new Collection<char> { '-' };
            expectedErrorMessage = string.Empty;

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "2 - 3.5";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Be(expectedErrorMessage);
        }

        [TestMethod]
        public void ShowMessageboxOne()
        {
            operandsCollection = new Collection<double> { 1, 4, 2 };
            operatorsCollection = new Collection<char> { '-', '*' };
            expectedErrorMessage = testee.ErrorMessages[0];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1 - 4 * 2";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Contain(expectedErrorMessage);
        }

        [TestMethod]
        public void ShowMessageboxTwo()
        {
            operandsCollection = new Collection<double> { 1, 3 };
            operatorsCollection = new Collection<char> ();
            expectedErrorMessage = testee.ErrorMessages[1];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1 3";
            string errorMessage = testee.StartCalculation();

            // Assert
            errorMessage.Should().Contain(expectedErrorMessage);
        }
    }
}
