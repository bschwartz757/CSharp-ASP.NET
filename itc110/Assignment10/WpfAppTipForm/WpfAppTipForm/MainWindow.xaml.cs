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
using System.IO;

namespace WpfAppTipForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tip t = new Tip();
        public MainWindow()
        
        {
            InitializeComponent();
        }

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
           

            t.MealAmount = double.Parse(Meal_Amount.Text);

            if (Tip_Percent1.IsChecked==true)
            {
                t.TipPercent = .1;
            }
            else if(Tip_Percent2.IsChecked==true)
            {
                t.TipPercent = .15;
            }
            else if(Tip_Percent3.IsChecked==true)
            {
                t.TipPercent = .2;
            }
            else
            {
                t.TipPercent = double.Parse(Alt_Tip.Text)/100;
            }
            Tip_Output.Content = t.CalculateTip().ToString();
            Tax_Output.Content = t.CalculateTaxAmount().ToString();
            Total_Output.Content = t.CalculateTotalAmount().ToString();
            
        }

        private void Write_Button_Click(object sender, RoutedEventArgs e)
        {
            WriteTip f = new WriteTip(@"C:\SCCC 2014-2015 WD Files\ITC110\Assignment10\tiptext.txt");
            
            f.AddToFile(t.CalculateTip().ToString());
            f.AddToFile(t.CalculateTaxAmount().ToString());
            f.AddToFile(t.CalculateTotalAmount().ToString());

            f.CloseFile();
        }

        private void Read_Button_Click(object sender, RoutedEventArgs e)
        {
            ReadTip f = new ReadTip(@"C:\SCCC 2014-2015 WD Files\ITC110\Assignment10\tiptext.txt");
            Reader.Content = f.GetFile();
        }

    }
}
