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

namespace MicroCredentialsSystem.Pages
{
    /// <summary>
    /// Interaction logic for ModifyActivity.xaml
    /// </summary>
    public partial class ModifyActivity : Page
    {
        public bool _isNew;
        public bool IsNew
        {
            get
            {
                return _isNew;
            }
            set
            {
                _isNew = value;
                ButtonDelete.Visibility = (value ? Visibility.Hidden : Visibility.Visible);
            }
        }
        public ModifyActivity()
        {
            InitializeComponent();
        }
    }
}
