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

namespace MileageFormWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            Mileage m = new Mileage();
            //inputs
            m.Distance = double.Parse(textMiles.Text);
            m.Gallons = double.Parse(textGallons.Text);
            m.PricePerGallon = double.Parse(textPrice.Text);
            //outputs
            labelMileage.Content = m.CalculateMileage().ToString();
            labelCost.Content = m.CalculatePricePerMile().ToString();

        }
    }
}
