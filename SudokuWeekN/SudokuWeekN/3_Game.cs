using System;
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
            //Random random = new Random();
            //int paketsoal = random.Next(1, 10);
            string[,] soal = new string[9, 9];

            //if (paketsoal == 1)
            //{
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
            //}

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
                    tbox[i, j].Text = soal[i,j];
                }
            }
        }
    }
}
