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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

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

            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.Duration = new Duration(TimeSpan.FromSeconds(3));
            da.RepeatBehavior = RepeatBehavior.Forever;
            RotateTransform rt = new RotateTransform();
            runImg.RenderTransform = rt;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);

            LoadingWait();
        }




        public DispatcherTimer animationTimer;

        public void LoadingWait()
        {
            animationTimer = new DispatcherTimer(
               DispatcherPriority.ContextIdle, Dispatcher);
            animationTimer.Interval = new TimeSpan(0, 0, 0, 0, 90);
        }

        private void Start()
        {
            animationTimer.Tick += HandleAnimationTick;
            animationTimer.Start();
        }

        private void Stop()
        {
            animationTimer.Stop();
            animationTimer.Tick -= HandleAnimationTick;
        }

        private void HandleAnimationTick(object sender, EventArgs e)
        {
            SpinnerRotate.Angle = (SpinnerRotate.Angle + 36) % 360;
        }

        private void HandleLoaded(object sender, RoutedEventArgs e)
        {
            const double offset = Math.PI;
            const double step = Math.PI * 2 / 10.0;

            SetPosition(C0, offset, 0.0, step);
            SetPosition(C1, offset, 1.0, step);
            SetPosition(C2, offset, 2.0, step);
            SetPosition(C3, offset, 3.0, step);
            SetPosition(C4, offset, 4.0, step);
            SetPosition(C5, offset, 5.0, step);
            SetPosition(C6, offset, 6.0, step);
            SetPosition(C7, offset, 7.0, step);
            SetPosition(C8, offset, 8.0, step);
        }

        private void SetPosition(Ellipse ellipse, double offset,
            double posOffSet, double step)
        {
            ellipse.SetValue(Canvas.LeftProperty, 50.0
                + Math.Sin(offset + posOffSet * step) * 50.0);

            ellipse.SetValue(Canvas.TopProperty, 50
                + Math.Cos(offset + posOffSet * step) * 50.0);
        }

        private void HandleUnloaded(object sender, RoutedEventArgs e)
        {
            Stop();
        }

        private void HandleVisibleChanged(object sender,
            DependencyPropertyChangedEventArgs e)
        {
            bool isVisible = (bool)e.NewValue;
            if (animationTimer == null)
            {
                LoadingWait();
            }
            if (isVisible)
                Start();
            else
                Stop();
        }


        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            this._loading.Visibility = Visibility.Visible;
        }

        private void HideButton_Click(object sender, RoutedEventArgs e)
        {
            this._loading.Visibility = Visibility.Collapsed;
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

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Position = ((MediaElement)sender).Position.Add(TimeSpan.FromMilliseconds(1));
        }
    }
}
