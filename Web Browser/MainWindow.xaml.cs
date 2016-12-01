using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Web_Browser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string page = searchBar.Text.Trim();
            webBrowser.Navigate(page);
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            string page = searchBar.Text.Trim();
            page = Regex.Replace(page, "https://", "").Trim();
            page = Regex.Replace(page, "http://", "").Trim();
            page = "https://" + page;
            webBrowser.Navigate(page);
            
        }

        private void searchBar_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void webBrowser_LoadCompleted(object sender, NavigationEventArgs e)
        {
            searchBar.Text = webBrowser.Source.AbsoluteUri;
        }

        private void forwardButton_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.GoForward();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.GoBack();
        }
    }
}
