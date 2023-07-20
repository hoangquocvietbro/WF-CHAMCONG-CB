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

namespace ChamCong365
{
    /// <summary>
    /// Interaction logic for companyManagerment.xaml
    /// </summary>
    public partial class companyManagerment : UserControl
    {
        public companyManagerment()
        {
            InitializeComponent();
        }
        private void buttonShiftManagement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ucShiftManager uc = new ucShiftManager();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }
        private void warpChildCompanyManager_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ucChildCompanyManagerment uc = new ucChildCompanyManagerment();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }
    }
}
