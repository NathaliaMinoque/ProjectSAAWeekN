﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuWeekN
{
    public partial class FormCongrats : Form
    {
        public FormCongrats()
        {
            InitializeComponent();
        }

        private void FormCongrats_Load(object sender, EventArgs e)
        {
            labelScore.Text = FormGame.score.ToString();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormLevel level = new FormLevel();
            level.Show();
            this.Hide();
        }
        
    
    }
}