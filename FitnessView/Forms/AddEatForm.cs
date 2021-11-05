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
        public EatingController EatingController { get; private set; }
        UserController userController;
        public AddEatForm(UserController userController)
        {
            EatingController = new EatingController(userController);
            this.userController = userController;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            addButton.Enabled = true;
        }

        private void AddEatForm_Load(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            foreach (var food in EatingController.Foods)
                foodListComboBox.Items.Add(food);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addFood = new NewFoodForm(EatingController);
            addFood.ShowDialog();
            foreach (var food in EatingController.Foods)
                foodListComboBox.Items.Add(food);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EatingController.AddFoodToEating(foodListComboBox.Text, (double)weightNumeric.Value);
            Close();
        }
    }
}
