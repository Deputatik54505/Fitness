﻿using BL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class NewActForm : Form
    {
        ExerciseController exerciseController;
        int type;
        public NewActForm(ExerciseController exerciseController,int type)
        {
            this.exerciseController = exerciseController;
            this.type = type;
            InitializeComponent();
            if (type == 0)
            {
                label1.Text = "Calories per minute";
            }
            if (type == 1)
            {
                label1.Text = "calories per time";
                numericUpDown1.Maximum = 15;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewActForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                exerciseController.CreateCardioActivity(textBox1.Text, (int)numericUpDown1.Value);
                exerciseController.Save();
                Close();
            }
            else if(type == 1)
            {
                exerciseController.CreatePowerActivity(textBox1.Text, (int)numericUpDown1.Value);
                exerciseController.Save();
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
