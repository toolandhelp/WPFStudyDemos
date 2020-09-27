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
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// demo1.xaml 的交互逻辑
    /// </summary>
    public partial class demo1 : Window
    {
        ObservableCollection<AttrType> _task = null;
        public demo1()
        {
            InitializeComponent();
            // LoadData();

            _task = new ObservableCollection<AttrType>()
            {
                 new AttrType
                    {
                        AttrTypeName="类型",
                        ChildAttrs = new List<ChildAttrName>
                        {
                            new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮12"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }, new ChildAttrName
                            {
                                AttrName="按钮1"
                            }
                        }
                    },
                 new AttrType
                 {
                     AttrTypeName="类型2",
                     ChildAttrs = new List<ChildAttrName>
                     {
                         new ChildAttrName
                         {
                             AttrName="按钮1"
                         }, new ChildAttrName
                         {
                             AttrName="按钮2"
                         }, new ChildAttrName
                         {
                             AttrName="按钮3"
                         }
                     }
                 }
            };
            DataContext = _task;
        }


        void LoadData()
        {
            List<GradeItemModel> listBoxItems = new List<GradeItemModel>();

            List<StudentModel> items = new List<StudentModel>();
            items.Add(new StudentModel() { Name = "小明"});
            items.Add(new StudentModel() { Name = "小花"});
            items.Add(new StudentModel() { Name = "小米"});
            listBoxItems.Add(new GradeItemModel() { GradeName = "一班", StudentItems = items });

            List<StudentModel> items1 = new List<StudentModel>();
            items1.Add(new StudentModel() { Name = "小一" });
            items1.Add(new StudentModel() { Name = "小二" });
            items1.Add(new StudentModel() { Name = "小三" });
            items1.Add(new StudentModel() { Name = "小三" });
            items1.Add(new StudentModel() { Name = "小三" });
            items1.Add(new StudentModel() { Name = "小三" });
            items1.Add(new StudentModel() { Name = "小三" });
            items1.Add(new StudentModel() { Name = "小三" });
            listBoxItems.Add(new GradeItemModel() { GradeName = "二班 ：", StudentItems = items1 });

            listbox.ItemsSource = listBoxItems;
            //  listbox3.ItemsSource = listBoxItems;
        }
    }
}
