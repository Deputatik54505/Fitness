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
            var addExercise = new NewActForm(actController,(int)ActTypeBox.SelectedItem);
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
            ActTypeBox.Items.Add(0);
            ActTypeBox.Items.Add(1);

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ActTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Enabled = true;
            button2.Enabled = true;
            if (ActTypeBox.SelectedItem.ToString() == "1")
            {
                foreach (var act in actController.ActivitiesData[1])
                    comboBox1.Items.Add(act);
            }
            else if (ActTypeBox.SelectedItem.ToString() == "0")
            {
                foreach (var act in actController.ActivitiesData[0])
                    comboBox1.Items.Add(act);
            }
        }
    }
}
