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

namespace UltraPasswordGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
           Type_ComboBox.Items.Add(new Easy_dictionary());
           Type_ComboBox.Items.Add(new Digits_and_letters());
           Type_ComboBox.Items.Add(new Only_digits());
           Type_ComboBox.Items.Add(new Any_dictionary());
           Type_ComboBox.SelectedIndex = 0;
        }
    }
}
