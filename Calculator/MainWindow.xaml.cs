using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalculatorBusinessLogic;
using CalculatorParsing;

namespace CalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly IParsing Parsing = new Parsing();
        private static readonly ICalculation Calculation = new Calculation();
        private readonly CalculatorViewModel viewModel = new CalculatorViewModel(Parsing, Calculation);

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = this.viewModel.StartCalculation();
            if (string.IsNullOrEmpty(errorMessage))
            {
                OutputTextBlock.Text = Convert.ToString(this.viewModel.Result, CultureInfo.CurrentCulture);   
                return;
            }
            OutputTextBlock.Text = "-";
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.viewModel.UserInput = InputTextBox.Text;
        }
    }
}
