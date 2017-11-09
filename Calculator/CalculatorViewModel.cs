using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using CalculatorBusinessLogic;
using CalculatorParsing;

namespace CalculatorUI
{
    public class CalculatorViewModel
    {
        public string UserInput { get; set; }
        public double Result { get; set; }
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

        public CalculatorViewModel(IParsing parsing, ICalculation calculation)
        {
            this.parsing = parsing;
            this.calculation = calculation;
        }

        public string StartCalculation()
        {
            this.operatorsCollection = this.parsing.ReadOperatorsOutOfInput(this.UserInput);
            if (this.UserInput.Contains("*") || this.UserInput.Contains(":") || this.UserInput.Contains("/"))
            {
                return this.ShowErrorMessage(this.ErrorMessages[0]);
            }
            try
            {
                this.operandsCollection = this.parsing.SplitInputIntoOperands(this.UserInput);
            }
            catch (Exception)
            {
                return this.ShowErrorMessage(this.ErrorMessages[2]);
            }
            if (this.operatorsCollection.Count == 0 || this.operandsCollection.Count <= 1)
            {
                return this.ShowErrorMessage(this.ErrorMessages[1]);
            }
            this.Result = this.calculation.Calculate(this.operandsCollection, this.operatorsCollection);
            return string.Empty;
        }

        public string ShowErrorMessage(string specificMessage)
        {
            string errorMessage = string.Format(CultureInfo.CurrentCulture, "Your Input: \"{0}\" has a wrong format.\n{1}", this.UserInput, specificMessage);
            MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK);
            return errorMessage;
        }
    }
}
