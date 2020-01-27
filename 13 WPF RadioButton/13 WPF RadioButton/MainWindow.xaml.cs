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

namespace _13_WPF_RadioButton
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

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Good choice, thanks");
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You selected NO, Please say yes!");
        }

        private void Maybe_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You selected, Maybe, Please say yes!");
        }
    }
}
