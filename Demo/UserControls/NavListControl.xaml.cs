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
    /// NavListControl.xaml 的交互逻辑
    /// </summary>
    public partial class NavListControl : UserControl
    {
        ObservableCollection<TopMenuModel> _task = null;
        public NavListControl()
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
                 },
                 new TopMenuModel
                 {
                     MenuName="SU 模 型"
                 },
                 new TopMenuModel
                 {
                     MenuName=" 总 图 "
                 },
                 new TopMenuModel
                 {
                     MenuName=" 平 面 ",
                     PartitionVisibility= Visibility.Hidden
                 },
                 //new TopMenuModel
                 //{
                 //    MenuName=" 文 本 "
                 //},
                 //new TopMenuModel
                 //{
                 //    MenuName="建筑规范"
                 //},
                 //new TopMenuModel
                 //{
                 //    MenuName="新 楼 盘"
                 //}
            };
            DataContext = _task;
        }
    }
}
