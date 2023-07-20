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
    /// Interaction logic for ucUpdateFace.xaml
    /// </summary>
    public partial class ucUpdateFace : UserControl
    {
       
        List<Saff> itemsSaff = new List<Saff>();
        List<string> ListRoom = new List<string>() { " Kỹ Thuật", "Kinh Doanh", "Đề Án", "Sale", "Đào tạo", "Sáng Tạo" };
        List<string> ListCompany = new List<string>() { " FPT", "365", "Monsta-Lab", "Sun*" };
      
        public ucUpdateFace()
        {
            InitializeComponent();
            #region FakeSaff
            itemsSaff.Add(new Saff() { IdSaff = 50001, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto001@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50002, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto002@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50003, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto003@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50004, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto004@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50004, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto005@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50005, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto006@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50001, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto001@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50002, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto002@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50003, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto003@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50004, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto004@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50004, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto005@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50005, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto006@gmail.com", NumPhoneSaff = "0393039393" });
            #endregion
            lsvSelectRoom.ItemsSource = ListRoom;
            lsvSelectCompaty.ItemsSource = ListCompany;
            lsvListSaffInFace.ItemsSource = itemsSaff;
            lsvListNameSaff.ItemsSource = itemsSaff;
            var namesaff = from saff in itemsSaff select saff.NameSaff;
               lsvListNameSaff.ItemsSource = namesaff;
        }

        private void bodSelectCompany_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodSelectCompanyCollapsed.Visibility == Visibility.Collapsed)
            {
                bodSelectCompanyCollapsed.Visibility = Visibility.Visible;
                bodSelectNameSaffCollapsed.Visibility = Visibility.Collapsed;
                bodSelectRoomCollapsed.Visibility = Visibility.Collapsed;
                txtSelectCompany.Focus();
                
            }
            else
            {
                bodSelectCompanyCollapsed.Visibility = Visibility.Collapsed;
            }
        }

        private void bodSelectNameSaff_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodSelectNameSaffCollapsed.Visibility == Visibility.Collapsed)
            {
                bodSelectNameSaffCollapsed.Visibility = Visibility.Visible;
                bodSelectRoomCollapsed.Visibility = Visibility.Collapsed;
                bodSelectCompanyCollapsed.Visibility = Visibility.Collapsed;
                txtSelectNameSaff.Focus();
            }
            else
            {
                bodSelectNameSaffCollapsed.Visibility = Visibility.Collapsed;
            }
        }

        private void bodSelectRoom_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodSelectRoomCollapsed.Visibility == Visibility.Collapsed)
            {
                bodSelectRoomCollapsed.Visibility = Visibility.Visible;
                bodSelectCompanyCollapsed.Visibility = Visibility.Collapsed;
                bodSelectNameSaffCollapsed.Visibility = Visibility.Collapsed;
                txtSelectRoom.Focus();
            }
            else
            {
                bodSelectRoomCollapsed.Visibility = Visibility.Collapsed;
            }
        }

        private void lsvListNameSaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtSelectNameSaff.Text = lsvListNameSaff.SelectedItem.ToString();
            bodSelectNameSaffCollapsed.Visibility = Visibility.Collapsed; 
        }

        private void txtSearchYear_TextChanged(object sender, TextChangedEventArgs e)
        {
           
           
           
        }

        private void lsvSelectRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtSelectRoom.Text = lsvSelectRoom.SelectedItem.ToString();
            bodSelectRoomCollapsed.Visibility = Visibility.Collapsed;
        }

        private void lsvSelectCompaty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txbSelectCompany.Text = lsvSelectCompaty.SelectedItem.ToString();
            bodSelectCompanyCollapsed.Visibility = Visibility.Collapsed;
           
        }

        private void txtSearchNameSaff_TextChanged(object sender, TextChangedEventArgs e)
        {
 
        }

        private void checkManager_Checked(object sender, RoutedEventArgs e)
        {
            bodMessageboxYesAll.Visibility = Visibility.Visible;
            bodMessageboxNoAll.Visibility = Visibility.Collapsed;
        }

        private void checkManager_Unchecked(object sender, RoutedEventArgs e)
        {
            bodMessageboxNoAll.Visibility = Visibility.Visible;
            bodMessageboxYesAll.Visibility = Visibility.Collapsed;
        }

        private void bodOkMessageYesAll_MouseUp(object sender, MouseButtonEventArgs e)
        {
            bodMessageboxYesAll.Visibility= Visibility.Collapsed;
        }
        private void bodOkMessageNoAll_MouseUp(object sender, MouseButtonEventArgs e)
        {
            bodMessageboxNoAll.Visibility = Visibility.Collapsed;
        }

        private void bodOkMessageYesSelected_MouseUp(object sender, MouseButtonEventArgs e)
        {
            bodMessageboxYesSelected.Visibility = Visibility.Collapsed;
        }

        private void bodOkMessageNoSelected_MouseUp(object sender, MouseButtonEventArgs e)
        {
            bodMessageboxNoSelected.Visibility = Visibility.Collapsed;
        }

        private void checkManagerSelected_Checked(object sender, RoutedEventArgs e)
        {
            bodMessageboxYesSelected.Visibility = Visibility.Visible;
            bodMessageboxNoSelected.Visibility = Visibility.Collapsed;
        }

        private void checkManagerSelected_Unchecked(object sender, RoutedEventArgs e)
        {
            bodMessageboxNoSelected.Visibility = Visibility.Visible;
            bodMessageboxYesSelected.Visibility= Visibility.Collapsed;
        }
    }
}
