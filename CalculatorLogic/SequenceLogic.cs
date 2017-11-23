using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public event DgIllegalInput EvIllegalInputGivenIllegalOperator;
        public event DgIllegalInput EvIllegalInputGivenNotEnoughOperands;
        public event DgIllegalInput EvIllegalInputGivenIllegalOperand;
        
        public SequenceLogic(IParsing parsing, ICalculation calculation)
        {
            this.parsing = parsing;
            this.calculation = calculation;
        }

        public string Calculate(string input)
        {
            this.operatorsCollection = this.parsing.ReadOperatorsOutOfInput(input);
            if (input.Contains("*") || input.Contains(":") || input.Contains("/"))
            {
                EvIllegalInputGivenIllegalOperator();
                return null;
            }
            try
            {
                this.operandsCollection = this.parsing.SplitInputIntoOperands(input);
            }
            catch (Exception)
            {
                EvIllegalInputGivenIllegalOperand();
                return null;
            }
            if (this.operatorsCollection.Count == 0 || this.operandsCollection.Count <= 1)
            {
                EvIllegalInputGivenNotEnoughOperands();
                return null;
            }
            return Convert.ToString(this.calculation.Calculate(this.operandsCollection, this.operatorsCollection));
        }
    }
}
