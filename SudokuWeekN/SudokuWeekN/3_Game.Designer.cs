﻿
namespace SudokuWeekN
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxHint = new System.Windows.Forms.PictureBox();
            this.pictureBoxGiveUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiveUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHint
            // 
            this.pictureBoxHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHint.Image = global::SudokuWeekN.Properties.Resources.PicsArt_01_08_09_43_38;
            this.pictureBoxHint.Location = new System.Drawing.Point(591, 46);
            this.pictureBoxHint.Name = "pictureBoxHint";
            this.pictureBoxHint.Size = new System.Drawing.Size(151, 109);
            this.pictureBoxHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHint.TabIndex = 1;
            this.pictureBoxHint.TabStop = false;
            // 
            // pictureBoxGiveUp
            // 
            this.pictureBoxGiveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGiveUp.Image = global::SudokuWeekN.Properties.Resources.PicsArt_01_08_09_42_53;
            this.pictureBoxGiveUp.Location = new System.Drawing.Point(591, 182);
            this.pictureBoxGiveUp.Name = "pictureBoxGiveUp";
            this.pictureBoxGiveUp.Size = new System.Drawing.Size(151, 109);
            this.pictureBoxGiveUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGiveUp.TabIndex = 2;
            this.pictureBoxGiveUp.TabStop = false;
            // 
            // pictureBoxRestart
            // 
            this.pictureBoxRestart.Image = global::SudokuWeekN.Properties.Resources._20210111_095911;
            this.pictureBoxRestart.Location = new System.Drawing.Point(591, 356);
            this.pictureBoxRestart.Name = "pictureBoxRestart";
            this.pictureBoxRestart.Size = new System.Drawing.Size(151, 75);
            this.pictureBoxRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRestart.TabIndex = 3;
            this.pictureBoxRestart.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SudokuWeekN.Properties.Resources._20210110_131058_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.pictureBoxRestart);
            this.Controls.Add(this.pictureBoxGiveUp);
            this.Controls.Add(this.pictureBoxHint);
            this.DoubleBuffered = true;
            this.Name = "FormGame";
            this.Text = "Sudoku Week-N";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiveUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHint;
        private System.Windows.Forms.PictureBox pictureBoxGiveUp;
        private System.Windows.Forms.PictureBox pictureBoxRestart;
    }
}