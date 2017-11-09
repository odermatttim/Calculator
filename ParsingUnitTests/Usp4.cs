using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using CalculatorParsing;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParsingUnitTests
{
    [TestClass]
    public class Usp4
    {
        private Parsing parsing;

        [TestInitialize]
        public void SetUp()
        {
            parsing = new Parsing();
        }

        [TestMethod]
        public void TwoNumbers()
        {
            //Act
            Collection<double> values = parsing.SplitInputIntoOperands("1 + 2");
            //Assert
            values.Should().HaveCount(2);
        }

        [TestMethod]
        public void OneNumber()
        {
            //Act
            Action action = () => parsing.SplitInputIntoOperands("1 + ");
            //Assert
            action.ShouldThrow<Exception>();
        }

        [TestMethod]
        public void OneOperator()
        {
            //Act
            Collection<char> operatorsCollection = parsing.ReadOperatorsOutOfInput("1 + 2");
            //Assert
            operatorsCollection.Should().Contain("+");
        }

        [TestMethod]
        public void NoOperator()
        {
            //Act
            Collection<char> operatorsCollection = parsing.ReadOperatorsOutOfInput("1 2");
            //Assert
            operatorsCollection.Should().NotContain("+").And.NotContain("-");
        }
    }
}
