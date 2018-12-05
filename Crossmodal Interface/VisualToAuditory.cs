using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossmodal_Interface
{
    public partial class VisualToAuditory : Form
    {
        private int count = 0;
        private Size size1 = new Size(100, 100);
        private Size size2 = new Size(200, 200);
        private Size size3 = new Size(300, 300);
        public VisualToAuditory()
        {
            InitializeComponent();
            redDot.Size = size1;
        }

        private void VisualToAuditory_Load(object sender, EventArgs e)
        {

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //This method is used to control the size
            if(e.KeyCode == Keys.Right)
            {
                if(!(count == 3))
                {
                    count++;
                }
            }
            else if(e.KeyCode == Keys.Left)
            {
                if(!(count == 1))
                {
                    count--;
                }
            }
            switch (count)
            {
                case 1:
                    redDot.Size = size1;
                break;
                case 2:
                    redDot.Size = size2;
                    break;
                case 3:
                    redDot.Size = size3;
                    break;
                


            }
        }
        //method used to resize the dot
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
