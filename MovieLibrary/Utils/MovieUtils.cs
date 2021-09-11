using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Utils
{
    public class MovieUtils
    {

        public static Image getImage(string url)
        {
            try
            {
                Image img;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(url);
                MemoryStream ms = new MemoryStream(bytes);
                img = Image.FromStream(ms);
                return img;
            }
            catch (Exception)
            {
                //return Image.FromFile("blank.jpg");
                return null;
            }

        }

    }
}
