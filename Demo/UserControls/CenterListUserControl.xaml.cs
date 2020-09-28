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
    /// CenterListUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class CenterListUserControl : UserControl
    {
        ObservableCollection<CententModel> _task = null;
        public CenterListUserControl()
        {
            InitializeComponent();

            _task = new ObservableCollection<CententModel>
            {
                new CententModel
                {
                    ProfileName="张大姐",
                    ProfilePictureImageUrl="/assets/user-1.png",
                    IsFavorites=true,
                    Title="广东设计示范区",
                    View=599,
                    ItmeImageUrl="/assets/item-1.jpg"
                },
                new CententModel
                {
                    ProfileName="张2姐",
                    ProfilePictureImageUrl="/assets/user-3.png",
                    Title="设计示范区",
                    View=599,
                    ItmeImageUrl="/assets/item-2.jpg"
                }, new CententModel
                {
                    ProfileName="张3姐",
                    ProfilePictureImageUrl="/assets/user-1.png",
                    IsFavorites=true,
                    Title="广东设计示范区",
                    View=599,
                    ItmeImageUrl="/assets/item-1.jpg"
                },
            };

            DataContext = _task;
        }
    }

    public class CententModel
    {
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ItmeImageUrl { get; set; }
        /// <summary>
        /// 查看次数
        /// </summary>
        public int View { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 收藏
        /// </summary>
        public bool IsFavorites { get; set; } = false;
        /// <summary>
        /// 用户头像图片路径
        /// </summary>
        public string ProfilePictureImageUrl { get; set; }
        /// <summary>
        /// 用户名字
        /// </summary>
        public string ProfileName { get; set; }
    }
}
