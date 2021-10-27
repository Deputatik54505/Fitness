using BL.Controller;
using BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class AddActForm : Form
    {
        ExerciseController actController;
        UserController userController;
        public AddActForm(UserController userController)
        {
            actController = new ExerciseController(userController.activeUser);
            this.userController = userController;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addExercise = new NewActForm(actController);
            addExercise.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }


        private void AddActForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            foreach (var act in  actController.Activities)
                comboBox1.Items.Add(act);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actController.AddExercise(comboBox1.Text,(double)numericUpDown1.Value);
            userController.Save();
            Close();
        }
    }
}
