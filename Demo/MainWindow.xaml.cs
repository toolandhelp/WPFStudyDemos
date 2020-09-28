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

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<TopMenuModel> _task = null;

        public MainWindow()
        {
            InitializeComponent();

            _task = new ObservableCollection<TopMenuModel>()
            {
                 new TopMenuModel
                 {
                     MenuName=" 首 页 ",
                     Icon= "M971.6736 445.2352L594.8416 53.3504a122.2656 122.2656 0 0 0-176.5376 0L41.5744 445.2352c-38.912 40.96-33.8944 75.4688-27.5456 90.0096a65.536 65.536 0 0 0 64.6144 38.912h55.296v301.4656c0 68.4032 49.152 133.12 119.0912 133.12h160.3584V689.4592c0-34.2016-5.12-53.248 29.7984-53.248h126.7712c35.0208 0 29.7984 19.0464 29.7984 53.248v319.0784h160.4608c69.8368 0 119.0912-64.512 119.0912-133.12V574.1568h55.1936a65.536 65.536 0 0 0 64.6144-38.912c6.4512-14.5408 11.4688-49.5616-27.4432-90.0096z"
                 },
                 new TopMenuModel
                 {
                     MenuName="示 范 区"
                 },
                 new TopMenuModel
                 {
                     MenuName=" 楼 盘 "
                 },
                 new TopMenuModel
                 {
                     MenuName="效 果 图"
                 }
            };
            DataContext = _task;

            //InitTopMenu();
        }

        private void InitTopMenu()
        {
            DataContext = new List<TopMenuModel>
            {
                 new TopMenuModel{ MenuName=" 首 页 "},
                 new TopMenuModel{ MenuName="示 范 区"},
                 new TopMenuModel{ MenuName=" 楼 盘 "},
                 new TopMenuModel{ MenuName="效 果 图"}
            };
        }

        private void ContentPresenter_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int index = int.Parse(((System.Windows.UIElement)((System.Windows.FrameworkElement)e.Source).TemplatedParent).Uid);


            MessageBox.Show(((System.Windows.Controls.ContentPresenter)sender).Content.ToString());
            //switch (index)
            //{
            //    case 0:
            //        GridMaim.Background = Brushes.Aquamarine;
            //        break;
            //    case 1:
            //        GridMaim.Background = Brushes.AntiqueWhite;
            //        break;
            //    case 2:
            //        GridMaim.Background = Brushes.Beige;
            //        break;
            //    case 3:
            //        GridMaim.Background = Brushes.SeaGreen;
            //        break;
            //    case 4:
            //        GridMaim.Background = Brushes.Aqua;
            //        break;
            //    case 5:
            //        GridMaim.Background = Brushes.Blue;
            //        break;
            //    case 6:
            //        GridMaim.Background = Brushes.Black;
            //        break;
            //    case 7:
            //        GridMaim.Background = Brushes.Tomato;
            //        break;
            //    case 8:
            //        GridMaim.Background = Brushes.Red;
            //        break;
            //    case 9:
            //        GridMaim.Background = Brushes.BurlyWood;
            //        break;
            //    case 10:
            //        GridMaim.Background = Brushes.Gray;
            //        break;
            //}
        }

        private void ListBoxItem_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Console.WriteLine(e);
            //Foreground = "#FFFF3C00"
        }

    }

    public class TopMenuModel
    {
        public string MenuName { get; set; }

        public string Icon { get; set; }

        public bool IsItemSelected { get; set; } = false;

        public Visibility PartitionVisibility { get; set; } = Visibility.Visible;
        

    }


   
    //类型名称
    public class AttrType
    {
        public string AttrTypeName { get; set; }
        public List<ChildAttrName> ChildAttrs { get; set; }
        public Visibility Visibility { get; set; } = Visibility.Visible;
    }

    //类型名称子属性
    public class ChildAttrName
    {
        public string AttrName { get; set; }
    }
}
