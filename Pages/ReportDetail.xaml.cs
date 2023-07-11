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
    /// Interaction logic for ReportDetail.xaml
    /// </summary>
    public partial class ReportDetail : Page
    {
        public ObservableCollection<string> Names { get; set; }
        public string selectedName { get; set; }
        public ReportDetail()
        {
            Names = new ObservableCollection<string>() { "Report 1", "Report 2", "Report 3", "Report 4", "Report 5" };
            InitializeComponent();
            DataContext = this;
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
