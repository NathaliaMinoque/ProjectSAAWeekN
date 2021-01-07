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
    public partial class FormOpening : Form
    {
        public FormOpening()
        {
            InitializeComponent();
        }

        private void FormOpening_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxWeekN_Click(object sender, EventArgs e)
        {
            FormLevel f2 = new FormLevel();
            f2.Show();
            this.Hide();
        }
    }
}
