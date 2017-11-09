using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBusinessLogic;
using CalculatorParsing;
using CalculatorUI;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests
{
    [TestClass]
    public class IntegrationTests
    {
        private Calculation calculation;
        private Parsing parsing;
        private CalculatorViewModel testee;
        private string expectedErrorMessage;

        [TestInitialize]
        public void SetUp()
        {
            this.parsing = new Parsing();
            this.calculation = new Calculation();
            this.testee = new CalculatorViewModel(this.parsing, this.calculation);
        }

        [TestMethod]
        public void ValidOperationOne()
        {
            expectedErrorMessage = string.Empty;
            //Act
            testee.UserInput = "1 + 2";
            string errorMessage = testee.StartCalculation();
            //Assert
            errorMessage.Should().Be(expectedErrorMessage);
        }

        [TestMethod]
        public void ValidOperationTwo()
        {
            expectedErrorMessage = string.Empty;
            //Act
            testee.UserInput = "4.31 - 30.068 + 0.0002 - 2028";
            string errorMessage = testee.StartCalculation();
            //Assert
            errorMessage.Should().Be(expectedErrorMessage);
        }

        [TestMethod]
        public void InvalidOperationOne()
        {
            expectedErrorMessage = testee.ErrorMessages[0];
            //Act
            testee.UserInput = "1 * 2";
            string errorMessage = testee.StartCalculation();
            //Assert
            errorMessage.Should().Contain(expectedErrorMessage);
        }

        [TestMethod]
        public void InvalidOperationTwo()
        {
            expectedErrorMessage = testee.ErrorMessages[1];
            //Act
            testee.UserInput = "1 2";
            string errorMessage = testee.StartCalculation();
            //Assert
            errorMessage.Should().Contain(expectedErrorMessage);
        }

        [TestMethod]
        public void InvalidOperationThree()
        {
            expectedErrorMessage = testee.ErrorMessages[2];
            //Act
            testee.UserInput = "4.31 - 30.068 + 0.0002 2028";
            string errorMessage = testee.StartCalculation();
            //Assert
            errorMessage.Should().Contain(expectedErrorMessage);
        }
    }
}
