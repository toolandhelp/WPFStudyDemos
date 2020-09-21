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

namespace Chat_2.UserUcontrols
{
    /// <summary>
    /// UCRoundProfileButton.xaml 的交互逻辑
    /// </summary>
    public partial class UCRoundProfileButton : UserControl
    {
        public UCRoundProfileButton()
        {
            InitializeComponent();
        }



        public ImageSource ProfileImageSource
        {
            get { return (ImageSource)GetValue(ProfileImageSourceProperty); }
            set { SetValue(ProfileImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProfileImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProfileImageSourceProperty =
            DependencyProperty.Register("ProfileImageSource", typeof(ImageSource), typeof(UCRoundProfileButton));






        public bool IsOnline
        {
            get { return (bool)GetValue(IsOnlineProperty); }
            set { SetValue(IsOnlineProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOnline.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOnlineProperty =
            DependencyProperty.Register("IsOnline", typeof(bool), typeof(UCRoundProfileButton));




        public Color StrokeBrush
        {
            get { return (Color)GetValue(StrokeBrushProperty); }
            set { SetValue(StrokeBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StrokeBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StrokeBrushProperty =
            DependencyProperty.Register("StrokeBrush", typeof(Color), typeof(UCRoundProfileButton));





        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserNameProperty =
            DependencyProperty.Register("UserName", typeof(string), typeof(UCRoundProfileButton));




        public string Availability
        {
            get { return (string)GetValue(AvailabilityProperty); }
            set { SetValue(AvailabilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Availability.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AvailabilityProperty =
            DependencyProperty.Register("Availability", typeof(string), typeof(UCRoundProfileButton));



    }
}
