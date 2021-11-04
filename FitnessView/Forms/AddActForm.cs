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
        int selectedType;
        public AddActForm(UserController userController)
        {
            actController = new ExerciseController(userController);
            this.userController = userController;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addExercise = new NewActForm(actController,selectedType);
            addExercise.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }


        private void AddActForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = false;
            label2.Enabled = false;
            label4.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Visible = false;
            numericUpDown1.Visible = false;
            ActTypeBox.Items.Add("Cardio");
            ActTypeBox.Items.Add("Power");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedType == 0)
            {
                actController.AddExercise(comboBox1.SelectedItem.ToString(), (int)numericUpDown1.Value, selectedType);
                Close();
            }
            else if (selectedType == 1)
            {
                actController.AddExercise(comboBox1.SelectedItem.ToString(),
                    (int)numericUpDown1.Value * (int)numericUpDown2.Value, 
                    selectedType);
                Close();
            }
        }

        private void ActTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Enabled = true;
            button2.Enabled = true;
            label2.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown1.Visible = true;
            if (ActTypeBox.SelectedItem.ToString() == "Power")
            {
                foreach (var act in actController.ActivitiesData[1])
                    comboBox1.Items.Add(act);
                selectedType = 1;
                label4.Enabled = true;
                label4.Text = "sets";
                label2.Text = "reps";
                numericUpDown1.Enabled = true;
                numericUpDown2.Visible = true;
                numericUpDown2.Enabled = true;
            }
            else if (ActTypeBox.SelectedItem.ToString() == "Cardio")
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Visible = false;
                label4.Enabled = false;
                label4.Visible = false;
                label2.Text = "duration";
                foreach (var act in actController.ActivitiesData[0])
                    comboBox1.Items.Add(act);
                selectedType = 0;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
