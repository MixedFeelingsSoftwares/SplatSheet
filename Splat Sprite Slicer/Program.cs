//-----------------------------------------------------------------------
// <copyright file="C:\Users\IsKaffe\source\repos\Splat Sprite Slicer\Splat Sprite Slicer\Program.cs" company="Decipher 0x0">
//     Author: Malzahar Olsson
//     Copyright (c) Decipher 0x0. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using System.Windows.Forms;

namespace Splat_Sprite_Slicer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainFrm());
        }
    }
}
