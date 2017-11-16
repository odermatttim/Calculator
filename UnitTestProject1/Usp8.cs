﻿using System;
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
        private SequenceLogic testee;
        private string expectedErrorMessage;
        private const int irrelevantCalculationResult = 0;
        
        [TestInitialize]
        public void SetUp()
        {
            this.parsingStub = new StubIParsing();
            this.calculationStub = new StubICalculation();
            this.testee = new SequenceLogic(this.parsingStub, this.calculationStub);
        }

        [TestMethod]
        public void ErrorMessageShowsHintOne()
        {
            expectedErrorMessage = testee.ErrorMessages[0];
            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => new Collection<double> { 1.5, 2 };
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => new Collection<char>();
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1.5 * 2";
            testee.Calculate();

            // Assert
            testee.Result.Should().Contain(expectedErrorMessage);
        }

        [TestMethod]
        public void ErrorMessageShowsHintTwo()
        {
            expectedErrorMessage = testee.ErrorMessages[1];
            // Arrange
            this.parsingStub.SplitInputIntoOperandsString = (userInput) => new Collection<double> { 1.5 };
            this.parsingStub.ReadOperatorsOutOfInputString = (userInput) => new Collection<char> {'+'};
            this.calculationStub.CalculateCollectionOfDoubleCollectionOfChar = (doubleValues, charValues) => irrelevantCalculationResult;

            // Act
            testee.UserInput = "1.5 +";
            testee.Calculate();

            // Assert
            testee.Result.Should().Contain(expectedErrorMessage);
        }
    }
}
