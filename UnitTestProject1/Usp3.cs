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
using CalculatorLogic.Fakes;
using CalculatorParsing;
using CalculatorParsing.Fakes;
using CalculatorUI;
using FluentAssertions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParsingUnitTests
{
    [TestClass]
    public class Usp3
    {
        private StubIParsing parsingStub;
        private StubICalculation calculationStub;
        private CalculatorViewModel testee;
        private Collection<double> operandsCollection;
        private Collection<char> operatorsCollection;
        private int irrelevantCalculationResult;
        private string expectedResult;
        private string result;
            
        [TestInitialize]
        public void SetUp()
        {
            this.parsingStub = new StubIParsing();
            this.calculationStub = new StubICalculation();
            testee = new CalculatorViewModel(parsingStub, calculationStub);
            irrelevantCalculationResult = 0;
        }

        [TestMethod]
        public void ValidInput_NoInvalidCharacters()
        {
            operandsCollection = new Collection<double>{3.5, 6.5};
            operatorsCollection = new Collection<char>{'+'};
            expectedResult = "10";

            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => operandsCollection;
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => operatorsCollection;
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => double.Parse(expectedResult);
            
            // Act
            testee.UserInput = "3.5 + 6.5";
            result = testee.StartCalculation();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void InvalidInput_NoOperator()
        {
            operandsCollection = new Collection<double>{4.395, 6};
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
