using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorParsing
{
    public class Parsing : IParsing
    {
        public Collection<double> SplitInputIntoOperands(string userInput)
        {
            Collection<double> operandsCollection = new Collection<double>();
            if (userInput.Contains("+") || userInput.Contains("-") || userInput.Contains("*") || userInput.Contains("/"))
            {
                char[] operators = { '+', '-', '*', '/' };
                string[] values = userInput.Split(operators);
                foreach (string value in values)
                {
                    double operand = double.Parse(value, CultureInfo.CurrentCulture);
                    operandsCollection.Add(operand);
                }
            }
            return operandsCollection;
        }

        public Collection<char> ReadOperatorsOutOfInput(string userInput)
        {
            Collection<char> operatorsCollection = new Collection<char>();
            foreach (var v in userInput)
            {
                if (v == '+' || v == '-' || v == '*' || v == '/')
                {
                    operatorsCollection.Add(v);
                }
            }
            return operatorsCollection;
        }

        public bool AmountOfOperandsAndOperatorsIsWrong(Collection<double> operandsCollection, Collection<char> operatorsCollection)
        {
            if (operatorsCollection.Count == 0 || operandsCollection.Count <= 1)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
