using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBusinessLogic;
using CalculatorLogic;
using CalculatorParsing;
using CalculatorUI;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests
{
    [TestClass]
    public class IntegrationTests
    {
        private CalculatorViewModel testee;
        private Calculation calculation;
        private Parsing parsing;
        private string result;
        private string expectedResult;

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
            expectedResult = "3";
            //Act
            testee.UserInput = "1 + 2";
            result = testee.StartCalculation();
            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ValidOperationTwo()
        {
            expectedResult = "-2053.7578";
            //Act
            testee.UserInput = "4.31 - 30.068 + 0.0002 - 2028";
            result = testee.StartCalculation();
            //Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void InvalidOperationOne()
        {
            expectedResult = testee.ErrorMessages[0];
            //Act
            testee.UserInput = "1 * 2";
            testee.StartCalculation();
            //Assert
            testee.ErrorMessage.Should().Contain(expectedResult);
        }

        [TestMethod]
        public void InvalidOperationTwo()
        {
            expectedResult = testee.ErrorMessages[1];
            //Act
            testee.UserInput = "1 2";
            testee.StartCalculation();
            //Assert
            testee.ErrorMessage.Should().Contain(expectedResult);
        }

        [TestMethod]
        public void InvalidOperationThree()
        {
            expectedResult = testee.ErrorMessages[2];
            //Act
            testee.UserInput = "4.31 - 30.068 + 0.0002 2028";
            testee.StartCalculation();
            //Assert
            testee.ErrorMessage.Should().Contain(expectedResult);
        }
    }
}
