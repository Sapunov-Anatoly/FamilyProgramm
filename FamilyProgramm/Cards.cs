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
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }

        public int[] masti = new int[] { 1, 2, 3, 4 };
        public int resultGeneration = 0;

        int counterAriana = 0;
        int counterTolya = 0;

        private void GenerateMastButton_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();

            resultGeneration = rnd.Next(1, 5);

            if (resultGeneration == 1)
            {
                mastResultTextBox.Text = "Черви (красное сердечко)";
            }
            else if (resultGeneration == 2)
            {
                mastResultTextBox.Text = "Пики (черное сердечко)";
            }
            else if(resultGeneration == 3)
            {
                mastResultTextBox.Text = "Крести";
            }
            else if(resultGeneration == 4)
            {
                mastResultTextBox.Text = "Буби (красный ромбик)";
            }
            else { mastResultTextBox.Text = "Error 192"; }

        }

        private void ArianaCounterButton_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(ArianaCounterTextBox.Text);
            ArianaCounterTextBox.Text = (counterAriana + 1).ToString();
            counterAriana++;
        }

        private void TolyaCounterButton_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(TolyaCounterTextBox.Text);
            TolyaCounterTextBox.Text = (counterTolya + 1).ToString();
            counterTolya++;
        }

        private void Cards_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
