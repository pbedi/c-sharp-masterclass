using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using System.Threading;
using System.Diagnostics;

namespace _16_Threads_WPF_160
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

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/200MB.zip").Result;

                myButton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} owns my button");
                    myButton.Content = "Done";
                });
                
            });
            
        }

        private async void MyButton_Click1(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async () =>
            {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/200MB.zip").Result;
            });
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} after await task");
            myButton.Content = "Done downloading";
        }
    }
}
