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
    /// Interaction logic for Reviews.xaml
    /// </summary>
    public partial class Reviews : Page
    {
        public ObservableCollection<string> Names { get; set; }
        public string selectedName { get; set; }
        public Reviews()
        {
            Names = new ObservableCollection<string>() { "Review 1", "Review 2", "Review 3", "Review 4", "Review 5" };
            InitializeComponent();
            DataContext = this;
        }
        private void ButtonNewTag_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages\\ModifyReviews.xaml", UriKind.Relative));
        }
    }
}
