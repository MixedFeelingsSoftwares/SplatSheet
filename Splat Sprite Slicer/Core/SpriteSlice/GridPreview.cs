//-----------------------------------------------------------------------
// <copyright file="C:\Users\IsKaffe\source\repos\Splat Sprite Slicer\Splat Sprite Slicer\Core\SpriteSlice\GridPreview.cs" company="Decipher 0x0">
//     Author: Malzahar Olsson
//     Copyright (c) Decipher 0x0. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteSlicer.Core.Slicer
{
    public static class GridPreview
    {
        public static bool isBusy = false;

        public static Bitmap gridMap(this Bitmap bmp, int pX, int pY)
        {
            Bitmap bb = null;
            if (bmp != null)
            {
                Bitmap b = new Bitmap(bmp);
                if (pX > 0 && pY > 0)
                {
                    int p1 = bmp.Width / pX;
                    int p2 = bmp.Height / pY;

                    using (Graphics g = Graphics.FromImage(b))
                    {
                        Pen pn = new Pen(Brushes.Red, 3);
                        for (int y = 0; y < p2; y++)
                        {
                            for (int x = 0; x < p1; x++)
                            {
                                int X = x * pX;
                                int Y = y * pY;
                                // Y
                                g.DrawLine(pn, new Point(0, Y), new Point(bmp.Width, Y));

                                // X
                                g.DrawLine(pn, new Point(X, 0), new Point(X, bmp.Height));
                            }
                        }
                    }
                }
                bb = b;
            }
            return bb != null ? bb : null;
        }

        public static void PreviewImage(this PictureBox pic, Button Previewbtn, Button splitBtn, int NumX, int NumY)
        {
            if (NumY > 0 && NumX > 0 && Slicer.GetImagery != null && !isBusy)
            {
                Thread t = new Thread(() =>
                {
                    isBusy = true;
                    Previewbtn.BeginInvoke(new Action(() => Previewbtn.Enabled = false));
                    Previewbtn.BeginInvoke(new Action(() => Previewbtn.Text = "Generating Map.."));
                    Task ts = new Task(() =>
                    {
                        Bitmap bmp = Slicer.GetImagery.Image.gridMap(NumX, NumY);
                        pic.BeginInvoke(new Action(() => pic.Image = bmp));

                        Previewbtn.BeginInvoke(new Action(() => Previewbtn.Text = "Generate Preview Map"));
                        Previewbtn.BeginInvoke(new Action(() => Previewbtn.Enabled = true));
                        splitBtn.BeginInvoke(new Action(() => splitBtn.Enabled = true));
                        isBusy = false;
                    });
                    ts.Start();
                });
                t.IsBackground = true;
                t.Start();
            }
        }
    }
}
