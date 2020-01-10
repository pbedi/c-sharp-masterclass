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

namespace _13_WPF02
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was clicked - Direct event");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button went up / was released - Bubling event.");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button went up / was released - Tunneling event.");
        }

        private void Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Left Button went up / was released - Tunneling event.");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Right Button went up - Tunneling event.");
        }
    }
}
