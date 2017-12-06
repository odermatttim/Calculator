using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorParsing
{
    public interface IParsing
    {
        Collection<double> SplitInputIntoOperands(string userInput);

        Collection<char> ReadOperatorsOutOfInput(string userInput);

        bool AmountOfOperandsAndOperatorsIsWrong(Collection<double> operandsCollection, Collection<char> operatorsCollection);
    }
}
