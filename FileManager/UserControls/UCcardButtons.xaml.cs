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

namespace FileManager
{
    /// <summary>
    /// UCcardButtons.xaml 的交互逻辑
    /// </summary>
    public partial class UCcardButtons : UserControl
    {
        public UCcardButtons()
        {
            InitializeComponent();
        }




        public Uri imageSource
        {
            get { return (Uri)GetValue(imageSourceProperty); }
            set { SetValue(imageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for imageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty imageSourceProperty =
            DependencyProperty.Register("imageSource", typeof(Uri), typeof(UCcardButtons));




        public string text1
        {
            get { return (string)GetValue(text1Property); }
            set { SetValue(text1Property, value); }
        }

        // Using a DependencyProperty as the backing store for text1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty text1Property =
            DependencyProperty.Register("text1", typeof(string), typeof(UCcardButtons));




        public string text2
        {
            get { return (string)GetValue(text2Property); }
            set { SetValue(text2Property, value); }
        }

        // Using a DependencyProperty as the backing store for text2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty text2Property =
            DependencyProperty.Register("text2", typeof(string), typeof(UCcardButtons));



        public int Progress
        {
            get { return (int)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Progress.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressProperty =
            DependencyProperty.Register("Progress", typeof(int), typeof(UCcardButtons));



    }
}
