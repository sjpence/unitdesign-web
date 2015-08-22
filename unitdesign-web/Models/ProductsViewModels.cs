using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace unitdesign_web.Models
{
    public class ImageMetaData
    {
        public ImageMetaData(string path, string altText)
        {
            Path = path;
            AltText = altText;
        }

        public string Path { get; private set; }
        public string AltText { get; private set; }
    }

    public class MdsViewModel
    {
        public MdsViewModel()
        {
            SliderImages = new List<ImageMetaData>();
        }
        public IList<ImageMetaData> SliderImages { get; set; }
    }
}