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
using ConvertTemp.ViewModel;
using static System.Net.Mime.MediaTypeNames;

namespace ConvertTemp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            ButtonConvert.Click += ButtonConvert_Click;
        }

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            if (CboFrom.SelectedItem != null && TextBoxValue.Text != null)   // Je veux m'assurer que l'utilisateur selectionnent les 2 unités et donne une valeur
            {
                double value = double.Parse(TextBoxValue.Text); // Ceci est la valeur à convertir
                object readtextFrom = ((ComboBoxItem)CboFrom.SelectedItem).Content; // Ceci est l'unité de départ 
                object readtextTo = ((ComboBoxItem)CboTo.SelectedItem).Content; // Ceci est l'unité de d'arrivé 


                ViewModel.ConverterTempVM temp = new ViewModel.ConverterTempVM(readtextFrom, readtextTo, value);

                TextBoxTotal.Text = temp.converterTemp();
            }

            else
            {
                
            }
        }
    }
}
