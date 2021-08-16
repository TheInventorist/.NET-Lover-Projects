using _36_InstagramUserControl.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_InstagramUserControl.Models
{
    public class VideoPostModel
    {
        public Uri _videoPlayerSource;

        public Uri VideoPlayerSource
        {
            get
            {
                if (_videoPlayerSource == null) return MockDB.GetPostVideo();
                else return _videoPlayerSource;
            }
            set
            {
                _videoPlayerSource = value;
            }
        }
    }
}
