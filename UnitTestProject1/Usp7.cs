using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
    public class Usp7
    {
        private StubIParsing parsingStub;
        private StubICalculation calculationStub;
        private CalculatorViewModel testee;

        [TestInitialize]
        public void SetUp()
        {
            this.parsingStub = new StubIParsing();
            this.calculationStub = new StubICalculation();
            this.testee = new CalculatorViewModel(this.parsingStub, calculationStub);
        }

        [TestMethod]
        public void ErrorMessageIncludesInput()
        {
            const int irrelevantCalculationResult = 0;
            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => new Collection<double> {1.57, 2};
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => new Collection<char>();
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1.57 2";
            testee.StartCalculation();

            // Assert
            testee.ErrorMessage.Should().Contain(testee.UserInput);
        }
    }
}
