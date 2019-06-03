//-----------------------------------------------------------------------
// <copyright file="C:\Users\IsKaffe\source\repos\Splat Sprite Slicer\Splat Sprite Slicer\Form1.cs" company="Decipher 0x0">
//     Author: Malzahar Olsson
//     Copyright (c) Decipher 0x0. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using SpriteSlicer.Core.Slicer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Splat_Sprite_Slicer
{
    public partial class mainFrm : Form
    {
        public mainFrm() => InitializeComponent();

        private void Btn_LoadSpritesheet_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Slicer.LoadImage(ofd.FileName);
                }
            }
        }

        private void Btn_PreviewMap_Click(object sender, EventArgs e)
        {
            IMG_Spritesheet.PreviewImage(Btn_PreviewMap, Btn_SplitSpriteSheet, (int)NUM_X.Value, (int)NUM_Y.Value);
        }

        private void Btn_SplitSpriteSheet_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    int X = (int)NUM_X.Value;
                    int Y = (int)NUM_Y.Value;
                    Slicer.Slices sliceImage = Slicer.SliceImage(X, Y);
                    for (int i = 0; i < sliceImage.slices.Count; i++)
                    {
                        Slicer.Slices.Slice slc = sliceImage.slices[i];
                        string fN = $"{fbd.SelectedPath}/Split_{slc.part}.png";

                        slc.getBitmap.Save(fN, format: System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            Slicer.onImageChanged += (s, g) =>
            {
                IMG_Spritesheet.Image = g.Image;
                LB_LoadedIMG.Text = $"Loaded Image: {g.FilePath}";
                GB_Preview.Enabled = true;
            };
        }

        private void NUM_X_ValueChanged(object sender, EventArgs e)
        {
            IMG_Spritesheet.PreviewImage(Btn_PreviewMap, Btn_SplitSpriteSheet, (int)NUM_X.Value, (int)NUM_Y.Value);
        }

        private void NUM_Y_ValueChanged(object sender, EventArgs e)
        {
            IMG_Spritesheet.PreviewImage(Btn_PreviewMap, Btn_SplitSpriteSheet, (int)NUM_X.Value, (int)NUM_Y.Value);
        }
    }
}
