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
            //Calculate Multiplications and Divisions first
            for (int i = 0; i < operatorsCollection.Count; i++)
            {
                if (operatorsCollection[i] == '*')
                {
                    operandsCollection[i] *= operandsCollection[i + 1];
                    operandsCollection.RemoveAt(i + 1);
                    operatorsCollection.RemoveAt(i);
                    i -= 1;
                }
                else if (operatorsCollection[i] == '/')
                {
                    operandsCollection[i] /= operandsCollection[i + 1];
                    operandsCollection.RemoveAt(i + 1);
                    operatorsCollection.RemoveAt(i);
                    i -= 1;
                }
            }
            //Calculate rest
            this.Result = operandsCollection[0];
            for (int i = 0; i < operatorsCollection.Count; i++)
            {
                if (operatorsCollection[i] == '+')
                {
                    this.Result += operandsCollection[i + 1];
                }
                else if (operatorsCollection[i] == '-')
                {
                    this.Result -= operandsCollection[i + 1];
                }
            }
            return Result;
        }
    }
}
