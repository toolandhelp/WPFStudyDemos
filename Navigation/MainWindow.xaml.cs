﻿using MaterialDesignThemes.Wpf;
using Navigation.Domin;
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

namespace Navigation
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

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Link.OpenInBrowser("https://feedback.com/");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Link.OpenInBrowser("https://feedback.com/");
        }

        private void DialogHost_OnDialogClosing(object sender,DialogClosingEventArgs e)
        {
            Console.WriteLine("关闭事件……");
        }
    }
}
