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
            saveButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eatingController.CreateFood(nameTextbox.Text,
                (double)protsNumericUpDown.Value, 
                (double)fatsNumericUpDown.Value,
                (double)carbsNumericUpDown.Value,
                (double)caloryNumericUpDown.Value);
            eatingController.Save();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                saveButton.Enabled = false;
            }
            else
                saveButton.Enabled = true;
        }
    }
}
