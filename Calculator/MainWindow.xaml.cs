using System;
using System.Collections.Generic;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            resultLabel.Content = "0";
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            assignValue(Convert.ToInt16(sevenButton.Content));
        }

        private void assignValue(int num)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = num;
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}" + num;
            }
        }
    }
}
