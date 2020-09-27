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
    /// ListBoxNested.xaml 的交互逻辑
    /// </summary>
    public partial class ListBoxNested : Window
    {
        ObservableCollection<TempData> _task = null;
        public ListBoxNested()
        {
            InitializeComponent();

            LoadData();


            _task = new ObservableCollection<TempData>()
            {
                new TempData
                {
                    DataName="第一条",
                    //ListDatas=new List<ChildAttrs>()
                    //{
                    //    new ChildAttrs
                    //    {
                    //        ChildDataName="高层"
                    //    },
                    //    new ChildAttrs
                    //    {
                    //        ChildDataName="中高层"
                    //    }
                    //}
                },
                new TempData
                {
                    DataName="第2条"
                },
                new TempData
                {
                    DataName="第3条"
                },
                new TempData
                {
                    DataName="第4条"
                },
                new TempData
                {
                    DataName="第5条"
                },
            };

            _task.Add(new TempData
            {
                DataName = "属性：",
                ListDatas = new List<ChildAttrs>
            {
                new ChildAttrs
                {
                    ChildDataName="子属性"
                }
            }
            });

            DataContext = _task;

        }
             //题目类
        class question
        {
            public string qutestionName//题目名,比如:第1题或第2题等
            { get; set; }
            public ObservableCollection<choseItem> choseItems//某题中"选项类"的集合,比如A-D
            { get; set; }
            public question(string _questionname, ObservableCollection<choseItem> _choseitems)//构造函数
            {
                qutestionName = _questionname;
                choseItems = _choseitems;
            }
        }
        //选项类
        class choseItem
        {
            public string ChoseName//选项名,比如:A,B,C,D之类
            { get; set; }
            public string ChoseContent//选项内容
            { get; set; }
        }
        ObservableCollection<question> Questions = new ObservableCollection<question>();//题目数组
    

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] CharStr = new string[28] { "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D" };
            for (int i = 0; i < 5; i++)
            {
                ObservableCollection<choseItem> ChoseItems = new ObservableCollection<choseItem>();//选项数组               
                for (int j = 0; j < 14; j++)
                {
                    choseItem item = new choseItem();//选项类
                    item.ChoseName = CharStr[j] + ":";
                    item.ChoseContent = "选项内容"+j;
                    ChoseItems.Add(item);
                }
                Questions.Add(new question("__第" + (i + 1).ToString() + "题", ChoseItems));
            }
            //  listbox1.ItemsSource = Questions;

           // listbox3.ItemsSource = Questions;
        }


        void LoadData()
        {
            List<GradeItemModel> listBoxItems = new List<GradeItemModel>();

            List<StudentModel> items = new List<StudentModel>();
            items.Add(new StudentModel() { Name = "小明" });
            items.Add(new StudentModel() { Name = "小花" });
            items.Add(new StudentModel() { Name = "小米" });
            listBoxItems.Add(new GradeItemModel() {  GradeName = "一班", StudentItems = items });

            List<StudentModel> items1 = new List<StudentModel>();
            items1.Add(new StudentModel() { Name = "小一"});
            items1.Add(new StudentModel() { Name = "小二"});
            items1.Add(new StudentModel() { Name = "小三"});
            items1.Add(new StudentModel() { Name = "小三"});
            items1.Add(new StudentModel() { Name = "小三"});
            items1.Add(new StudentModel() { Name = "小三"});
            items1.Add(new StudentModel() { Name = "小三"});
            items1.Add(new StudentModel() { Name = "小三"});
            listBoxItems.Add(new GradeItemModel() {  GradeName = "二班", StudentItems = items1 });

            lbTodoList.ItemsSource = listBoxItems;
          //  listbox3.ItemsSource = listBoxItems;
        }
    }

    /// <summary>
    /// 学生实体
    /// </summary>
    public class StudentModel
    {
        public string Name { get; set; }

        /// <summary>
        /// 楼层类型数据源
        /// </summary>
        public List<GradeItemModel> GradeItems { get; set; }
    }

    /// <summary>
    /// 班级下拉框实体
    /// </summary>
    public class GradeItemModel
    {
        //public int GradeID { get; set; }
        public string GradeName { get; set; }
        public List<StudentModel> StudentItems { get; set; }
    }


    public class TempData
    {
        public string DataName { get; set; }
        public List<ChildAttrs> ListDatas { get; set; }
    }

    public class ChildAttrs
    {
        public string ChildDataName { get; set; }

    }
}
