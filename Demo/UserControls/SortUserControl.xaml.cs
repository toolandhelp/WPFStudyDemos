using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo.UserControls
{
    /// <summary>
    /// SortUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class SortUserControl : UserControl
    {
        ObservableCollection<SotrModel> _task = null;
        public SortUserControl()
        {
            InitializeComponent();

            _task = new ObservableCollection<SotrModel>()
            {
                new SotrModel
                {
                     IsItemSelected=true,
                     SortFieldName="最新上传"
                },new SotrModel
                {
                     IsItemSelected=false,
                     SortFieldName="人气"
                },new SotrModel
                {
                     IsItemSelected=false,
                     SortFieldName="下载",
                     IsShowSortIcon=Visibility.Hidden
                },new SotrModel
                {
                     IsItemSelected=false,
                     SortFieldName="收藏",
                     IsShowSortIcon=Visibility.Hidden
                },
            };

            DataContext = _task;
        }
    }

    public class SotrModel
    {
        public string SortFieldName { get; set; }
        public bool IsItemSelected { get; set; } = false;
        public Visibility IsShowSortIcon { get; set; } = Visibility.Visible;
    }
}
