using System;
using System.Windows;
using System.Windows.Controls;

namespace calculator_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonValue = button.Content.ToString();

            if (resultTextBlock.Text == "0")
            {
                resultTextBlock.Text = buttonValue;
            }
            else
            {
                resultTextBlock.Text += buttonValue;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            string expression = resultTextBlock.Text;
            try
            {
                var result = new System.Data.DataTable().Compute(expression, null);
                resultTextBlock.Text = result.ToString();
            }
            catch (Exception ex)
            {
                resultTextBlock.Text = "Ошибка";
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text = "0";
        }
    }
}