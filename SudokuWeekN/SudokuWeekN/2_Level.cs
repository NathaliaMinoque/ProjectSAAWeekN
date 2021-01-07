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
    public partial class FormLevel : Form
    {
        public FormLevel()
        {
            InitializeComponent();
        }

        private void pictureBoxEasy_Click(object sender, EventArgs e)
        {
            FormGame f2 = new FormGame();
            f2.Show();
            this.Hide();
        }

        private void pictureBoxMedium_Click(object sender, EventArgs e)
        {
            FormGame f2 = new FormGame();
            f2.Show();
            this.Hide();
        }

        private void pictureBoxHard_Click(object sender, EventArgs e)
        {
            FormGame f2 = new FormGame();
            f2.Show();
            this.Hide();
        }
    }
}
