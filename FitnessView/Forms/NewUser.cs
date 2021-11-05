using BL.Controller;
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
            saveButton.Enabled = true;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool gender;
            if (genderComboBox.SelectedItem.ToString() == "female")
            {
                gender = true;
                UserController.activeUser.AddСharacteristics((double)weightNumericUpDown.Value, (int)heightNumericUpDown.Value, (int)ageNumericUpDown.Value, gender, (double)actNumericUpDown.Value);
                Close();
            }
            else if (genderComboBox.SelectedItem.ToString() == "male")
            {
                gender = false;
                UserController.activeUser.AddСharacteristics((double)weightNumericUpDown.Value, (int)heightNumericUpDown.Value, (int)ageNumericUpDown.Value, gender, (double)actNumericUpDown.Value);
                Close();
            }
        }
    }
}
