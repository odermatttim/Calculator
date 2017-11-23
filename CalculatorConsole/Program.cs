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
            sequenceLogic.EvIllegalInputGivenIllegalOperator += new SequenceLogic.DgIllegalInput(WriteMessageIllegalOperator);
            sequenceLogic.EvIllegalInputGivenNotEnoughOperands += new SequenceLogic.DgIllegalInput(WriteMessageNotEnoughOperands);
            sequenceLogic.EvIllegalInputGivenIllegalOperand += new SequenceLogic.DgIllegalInput(WriteMessageIllegalOperand);
            while (true)
            {
                Console.WriteLine("Type your calculation: ");
                string userInput = Console.ReadLine();
                string result = sequenceLogic.Calculate(userInput);
                Console.WriteLine(result + "\n");
            }
        }

        private static void WriteMessageIllegalOperator()
        {
            Console.WriteLine("Error occured. Only \"+\", \"-\" and numbers are allowed");
        }

        private static void WriteMessageNotEnoughOperands()
        {
            Console.WriteLine("Error occured. Use at least \"+\" or \"-\" and two numbers.");
        }

        private static void WriteMessageIllegalOperand()
        {
            Console.WriteLine("Error occured. One or multiple operands have an illegal value.");
        }
    }
}
