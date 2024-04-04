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

namespace BOUSSADAQA_Oussama
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

        private void Slider_1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number1.Text = Slider_1.Value.ToString("0");
        }

        private void Slider_2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number2.Text = Slider_2.Value.ToString("0");
        }

        private void Slider_3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number3.Text = Slider_3.Value.ToString("0");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string val1 = Slider_1.Value.ToString("0");
            string val2 = Slider_2.Value.ToString("0");
            string val3 = Slider_3.Value.ToString("0");
            text1.Text = val1;
            text2.Text = val2;
            text3.Text = val3;
            
            string[] val0 = new string[3];
            val0[0] = val1;
            val0[1] = val2;
            val0[2] = val3;
            listnbr.Items.Clear();
            foreach (string val4 in val0)
            {
                listnbr.Items.Add(val4);
            }
        }
    }
}
