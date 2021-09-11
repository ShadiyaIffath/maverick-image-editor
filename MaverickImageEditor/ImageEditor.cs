using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Threading;

namespace MaverickImageEditor
{
    class ImageEditor
    {
        private Bitmap img;

        public ImageEditor(Bitmap img)
        {
            this.img = img;
        }

        public Bitmap GrayScale(CancellationToken token) //grayscale filter 
        {
            var objectLock = new object();
            Bitmap temp = (Bitmap)img.Clone();
            Parallel.For(0, 2, (i,LoopControl) =>
            {
                int height = 0;
                int inHeight = 0;
                int width = 0;
                if (i == 0)
                {
                    lock (objectLock)
                    {
                        height = temp.Height / 2;
                        inHeight = 0;
                        width = temp.Width;
                    }
                }
                else
                {
                    lock (objectLock)
                    {
                        height = temp.Height;
                        inHeight = temp.Height / 2;
                        width = temp.Width;
                    }
                }
                for (int w = 0; w < width; w++)
                {
                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                        LoopControl.Stop();

                    }
                    for (int h = inHeight; h < height; h++)
                    {
                        Color c;
                        lock (objectLock)
                        {
                            c = temp.GetPixel(w, h);
                        }
                        int a = c.A;
                        int r = c.R;
                        int g = c.G;
                        int b = c.B;

                        int avg = (r + g + b) / 3;  //find average
                        lock (objectLock)
                        {
                            temp.SetPixel(w, h, Color.FromArgb(a, avg, avg, avg));
                        }
                    }
                }
            });
            img = temp;
            return img;
        }

        public Bitmap Brightness(int brightness, CancellationToken token)
        {
            var objectLock = new object();
            Bitmap temp = (Bitmap)img.Clone();
            if (brightness < -255) brightness = -255;
            if (brightness > 255) brightness = 255;

            Parallel.For(0, 2, (i, LoopControl) =>
            {
                int height = 0;
                int inHeight = 0;
                int width = 0;
                if (i == 0)
                {
                    lock (objectLock)
                    {
                        height = temp.Height / 2;
                        inHeight = 0;
                        width = temp.Width;
                    }

                }
                else
                {
                    lock (objectLock)
                    {
                        height = temp.Height;
                        inHeight = temp.Height / 2;
                        width = temp.Width;
                    }
                }
                for (int w = 0; w < width; w++)
                {
                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                        LoopControl.Stop();
                    }
                    for (int h = inHeight; h < height; h++)
                    {
                        Color c;
                        lock (objectLock)
                        {
                            c = temp.GetPixel(w, h);
                        }
                        int r = c.R + brightness;
                        int g = c.G + brightness;
                        int b = c.B + brightness;

                        if (r < 0) r = 1;
                        if (r > 255) r = 255;

                        if (g < 0) g = 1;
                        if (g > 255) g = 255;

                        if (b < 0) b = 1;
                        if (b > 255) b = 255;

                        lock (objectLock)
                        {
                            temp.SetPixel(w, h, Color.FromArgb((byte)r, (byte)g, (byte)b));
                        }
                    }
                }
            });
            
