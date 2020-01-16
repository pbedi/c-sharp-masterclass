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

namespace _13_WPF10_Checkbox
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

        private void CbAllCheckChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAll.IsChecked == true);
            cbSlami.IsChecked = newVal;
            cbMozzarella.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
        }

        private void CbSingleCheckChanged(object sender, RoutedEventArgs e)
        {
            cbAll.IsChecked = null;
            if(cbSlami.IsChecked == true && cbMushrooms.IsChecked == true && cbMozzarella.IsChecked == true)
            {
                cbAll.IsChecked = true;
            } else if (cbSlami.IsChecked == false && cbMushrooms.IsChecked == false && cbMozzarella.IsChecked == false)
            {
                cbAll.IsChecked = false;
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            //(sender as Button).Background = Brush.
        }
    }
}
