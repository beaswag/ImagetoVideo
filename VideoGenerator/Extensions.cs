using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGenerator
{
    public static class Extensions
    {
        public static bool IsOneOf(this object item, params object[] options)
        {
            return options.Contains(item);
            
        }

        public static bool IsDivisible(this int x, int n)
        {
            return (x % n) == 0;
        }

        public static Bitmap Resize(Bitmap image, int width, int height)
        {
            int newWidth = width;
            int newHeight = height;
            Bitmap bitmap = image;

            using (var newImage = new Bitmap(width, height))
            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.DrawImage(bitmap, new Rectangle(0, 0, width, height));
                return newImage;
            }
        }
    }
}
