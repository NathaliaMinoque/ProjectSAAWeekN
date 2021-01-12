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


        public void pictureBoxEasy_Click(object sender, EventArgs e)
        {
            FormGame Easy = new FormGame();
            Easy.Show();
            this.Hide();
            
        }

        public void pictureBoxMedium_Click(object sender, EventArgs e)
        {

            FormMedium Medium = new FormMedium();
            Medium.Show();
            this.Hide();
        }

        public void pictureBoxHard_Click(object sender, EventArgs e)
        {
            FormHard Hard = new FormHard();
            Hard.Show();
            this.Hide();
        }

        private void pictureBoxRules_Click(object sender, EventArgs e)
        {
            FormRules rules = new FormRules();
            rules.Show();
            this.Hide();
        }
    }
}
