using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorBusinessLogic;
using CalculatorBusinessLogic.Fakes;
using CalculatorLogic;
using CalculatorParsing;
using CalculatorParsing.Fakes;
using CalculatorUI;
using FluentAssertions;
using Microsoft.QualityTools.Testing.Fakes.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
        private string expectedResult;
        private string result;
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
            operandsCollection = new Collection<double> {1, 2};
            operatorsCollection = new Collection<char> {'+'};
            expectedResult = "3";

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => double.Parse(expectedResult);

            // Act
            testee.UserInput = "1 + 2";
            result = testee.StartCalculation();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ShowNoMessageboxTwo()
        {
            operandsCollection = new Collection<double>{2, 3.5};
            operatorsCollection = new Collection<char>{'-'};
            expectedResult = "-1.5";

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => double.Parse(expectedResult);

            // Act
            testee.UserInput = "2 - 3.5";
            result = testee.StartCalculation();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ShowMessageboxOne()
        {
            operandsCollection = new Collection<double> { 1, 4, 2 };
            operatorsCollection = new Collection<char> { '-', '*' };
            expectedResult = testee.ErrorMessages[0];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1 - 4 * 2";
            testee.StartCalculation();

            // Assert
            testee.ErrorMessage.Should().Contain(expectedResult);
        }

        [TestMethod]
        public void ShowMessageboxTwo()
        {
            operandsCollection = new Collection<double> { 1, 3 };
            operatorsCollection = new Collection<char> ();
            expectedResult = testee.ErrorMessages[1];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1 3";
            testee.StartCalculation();

            // Assert
            testee.ErrorMessage.Should().Contain(expectedResult);
        }
    }
}