            img = temp;
            return img;
        }

        public Bitmap Flip(int rotate)
        {
            Bitmap temp = (Bitmap)img.Clone();
            if (rotate == 90)
            {
                temp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if(rotate == -90)
            {
                temp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if (rotate == 180)
            {
                temp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if(rotate == 0)
            {
                temp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            else if(rotate == -180)
            {
                temp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            img = temp;
            return img;

        }
        public Bitmap Img
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
            }
        }

        public Bitmap Invert(CancellationToken token)
        {
            Bitmap temp = (Bitmap)img.Clone();
            var objectLock = new object();
            int[] inHeights = { 0, (temp.Height / 2) };
            int width = temp.Width;
            int lastHeight = 0;
            Parallel.ForEach(inHeights, (height, LoopControl) =>
             {
                 if(height == 0)
                 {
                     lastHeight = (temp.Height/2);
                 }
                 else
                 {
                     lastHeight = (height *2);
                 }
                 for (int w = 0; w < width; w++)
                 {
                     if (token.IsCancellationRequested)
                     {
                         token.ThrowIfCancellationRequested(); ;
                         LoopControl.Stop();
                     }

                     for (int h = height; h < lastHeight; h++)
                     {
                         //Interlocked.Read( ref temp );
                         Color c = temp.GetPixel(w, h);
                         temp.SetPixel(w, h, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));

                     }
                 }
             });

            
            //Parallel.For(0, 2, (i, LoopControl) =>
            //{
            //    int height = 0;
            //    int inHeight = 0;
            //    int width = 0;
            //    if (i == 0)
            //    {
            //        lock (objectLock)
            //        {
            //            height = temp.Height / 2;
            //            inHeight = 0;
            //            width = temp.Width;
            //        }
            //    }
            //    else
            //    {
            //        lock (objectLock)
            //        {
            //            height = temp.Height;
            //            inHeight = temp.Height / 2;
            //            width = temp.Width;
            //        }
            //    }
            //    for (int w = 0; w < width; w++)
            //    {
            //        if (token.IsCancellationRequested)
            //        {
            //            token.ThrowIfCancellationRequested();
            //            LoopControl.Stop();
            //        }
            //        for (int h = inHeight; h < height; h++)
            //        {
            //            lock (objectLock)
            //            {
            //                Color c = temp.GetPixel(w, h);
            //                temp.SetPixel(w, h, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
            //            }                      
            //        }
            //    }
            //});               
            img = temp;
            return img;
        }

        public Bitmap ContrastImage(double contrast, CancellationToken token)           
        {
            var objectLock = new object();
            Bitmap temp = (Bitmap)img.Clone();
            if (contrast < -100) contrast = -100;
            if (contrast > 100) contrast = 100;
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;
            Parallel.For(0, 2, (i, LoopControl) =>
                {
                    int height = 0;
                    int inHeight = 0;
                    int width = 0;
                    if (i == 0)
                    {
                        lock (objectLock)
                        {
                            height = temp.Height / 2;
                            inHeight = 0;
                            width = temp.Width;
                        }
                    }
                    else
                    {
                        lock (objectLock)
                        {
                            height = temp.Height;
                            inHeight = temp.Height / 2;
                            width = temp.Width;
                        }
                    }
                    for (int w = 0; w < width; w++)
                    {
                        if (token.IsCancellationRequested)
                        {
                            token.ThrowIfCancellationRequested();
                            LoopControl.Stop();
                        }
                        for (int h = inHeight; h < height; h++)
                        {
                            Color c;
                            lock (objectLock)
                            {
                                c = temp.GetPixel(w, h);
                            }
                            double r = c.R / 255.0;
                            double g = c.G / 255.0;
                            double b = c.B / 255.0;
                            r -= 0.5;
                            r *= contrast;
                            r += 0.5;
                            r *= 255;

                            if (r < 0) r = 0;
                            if (r > 255) r = 255;

                            g -= 0.5;
                            g *= contrast;
                            g += 0.5;
                            g *= 255;
                            if (g < 0) g = 0;
                            if (g > 255) g = 255;
                            b -= 0.5;
                            b *= contrast;
                            b += 0.5;
                            b *= 255;
                            if (b < 0) b = 0;
                            if (b > 255) b = 255;
                            lock (objectLock)
                            {
                                temp.SetPixel(w, h, Color.FromArgb((byte)r, (byte)g, (byte)b));
                            }
                        }
                    }
                });
                img = temp;
            return img;
        }

        public Bitmap FilterImage(String color, CancellationToken token)
        {
            var objectLock = new object();
            Bitmap temp = (Bitmap)img.Clone();
            Color c;

            Parallel.For(0, 2, (i, LoopControl) =>
             {
                 int height = 0;
                 int inHeight = 0;
                 int width = 0;
                 if (i == 0)
                 {
                     lock (objectLock)
                     {
                         height = temp.Height / 2;
                         inHeight = 0;
                         width = temp.Width;
                     }

                 }
                 else
                 {
                     lock (objectLock)
                     {
                         height = temp.Height;
                         inHeight = temp.Height / 2;
                         width = temp.Width;
                     }
                 }

                 for (int w = 0; w < width; w++)
                 {
                     if (token.IsCancellationRequested)
                     {
                         token.ThrowIfCancellationRequested();
                         LoopControl.Stop();
                     }
                     for (int h = inHeight; h < height; h++)
                     {
                         lock (objectLock)
                         {
                             c = temp.GetPixel(w, h);
                             switch (color)
                             {
                                 case "Red":
                                     temp.SetPixel(w, h, Color.FromArgb(c.R, 0, 0));
                                     break;
                                 case "Green":
                                     temp.SetPixel(w, h, Color.FromArgb(0, c.G, 0));
                                     break;
                                 case "Blue":
                                     temp.SetPixel(w, h, Color.FromArgb(0, 0, c.B));
                                     break;
                             }

                         }
                     }
                 }
             });

            img = temp;
            return img;
        }

        public Bitmap SepiaEditor(CancellationToken token)
        {
            var objectLock = new object();
            Bitmap temp = (Bitmap)img.Clone();

            Parallel.For(0, 2, (i, LoopControl) =>
            {

                int height = 0;
                int inHeight = 0;
                int width = 0;
                if (i == 0)
                {
                    lock (objectLock)
                    {
                        height = temp.Height / 2;
                        inHeight = 0;
                        width = temp.Width;
                    }

                }
                else
                {
                    lock (objectLock)
                    {
                        height = temp.Height;
                        inHeight = temp.Height / 2;
                        width = temp.Width;
                    }
                }
                for (int w = 0; w < width; w++)
                {
                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                        LoopControl.Stop();
                    }
                    for (int h = inHeight; h < height; h++)
                    {
                        Color c;
                        lock (objectLock)
                        {
                            c = temp.GetPixel(w, h);
                        }
                        int a = c.A;
                        int r = c.R;
                        int g = c.G;
                        int b = c.B;

                        int tempR = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                        if (tempR > 255)
                        {
                            r = 255;
                        }
                        else
                        {
                            r = tempR;
                        }
                        int tempG = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                        if (tempG > 255)
                        {
                            g = 255;
                        }
                        else
                        {
                            g = tempG;
                        }
                        int tempB = (int)(0.272 * r + 0.534 * g + 0.131 * b);
                        if (tempB > 255)
                        {
                            b = 255;
                        }
                        else
                        {
                            b = tempB;
                        }
                        lock (objectLock)
                        {
                            temp.SetPixel(w, h, Color.FromArgb((byte)r, (byte)g, (byte)b));
                        }
                    }
                }
            });
            img = temp;
            return img;
        }

        public Bitmap CropImage(Rectangle cropArea)
        {
            Bitmap temp = new Bitmap(cropArea.Width,cropArea.Height);
            Graphics graphics = Graphics.FromImage(temp);
            graphics.DrawImage(img, -cropArea.X, -cropArea.Y);
            return temp;
        }
    }
}
