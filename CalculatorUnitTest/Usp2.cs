using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBusinessLogic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParsingUnitTests
{
    [TestClass]
    public class Usp2
    {
        private Calculation calculation;

        [TestInitialize]
        public void SetUp()
        {
            calculation = new Calculation();
        }

        [TestMethod]
        public void ValidCalculation()
        {   
            //Act
            double Result;
            Collection<double> operandsCollection = new Collection<double>()
            {
                4, 6.5, 0.5
            };
            Collection<char> operatorsCollection = new Collection<char>()
            {
                '+', '-'
            };
            Result = calculation.Calculate(operandsCollection, operatorsCollection);
            //Assert
            Result.Should().Be(10);
        }
    }
}
