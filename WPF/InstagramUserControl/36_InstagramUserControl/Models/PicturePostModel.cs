using _36_InstagramUserControl.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _36_InstagramUserControl.Models
{
    public class PicturePostModel
    {
        BitmapImage _postImage;

        public BitmapImage PostImage
        {
            get
            {
                if (_postImage == null) return MockDB.GetPostPicture();
                else return _postImage;
            }
            set
            {
                _postImage = value;
            }
        }
    }
}
