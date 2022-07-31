using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyProgramm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            Finance finance = new Finance();
            finance.Show();
            this.Hide();
        }

        private void cardsButton_Click(object sender, EventArgs e)
        {
            Cards cards = new Cards();
            cards.Show();
            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
