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
using CalculatorLogic;
using CalculatorParsing;

namespace CalculatorUI
{
    public class CalculatorViewModel
    {
        public string UserInput { get; set; }
        public string ErrorMessage { get; set; }
        private static ISequenceLogic sequenceLogic;
        private static readonly Collection<string> errorMessages = new Collection<string>()
        {
            "Operators \"*\" and \"/\" are not allowed. \nPlease only use numbers and operators \"-\" or \"+\" for your input.",
            "Use at least one operator \"-\" or \"+\" and two numbers for your input.",
            "One or multiple operands have an illegal value and/or you haven't put an operator between every two operands. \nPlease only use numbers and operators \"-\" or \"+\" for your input."
        };

        public Collection<string> ErrorMessages
        {
            get { return errorMessages; }
        }

        public CalculatorViewModel(IParsing parsing, ICalculation calculation)
        {
            sequenceLogic = new SequenceLogic(parsing, calculation);
            sequenceLogic.EvIllegalInputGivenIllegalOperator += new SequenceLogic.DgIllegalInput(WriteMessageIllegalOperator);
            sequenceLogic.EvIllegalInputGivenNotEnoughOperands += new SequenceLogic.DgIllegalInput(WriteMessageNotEnoughOperands);
            sequenceLogic.EvIllegalInputGivenIllegalOperand += new SequenceLogic.DgIllegalInput(WriteMessageIllegalOperand);
        }

        public string StartCalculation()
        {
            string result = sequenceLogic.Calculate(UserInput);
            return result;
        }

        private void WriteMessageIllegalOperator()
        {
            ErrorMessage = ShowErrorMessageBox(errorMessages[0]);
        }

        private void WriteMessageNotEnoughOperands()
        {
            ErrorMessage = ShowErrorMessageBox(errorMessages[1]);
        }

        private void WriteMessageIllegalOperand()
        {
            ErrorMessage = ShowErrorMessageBox(errorMessages[2]);
        }

        public string ShowErrorMessageBox(string specificMessage)
        {
            string completeMessage = string.Format(CultureInfo.CurrentCulture, "Your Input: \"{0}\" has a wrong format.\n{1}", UserInput, specificMessage);
            MessageBox.Show(string.Format(completeMessage, "Error", MessageBoxButton.OK));
            return completeMessage;
        }
    }
}
