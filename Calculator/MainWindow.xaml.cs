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
using CalculatorLogic;
using CalculatorParsing;

namespace CalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly IParsing parsing = new Parsing();
        private static readonly ICalculation calculation = new Calculation();
        private readonly CalculatorViewModel viewModel = new CalculatorViewModel(parsing, calculation);

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string result = this.viewModel.StartCalculation();
            if (!result.StartsWith("Your Input:"))
            {
                OutputTextBlock.Text = result;
                return;
            }
            OutputTextBlock.Text = "-";
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.UserInput = InputTextBox.Text;
        }
    }
}
