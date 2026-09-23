using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace Calculator
{
    public enum Operators{ ADD, SUB, MUL, DIV,};
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OperatorComboBox.ItemsSource = Enum.GetValues(typeof(Operators));
            OperatorComboBox.SelectedIndex = 0;
        }

        private void OnCalculateClicked(object? sender, RoutedEventArgs e)
        {
            if (double.TryParse(TextBox1.Text, out var a) &&
                double.TryParse(TextBox2.Text, out var b))
            {
                if (OperatorComboBox.SelectedItem is not Operators op)
                {
                    ResultLabel.Text = "Please select an operator.";
                    return;
                }

                double result = 0;

                switch (op)
                {
                    case Operators.ADD:
                        result = a + b;
                        break;

                    case Operators.SUB:
                        result = a - b;
                        break;

                    case Operators.MUL:
                        result = a * b;
                        break;

                    case Operators.DIV:
                        result = b != 0 ? a / b : double.NaN;
                        break;

                    default:
                        ResultLabel.Text = "Please select an operator.";
                        return;
                }

                ResultLabel.Text = $"Result: {result}";
            }
            else
            {
                ResultLabel.Text = "Please enter valid numbers.";
            }
        }
    }
}
