using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CalculatorBusinessLogic;
using CalculatorLogic;
using CalculatorParsing;

namespace CalculatorConsole
{
    class Program
    {
        private static readonly IParsing parsing = new Parsing();
        private static readonly ICalculation calculation = new Calculation();
        private static readonly ISequenceLogic sequenceLogic = new SequenceLogic(parsing, calculation);

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type your calculation: ");
                sequenceLogic.UserInput = Console.ReadLine();
                sequenceLogic.Calculate();
                Console.WriteLine(sequenceLogic.Result + "\n");
            }
        }
    }
}
