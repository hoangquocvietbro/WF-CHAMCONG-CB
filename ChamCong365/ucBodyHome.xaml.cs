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
    /// Interaction logic for ucBodyHome.xaml
    /// </summary>
    public partial class ucBodyHome : UserControl
    {
        public ucBodyHome()
        {
            InitializeComponent();
        }
        private void wapbuttonSecurityWifi_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ucSecurityWifi uc = new ucSecurityWifi();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }
        private void wapInstallCalendarWork_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ucInstallCalendarWork uc = new ucInstallCalendarWork();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }

        private void wapStandardInstallation_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ucStandardInstallation uc = new ucStandardInstallation();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }

        private void wapUpdateFace_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ucUpdateFace uc = new ucUpdateFace();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }
    }
}
