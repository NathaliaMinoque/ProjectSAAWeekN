﻿
namespace SudokuWeekN
{
    partial class FormMedium
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
            this.pictureBoxRestart = new System.Windows.Forms.PictureBox();
            this.pictureBoxGiveUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxHint = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiveUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRestart
            // 
            this.pictureBoxRestart.Image = global::SudokuWeekN.Properties.Resources._20210111_095911;
            this.pictureBoxRestart.Location = new System.Drawing.Point(627, 313);
            this.pictureBoxRestart.Name = "pictureBoxRestart";
            this.pictureBoxRestart.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRestart.TabIndex = 0;
            this.pictureBoxRestart.TabStop = false;
            this.pictureBoxRestart.Click += new System.EventHandler(this.pictureBoxRestart_Click);
            // 
            // pictureBoxGiveUp
            // 
            this.pictureBoxGiveUp.Image = global::SudokuWeekN.Properties.Resources.PicsArt_01_08_09_42_53;
            this.pictureBoxGiveUp.Location = new System.Drawing.Point(612, 183);
            this.pictureBoxGiveUp.Name = "pictureBoxGiveUp";
            this.pictureBoxGiveUp.Size = new System.Drawing.Size(132, 107);
            this.pictureBoxGiveUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGiveUp.TabIndex = 1;
            this.pictureBoxGiveUp.TabStop = false;
            this.pictureBoxGiveUp.Click += new System.EventHandler(this.pictureBoxGiveUp_Click);
            // 
            // pictureBoxHint
            // 
            this.pictureBoxHint.Image = global::SudokuWeekN.Properties.Resources.PicsArt_01_08_09_43_38;
            this.pictureBoxHint.Location = new System.Drawing.Point(612, 56);
            this.pictureBoxHint.Name = "pictureBoxHint";
            this.pictureBoxHint.Size = new System.Drawing.Size(132, 112);
            this.pictureBoxHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHint.TabIndex = 2;
            this.pictureBoxHint.TabStop = false;
            this.pictureBoxHint.Click += new System.EventHandler(this.pictureBoxHint_Click);
            // 
            // pictureBoxClose1
            // 
            this.pictureBoxClose1.Image = global::SudokuWeekN.Properties.Resources._20210111_100002;
            this.pictureBoxClose1.Location = new System.Drawing.Point(707, 369);
            this.pictureBoxClose1.Name = "pictureBoxClose1";
            this.pictureBoxClose1.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxClose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose1.TabIndex = 5;
            this.pictureBoxClose1.TabStop = false;
            this.pictureBoxClose1.Click += new System.EventHandler(this.pictureBoxClose1_Click);
            // 
            // FormMedium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SudokuWeekN.Properties.Resources._20210110_131058_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.pictureBoxClose1);
            this.Controls.Add(this.pictureBoxHint);
            this.Controls.Add(this.pictureBoxGiveUp);
            this.Controls.Add(this.pictureBoxRestart);
            this.DoubleBuffered = true;
            this.Name = "FormMedium";
            this.Text = "Sudoku Week-N";
            this.Load += new System.EventHandler(this.FormMedium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiveUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRestart;
        private System.Windows.Forms.PictureBox pictureBoxGiveUp;
        private System.Windows.Forms.PictureBox pictureBoxHint;
        private System.Windows.Forms.PictureBox pictureBoxClose1;
    }
}