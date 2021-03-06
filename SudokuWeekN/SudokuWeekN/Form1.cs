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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ini codingan bikin textbox array
            var soal = new TextBox[10, 10];
            for (var i = 1; i < 10; i++)
            {
                for (var j = 1; j < 10; j++)
                {
                    var tbox = new TextBox();
                    tbox.Name = "Soal" + i + j;
                    tbox.Location = new Point(i * 25, j * 25);
                    tbox.Visible = true;
                    tbox.Size = new Size(20, 20);
                    this.Controls.Add(tbox);
                    tbox.Text = " ";
                    soal[i, j] = tbox;
                }
            }
        }
    }
}
