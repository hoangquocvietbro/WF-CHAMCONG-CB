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
    /// Interaction logic for ucSecurityWifi.xaml
    /// </summary>
    public class Wifi
    {
        public string NameWifi { get; set; }
        public string AddressWifi { get; set; }
        public String AddressIP { get; set; }
        public DateTime UpdateWifi { get; set; }
    }
    /// <summary>
    /// Interaction logic for ucSecurityWifi.xaml
    /// </summary>
    /// 

    public partial class ucSecurityWifi : UserControl
    {
        List<Wifi> itemsWifi = new List<Wifi>();
        public ucSecurityWifi()
        {
            InitializeComponent();
            #region FakeWifi

            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 1", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 2", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 3", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 4", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 5", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 6", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 7", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 8", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 9", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 10", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 11", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 12", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 13", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 14", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 15", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 16", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 17", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 18", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 19", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            itemsWifi.Add(new Wifi() { NameWifi = "John Doe 20", AddressWifi = "Triều Khúc", AddressIP = "192.168.1.1", UpdateWifi = DateTime.Now });
            lsvLoadWifi.ItemsSource = itemsWifi;
            lsvLoaIP.ItemsSource = itemsWifi;
            #endregion
        }

       

        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (BodCreateWifi.Visibility == Visibility.Collapsed)
            {
                BodCreateWifi.Visibility = Visibility.Visible;
            }
            else
            {
                BodCreateWifi.Visibility = Visibility.Collapsed;
            }
        }

        private void Border_MouseLeftButtonUp_UpdateVisibility(object sender, MouseButtonEventArgs e)
        {
            if (bodUpdateWifi.Visibility == Visibility.Collapsed)
            {
                bodUpdateWifi.Visibility = Visibility.Visible;
            }
            else
            {
                bodUpdateWifi.Visibility = Visibility.Collapsed;
            }
        }

        private void Border_MouseLeftButtonUp_DeleteVisibility(object sender, MouseButtonEventArgs e)
        {
            if (bodDelete.Visibility == Visibility.Collapsed)
            {
                bodDelete.Visibility = Visibility.Visible;
            }
            else
            {
                bodDelete.Visibility = Visibility.Collapsed;
            }
        }

        private void Border_MouseLeftButtonUp_Ip(object sender, MouseButtonEventArgs e)
        {
            bodListIp.Visibility = Visibility.Visible;
            bodListWifi.Visibility = Visibility.Collapsed;
            borAddIp.Visibility = Visibility.Visible;
            bodAddWifi.Visibility = Visibility.Collapsed;
            lsvLoaIP.Visibility = Visibility.Visible;
            lsvLoadWifi.Visibility = Visibility.Collapsed;
            bodTextIP.Foreground = new SolidColorBrush(Colors.Blue);
            bodTextWifi.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void Border_MouseLeftButtonUp_Wifi(object sender, MouseButtonEventArgs e)
        {
            bodListWifi.Visibility = Visibility.Visible;
            bodListIp.Visibility = Visibility.Collapsed;
            borAddIp.Visibility = Visibility.Collapsed;
            bodAddWifi.Visibility = Visibility.Visible;
            bodTextWifi.Foreground = new SolidColorBrush(Colors.Blue);
            bodTextIP.Foreground = new SolidColorBrush(Colors.Black);


        }

        private void borAddIp_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (bodCreateIP.Visibility == Visibility.Collapsed)
            {
                bodCreateIP.Visibility = Visibility.Visible;
            }
            else
            {
                bodCreateIP.Visibility -= Visibility.Collapsed;
            }
        }

        private void Border_MouseLeftButtonUp_UpdateCollapsed(object sender, MouseButtonEventArgs e)
        {
            if (bodUpdateIP.Visibility == Visibility.Collapsed)
            {
                bodUpdateIP.Visibility = Visibility.Visible;
            }
            else
            {
                bodUpdateIP.Visibility -= Visibility.Collapsed;
            }
        }

        private void Border_MouseLeftButtonUp_DeleteCollapsed(object sender, MouseButtonEventArgs e)
        {
            if (bodDelete.Visibility == Visibility.Collapsed)
            {
                bodDelete.Visibility = Visibility.Visible;
            }
            else
            {
                bodDelete.Visibility = Visibility.Collapsed;
            }
        }

        private void Border_MouseLeftButtonUp_OffDelete(object sender, MouseButtonEventArgs e)
        {
            bodDelete.Visibility -= Visibility.Collapsed;
        }

        private void Border_MouseLeftButtonUp_ExitIp(object sender, MouseButtonEventArgs e)
        {
            bodCreateIP.Visibility = Visibility.Collapsed;
            BodCreateWifi.Visibility = Visibility.Collapsed;
            bodUpdateIP.Visibility = Visibility.Collapsed;
            bodUpdateWifi.Visibility = Visibility.Collapsed;
        }
    }
}
