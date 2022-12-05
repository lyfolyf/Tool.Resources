using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Lead.Tool.Resources
{
    public class ImageManager
    {
        public static Image GetImage(string Name)
        {
            ResourceManager manager = new ResourceManager(typeof(Resource1));
            return (Image)manager.GetObject(Name);
        }
    }
}
