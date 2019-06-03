//-----------------------------------------------------------------------
// <copyright file="C:\Users\IsKaffe\source\repos\Splat Sprite Slicer\Splat Sprite Slicer\Form1.Designer.cs" company="Decipher 0x0">
//     Author: Malzahar Olsson
//     Copyright (c) Decipher 0x0. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Splat_Sprite_Slicer
{
    partial class mainFrm
    {

        private System.Windows.Forms.Button Btn_LoadSpritesheet;

        private System.Windows.Forms.Button Btn_PreviewMap;
        private System.Windows.Forms.Button Btn_SplitSpriteSheet;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox GB_Preview;
        private System.Windows.Forms.PictureBox IMG_Spritesheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel LB_LoadedIMG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown NUM_X;
        private System.Windows.Forms.NumericUpDown NUM_Y;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            LB_LoadedIMG = new System.Windows.Forms.ToolStripStatusLabel();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Btn_LoadSpritesheet = new System.Windows.Forms.Button();
            GB_Preview = new System.Windows.Forms.GroupBox();
            Btn_PreviewMap = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            NUM_Y = new System.Windows.Forms.NumericUpDown();
            NUM_X = new System.Windows.Forms.NumericUpDown();
            Btn_SplitSpriteSheet = new System.Windows.Forms.Button();
            IMG_Spritesheet = new System.Windows.Forms.PictureBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            GB_Preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(NUM_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(NUM_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(IMG_Spritesheet)).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            LB_LoadedIMG});
            statusStrip1.Location = new System.Drawing.Point(0, 372);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(531, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // LB_LoadedIMG
            // 
            LB_LoadedIMG.Name = "LB_LoadedIMG";
            LB_LoadedIMG.Size = new System.Drawing.Size(110, 17);
            LB_LoadedIMG.Text = "Loaded Image: N/A";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(531, 348);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(Btn_LoadSpritesheet);
            tabPage1.Controls.Add(GB_Preview);
            tabPage1.Controls.Add(Btn_SplitSpriteSheet);
            tabPage1.Controls.Add(IMG_Spritesheet);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(523, 322);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sprite Tool";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(270, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(245, 143);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Btn_LoadSpritesheet
            // 
            Btn_LoadSpritesheet.Location = new System.Drawing.Point(116, 293);
            Btn_LoadSpritesheet.Name = "Btn_LoadSpritesheet";
            Btn_LoadSpritesheet.Size = new System.Drawing.Size(102, 23);
            Btn_LoadSpritesheet.TabIndex = 3;
            Btn_LoadSpritesheet.Text = "Load Spritesheet";
            Btn_LoadSpritesheet.UseVisualStyleBackColor = true;
            Btn_LoadSpritesheet.Click += new System.EventHandler(Btn_LoadSpritesheet_Click);
            // 
            // GB_Preview
            // 
            GB_Preview.Controls.Add(Btn_PreviewMap);
            GB_Preview.Controls.Add(label2);
            GB_Preview.Controls.Add(label1);
            GB_Preview.Controls.Add(NUM_Y);
            GB_Preview.Controls.Add(NUM_X);
            GB_Preview.Enabled = false;
            GB_Preview.Location = new System.Drawing.Point(270, 31);
            GB_Preview.Name = "GB_Preview";
            GB_Preview.Size = new System.Drawing.Size(245, 107);
            GB_Preview.TabIndex = 2;
            GB_Preview.TabStop = false;
            GB_Preview.Text = "Preview";
            // 
            // Btn_PreviewMap
            // 
            Btn_PreviewMap.Location = new System.Drawing.Point(6, 71);
            Btn_PreviewMap.Name = "Btn_PreviewMap";
            Btn_PreviewMap.Size = new System.Drawing.Size(233, 23);
            Btn_PreviewMap.TabIndex = 4;
            Btn_PreviewMap.Text = "Generate Preview Map";
            Btn_PreviewMap.UseVisualStyleBackColor = true;
            Btn_PreviewMap.Click += new System.EventHandler(Btn_PreviewMap_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(7, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 13);
            label2.TabIndex = 3;
            label2.Text = "Y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(7, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 13);
            label1.TabIndex = 2;
            label1.Text = "X:";
            // 
            // NUM_Y
            // 
            NUM_Y.Location = new System.Drawing.Point(30, 45);
            NUM_Y.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            NUM_Y.Name = "NUM_Y";
            NUM_Y.Size = new System.Drawing.Size(206, 20);
            NUM_Y.TabIndex = 1;
            NUM_Y.ValueChanged += new System.EventHandler(NUM_Y_ValueChanged);
            // 
            // NUM_X
            // 
            NUM_X.Location = new System.Drawing.Point(30, 19);
            NUM_X.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            NUM_X.Name = "NUM_X";
            NUM_X.Size = new System.Drawing.Size(206, 20);
            NUM_X.TabIndex = 0;
            NUM_X.ValueChanged += new System.EventHandler(NUM_X_ValueChanged);
            // 
            // Btn_SplitSpriteSheet
            // 
            Btn_SplitSpriteSheet.Enabled = false;
            Btn_SplitSpriteSheet.Location = new System.Drawing.Point(8, 293);
            Btn_SplitSpriteSheet.Name = "Btn_SplitSpriteSheet";
            Btn_SplitSpriteSheet.Size = new System.Drawing.Size(102, 23);
            Btn_SplitSpriteSheet.TabIndex = 1;
            Btn_SplitSpriteSheet.Text = "Split Spritesheet";
            Btn_SplitSpriteSheet.UseVisualStyleBackColor = true;
            Btn_SplitSpriteSheet.Click += new System.EventHandler(Btn_SplitSpriteSheet_Click);
            // 
            // IMG_Spritesheet
            // 
            IMG_Spritesheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            IMG_Spritesheet.Image = global::Splat_Sprite_Slicer.Properties.Resources.Splat;
            IMG_Spritesheet.Location = new System.Drawing.Point(8, 31);
            IMG_Spritesheet.Name = "IMG_Spritesheet";
            IMG_Spritesheet.Size = new System.Drawing.Size(256, 256);
            IMG_Spritesheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            IMG_Spritesheet.TabIndex = 0;
            IMG_Spritesheet.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(523, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "About";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(531, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // mainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(531, 394);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "mainFrm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Splat Spritesheet Slicer";
            Load += new System.EventHandler(mainFrm_Load);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            GB_Preview.ResumeLayout(false);
            GB_Preview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(NUM_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(NUM_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(IMG_Spritesheet)).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

