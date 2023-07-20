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
    /// Interaction logic for ucTest.xaml
    /// </summary>
    public partial class ucTest : UserControl
    {
        List<string> MyList = new List<string>() { "1","2"};
        public ucTest()
        {
            InitializeComponent();
            //myListView.ItemsSource = MyList;    
        }

        private void lsvHours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        //private void myListView_Loaded(object sender, RoutedEventArgs e)
        //{
        //    if (myListView.Items.Count > 0)
        //    {
        //        // Get the last item
        //        var lastItem = myListView.Items[myListView.Items.Count-1];

        //        // Apply the custom template to the last item
        //        var lastItemContainer = myListView.ItemContainerGenerator.ContainerFromItem(lastItem) as ListViewItem;
        //        if (lastItemContainer != null)
        //        {
        //            lastItemContainer.ContentTemplate = myListView.Resources["LastItemTemplate"] as DataTemplate;
        //        }
        //    }
        //}



    }
}
