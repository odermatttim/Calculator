using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorBusinessLogic;
using CalculatorParsing;

namespace CalculatorLogic
{
    public interface ISequenceLogic
    {
        string UserInput { get; set; }

        string Result { get; set; }

        Collection<string> ErrorMessages { get; }

        void Calculate();

        string GetErrorMessage(string specificMessage);
    }
}
