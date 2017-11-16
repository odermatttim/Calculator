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
        private readonly ISequenceLogic sequenceLogic;

        public CalculatorViewModel(IParsing parsing, ICalculation calculation)
        {
            sequenceLogic = new SequenceLogic(parsing, calculation, UserInput);
        }

        public string StartCalculation()
        {
            sequenceLogic.Calculate();
            if (sequenceLogic.Result.StartsWith("Your Input:"))
            {
                MessageBox.Show(sequenceLogic.Result, "Error", MessageBoxButton.OK);
            }
            return sequenceLogic.Result;
        }
    }
}
