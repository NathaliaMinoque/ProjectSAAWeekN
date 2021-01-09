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
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        public TextBox[,] tbox = new TextBox[9, 9];

        private void FormGame_Load(object sender, EventArgs e)
        {
            //Code buat nentuin paket soal           
            Random random = new Random();
            int tempsoal = random.Next(1, 10);
            string[,] soal = new string[9, 9];

            if (tempsoal == 1)
            {
                soal[0, 0] = "2";
                soal[0, 1] = "4";
                soal[0, 2] = "8";
                soal[0, 3] = "1";
                soal[0, 4] = "3";
                soal[0, 5] = "6";
                soal[0, 6] = "5";
                soal[0, 7] = "7";
                soal[0, 8] = "9";
                soal[1, 0] = "7";
                soal[1, 1] = "6";
                soal[1, 2] = "5";
                soal[1, 3] = "2";
                soal[1, 4] = "9";
                soal[1, 5] = "4";
                soal[1, 6] = "1";
                soal[1, 7] = "3";
                soal[1, 8] = "8";
                soal[2, 0] = "3";
                soal[2, 1] = "9";
                soal[2, 2] = "1";
                soal[2, 3] = "8";
                soal[2, 4] = "5";
                soal[2, 5] = "7";
                soal[2, 6] = "4";
                soal[2, 7] = "6";
                soal[2, 8] = "2";
                soal[3, 0] = "4";
                soal[3, 1] = "1";
                soal[3, 2] = "9";
                soal[3, 3] = "7";
                soal[3, 4] = "6";
                soal[3, 5] = "8";
                soal[3, 6] = "2";
                soal[3, 7] = "5";
                soal[3, 8] = "3";
                soal[4, 0] = "6";
                soal[4, 1] = "8";
                soal[4, 2] = "7";
                soal[4, 3] = "5";
                soal[4, 4] = "2";
                soal[4, 5] = "3";
                soal[4, 6] = "9";
                soal[4, 7] = "4";
                soal[4, 8] = "1";
                soal[5, 0] = "5";
                soal[5, 1] = "2";
                soal[5, 2] = "3";
                soal[5, 3] = "4";
                soal[5, 4] = "1";
                soal[5, 5] = "9";
                soal[5, 6] = "6";
                soal[5, 7] = "8";
                soal[5, 8] = "7";
                soal[6, 0] = "1";
                soal[6, 1] = "7";
                soal[6, 2] = "4";
                soal[6, 3] = "9";
                soal[6, 4] = "8";
                soal[6, 5] = "5";
                soal[6, 6] = "3";
                soal[6, 7] = "2";
                soal[6, 8] = "6";
                soal[7, 0] = "8";
                soal[7, 1] = "3";
                soal[7, 2] = "2";
                soal[7, 3] = "6";
                soal[7, 4] = "4";
                soal[7, 5] = "1";
                soal[7, 6] = "7";
                soal[7, 7] = "9";
                soal[7, 8] = "5";
                soal[8, 0] = "4";
                soal[8, 1] = "3";
                soal[8, 2] = "7";
                soal[8, 3] = "3";
                soal[8, 4] = "7";
                soal[8, 5] = "2";
                soal[8, 6] = "8";
                soal[8, 7] = "1";
                soal[8, 8] = "4";
            }

            else if (tempsoal == 2)
            {
                soal[0, 0] = "1";
                soal[0, 1] = "2";
                soal[0, 2] = "5";
                soal[0, 3] = "4";
                soal[0, 4] = "8";
                soal[0, 5] = "3";
                soal[0, 6] = "6";
                soal[0, 7] = "9";
                soal[0, 8] = "7";
                soal[1, 0] = "7";
                soal[1, 1] = "4";
                soal[1, 2] = "8";
                soal[1, 3] = "1";
                soal[1, 4] = "6";
                soal[1, 5] = "9";
                soal[1, 6] = "2";
                soal[1, 7] = "3";
                soal[1, 8] = "5";
                soal[2, 0] = "9";
                soal[2, 1] = "6";
                soal[2, 2] = "3";
                soal[2, 3] = "2";
                soal[2, 4] = "5";
                soal[2, 5] = "7";
                soal[2, 6] = "4";
                soal[2, 7] = "1";
                soal[2, 8] = "8";
                soal[3, 0] = "4";
                soal[3, 1] = "3";
                soal[3, 2] = "7";
                soal[3, 3] = "8";
                soal[3, 4] = "2";
                soal[3, 5] = "1";
                soal[3, 6] = "5";
                soal[3, 7] = "6";
                soal[3, 8] = "9";
                soal[4, 0] = "8";
                soal[4, 1] = "5";
                soal[4, 2] = "6";
                soal[4, 3] = "9";
                soal[4, 4] = "3";
                soal[4, 5] = "4";
                soal[4, 6] = "1";
                soal[4, 7] = "7";
                soal[4, 8] = "2";
                soal[5, 0] = "2";
                soal[5, 1] = "1";
                soal[5, 2] = "9";
                soal[5, 3] = "6";
                soal[5, 4] = "7";
                soal[5, 5] = "5";
                soal[5, 6] = "8";
                soal[5, 7] = "4";
                soal[5, 8] = "3";
                soal[6, 0] = "5";
                soal[6, 1] = "8";
                soal[6, 2] = "4";
                soal[6, 3] = "3";
                soal[6, 4] = "9";
                soal[6, 5] = "6";
                soal[6, 6] = "7";
                soal[6, 7] = "2";
                soal[6, 8] = "1";
                soal[7, 0] = "6";
                soal[7, 1] = "9";
                soal[7, 2] = "2";
                soal[7, 3] = "7";
                soal[7, 4] = "1";
                soal[7, 5] = "8";
                soal[7, 6] = "3";
                soal[7, 7] = "5";
                soal[7, 8] = "4";
                soal[8, 0] = "3";
                soal[8, 1] = "7";
                soal[8, 2] = "1";
                soal[8, 3] = "5";
                soal[8, 4] = "4";
                soal[8, 5] = "2";
                soal[8, 6] = "9";
                soal[8, 7] = "8";
                soal[8, 8] = "6";
            }

            else if (tempsoal == 3)
            {
                soal[0, 0] = "2";
                soal[0, 1] = "3";
                soal[0, 2] = "5";
                soal[0, 3] = "1";
                soal[0, 4] = "4";
                soal[0, 5] = "7";
                soal[0, 6] = "9";
                soal[0, 7] = "8";
                soal[0, 8] = "6";
                soal[1, 0] = "4";
                soal[1, 1] = "1";
                soal[1, 2] = "8";
                soal[1, 3] = "9";
                soal[1, 4] = "6";
                soal[1, 5] = "5";
                soal[1, 6] = "7";
                soal[1, 7] = "2";
                soal[1, 8] = "3";
                soal[2, 0] = "6";
                soal[2, 1] = "9";
                soal[2, 2] = "7";
                soal[2, 3] = "2";
                soal[2, 4] = "8";
                soal[2, 5] = "3";
                soal[2, 6] = "1";
                soal[2, 7] = "4";
                soal[2, 8] = "5";
                soal[3, 0] = "9";
                soal[3, 1] = "8";
                soal[3, 2] = "6";
                soal[3, 3] = "5";
                soal[3, 4] = "7";
                soal[3, 5] = "4";
                soal[3, 6] = "2";
                soal[3, 7] = "3";
                soal[3, 8] = "1";
                soal[4, 0] = "5";
                soal[4, 1] = "7";
                soal[4, 2] = "3";
                soal[4, 3] = "8";
                soal[4, 4] = "1";
                soal[4, 5] = "2";
                soal[4, 6] = "4";
                soal[4, 7] = "6";
                soal[4, 8] = "9";
                soal[5, 0] = "1";
                soal[5, 1] = "4";
                soal[5, 2] = "2";
                soal[5, 3] = "6";
                soal[5, 4] = "3";
                soal[5, 5] = "9";
                soal[5, 6] = "8";
                soal[5, 7] = "5";
                soal[5, 8] = "7";
                soal[6, 0] = "7";
                soal[6, 1] = "5";
                soal[6, 2] = "9";
                soal[6, 3] = "3";
                soal[6, 4] = "2";
                soal[6, 5] = "8";
                soal[6, 6] = "6";
                soal[6, 7] = "1";
                soal[6, 8] = "4";
                soal[7, 0] = "8";
                soal[7, 1] = "6";
                soal[7, 2] = "4";
                soal[7, 3] = "7";
                soal[7, 4] = "5";
                soal[7, 5] = "1";
                soal[7, 6] = "3";
                soal[7, 7] = "9";
                soal[7, 8] = "2";
                soal[8, 0] = "3";
                soal[8, 1] = "2";
                soal[8, 2] = "1";
                soal[8, 3] = "4";
                soal[8, 4] = "9";
                soal[8, 5] = "6";
                soal[8, 6] = "5";
                soal[8, 7] = "7";
                soal[8, 8] = "8";
            }

            else if (tempsoal == 4)
            {
                soal[0, 0] = "5";
                soal[0, 1] = "3";
                soal[0, 2] = "4";
                soal[0, 3] = "6";
                soal[0, 4] = "7";
                soal[0, 5] = "8";
                soal[0, 6] = "9";
                soal[0, 7] = "1";
                soal[0, 8] = "2";
                soal[1, 0] = "6";
                soal[1, 1] = "7";
                soal[1, 2] = "2";
                soal[1, 3] = "1";
                soal[1, 4] = "9";
                soal[1, 5] = "5";
                soal[1, 6] = "3";
                soal[1, 7] = "4";
                soal[1, 8] = "8";
                soal[2, 0] = "1";
                soal[2, 1] = "9";
                soal[2, 2] = "8";
                soal[2, 3] = "3";
                soal[2, 4] = "4";
                soal[2, 5] = "2";
                soal[2, 6] = "5";
                soal[2, 7] = "6";
                soal[2, 8] = "7";
                soal[3, 0] = "8";
                soal[3, 1] = "5";
                soal[3, 2] = "9";
                soal[3, 3] = "7";
                soal[3, 4] = "6";
                soal[3, 5] = "1";
                soal[3, 6] = "4";
                soal[3, 7] = "2";
                soal[3, 8] = "3";
                soal[4, 0] = "4";
                soal[4, 1] = "2";
                soal[4, 2] = "6";
                soal[4, 3] = "8";
                soal[4, 4] = "5";
                soal[4, 5] = "3";
                soal[4, 6] = "7";
                soal[4, 7] = "9";
                soal[4, 8] = "1";
                soal[5, 0] = "7";
                soal[5, 1] = "1";
                soal[5, 2] = "3";
                soal[5, 3] = "9";
                soal[5, 4] = "2";
                soal[5, 5] = "4";
                soal[5, 6] = "8";
                soal[5, 7] = "5";
                soal[5, 8] = "6";
                soal[6, 0] = "9";
                soal[6, 1] = "6";
                soal[6, 2] = "1";
                soal[6, 3] = "5";
                soal[6, 4] = "3";
                soal[6, 5] = "7";
                soal[6, 6] = "2";
                soal[6, 7] = "8";
                soal[6, 8] = "4";
                soal[7, 0] = "2";
                soal[7, 1] = "8";
                soal[7, 2] = "7";
                soal[7, 3] = "4";
                soal[7, 4] = "1";
                soal[7, 5] = "9";
                soal[7, 6] = "6";
                soal[7, 7] = "3";
                soal[7, 8] = "5";
                soal[8, 0] = "3";
                soal[8, 1] = "4";
                soal[8, 2] = "5";
                soal[8, 3] = "2";
                soal[8, 4] = "8";
                soal[8, 5] = "6";
                soal[8, 6] = "1";
                soal[8, 7] = "7";
                soal[8, 8] = "9";
            }

            else if (tempsoal == 5)
            {
                soal[0, 0] = "1";
                soal[0, 1] = "7";
                soal[0, 2] = "5";
                soal[0, 3] = "2";
                soal[0, 4] = "9";
                soal[0, 5] = "4";
                soal[0, 6] = "8";
                soal[0, 7] = "3";
                soal[0, 8] = "6";
                soal[1, 0] = "6";
                soal[1, 1] = "2";
                soal[1, 2] = "3";
                soal[1, 3] = "1";
                soal[1, 4] = "8";
                soal[1, 5] = "7";
                soal[1, 6] = "9";
                soal[1, 7] = "4";
                soal[1, 8] = "5";
                soal[2, 0] = "8";
                soal[2, 1] = "9";
                soal[2, 2] = "4";
                soal[2, 3] = "5";
                soal[2, 4] = "6";
                soal[2, 5] = "3";
                soal[2, 6] = "2";
                soal[2, 7] = "7";
                soal[2, 8] = "1";
                soal[3, 0] = "5";
                soal[3, 1] = "1";
                soal[3, 2] = "9";
                soal[3, 3] = "7";
                soal[3, 4] = "3";
                soal[3, 5] = "2";
                soal[3, 6] = "4";
                soal[3, 7] = "6";
                soal[3, 8] = "8";
                soal[4, 0] = "3";
                soal[4, 1] = "4";
                soal[4, 2] = "7";
                soal[4, 3] = "8";
                soal[4, 4] = "5";
                soal[4, 5] = "6";
                soal[4, 6] = "1";
                soal[4, 7] = "2";
                soal[4, 8] = "9";
                soal[5, 0] = "2";
                soal[5, 1] = "8";
                soal[5, 2] = "6";
                soal[5, 3] = "9";
                soal[5, 4] = "4";
                soal[5, 5] = "1";
                soal[5, 6] = "7";
                soal[5, 7] = "5";
                soal[5, 8] = "3";
                soal[6, 0] = "9";
                soal[6, 1] = "3";
                soal[6, 2] = "8";
                soal[6, 3] = "4";
                soal[6, 4] = "2";
                soal[6, 5] = "5";
                soal[6, 6] = "6";
                soal[6, 7] = "1";
                soal[6, 8] = "7";
                soal[7, 0] = "4";
                soal[7, 1] = "6";
                soal[7, 2] = "1";
                soal[7, 3] = "3";
                soal[7, 4] = "7";
                soal[7, 5] = "9";
                soal[7, 6] = "5";
                soal[7, 7] = "8";
                soal[7, 8] = "2";
                soal[8, 0] = "7";
                soal[8, 1] = "5";
                soal[8, 2] = "2";
                soal[8, 3] = "6";
                soal[8, 4] = "1";
                soal[8, 5] = "8";
                soal[8, 6] = "3";
                soal[8, 7] = "9";
                soal[8, 8] = "4";
            }

            else if (tempsoal == 6)
            {
                soal[0, 0] = "9";
                soal[0, 1] = "4";
                soal[0, 2] = "8";
                soal[0, 3] = "5";
                soal[0, 4] = "7";
                soal[0, 5] = "2";
                soal[0, 6] = "6";
                soal[0, 7] = "3";
                soal[0, 8] = "1";
                soal[1, 0] = "2";
                soal[1, 1] = "1";
                soal[1, 2] = "5";
                soal[1, 3] = "6";
                soal[1, 4] = "8";
                soal[1, 5] = "3";
                soal[1, 6] = "7";
                soal[1, 7] = "4";
                soal[1, 8] = "9";
                soal[2, 0] = "7";
                soal[2, 1] = "3";
                soal[2, 2] = "6";
                soal[2, 3] = "4";
                soal[2, 4] = "1";
                soal[2, 5] = "9";
                soal[2, 6] = "2";
                soal[2, 7] = "5";
                soal[2, 8] = "8";
                soal[3, 0] = "4";
                soal[3, 1] = "6";
                soal[3, 2] = "7";
                soal[3, 3] = "8";
                soal[3, 4] = "5";
                soal[3, 5] = "1";
                soal[3, 6] = "3";
                soal[3, 7] = "9";
                soal[3, 8] = "2";
                soal[4, 0] = "3";
                soal[4, 1] = "8";
                soal[4, 2] = "9";
                soal[4, 3] = "7";
                soal[4, 4] = "2";
                soal[4, 5] = "4";
                soal[4, 6] = "5";
                soal[4, 7] = "1";
                soal[4, 8] = "6";
                soal[5, 0] = "1";
                soal[5, 1] = "5";
                soal[5, 2] = "2";
                soal[5, 3] = "3";
                soal[5, 4] = "9";
                soal[5, 5] = "6";
                soal[5, 6] = "4";
                soal[5, 7] = "8";
                soal[5, 8] = "7";
                soal[6, 0] = "6";
                soal[6, 1] = "9";
                soal[6, 2] = "4";
                soal[6, 3] = "1";
                soal[6, 4] = "3";
                soal[6, 5] = "7";
                soal[6, 6] = "8";
                soal[6, 7] = "2";
                soal[6, 8] = "5";
                soal[7, 0] = "5";
                soal[7, 1] = "2";
                soal[7, 2] = "3";
                soal[7, 3] = "9";
                soal[7, 4] = "6";
                soal[7, 5] = "8";
                soal[7, 6] = "1";
                soal[7, 7] = "7";
                soal[7, 8] = "4";
                soal[8, 0] = "8";
                soal[8, 1] = "7";
                soal[8, 2] = "1";
                soal[8, 3] = "2";
                soal[8, 4] = "4";
                soal[8, 5] = "5";
                soal[8, 6] = "9";
                soal[8, 7] = "6";
                soal[8, 8] = "3";

            }

            else if (tempsoal == 7)
            {
                soal[0, 0] = "4";
                soal[0, 1] = "6";
                soal[0, 2] = "2";
                soal[0, 3] = "3";
                soal[0, 4] = "7";
                soal[0, 5] = "5";
                soal[0, 6] = "8";
                soal[0, 7] = "1";
                soal[0, 8] = "9";
                soal[1, 0] = "5";
                soal[1, 1] = "9";
                soal[1, 2] = "1";
                soal[1, 3] = "8";
                soal[1, 4] = "6";
                soal[1, 5] = "4";
                soal[1, 6] = "7";
                soal[1, 7] = "3";
                soal[1, 8] = "2";
                soal[2, 0] = "7";
                soal[2, 1] = "3";
                soal[2, 2] = "8";
                soal[2, 3] = "2";
                soal[2, 4] = "9";
                soal[2, 5] = "1";
                soal[2, 6] = "5";
                soal[2, 7] = "4";
                soal[2, 8] = "6";
                soal[3, 0] = "9";
                soal[3, 1] = "4";
                soal[3, 2] = "7";
                soal[3, 3] = "6";
                soal[3, 4] = "3";
                soal[3, 5] = "8";
                soal[3, 6] = "1";
                soal[3, 7] = "2";
                soal[3, 8] = "5";
                soal[4, 0] = "1";
                soal[4, 1] = "2";
                soal[4, 2] = "6";
                soal[4, 3] = "5";
                soal[4, 4] = "4";
                soal[4, 5] = "7";
                soal[4, 6] = "9";
                soal[4, 7] = "8";
                soal[4, 8] = "3";
                soal[5, 0] = "3";
                soal[5, 1] = "8";
                soal[5, 2] = "5";
                soal[5, 3] = "9";
                soal[5, 4] = "1";
                soal[5, 5] = "2";
                soal[5, 6] = "4";
                soal[5, 7] = "6";
                soal[5, 8] = "7";
                soal[6, 0] = "6";
                soal[6, 1] = "5";
                soal[6, 2] = "4";
                soal[6, 3] = "7";
                soal[6, 4] = "8";
                soal[6, 5] = "3";
                soal[6, 6] = "2";
                soal[6, 7] = "9";
                soal[6, 8] = "1";
                soal[7, 0] = "2";
                soal[7, 1] = "1";
                soal[7, 2] = "9";
                soal[7, 3] = "4";
                soal[7, 4] = "5";
                soal[7, 5] = "6";
                soal[7, 6] = "3";
                soal[7, 7] = "7";
                soal[7, 8] = "8";
                soal[8, 0] = "8";
                soal[8, 1] = "7";
                soal[8, 2] = "3";
                soal[8, 3] = "1";
                soal[8, 4] = "2";
                soal[8, 5] = "9";
                soal[8, 6] = "6";
                soal[8, 7] = "5";
                soal[8, 8] = "4";
            }

            else if (tempsoal == 8)
            {
                soal[0, 0] = "2";
                soal[0, 1] = "6";
                soal[0, 2] = "5";
                soal[0, 3] = "4";
                soal[0, 4] = "7";
                soal[0, 5] = "1";
                soal[0, 6] = "8";
                soal[0, 7] = "9";
                soal[0, 8] = "3";
                soal[1, 0] = "4";
                soal[1, 1] = "8";
                soal[1, 2] = "1";
                soal[1, 3] = "3";
                soal[1, 4] = "9";
                soal[1, 5] = "6";
                soal[1, 6] = "7";
                soal[1, 7] = "2";
                soal[1, 8] = "5";
                soal[2, 0] = "3";
                soal[2, 1] = "7";
                soal[2, 2] = "9";
                soal[2, 3] = "2";
                soal[2, 4] = "8";
                soal[2, 5] = "5";
                soal[2, 6] = "4";
                soal[2, 7] = "6";
                soal[2, 8] = "1";
                soal[3, 0] = "5";
                soal[3, 1] = "4";
                soal[3, 2] = "8";
                soal[3, 3] = "9";
                soal[3, 4] = "5";
                soal[3, 5] = "7";
                soal[3, 6] = "1";
                soal[3, 7] = "3";
                soal[3, 8] = "2";
                soal[4, 0] = "7";
                soal[4, 1] = "5";
                soal[4, 2] = "3";
                soal[4, 3] = "6";
                soal[4, 4] = "1";
                soal[4, 5] = "2";
                soal[4, 6] = "9";
                soal[4, 7] = "4";
                soal[4, 8] = "8";
                soal[5, 0] = "9";
                soal[5, 1] = "1";
                soal[5, 2] = "2";
                soal[5, 3] = "8";
                soal[5, 4] = "4";
                soal[5, 5] = "3";
                soal[5, 6] = "6";
                soal[5, 7] = "5";
                soal[5, 8] = "7";
                soal[6, 0] = "5";
                soal[6, 1] = "2";
                soal[6, 2] = "4";
                soal[6, 3] = "7";
                soal[6, 4] = "6";
                soal[6, 5] = "8";
                soal[6, 6] = "3";
                soal[6, 7] = "1";
                soal[6, 8] = "9";
                soal[7, 0] = "8";
                soal[7, 1] = "3";
                soal[7, 2] = "6";
                soal[7, 3] = "1";
                soal[7, 4] = "2";
                soal[7, 5] = "9";
                soal[7, 6] = "5";
                soal[7, 7] = "7";
                soal[7, 8] = "4";
                soal[8, 0] = "1";
                soal[8, 1] = "9";
                soal[8, 2] = "7";
                soal[8, 3] = "5";
                soal[8, 4] = "3";
                soal[8, 5] = "4";
                soal[8, 6] = "2";
                soal[8, 7] = "8";
                soal[8, 8] = "6";
            }

            else if (tempsoal == 9)
            {
                soal[0, 0] = "1";
                soal[0, 1] = "4";
                soal[0, 2] = "5";
                soal[0, 3] = "2";
                soal[0, 4] = "3";
                soal[0, 5] = "6";
                soal[0, 6] = "7";
                soal[0, 7] = "8";
                soal[0, 8] = "9";
                soal[1, 0] = "6";
                soal[1, 1] = "2";
                soal[1, 2] = "7";
                soal[1, 3] = "1";
                soal[1, 4] = "8";
                soal[1, 5] = "9";
                soal[1, 6] = "3";
                soal[1, 7] = "4";
                soal[1, 8] = "5";
                soal[2, 0] = "8";
                soal[2, 1] = "9";
                soal[2, 2] = "3";
                soal[2, 3] = "4";
                soal[2, 4] = "5";
                soal[2, 5] = "7";
                soal[2, 6] = "1";
                soal[2, 7] = "2";
                soal[2, 8] = "6";
                soal[3, 0] = "2";
                soal[3, 1] = "1";
                soal[3, 2] = "4";
                soal[3, 3] = "3";
                soal[3, 4] = "6";
                soal[3, 5] = "5";
                soal[3, 6] = "8";
                soal[3, 7] = "9";
                soal[3, 8] = "7";
                soal[4, 0] = "3";
                soal[4, 1] = "5";
                soal[4, 2] = "8";
                soal[4, 3] = "7";
                soal[4, 4] = "9";
                soal[4, 5] = "1";
                soal[4, 6] = "2";
                soal[4, 7] = "6";
                soal[4, 8] = "4";
                soal[5, 0] = "7";
                soal[5, 1] = "6";
                soal[5, 2] = "9";
                soal[5, 3] = "8";
                soal[5, 4] = "2";
                soal[5, 5] = "4";
                soal[5, 6] = "5";
                soal[5, 7] = "1";
                soal[5, 8] = "3";
                soal[6, 0] = "4";
                soal[6, 1] = "3";
                soal[6, 2] = "1";
                soal[6, 3] = "6";
                soal[6, 4] = "7";
                soal[6, 5] = "2";
                soal[6, 6] = "9";
                soal[6, 7] = "5";
                soal[6, 8] = "8";
                soal[7, 0] = "5";
                soal[7, 1] = "7";
                soal[7, 2] = "2";
                soal[7, 3] = "9";
                soal[7, 4] = "4";
                soal[7, 5] = "8";
                soal[7, 6] = "6";
                soal[7, 7] = "3";
                soal[7, 8] = "1";
                soal[8, 0] = "9";
                soal[8, 1] = "8";
                soal[8, 2] = "6";
                soal[8, 3] = "5";
                soal[8, 4] = "1";
                soal[8, 5] = "3";
                soal[8, 6] = "4";
                soal[8, 7] = "7";
                soal[8, 8] = "2";
            }

            else if (tempsoal == 10)
            {
                soal[0, 0] = "3";
                soal[0, 1] = "6";
                soal[0, 2] = "5";
                soal[0, 3] = "7";
                soal[0, 4] = "4";
                soal[0, 5] = "2";
                soal[0, 6] = "8";
                soal[0, 7] = "1";
                soal[0, 8] = "9";
                soal[1, 0] = "8";
                soal[1, 1] = "4";
                soal[1, 2] = "2";
                soal[1, 3] = "3";
                soal[1, 4] = "1";
                soal[1, 5] = "9";
                soal[1, 6] = "7";
                soal[1, 7] = "5";
                soal[1, 8] = "6";
                soal[2, 0] = "9";
                soal[2, 1] = "7";
                soal[2, 2] = "1";
                soal[2, 3] = "8";
                soal[2, 4] = "5";
                soal[2, 5] = "6";
                soal[2, 6] = "3";
                soal[2, 7] = "4";
                soal[2, 8] = "2";
                soal[3, 0] = "4";
                soal[3, 1] = "5";
                soal[3, 2] = "6";
                soal[3, 3] = "9";
                soal[3, 4] = "7";
                soal[3, 5] = "8";
                soal[3, 6] = "1";
                soal[3, 7] = "2";
                soal[3, 8] = "3";
                soal[4, 0] = "1";
                soal[4, 1] = "3";
                soal[4, 2] = "9";
                soal[4, 3] = "4";
                soal[4, 4] = "2";
                soal[4, 5] = "5";
                soal[4, 6] = "6";
                soal[4, 7] = "7";
                soal[4, 8] = "8";
                soal[5, 0] = "2";
                soal[5, 1] = "8";
                soal[5, 2] = "7";
                soal[5, 3] = "6";
                soal[5, 4] = "3";
                soal[5, 5] = "1";
                soal[5, 6] = "5";
                soal[5, 7] = "9";
                soal[5, 8] = "4";
                soal[6, 0] = "6";
                soal[6, 1] = "1";
                soal[6, 2] = "4";
                soal[6, 3] = "5";
                soal[6, 4] = "9";
                soal[6, 5] = "3";
                soal[6, 6] = "2";
                soal[6, 7] = "8";
                soal[6, 8] = "7";
                soal[7, 0] = "5";
                soal[7, 1] = "9";
                soal[7, 2] = "3";
                soal[7, 3] = "2";
                soal[7, 4] = "8";
                soal[7, 5] = "7";
                soal[7, 6] = "4";
                soal[7, 7] = "6";
                soal[7, 8] = "1";
                soal[8, 0] = "7";
                soal[8, 1] = "2";
                soal[8, 2] = "8";
                soal[8, 3] = "1";
                soal[8, 4] = "6";
                soal[8, 5] = "4";
                soal[8, 6] = "9";
                soal[8, 7] = "3";
                soal[8, 8] = "5";
            }

            //Ini codingan bikin textbox array          
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tbox[i, j] = new TextBox();
                    tbox[i, j].Location = new Point((i + 2) * 22, (j + 2) * 22);
                    tbox[i, j].Visible = true;
                    tbox[i, j].Size = new Size(20, 20);
                    tbox[i, j].MaxLength = 1;
                    tbox[i, j].TextAlign = HorizontalAlignment.Center;
                    this.Controls.Add(tbox[i, j]);
                    tbox[i, j].Text = soal[i, j];
                }
            }

            //check kolom
            int cekkembar = 0;
            for (int baris = 0; baris < 9; baris++)
            {
                for (int kolom = 0; kolom < 9; kolom++)
                {
                    for (int counter = 0; counter < 9; counter++)
                    {
                        if (tbox[baris, kolom] == tbox[baris, counter])
                        {
                            cekkembar++;
                        }
                        if (cekkembar > 1)
                        {
                            tbox[baris, kolom].ForeColor = Color.Red;
                            tbox[baris, counter].ForeColor = Color.Red;
                            cekkembar = 0;
                        }
                    }
                    cekkembar = 0;
                }
                cekkembar = 0;
            }
        }

        private void tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string karakter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ., ";
            if (karakter.IndexOf(e.KeyChar) < 0)
            {
                MessageBox.Show("Hanya Bisa Dimasuki Huruf");
                e.Handled = true; 
            }
            else
            {

            }
        }
    }
}
