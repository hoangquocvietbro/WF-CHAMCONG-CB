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
    /// Interaction logic for ucInstallCalendarWork.xaml
    /// </summary>
    ///

    public class Saff
    {
        public string NameSaff { get; set; }
        public int IdSaff { get; set; }
        public string ImageSaff { get; set; }
        public string MonthYear { get; set; }
        public int NubSaff { get; set; }
        public string EmailSaff { get; set; }
        public string NumPhoneSaff { get; set; }
    }
    public partial class ucInstallCalendarWork : UserControl
    {
        List<string> listSearch = new List<string>();
        List<Saff> itemsSaff = new List<Saff>();
        List<String> itemsLich = new List<String>() { "Thứ 2 - Thứ 6", "Thứ 2 - Thứ 7", "Thứ 2 - CN" };
        List<string> listYear = new List<string>() { "Năm 2023", "Năm 2024", "Năm 2025", "Năm 2026", "Năm 2027" };
        List<string> listMonth = new List<string>() { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
        public ucInstallCalendarWork()
        {
            InitializeComponent();
            txbSelectMonth.Text = listMonth[0];
            txbSelectYear.Text = listYear[0];

            #region FakeSaff
            itemsSaff.Add(new Saff() { IdSaff = 50001, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto001@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50002, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto002@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50003, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto003@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50004, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto004@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50004, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto005@gmail.com", NumPhoneSaff = "0393039393" });
            itemsSaff.Add(new Saff() { IdSaff = 50005, NameSaff = "Tô Ngọc Ký", ImageSaff = "./Resource/image/KyTo.jpg", NubSaff = 1, MonthYear = "Tháng 6-2023", EmailSaff = "ngockyto006@gmail.com", NumPhoneSaff = "0393039393" });
            #endregion
            lsvListSaffSmall.ItemsSource = itemsSaff;
            lsvListSaff.ItemsSource = itemsSaff;
            lsvCalendarMonth.ItemsSource = itemsSaff;
            lsvListMonth.ItemsSource = listMonth;
            lsvListYear.ItemsSource = listYear;
            lsvloadSaff.ItemsSource = itemsSaff;
            lsvTestSaff.ItemsSource = itemsSaff;
            lsvLich.ItemsSource = itemsLich;
        }
        private void lsvListMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txbSelectMonth.Text = lsvListMonth.SelectedItem.ToString();
            bodMonth.Visibility = Visibility.Collapsed;

        }

        private void bodMonth_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (bodMonth.Visibility == Visibility.Collapsed)
            {
                bodMonth.Visibility = Visibility.Visible;
                txtSearchMonth.Focus();
            }
            else
            {
                bodMonth.Visibility -= Visibility.Collapsed;
            }
        }

        private void txtSearchMonth_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var itemMoth in listMonth)
            {
                if (itemMoth.ToLower().Contains(txtSearchMonth.Text.ToString()))
                {
                    listSearch.Add(itemMoth);
                }

            }
            lsvListMonth.ItemsSource = listSearch;
        }

        private void txtSearchYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var itemYear in listYear)
            {
                if (itemYear.ToLower().Contains(txtSearchYear.Text.ToString()))
                {
                    listSearch.Add(itemYear);
                }

            }
            lsvListYear.ItemsSource = listSearch;
        }

        private void lsvListYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txbSelectYear.Text = lsvListYear.SelectedItem.ToString();
            bodYear.Visibility = Visibility.Collapsed;
        }

        private void bodYear_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (bodYear.Visibility == Visibility.Collapsed)
            {
                bodYear.Visibility = Visibility.Visible;
                txtSearchYear.Focus();
            }
            else
            {
                bodYear.Visibility -= Visibility.Collapsed;
            }
        }

        private void bodAddLich_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (bodAddLich.Visibility == Visibility.Collapsed)
            {
                bodAddLich.Visibility = Visibility.Visible;
                txtNameCalendar.Text = "";
                txtNameCalendar.Focus();
                txbSelectLich.Text = itemsLich[0];
                dapMonth.SelectedDate = DateTime.Now;
                dapYear.SelectedDate = DateTime.Now;

            }
            else
            {
                bodAddLich.Visibility = Visibility.Collapsed;
                bodLich.Visibility = Visibility.Collapsed;
            }
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bodAddLich.Visibility = Visibility.Collapsed;
            bodLich.Visibility = Visibility.Collapsed;
            bodlistviewCoppyCalendar.Visibility = Visibility.Collapsed;
            bodAddSaff.Visibility = Visibility.Collapsed;
            stpListMethond.Visibility = Visibility.Collapsed;


        }

        private void lsvLich_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txbSelectLich.Text = lsvLich.SelectedItem.ToString();
            bodLich.Visibility = Visibility.Collapsed;
        }

        private void Image_MouseLeftButtonUp_SelectLich(object sender, MouseButtonEventArgs e)
        {
            if (bodLich.Visibility == Visibility.Collapsed)
            {
                bodLich.Visibility = Visibility.Visible;
            }
            else
            {
                bodLich.Visibility -= Visibility.Collapsed;

            }
        }

        private void bodContinue_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (bodContinue.Visibility == Visibility.Collapsed)
            {
                bodContinue.Visibility = Visibility.Visible;
                bodAddLich.Visibility = Visibility.Collapsed;
            }
            else
            {
                bodContinue.Visibility -= Visibility.Collapsed;
            }
        }



        private void BorderBack_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bodContinue.Visibility = Visibility.Collapsed;
            bodAddLich.Visibility = Visibility.Visible;
        }

        private void bodButonCoppyCalendar_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodlistviewCoppyCalendar.Visibility == Visibility.Collapsed)
            {
                bodlistviewCoppyCalendar.Visibility = Visibility.Visible;
                dapMonthCoppyCalendar.SelectedDate = DateTime.Now;
            }
            else
            {
                bodlistviewCoppyCalendar.Visibility = Visibility.Collapsed;
            }
        }

        private void bodListMethond_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (stpListMethond.Visibility == Visibility.Collapsed)
            {
                stpListMethond.Visibility = Visibility.Visible;
            }
            else
            {
                stpListMethond.Visibility = Visibility.Collapsed;
            }
        }

        private void dopAddSaff_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodAddSaff.Visibility == Visibility.Collapsed)
            {
                bodAddSaff.Visibility = Visibility.Visible;
            }
            else
            {
                bodAddSaff.Visibility = Visibility.Collapsed;
            }
        }

        private void bodButonAddFileSaff_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodAddFileSaff.Visibility == Visibility.Collapsed)
            {
                bodAddFileSaff.Visibility = Visibility.Visible;
            }
            else
            {
                bodAddFileSaff.Visibility = Visibility.Collapsed;
            }
        }

        private void ImageExitAddFileSaff_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            bodAddFileSaff.Visibility = Visibility.Collapsed;
        }

        private void dopListSaffSmall_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodListSaffSmall.Visibility == Visibility.Collapsed)
            {
                bodListSaffSmall.Visibility = Visibility.Visible;

            }
            else
            {
                bodListSaffSmall.Visibility = Visibility.Collapsed;
            }
        }

        private void dopCoppyCalendarSaff_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodlistviewCoppyCalendar.Visibility == Visibility.Collapsed)
            {
                bodlistviewCoppyCalendar.Visibility = Visibility.Visible;
                stpListMethond.Visibility = Visibility.Collapsed;

            }
            else
            {
                bodlistviewCoppyCalendar.Visibility = Visibility.Collapsed;
            }
        }

        private void bodDeleteCalendarSaff_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (bodDeleteCalendar.Visibility == Visibility.Collapsed)
            {
                bodDeleteCalendar.Visibility = Visibility.Visible;

            }
            else
            {
                bodDeleteCalendar.Visibility = Visibility.Collapsed;
            }
        }

        private void bodCancel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            bodDeleteCalendar.Visibility = Visibility.Collapsed;
            stpListMethond.Visibility = Visibility.Collapsed;
        }

        private void stpListMethond_MouseEnter(object sender, MouseEventArgs e)
        {
            txbAddSaff.Foreground = new SolidColorBrush(Colors.Blue);
            txbListSaff.Foreground = new SolidColorBrush(Colors.Blue);
            txbCoppySaff.Foreground = new SolidColorBrush(Colors.Blue);
            txbEditSaff.Foreground = new SolidColorBrush(Colors.Blue);
            txbDeleteCalendarSaff.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void stpListMethond_MouseLeave(object sender, MouseEventArgs e)
        {
            txbAddSaff.Foreground = new SolidColorBrush(Colors.Black);
            txbListSaff.Foreground = new SolidColorBrush(Colors.Black);
            txbCoppySaff.Foreground = new SolidColorBrush(Colors.Black);
            txbEditSaff.Foreground = new SolidColorBrush(Colors.Black);
            txbDeleteCalendarSaff.Foreground = new SolidColorBrush(Colors.Black);
        }
    }
}
