
namespace SudokuWeekN
{
    partial class FormOpening
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
            this.pictureBoxWeekN = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeekN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWeekN
            // 
            this.pictureBoxWeekN.Image = global::SudokuWeekN.Properties.Resources.PicsArt_01_07_03_06_17;
            this.pictureBoxWeekN.Location = new System.Drawing.Point(297, 130);
            this.pictureBoxWeekN.Name = "pictureBoxWeekN";
            this.pictureBoxWeekN.Size = new System.Drawing.Size(206, 197);
            this.pictureBoxWeekN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeekN.TabIndex = 1;
            this.pictureBoxWeekN.TabStop = false;
            this.pictureBoxWeekN.UseWaitCursor = true;
            this.pictureBoxWeekN.Click += new System.EventHandler(this.pictureBoxWeekN_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxStart.Image = global::SudokuWeekN.Properties.Resources._20210107_143905_0000__1_;
            this.pictureBoxStart.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStart.TabIndex = 0;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.UseWaitCursor = true;
            // 
            // FormOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxWeekN);
            this.Controls.Add(this.pictureBoxStart);
            this.Name = "FormOpening";
            this.Text = "Sudoku Week-N";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormOpening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeekN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.PictureBox pictureBoxWeekN;
    }
}

