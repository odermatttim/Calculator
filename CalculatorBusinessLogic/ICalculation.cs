using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBusinessLogic
{
    public interface ICalculation
    {
        double Calculate(Collection<double> operandsCollection, Collection<char> operatorsCollection );
    }
}
