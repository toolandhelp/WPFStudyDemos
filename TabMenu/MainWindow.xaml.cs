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

namespace TabMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (90 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    GridMaim.Background = Brushes.Aquamarine;
                    break;
                case 1:
                    GridMaim.Background = Brushes.AntiqueWhite;
                    break;
                case 2:
                    GridMaim.Background = Brushes.Beige;
                    break;
                case 3:
                    GridMaim.Background = Brushes.SeaGreen;
                    break;
                case 4:
                    GridMaim.Background = Brushes.Aqua;
                    break;
                case 5:
                    GridMaim.Background = Brushes.Blue;
                    break;
                case 6:
                    GridMaim.Background = Brushes.Black;
                    break;
                case 7:
                    GridMaim.Background = Brushes.Tomato;
                    break;
                case 8:
                    GridMaim.Background = Brushes.Red;
                    break;
                case 9:
                    GridMaim.Background = Brushes.BurlyWood;
                    break;
                case 10:
                    GridMaim.Background = Brushes.Gray;
                    break;
            }

        }

        private void ContentPresenter_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int index = int.Parse(((System.Windows.UIElement)((System.Windows.FrameworkElement)e.Source).TemplatedParent).Uid);
             switch (index)
            {
                case 0:
                    GridMaim.Background = Brushes.Aquamarine;
                    break;
                case 1:
                    GridMaim.Background = Brushes.AntiqueWhite;
                    break;
                case 2:
                    GridMaim.Background = Brushes.Beige;
                    break;
                case 3:
                    GridMaim.Background = Brushes.SeaGreen;
                    break;
                case 4:
                    GridMaim.Background = Brushes.Aqua;
                    break;
                case 5:
                    GridMaim.Background = Brushes.Blue;
                    break;
                case 6:
                    GridMaim.Background = Brushes.Black;
                    break;
                case 7:
                    GridMaim.Background = Brushes.Tomato;
                    break;
                case 8:
                    GridMaim.Background = Brushes.Red;
                    break;
                case 9:
                    GridMaim.Background = Brushes.BurlyWood;
                    break;
                case 10:
                    GridMaim.Background = Brushes.Gray;
                    break;
            }
        }
    }
}
