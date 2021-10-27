using BL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class AddEatForm : Form
    {
        EatingController eatingController;
        UserController userController;
        public AddEatForm(UserController userController)
        {
            eatingController = new EatingController(userController);
            this.userController = userController;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            button1.Enabled = true;
        }

        private void AddEatForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            foreach (var food in eatingController.Foods)
                comboBox1.Items.Add(food);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addFood = new NewFoodForm(eatingController);
            addFood.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eatingController.AddFoodToEating(comboBox1.Text, (double)numericUpDown1.Value);
            userController.Save();
            Close();
        }
    }
}
