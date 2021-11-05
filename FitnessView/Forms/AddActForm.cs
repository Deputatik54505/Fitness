using BL.Controller;
using System;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class AddActForm : Form
    {
        ExerciseController actController;
        int selectedType;

        public AddActForm(UserController userController)
        {
            actController = new ExerciseController(userController);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addExercise = new NewActForm(actController,selectedType);
            addExercise.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
        }


        private void AddActForm_Load(object sender, EventArgs e)
        {
            
            addButton.Enabled = false;
            exerciseListComboBox.Enabled = false;
            newActButton.Enabled = false;
            label.Enabled = false;
            setsLabel.Enabled = false;
            numeric2.Enabled = false;
            numeric1.Enabled = false;
            numeric2.Visible = false;
            numeric1.Visible = false;
            ActTypeComboBox.Items.Add("Cardio");
            ActTypeComboBox.Items.Add("Power");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedType == 0)
            {
                //add cardio exercise
                actController.AddExercise(exerciseListComboBox.SelectedItem.ToString(), (int)numeric1.Value, selectedType);
                Close();
            }
            else if (selectedType == 1)
            {
                //add power exercise
                actController.AddExercise(exerciseListComboBox.SelectedItem.ToString(),
                    (int)numeric1.Value * (int)numeric2.Value, 
                    selectedType);
                Close();
            }
        }

        private void ActTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            exerciseListComboBox.Items.Clear();
            exerciseListComboBox.Enabled = true;
            newActButton.Enabled = true;
            label.Enabled = true;
            numeric1.Enabled = true;
            numeric1.Visible = true;
            if (ActTypeComboBox.SelectedItem.ToString() == "Power")
            {
                //adding power exercises to comboBox
                foreach (var act in actController.ActivitiesData[1])
                    exerciseListComboBox.Items.Add(act);

                //correct form to work with power exercises
                selectedType = 1;
                setsLabel.Enabled = true;
                setsLabel.Text = "sets";
                label.Text = "reps";
                numeric1.Enabled = true;
                numeric2.Visible = true;
                numeric2.Enabled = true;
                setsLabel.Visible = true;
            }
            else if (ActTypeComboBox.SelectedItem.ToString() == "Cardio")
            {
                //adding cardio exercises to comboBox
                foreach (var act in actController.ActivitiesData[0])
                    exerciseListComboBox.Items.Add(act);
                selectedType = 0;

                // correct form to work with cardio exercises
                numeric2.Enabled = false;
                numeric2.Visible = false;
                setsLabel.Enabled = false;
                setsLabel.Visible = false;
                label.Text = "duration";
                
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
