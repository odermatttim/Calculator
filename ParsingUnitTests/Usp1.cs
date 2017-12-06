using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorParsing;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParsingUnitTests
{
    [TestClass]
    public class Usp1
    {
        private Parsing testee;

        [TestInitialize]
        public void SetUp()
        {
            testee = new Parsing();
        }

        [TestMethod]
        public void SplitIntoOperands()
        {
            //Act
            Collection<double> operands = testee.SplitInputIntoOperands("1 + 2.48 * 44 - 20");
            //Assert
            operands.Should().HaveCount(4);
        }

        [TestMethod]
        public void SplitIntoOperators()
        {
            //Act
            Collection<char> valuesOperators = testee.ReadOperatorsOutOfInput("1 / 2.48 - 44 - 20");
            //Assert
            valuesOperators.Should().HaveCount(3);
        }

        [TestMethod]
        public void CheckOperands()
        {
            //Act
            String[] values = { "2.73", "3", "17" };
            Collection<double> operands = testee.SplitInputIntoOperands(String.Format("{0}+{1}-{2}", values[0], values[1], values[2]));
            //Assert
            for (int i = 0; i < operands.Count; i++)
            {
                operands[i].Should().Be(Convert.ToDouble(values[i]));
            }
        }

        [TestMethod]
        public void CheckOperators()
        {
            //Act
            string[] values = { "+", "-" };
            Collection<char> operators = testee.ReadOperatorsOutOfInput(String.Format("2.73{0}3{1}17", values[0], values[1]));
            //Assert
            for (int i = 0; i < operators.Count; i++)
            {
                operators[i].Should().Be(Convert.ToChar(values[i]));
            }
        }
    }
}
