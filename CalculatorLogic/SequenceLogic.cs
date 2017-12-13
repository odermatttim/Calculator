using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CalculatorBusinessLogic;
using CalculatorParsing;

namespace CalculatorLogic
{
    public class SequenceLogic : ISequenceLogic
    {
        private readonly IParsing parsing;
        private readonly ICalculation calculation;
        private Collection<char> operatorsCollection;
        private Collection<double> operandsCollection;

        public delegate void DgIllegalInput();

        public event DgIllegalInput EvIllegalInputGivenNotEnoughOperands = delegate { };
        public event DgIllegalInput EvIllegalInputGivenIllegalOperand = delegate { };

        public SequenceLogic(IParsing parsing, ICalculation calculation)
        {
            this.parsing = parsing;
            this.calculation = calculation;
        }

        public string Calculate(string input)
        {
            this.operatorsCollection = this.parsing.ReadOperatorsOutOfInput(input);
            try
            {
                this.operandsCollection = this.parsing.SplitInputIntoOperands(input);
            }
            catch (Exception)
            {
                EvIllegalInputGivenIllegalOperand();
                return null;
            }
            if (parsing.AmountOfOperandsAndOperatorsIsWrong(this.operandsCollection, this.operatorsCollection))
            {
                EvIllegalInputGivenNotEnoughOperands();
                return null;
            }
            return Convert.ToString(this.calculation.Calculate(this.operandsCollection, this.operatorsCollection));
        }
    }
}
