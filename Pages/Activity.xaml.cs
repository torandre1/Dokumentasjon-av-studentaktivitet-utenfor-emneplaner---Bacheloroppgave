using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MicroCredentialsSystem.Pages
{
    /// <summary>
    /// Interaction logic for Activity.xaml
    /// </summary>
    public partial class Activity : Page
    {
        public ObservableCollection<string> Names { get; set; }
        public string selectedName { get; set; }
        public Activity()
        {
            Names = new ObservableCollection<string>() { "Activity 1", "Activity 2", "Activity 3", "Activity 4", "Activity 5" };

            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonNewActivity_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages\\ModifyActivity.xaml", UriKind.Relative));
        }
    }
}
