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
    /// Lógica de interacción para PostOperationsUC.xaml
    /// </summary>
    public partial class PostOperationsUC : UserControl
    {
        public bool postliked { get; set; }
        public PostOperationsUC()
        {
            InitializeComponent();
        }

        public void likePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\..\Icons\like.png", UriKind.RelativeOrAbsolute));
            postliked = true;
        }

        public void unlikePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\..\Icons\nolike.png", UriKind.RelativeOrAbsolute));
            postliked = false;
        }

        private void Heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!postliked)
            {
                likePost();
            }
            else
            {
                unlikePost();
            }
        }
    }
}
