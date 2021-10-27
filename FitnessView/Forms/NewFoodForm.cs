using BL.Controller;
using System;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class NewFoodForm : Form
    {
        EatingController eatingController;
        public NewFoodForm(EatingController eatingController)
        {
            this.eatingController = eatingController;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewFoodForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eatingController.CreateFood(NameTextBox.Text,
                (double)ProtsNumericUpDown.Value, 
                (double)FatsNumericUpDown.Value,
                (double)CarbsNumericUpDown.Value,
                (double)CaloryNumericUpDown.Value);
            eatingController.Save();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }
    }
}
