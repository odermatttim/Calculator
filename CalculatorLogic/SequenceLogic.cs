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
        public string UserInput { get; set; }
        public string Result { get; set; }
        private readonly IParsing parsing;
        private readonly ICalculation calculation;
        private Collection<char> operatorsCollection;
        private Collection<double> operandsCollection;
        private readonly Collection<string> errorMessages = new Collection<string>()
        {
            "Operators \"*\" and \"/\" are not allowed. \nPlease only use numbers and operators \"-\" or \"+\" for your input.",
            "Use at least one operator \"-\" or \"+\" and two numbers.",
            "One or multiple operands have an illegal value and/or you haven't put an operator between every two operands. \nPlease only use numbers and operators \"-\" or \"+\" for your input."
        };
        public Collection<string> ErrorMessages
        {
            get { return this.errorMessages; }
        }

        public SequenceLogic(IParsing parsing, ICalculation calculation, string userInput = "")
        {
            this.parsing = parsing;
            this.calculation = calculation;
            this.UserInput = userInput;
        }

        public void Calculate()
        {
            this.operatorsCollection = this.parsing.ReadOperatorsOutOfInput(this.UserInput);
            if (this.UserInput.Contains("*") || this.UserInput.Contains(":") || this.UserInput.Contains("/"))
            {
                this.Result = this.GetErrorMessage(this.ErrorMessages[0]);
                return;
            }
            try
            {
                this.operandsCollection = this.parsing.SplitInputIntoOperands(this.UserInput);
            }
            catch (Exception)
            {
                this.Result = this.GetErrorMessage(this.ErrorMessages[2]);
                return;
            }
            if (this.operatorsCollection.Count == 0 || this.operandsCollection.Count <= 1)
            {
                this.Result = this.GetErrorMessage(this.ErrorMessages[1]);
                return;
            }
            this.Result = Convert.ToString(this.calculation.Calculate(this.operandsCollection, this.operatorsCollection));
        }

        public string GetErrorMessage(string specificMessage)
        {
            string errorMessage = string.Format(CultureInfo.CurrentCulture, "Your Input: \"{0}\" has a wrong format.\n{1}", this.UserInput, specificMessage);
            return errorMessage;
        }
    }
}
