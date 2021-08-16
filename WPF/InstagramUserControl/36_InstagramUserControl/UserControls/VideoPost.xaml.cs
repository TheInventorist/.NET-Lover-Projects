using _36_InstagramUserControl.Models;
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

namespace _36_InstagramUserControl.UserControls
{
    /// <summary>
    /// Lógica de interacción para VideoPost.xaml
    /// </summary>
    public partial class VideoPost : UserControl
    {
        public VideoPost(VideoPostModel videoPostModel)
        {
            InitializeComponent();
            VideoPlayer.Source = videoPostModel.VideoPlayerSource;
        }

        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (PostOps.postliked)
            {
                PostOps.unlikePost();
            }
            else
            {
                PostOps.likePost();
            }
        }
    }
}
