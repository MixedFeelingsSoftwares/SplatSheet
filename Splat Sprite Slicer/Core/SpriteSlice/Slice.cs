//-----------------------------------------------------------------------
// <copyright file="C:\Users\IsKaffe\source\repos\Splat Sprite Slicer\Splat Sprite Slicer\Core\SpriteSlice\Slice.cs" company="Decipher 0x0">
//     Author: Malzahar Olsson
//     Copyright (c) Decipher 0x0. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace SpriteSlicer.Core.Slicer
{
    public static class Slicer
    {

        private static Imagery temp_BMP;

        public static event System.EventHandler<Imagery> onImageChanged;

        public static void LoadImage(string file)
        {
            Imagery img = new Imagery
            {
                FilePath = file,
                Image = new Bitmap(Image.FromFile(file)),
            };
            GetImagery = img;
        }

        public static Slices SliceImage(int SliceWidth, int SliceHeight)
        {
            Slices _slices = new Slices();
            int p1 = GetImagery.Image.Width / SliceWidth;
            int p2 = GetImagery.Image.Height / SliceHeight;

            Debug.WriteLine($"{p1}:{p2}");

            for (int y = 0; y < p2; y++)
            {
                for (int x = 0; x < p1; x++)
                {
                    int valX = x * SliceWidth;
                    int valY = y * SliceHeight;

                    Rectangle rect = new Rectangle
                    {
                        Width = SliceWidth,
                        Height = SliceHeight,
                        Size = new Size(SliceWidth, SliceHeight),
                        Location = new Point(valX, valY),
                        X = valX,
                        Y = valY,
                    };

                    Bitmap bmp = GetImagery.Image.Clone(rect, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    Slices.Slice slc = new Slices.Slice
                    {
                        getBitmap = bmp,
                        part = x,
                    };
                    _slices.slices.Add(slc);
                }
            }
            return _slices;
        }

        public static Imagery GetImagery
        {
            get => temp_BMP;
            set
            {
                if (temp_BMP != value)
                {
                    value.Image.MakeTransparent();
                    temp_BMP = value;
                    onImageChanged?.Invoke(null, value);
                }
            }
        }

        public static string ImagePath { get; set; }

        public class Imagery
        {
            public string FilePath { get; set; }
            public Bitmap Image { get; set; }
        }

        public class Slices
        {
            public List<Slice> slices = new List<Slice>();

            public class Slice
            {
                public Bitmap getBitmap { get; set; }
                public int part { get; set; }
            }
        }
    }
}
