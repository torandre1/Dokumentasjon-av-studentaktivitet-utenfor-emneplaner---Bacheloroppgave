using MicroCredentialsSystem.Pages;
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

namespace MicroCredentialsSystem
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var menu =Convert.ToString((sender as MenuItem).Tag);

            MovePage(menu);

        }
        private void MovePage(string menu)
        {
            Page nextPage;
            switch (menu)
            {
                case "AllActivity":
                    nextPage = new Activity();
                    break;
                case "NewActivity":
                    nextPage = new ModifyActivity();
                    (nextPage as ModifyActivity).IsNew = true;
                    break;
                case "EditActivity":
                    nextPage = new ModifyActivity();
                    (nextPage as ModifyActivity).IsNew = false;
                    break;
                case "Reviews":
                    nextPage = new Reviews();
                    break;
                case "Tags":
                    nextPage = new Tags();
                    break;
                case "USers":
                    nextPage = new Users();
                    break;
                case "Reports":
                    nextPage = new Reports();
                    break;
                default:
                    nextPage = new Activity();
                    break;
            }

            MainFrame.Navigate(nextPage);
        }
        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MovePage("AllActivity");
        }
    }
}
