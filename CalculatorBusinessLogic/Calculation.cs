using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBusinessLogic
{
    public class Calculation : ICalculation
    {
        public double Result { get; set; }

        public double Calculate(Collection<double> operandsCollection, Collection<char> operatorsCollection)
        {
            this.Result = operandsCollection[0];
            for (int i = 0; i < operatorsCollection.Count; i++)
            {
                if (operatorsCollection[i] == '+')
                {
                    this.Result += operandsCollection[i + 1];
                }
                else
                {
                    this.Result -= operandsCollection[i + 1];
                }
            }
            return Result;
        }
    }
}
