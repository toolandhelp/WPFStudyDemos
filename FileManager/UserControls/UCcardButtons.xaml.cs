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

namespace FileManager.UserControls
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

        public Uri ImageSource
        {
            get { return (Uri)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(Uri), typeof(UCcardButtons));




        public string Text1
        {
            get { return (string)GetValue(Text1Property); }
            set { SetValue(Text1Property, value); }
        }

        // Using a DependencyProperty as the backing store for Text1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Text1Property =
            DependencyProperty.Register("Text1", typeof(string), typeof(UCcardButtons));




        public string Text2
        {
            get { return (string)GetValue(Text2Property); }
            set { SetValue(Text2Property, value); }
        }

        // Using a DependencyProperty as the backing store for Text2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Text2Property =
            DependencyProperty.Register("Text2", typeof(string), typeof(UCcardButtons));



        public int Progress
        {
            get { return (int)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Progress.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressProperty =
            DependencyProperty.Register("Progress", typeof(int), typeof(UCcardButtons));



        public Brush ProgressIndicatorBrush
        {
            get { return (Brush)GetValue(ProgressIndicatorBrushProperty); }
            set { SetValue(ProgressIndicatorBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressIndicatorBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressIndicatorBrushProperty =
            DependencyProperty.Register("ProgressIndicatorBrush", typeof(Brush), typeof(UCcardButtons));



        public Brush ProgressBackgroundBrush
        {
            get { return (Brush)GetValue(ProgressBackgroundBrushProperty); }
            set { SetValue(ProgressBackgroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressBackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressBackgroundBrushProperty =
            DependencyProperty.Register("ProgressBackgroundBrush", typeof(Brush), typeof(UCcardButtons));


        public int ProgressArcThickness
        {
            get { return (int)GetValue(ProgressArcThicknessProperty); }
            set { SetValue(ProgressArcThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressArcThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressArcThicknessProperty =
            DependencyProperty.Register("ProgressArcThickness", typeof(int), typeof(UCcardButtons));




        public Brush ProgressIndicatorBrushMouseOver
        {
            get { return (Brush)GetValue(ProgressIndicatorBrushMouseOverProperty); }
            set { SetValue(ProgressIndicatorBrushMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressIndicatorBrushMouseOver.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressIndicatorBrushMouseOverProperty =
            DependencyProperty.Register("ProgressIndicatorBrushMouseOver", typeof(Brush), typeof(UCcardButtons));



        public Brush ProgressBackgroundBrushMouseOver
        {
            get { return (Brush)GetValue(ProgressBackgroundBrushMouseOverProperty); }
            set { SetValue(ProgressBackgroundBrushMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressBackgroundBrushMouseOver.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressBackgroundBrushMouseOverProperty =
            DependencyProperty.Register("ProgressBackgroundBrushMouseOver", typeof(Brush), typeof(UCcardButtons));





        public SolidColorBrush IconBackground
        {
            get { return (SolidColorBrush)GetValue(IconBackgroundProperty); }
            set { SetValue(IconBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register("IconBackground", typeof(SolidColorBrush), typeof(UCcardButtons));




        public SolidColorBrush IconBackgroundMouseOver
        {
            get { return (SolidColorBrush)GetValue(IconBackgroundMouseOverProperty); }
            set { SetValue(IconBackgroundMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBackgroundMouseOver.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundMouseOverProperty =
            DependencyProperty.Register("IconBackgroundMouseOver", typeof(SolidColorBrush), typeof(UCcardButtons));


        
        public Brush ProgressTextColor
        {
            get { return (Brush)GetValue(ProgressTextColorProperty); }
            set { SetValue(ProgressTextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressTextColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressTextColorProperty =
            DependencyProperty.Register("ProgressTextColor", typeof(Brush), typeof(UCcardButtons));


        public Color ProgressTextColorMouseOver
        {
            get { return (Color)GetValue(ProgressTextColorMouseOverProperty); }
            set { SetValue(ProgressTextColorMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressTextColorMouseOver.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressTextColorMouseOverProperty =
            DependencyProperty.Register("ProgressTextColorMouseOver", typeof(Color), typeof(UCcardButtons));



        public FontWeight ProgressTextWeight
        {
            get { return (FontWeight)GetValue(ProgressTextWeightProperty); }
            set { SetValue(ProgressTextWeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressTextWeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressTextWeightProperty =
            DependencyProperty.Register("ProgressTextWeight", typeof(FontWeight), typeof(UCcardButtons));




    }
}
