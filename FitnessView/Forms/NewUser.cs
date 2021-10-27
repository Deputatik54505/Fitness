﻿using BL.Controller;
using System;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class NewUser : Form
    {
        public UserController UserController { get; private set; }
        public NewUser(UserController userController)
        {
            this.UserController = userController;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool gender;
            if (GenderComboBox.SelectedItem.ToString() == "female")
            {
                gender = true;
                UserController.activeUser.AddСharacteristics((double)WeightNumericUpDown.Value, (int)HeightNumericUpDown.Value, (int)AgeNumericUpDown.Value, gender, (double)ActNumericUpDown.Value);
                Close();
            }
            else if (GenderComboBox.SelectedItem.ToString() == "male")
            {
                gender = false;
                UserController.activeUser.AddСharacteristics((double)WeightNumericUpDown.Value, (int)HeightNumericUpDown.Value, (int)AgeNumericUpDown.Value, gender, (double)ActNumericUpDown.Value);
                Close();
            }
        }
    }
}