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
    /// Interaction logic for Tags.xaml
    /// </summary>
    public partial class Tags : Page
    {
        public ObservableCollection<string> Names { get; set; }
        public string selectedName { get; set; }
        public Tags()
        {
            Names = new ObservableCollection<string>() { "Tag 1", "Tag 2", "Tag 3", "Tag 4", "Tag 5" };
            InitializeComponent();
            DataContext = this;
        }
        private void ButtonNewTag_Click(object sender, RoutedEventArgs e)
        {
            ModifyTag dialog = new ModifyTag();
            dialog.ShowDialog();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
