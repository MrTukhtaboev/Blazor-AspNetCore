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

namespace EmployeeManagement.Desktop.Components
{
    /// <summary>
    /// Interaction logic for UserInfo.xaml
    /// </summary>
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        public string FullName { get; set; } = "Muhammadkarim To'xtaboyev";
        public Action<bool?> Ozgarganda { get; set; }
        private void UserCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Ozgarganda.Invoke(UserCheckBox.IsChecked);
        }
    }
}
