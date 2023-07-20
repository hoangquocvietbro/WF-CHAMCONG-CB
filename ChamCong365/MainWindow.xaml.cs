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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonCompanyManager_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            companyManagerment uc = new companyManagerment();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }

        private void wapbuttonSecurityWifi_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ucSecurityWifi uc = new ucSecurityWifi();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }

        private void bodBackto_MouseUp(object sender, MouseButtonEventArgs e)
        {

            dopFormBody.Children.Clear();
           
        }

        private void wapInstallCalendarWork_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ucInstallCalendarWork uc = new ucInstallCalendarWork();
            dopFormBody.Children.Clear();
            object Content = uc.Content;
            uc.Content = null;
            dopFormBody.Children.Add(Content as UIElement);
        }
    }
}
