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
    public class Usp5
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
        public void ValidInput_TwoOperandsOneOperator()
        {
            operandsCollection = new Collection<double>{4.395, 6};
            operatorsCollection = new Collection<char>{'+'};
            expectedResult = "10.395";

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => double.Parse(expectedResult);

            // Act
            testee.UserInput = "4.395 + 6";
            result = testee.StartCalculation();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ValidInput_ThreeOperandsTwoOperators()
        {
            operandsCollection = new Collection<double>{2, 6.43, 3};
            operatorsCollection = new Collection<char>{'+', '-'};
            expectedResult = "5.43";

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => double.Parse(expectedResult);

            // Act
            testee.UserInput = "2 + 6.43 - 3";
            result = testee.StartCalculation();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void InvalidInput_NoOperator()
        {
            operandsCollection = new Collection<double> { 4.395, 6 };
            operatorsCollection = new Collection<char>();
            expectedResult = testee.ErrorMessages[0];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "4.395 6";
            testee.StartCalculation();

            // Assert
            testee.ErrorMessage.Should().Contain(expectedResult);
        }

        [TestMethod]
        public void InvalidInput_OneOperand()
        {
            operandsCollection = new Collection<double> { 4.395 };
            operatorsCollection = new Collection<char> { '+' };
            expectedResult = testee.ErrorMessages[0];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "4.395 +";
            testee.StartCalculation();

            // Assert
            testee.ErrorMessage.Should().Contain(expectedResult);
        }

        [TestMethod]
        public void InvalidInput_NoOperand()
        {
            operandsCollection = new Collection<double>();
            operatorsCollection = new Collection<char> { '-', '+' };
            expectedResult = testee.ErrorMessages[0];

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "- +";
            testee.StartCalculation();

            // Assert
            testee.ErrorMessage.Should().Contain(expectedResult);
        }
    }
}
