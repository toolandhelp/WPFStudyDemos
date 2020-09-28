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
    /// SelectedAttrControl.xaml 的交互逻辑
    /// </summary>
    public partial class SelectedAttrControl : UserControl
    {
        ObservableCollection<AttrModel> _task = null;
        public SelectedAttrControl()
        {
            InitializeComponent();

            _task = new ObservableCollection<AttrModel>()
            {
                 new AttrModel
                 {
                     AttrFatherName="类型",
                     AttrChailName="小区出入口"
                 },new AttrModel
                 {
                     AttrFatherName="风格",
                     AttrChailName="新古典"
                 },new AttrModel
                 {
                     AttrFatherName="色调",
                     AttrChailName="日景"
                 },new AttrModel
                 {
                     AttrFatherName="类型",
                     AttrChailName="小区出入口"
                 },new AttrModel
                 {
                     AttrFatherName="公司属地",
                     AttrChailName="上海市"
                 },new AttrModel
                 {
                     AttrFatherName="属地1",
                     AttrChailName="值1"
                 },new AttrModel
                 {
                     AttrFatherName="属地2",
                     AttrChailName="值2"
                 }
            };

            DataContext = _task;
        }
    }

    public class AttrModel
    {
        public string AttrFatherName { get; set; }
        public string AttrChailName { get; set; }
    }
}
